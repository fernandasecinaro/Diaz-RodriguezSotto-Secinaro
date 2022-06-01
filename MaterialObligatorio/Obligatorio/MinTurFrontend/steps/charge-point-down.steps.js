'use strict';

var { Given } = require('cucumber');
var { When } = require('cucumber');
var { Then } = require('cucumber');

// Use the external Chai As Promised to deal with resolving promises in
// expectations
const chai = require('chai');
const chaiAsPromised = require('chai-as-promised');
chai.use(chaiAsPromised);
const expect = chai.expect;

let id;

Given(/^the url "([^"]*)"$/, function (url, callback) {
    browser.get(url).then(function () {
        callback();
    });
});

Given(/^the id "([^"]*)"$/, function (_id, callback) {
  id = _id;
  element(by.id("removeChargingPointIdInp")).value = _id;
  callback();
});

When(/^I click the \"Dar de baja\" button$/, function (callback) {
    element(by.id("removeChargingPointBtn")).click();
    callback();
});

When(/^I wait for (\d+) ms$/, function (timeToWait, callback) {
    setTimeout(callback, timeToWait);
});

Then(/^I should see the message "([^"]*)"$/, function (text) {
  browser.sleep(3000);
  browser.waitForAngular().then(() => {
    const message = element(by.css(".removeChargingPointResult"));
    expect(message.getText()).to.eventually.equal(text);
  });
});
