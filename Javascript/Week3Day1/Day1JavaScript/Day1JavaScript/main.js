//console.time("myTime");

//var firstNumber = 12;
//var secondNumber = 4;

//var result = addNumbers(firstNumber, secondNumber);

//console.timeEnd("myTime");

//function addNumbers(val1, val2) { //This is called 'hoisting'  when javascripr runs it looks for all functions first, then looks over code to use those functions.

//    "use strict";

//    var oops = val1 + val2;
//    console.log(oops);
//    return oops;
//}


//"use strict";



//for (var i = 0; i<100; i++){
//    let randomNumber = (Math.random() * 100) + 1;
//    console.log(randomNumber);
//}

//console.log(randomNumber);


//'use strict';

//console.log(parseInt('20.33')); //writes the int 20 to the page becuase type int cannot have decimalcl      

//console.log(parseFloat('20.33')); //Writes 20.33 to the console

//console.log(parseFloat("20.33 is too much!"))//writes 20.33 to the console


////These function the same as their counterparts above

//console.log(+'20.33');

//console.log(+'20.33');

//var favNum = parseFloat(prompt("What is your favorite Number?"));
//if (isNaN(favNum)) {
//    alert("Please reload the page and enter a valid number!");
//} else {
   
//    alert("Your favorite number multiplied by 100 is " + favNum * 100);
//}

////Ternary Operator to check if a fruit is an 'apple'

//'use strict';
//var fruit = 'apple';
//console.log(fruit == 'apple' ? 'Fruit is apple!' : 'Fruit is not apple!');

// a swithc statement to check if a fruit is an apple

//'use strict';
//var fruit = 'apple';

//switch (fruit) {
//    case 'apple':
//        console.log('Fruit is apple!');
//        break;
//    case 'orange':
//        console.log('Fruit is orange!');
//        break;
//    default:
//        console.log('Fruit is something else!');
//        break;
//}


//MATHMATICAL AND LOGICAL JS OPPERATORS

//+ - Addition.
//- - Subtracton.
/// - Division.
//* - Multiplication.
//% - Remainder (modulus).
//++ - Increment.
//-- - Decrement

// == is the weak equality check opperator
// === is the strong equality check opperator

//&& - Logical AND.
//|| - Logical OR.
//! - Logical NOT.

//SHORT CIRCUIT OPPERATORS!

// && and || short circuit.  This means that when evaluating conditions if the first condition does not meet the criteria, the second condition is never even checked.


////TRUTHINESS  //THESE ARE AWESOME WORKING EXAMPLES!!! DO NOT LOSE THESE!


//function calculateTax(price, taxRate) {
//    if (isNaN(taxRate)) {
//        taxRate = .08;
//    }
//    return price + (price * taxRate);
//}

//// Same as abouve but with a turturairy statement

//function calcTaxTurt(price, taxRate) {
//    taxRate = taxRate === 0 ? taxRate : taxRate > 0 ? taxRate : .08;
//    return prie + (price * taxRate);
//}



////Looping through an array with a for loop
//var colors = ['red', 'green', 'blue'];

//for (var color in colors) {
//    console.log(colors[color]);

//}


//looping through an object with a for loop

//var states = {
//    'wa': 'Washington',
//    'ca': 'California',
//    'tx': 'Texas'
//};

//for (var state in states) {
//    console.log(state);  //this will log the name of the property in the object
//    console.log(states[state]); //this will log the value of the specific property in that object
//}

////for-of loop

//'use strict';

//// loop over array keys
//var colors = ['red', 'green', 'blue'];
//for (var color of colors) {
//    console.log(color);
//}


//While Loops!
// this checks the condition BEFORE performing the action
//'use strict';

//var count = 0;
//while (count < 3) {
//    count++;
//    console.log('Still working...');
//}
//console.log('All done!');

//This checks the conditionn AFTER perfomring the action
//'use strict';

//var count = 0;
//do {
//    count++;
//    console.log('Still working...');
//} while (count < 3);
//console.log('All done!');

//HANDLING ERRORS

//Try/catch error with a 'finally'statement

//'use strict';

//try {
//    var result = 14/mushroom;
//} catch (ex) {
//    console.log('oops!');
//} finally {   //FINALLY MEANS THIS CODE WILL EXECUTE NO MATTER WHAT AFTER ALL CONDITIONS ARE CHECKED
//    console.log('The finally always executes!');
//}


/////THIS CODE DOES NOT WORK!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//function addInts(num1, num2) {
//    for (var arg in arguments) {
//        var num = arguments[arg];
//        parseInt(num);
//        if (isNaN(num)){
//            console.log("" + num + " is not a number.  Please try again!")
//            break;
//        } else {
//            console.log(num1 + num2);
//        }
//    }
//}
/////THIS CODE DOES NOT WORK!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!



////Object Literal Notation
//var product = {
//    name: 'Laptop Computer',
//    price: 12.33,
//    calcualteTax: function () {
//        return this.price * .08;
//    }
//};

// using a set function on a product object

//'use strict';

//var product = {
//    _price: 0,
//    set price(value) {
//        if (value < 0) {
//            throw new Error('Price cannot be less than 0');
//        }
//        this._price = value;
//    },
    
//    get price() {
//        return this._price;
//    }

//}

//product.price = -300.00;
//console.log(product.price);

//This is an example of using filter() on an array

//var products = [
//    { name: 'Cheese', price: 7.00 },
//    { name: 'Milk', price: 3.00 },
//    { name: 'Wine', price: 97.30 },
//    { name: 'Grapes', price: 4.00 }
//];

//var expensiveProducts = products.filter(function (product) {
//    return product.price > 5.00;
//});

//console.log(expensiveProducts); // writes [Cheese, Wines]


//multiplying an inputted number times 100

//asks the user to input a number to a prompt box
'use strict'
var userInput = prompt("Please enter the number you wish to multiply by 100")

//the function that is used to multiply the input by 100.
// includes a check to make sure the input is a number

function multiplyByOneHundred (userInput) {
    if (isNanN(userInput)) {
        return alert("Please enter a valid number and try again");
    } else {
        userInput
    }
}