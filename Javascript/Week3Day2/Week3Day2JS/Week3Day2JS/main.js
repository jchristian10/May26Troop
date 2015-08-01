//function addAll() {
//    var result = 0;
//    Array.prototype.forEach.call(arguments, function (value) {
//        result += value;
//        return result;
//    });
//};

//var sum = addAll(1, 2, 3);
//console.log(sum);

////Illustrating the 3 levels of scope in Javascript------------------------------------------------------------------------------------------------

//'use strict';

//var fruit = 'apple'; // global scope
//report(fruit);

//function report(thing) {
//    if (thing == 'apple') {
//        var message1 = 'Hello'; // function scope
//        let message2 = 'World!'; // block scope
//    }
//    console.log(message1);
//    console.log(message2); // throws exception
//}


//Basic structure for an IIFE or the Revealing Module Pattern------------------------------------------------------------------------------------------


//'use strict'
//var module = (function () { })();

//A working IIFE using the Revealing Module Pattern

//'use strict'

//var module = (function () {

//    //private methods
//    function _calculatePrice(price) {
//        return price + _calculateTax(price);
//    }


   
//    function _calculateTax(price) {
//        return price * .08;
//    }

    
//    //Exports! (only thing the user can access from outside the function)
//    return {
//        calculatePrice: _calculatePrice
//    }
//})();

//var price = module.calculatePrice(45.99);
//var tax = module.calculateTax(5.00); //This will not work because the _calculateTax function is private


//CLOSURES - The concept not the library... ------------------------------------------------------------------------------------------------------------------
//Rules -----------------------------------------------------
//
// Imagine that I have a lot of buttons on a web page. And, for some reason, I want to add a click handler to each button. 
// When you click each button, I want to report the index of the button on the page by displaying a browser alert.

//UNCOMMENT THIS CODE TO ACTIVATE THIS CODE ON THE BUTTONS!

//'use strict'

//var buttons = document.getElementsByTagName("button");
//addClickHandlers(buttons);

//function addClickHandlers(buttons) {
//    for (var i = 0; i < buttons.length; i++) {
//        addClickHandler(buttons[i], i)
//        });
//    }
//}

//function addClickHandler(button, index) {
//    button.addEventListener('click', function () {
//        alert('you clicked button ' + index);


//    });
//}

//function getFunction() {
//    var message = 'Hello, World!';

//    //inner function
//    return function () {
//        console.log('He says "${message}"');
//    }
//}

//var func = getFunction();
//func();


//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
//'use strict'
//function Product(name, price) {
//    this._name = name;
//    this._price = price;
//}

//Product.prototype = {
//    calculateTax: function () {
//        return this._price * .08;
//    }
//};

//var product1 = new Product("Milk", 2.39);
//var product2 = new Product("Eggs", 1.39);
////adding a function to product 1

//product1.displayMessage = function () {
//    var message = "I hate " + this._name;
//    return message;
//}

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//INDIVIDUAL TASK!
// Create a product object
// create a calculateTotalPrice() method which is public
// create a calcualteTaxPrice() methdod which is private
// you should not be able to call the calculateTaxPrice method outside of the product object

'use strict'

function Product(name, price) {
    this._name = name;
    this._price = price;
    
    function _calculateTaxPrice(price) { //since the 'this' keyword was not used, this function will act privately and cannot be accessed outside of the object
        return price * .0825;
    }

    this.calculateTotalPrice = function () {
        return this._price + _calculateTaxPrice(this._price);
    }
};


//V2 of the same thing as above!

function Product(name, price) {
    this._name = name;
    this._price = price;
}

Product.prototype = (function () {
    function _calculateTaxPrice(price) {
        return price * .0825;
    }

    function _calculateTotalPrice() {
        return this._price + _calculateTaxPrice(this._price);
    }

    return {
        calculateTotalPrice: -_calculateTotalPrice

    };
})();

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------
