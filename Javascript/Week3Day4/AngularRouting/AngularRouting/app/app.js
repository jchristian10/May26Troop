(function () {
    'use strict'

    function Config($routeProvider) {
        $routeProvider
        .when('/', {
            templateUrl: '/app/Views/home.html',
            controller: 'HomeController',
            controllerAs: 'vm'
        })
        .when('/about/:id', {
            templateUrl: '/app/views/about.html',
            controller: 'AboutController',
            controllerAs: 'vm'
        })
        .when('/contact', {
            templateUrl: '/app/views/contact.html',
            controller: 'AboutController',
            controllerAs: 'vm'
        });
    }

    function HomeController($location)
    {
        var vm = this;
        vm.move = function (id) {
            $location.path('about/' + id);

        }
    }

    function AboutController($routParams)
    {
        var vm = this;
        this.message = "You passed in " + $routParams.id;
    }

    function ContactController()
    {
        
    }


    angular.module('MyApp', ['ngRoute'])
        .config(Config)
        .controller('HomeController', HomeController)
        .controller('AboutController', AboutController)
        .controller('ContactController', ContactController);
})();