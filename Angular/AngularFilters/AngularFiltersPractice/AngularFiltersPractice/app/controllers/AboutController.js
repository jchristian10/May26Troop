(function () {  //starting with an iify ensures that everything created here stays in here
    angular.module('FilterApp').controller('AboutController', AboutController);
    function AboutController() {
        var vm = this;

        vm.message = "This is the About View";
    }
})();