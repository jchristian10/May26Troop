(function () {
    angular.module('MyApp')
        .controller('StartController', StartController)
        .controller('CreateController', CreateController);
    function StartController($http) {
        var vm = this;
        vm.fetch = function () {
            if (vm.search) { //Truthieness! Only in JavaScript
                $http.get('/api/food/' + vm.search)
                    .success(function (results) {
                        vm.items = results;
                    })
                    .error(function () {
                        console.error('Could not retrieve food!');
                    });

            }
        }
    }
    StartController.$inject = ['$http']; //must be added if you want to use minification

    function CreateController($http) {
        var vm = this;
        vm.add = add;

        function add() {
            var food = {  //turn the string into an object
                name: vm.name
            }

            $http.post('/api/food', food) //turn your object into a JSON object
                .success(function (id) {
                    console.log(id);
                })
                .error(function (data) {
                    console.log(data);
                });
        }
    }

    CreateController.$inject = ['$http'];

})();