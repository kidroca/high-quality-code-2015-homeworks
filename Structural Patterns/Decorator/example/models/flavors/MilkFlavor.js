/**
 * @module MilkFlavor
 */

var Coffee = require('../Coffee');

/**
 * @implements Coffee
 * @param {Coffee} coffee
 * @class
 */
function MilkFlavor(coffee) {
    this._coffee = coffee;
    this.price = coffee.price + 0.5;
}

MilkFlavor.prototype = Object.create(Coffee.prototype, {
    constructor: {value: MilkFlavor}
});

MilkFlavor.prototype.taste = function () {
    var baseTaste = this._coffee.taste();
    var addedTaste = 'a bit of milk';

    if (this._coffee.isDecorated) {
        return baseTaste + ', ' + addedTaste;
    }
    else {
        this._coffee.isDecorated = true;
        return baseTaste + 'with ' + addedTaste;
    }
};

module.exports = MilkFlavor;