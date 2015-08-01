(function () {
    angular.module('FilterApp', ['ngRoute']).config(Config); //calling the config function

    //creating named functions to use instead of anonomous functions

    function Config($routeProvider)
    {
        $routeProvider
        .when('/', {
            templateUrl: '/app/views/start.html',
            controller: 'StartController',  //this links directly to the name of the controller
            controllerAs: 'vm' //as a view model
        })
        .when('/about', {
            templateUrl: '/app/views/about.html',
            controller: 'AboutController', //this links directly to the name of the controller
            controllerAs: 'vm'
        });
    }
})();