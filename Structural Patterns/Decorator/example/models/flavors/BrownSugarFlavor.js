/**
 * @module BrownSugarFlavor
 */

var Coffee = require('../Coffee');

/**
 * @implements Coffee
 * @param {Coffee} coffee
 * @constructor
 */
function BrownSugarFlavor(coffee) {
    this._coffee = coffee;
    this.price = coffee.price + 0.2;
}

BrownSugarFlavor.prototype = Object.create(Coffee.prototype, {
    constructor: {value: BrownSugarFlavor}
});

BrownSugarFlavor.prototype.taste = function () {
    var baseTaste = this._coffee.taste();
    var addedTaste = 'brown sugar';

    if (this._coffee.isDecorated) {
        return baseTaste + ', ' + addedTaste;
    }
    else {
        this._coffee.isDecorated = true;
        return baseTaste + 'with ' + addedTaste;
    }
};

module.exports = BrownSugarFlavor;
