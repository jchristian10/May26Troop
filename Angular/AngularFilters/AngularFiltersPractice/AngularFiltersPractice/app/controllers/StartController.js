(function () {  //starting with an iify ensures that everything created here stays in here
    angular.module('FilterApp').controller('StartController', StartController);
    function StartController()
    {
        var vm = this;

        vm.message = "This is the Start View";

        vm.fetch = function () {
            var all = [

                'Milk',
                'Marzipan',
                'Mustard',
                'Eggs'
            ];
            var search = vm.search.toLowerCase();

            vm.food = all.filter(function (item) {
                return item.toLowerCase().startsWith(search);
            });
        }
    }
})();

//vm.food = [
//    'Milk',
//    'Marzipan',
//    'Mustard',
//    'Eggs'

//    //{ name:'Milk', price: 2.33, dateCreated:new Date('12/31/1977') },
//    //{name: 'Marzipan', price: 99.88, dateCreated: new Date('1/8/1982') },
//    //{ name: 'Mustard', price: 6.77, dateCreated: new Date ('12/04/1922') },
//    //{ name: 'Eggs', price: 3.44, dateCreated: new Date('12/31/1977') }
//];