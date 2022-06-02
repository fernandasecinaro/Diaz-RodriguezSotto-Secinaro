'use strict';

var { Given } = require('cucumber');
var { When } = require('cucumber');
var { Then } = require('cucumber');

const chai = require('chai');
const chaiAsPromised = require('chai-as-promised');
const { browser  } = require('protractor');
chai.use(chaiAsPromised);
const expect = chai.expect;

Given('the id to delete is {int}', function (int) {
    element(by.css('#charging-point-to-delete-id')).value = int;
});

When('I click on "Dar de baja" button', function () {
  browser.sleep(1000);
  element(by.css('#charging-point-delete-button')).click();
});

Then('I should see the message {string}', function (string) {
  // Write code here that turns the phrase above into concrete actions
  return 'pending';
});
