app.controller('UserCreateController', ['$scope', '$modalInstance', 'userController',
    function ($scope, $modalInstance, userCtrl) {
        var vm = this;

        $modalInstance.result.then(function () {
            console.log(vm);
        }, function () {

        });

        vm.close = function () {
            $modalInstance.dismiss('cancel');
        }

        vm.create = function () {
            $modalInstance.close();
        }
    }]);