/**
 * @module AcidFlavor
 */

var Coffee = require('../Coffee');

/**
 * @implements Coffee
 * @param {Coffee} coffee
 * @class
 */
function AcidFlavor(coffee) {
    this._coffee = coffee;
    this.price = coffee.price + 1;
}

AcidFlavor.prototype = Object.create(Coffee.prototype, {
    constructor: {value: AcidFlavor}
});

AcidFlavor.prototype.taste = function () {
    var baseTaste = this._coffee.taste();
    var addedTaste = 'a distinct taste of sulfuric acid';

    if (this._coffee.isDecorated) {
        return baseTaste + ', ' + addedTaste;
    }
    else {
        this._coffee.isDecorated = true;
        return baseTaste + 'with ' + addedTaste;
    }
};

module.exports = AcidFlavor;