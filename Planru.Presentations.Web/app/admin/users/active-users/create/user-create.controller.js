app.controller('UserCreateController', ['$scope', '$modalInstance', 'userCtrl', 'userService',
    function ($scope, $modalInstance, userCtrl, userService) {
        var vm = this;

        $modalInstance.result.then(function () {

        });

        vm.close = function () {
            $modalInstance.dismiss('cancel');
        }

        vm.create = function () {
            $modalInstance.close();
        }
    }]);