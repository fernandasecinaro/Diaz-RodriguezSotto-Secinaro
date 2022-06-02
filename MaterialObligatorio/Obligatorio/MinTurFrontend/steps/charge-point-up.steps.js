'use strict';

var { Given } = require('cucumber');
var { When } = require('cucumber');
var { Then } = require('cucumber');

const chai = require('chai');
const chaiAsPromised = require('chai-as-promised');
const { browser,  } = require('protractor');
chai.use(chaiAsPromised);
const expect = chai.expect;

Given(/^I view the "([^"]*)"$/, function (url) {
    browser.get(url).then(function () {
        browser.sleep(5000);
    });
});

Given('the Id input has the value {int}', function (int) {
    element(by.css('#charging-point-id')).value = int;
});

Given('the name input has the value {string}', function (string) {
    element(by.css('#charging-point-name')).value = string;
});

Given('the address input has the Value {string}', function (string) {
    element(by.css('#charging-point-address')).value = string;
});

Given('the region input has the value {int}', function (int) {
    element(by.css('#charging-point-region')).value = int;
});

Given('the description input has the value {string}', function (string) {
    element(by.css('#charging-point-description')).value = string;
});

When('I click on button "Dar de alta"', function () {
    browser.sleep(1000);
    element(by.css('#charging-point-button')).click();
});

Then('the charging point is registered and a success message {string} is shown', function (string) {
    browser.sleep(3000);
    browser.waitForAngular().then(() => {
        const message = element(by.css('#success-paragraph')).getText();
        expect(message).to.eventually.equal(string);
    });
});

Then('the charging point is not registered and an error message {string} is shown', function (string) {
    browser.sleep(3000);
    browser.waitForAngular().then(() => {
        const message = element(by.css('#error-paragraph')).getText();
        expect(message).to.eventually.equal(string);
    });
});