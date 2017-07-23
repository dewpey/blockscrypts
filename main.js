// BASE SETUP
// =============================================================================
// call the packages we need
var express = require('express'); // call express
var app = express(); // define our app using express
var bodyParser = require('body-parser');
var chain = require('chain-sdk');
// configure app to use bodyParser()
const client = new chain.Client()
const signer = new chain.HsmSigner()
const cryptoRandomString = require('crypto-random-string');

var prescriptionsState
// this will let us get the data from a POST
app.use(bodyParser.urlencoded({
   extended: true
}));
app.use(bodyParser.json());
var port = process.env.PORT || 8080; // set our port
// ROUTES FOR OUR API
// =============================================================================
var router = express.Router(); // get an instance of the express Router
// middleware to use for all requests
router.use(function (req, res, next) {
   // do logging
   console.log('Something is happening.');
   next(); // make sure we go to the next routes and don't stop here
});
// test route to make sure everything is working (accessed at GET http://localhost:8080/api)
router.get('/', function (req, res) {
   res.json({
      message: 'hooray! welcome to our api!'
   });
});
router.get('/getAll', function (req, res) {
   client.transactions.queryAll({
      filter: 'inputs(account_alias=$1) OR outputs(account_alias=$1)'
      , filterParams: [req.query.id]
   , }, (tx, next, done) => {
      res.send("Alice's transaction: " + tx.id)
         // next() moves to the next item.
         // done() terminates the loop early, and causes the
         //   query promise to resolve. Passing an error will reject
         //   the promise.
      next()
   })
});

router.get('/getBalances', function (req, res) {
  client.balances.queryAll({
  filter: 'account_alias=$1',
  filterParams: [req.query.id]
}, (balance, next, done) => {
  console.log(balance.sumBy.assetAlias)

  client.assets.queryAll({
      filter: 'alias=$1',
      filterParams: [balance.sumBy.assetAlias]
   }, (asset, next, done) => {
      console.log(asset.definition)
         // next() moves to the next item.
         // done() terminates the loop early, and causes the
         //   query promise to resolve. Passing an error will reject
         //   the promise.
      done()
   })
  
  
  // next() moves to the next item.
  // done() terminates the loop early, and causes the
  //   query promise to resolve. Passing an error will reject
  //   the promise.
  next()
})
});


router.get('/getData', function (req, res) {
   client.assets.queryAll({
      filter: 'alias=$1',
      filterParams: [req.query.id]
   }, (asset, next, done) => {
      res.send(asset.definition)
         // next() moves to the next item.
         // done() terminates the loop early, and causes the
         //   query promise to resolve. Passing an error will reject
         //   the promise.
      done()
   })
});

router.post('/createPrescription', function (req, res) {
    var uniqueName = cryptoRandomString(7);
    var hsm = req.body.hsm
    signer.addKey(hsm, client.mockHsm.signerConnection)
 client.assets.create({
  alias: uniqueName,
  rootXpubs: [hsm],
  quorum: 1,
  tags: {
    internalRating: '1',
  },
  definition: {
            drug: req.body.drug,
            quantity: req.body.quantity,
            hash: req.body.hash,
  },
}).then(asset =>{
   res.send(asset.alias)

   })   
});

router.post('/issuePrescription', function (req, res) {
    signer.addKey(req.body.hsm, client.mockHsm.signerConnection)
    client.transactions.build(builder => {
      builder.issue({
        assetAlias: req.body.assetAlias,
        amount: 1,
      })
      builder.controlWithAccount({
        accountAlias: req.body.accountAlias,
        assetAlias: req.body.assetAlias,
        amount: 1,
      })
    }).then(issuance => {
     return signer.sign(issuance)
    }).then(signed => {
          res.send('done');
      return client.transactions.submit(signed)
    })
});


router.get('/getPatients', function (req, res) {
    var jsonStr = '{"patients":[]}';
    var obj = JSON.parse(jsonStr);
    var i = 0;
client.accounts.queryAll({
  filter: 'tags.type=$1',
  filterParams: ['patient']
}, (account, next, done) => {
  console.log(account.id + ' ' + account.alias + ' ' + account.tags.messengerID)
  obj['patients'].push({"alias":account.alias,"id":account.id,"messengerID":account.tags.messengerID});
  jsonStr = JSON.stringify(obj);
  // next() moves to the next item.
  // done() terminates the loop early, and causes the
  //   query promise to resolve. Passing an error will reject
  //   the promise.
    
  i++;
  next()
  if(i > 1){
  console.log(jsonStr)
  res.send(jsonStr)
  }
    })



});

router.get('/test', function (req, res) {
var i = 0
client.balances.queryAll({
  filter: 'account_alias=$1',
  filterParams: [req.query.id],
  sumBy: ['asset_definition']
}, (balance, next, done) => {
  var denom = balance.sumBy['assetDefinition']
 res.write
 console.log(denom)
  i = i++
  // next() moves to the next item.
  // done() terminates the loop early, and causes the
  //   query promise to resolve. Passing an error will reject
  //   the promise.
  next()
})

});


router.post('/movePrescription', function (req, res){
signer.addKey(req.body.hsm, client.mockHsm.signerConnection)
return client.transactions.build(builder => {
  builder.spendFromAccount({
    accountAlias: req.body.fromAlias,
    assetAlias: req.body.assetAlias,
    amount: 1
  })
  builder.controlWithAccount({
    accountAlias: req.body.toAlias,
    assetAlias: req.body.assetAlias,
    amount: 1
  })
})
.then(payment => signer.sign(payment))
.then(signed => client.transactions.submit(signed))
.catch((err) => {
console.log(err.message)
  // Handle any error that occurred in any of the previous
  // promises in the chain.
});
});

router.get('/getState', function (req, res) {
    res.send(prescriptionsState.substring(0,prescriptionsState.length-2) + "}]}");
});


router.get('/pharmacyQuery', function (req, res) {
prescriptionsState = "{\"prescriptions\":[";
 var jsonStr = '';


client.balances.queryAll({
  filter: 'account_alias=$1',
  filterParams: [req.query.id]
}, (balance, next, done) => {
  //console.log(balance.sumBy.assetAlias)

    client.assets.queryAll({
      filter: 'alias=$1',
      filterParams: [balance.sumBy.assetAlias]
   }, (asset, next, done) => {
      console.log(jsonStr)

      prescriptionsState += JSON.stringify(asset.definition) + ','
    //console.log(obj.)
      //obj['presciptions'].push(asset.definition);
      //obj['presciptions'].append({"test":"hi"});
      //res.write("hi")
      //jsonStr = JSON.stringify(obj);
         // next() moves to the next item.
         // done() terminates the loop early, and causes the
         //   query promise to resolve. Passing an error will reject
         //   the promise.
      done()
    
   })
  next()
  res.send('')


});

})


// more routes for our API will happen here
// REGISTER OUR ROUTES -------------------------------
// all of our routes will be prefixed with /api
app.use('/api', router);
// START THE SERVER
// =============================================================================
app.listen(port);
console.log('Magic happens on port ' + port);