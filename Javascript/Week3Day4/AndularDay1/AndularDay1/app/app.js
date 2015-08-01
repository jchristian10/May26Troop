
//Creating the module
(function () {                   //IIFY!  Immediately Invoked Function
    'use strict'

    angular.module('MovieApp', []/*You would insert other modules you would be using with this module into this now empty array*/)
     .controller('MovieListController', function () {  //.controller('StringNameOfController', function
         this.movies = [
             { id: 1, title: 'Batman', director: 'Nolan' },
             { id: 2, title: 'Superman', director: 'Scott' },
             { id: 3, title: 'Spiderman', director: 'Wells' },
         ];
     });
})();
