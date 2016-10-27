/**
 * @module CoffeeDecoration
 */

require('colors');
var prompter = require('single-prompt');

// Models
var Espresso = require('./models/Espresso');
var BrownSugar = require('./models/flavors/BrownSugarFlavor');
var Milk = require('./models/flavors/MilkFlavor');
var Acid = require('./models/flavors/AcidFlavor');

var coffee = null;

startUp();

function startUp() {
    console.log('Welcome, would you like a coffee?'.underline.cyan);

    prompter
        .prompt('Would you like an espresso'.green, ['y', 'n'])
        .then(function(choice) {
            if (choice === 'y') {
                coffee = new Espresso();
                playBall();
            }
            else {
                quit();
            }
        });
}

function playBall() {

    printState();
    chooseDecoration();
}

function printState() {
    console.log('Coffee cost: %s', coffee.price);
    console.log('');

    console.log('Your coffee tastes like:');
    console.log(coffee.taste().magenta);
}

function chooseDecoration() {
    prompter
        .prompt('What would you like to add'.green, ['sugar', 'milk', 'acid', 'quit'])
        .then(function(choice) {
            if (choice !== 'quit') {
                wrap(choice);
                playBall();
            }
            else {
                quit();
            }
        });

}

function wrap(decoration) {
    console.log('Adding... ' + decoration.cyan);

    switch (decoration) {
        case 'sugar':
            coffee = new BrownSugar(coffee);
            break;
        case 'milk':
            coffee = new Milk(coffee);
            break;
        case 'acid':
            coffee = new Acid(coffee);
            break;
        default:
            throw new Error('El panadero no come pan')
    }
}

function quit() {
    console.log('Game over, you lose'.bold.red);
}

