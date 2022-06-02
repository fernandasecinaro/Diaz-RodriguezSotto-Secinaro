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

Then('the charging point is deleted and a success message {string} is shown', function (string) {
  browser.sleep(3000);
  browser.waitForAngular().then(() => {
      const message = element(by.css('#success-delete-paragraph')).getText();
      expect(message).to.eventually.equal(string);
  });
});

Then('the charging point is not deleted and an error message {string} is shown', function (string) {
  browser.sleep(3000);
  browser.waitForAngular().then(() => {
      const message = element(by.css('#error-delete-paragraph')).getText();
      expect(message).to.eventually.equal(string);
  });
});
