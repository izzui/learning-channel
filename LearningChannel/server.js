// requires express library: npm install -g connect
var express = require('express');
var fs = require('fs');

var app = express();

app.use(express.logger());
app.use(express.static(__dirname + '/.'));

app.get("/", function(req, res, next) {
  res.set('Content-Type', 'text/html');
  res.send(fs.readFileSync("index.cshtml"));
});

console.log("Server up!");
app.listen(60159);