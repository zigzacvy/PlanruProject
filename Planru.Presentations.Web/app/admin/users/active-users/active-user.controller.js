app.controller('userController', ['$scope', 'ngTableParams', '$modal', '$state', '$modal', '$rootScope',
    function ($scope, ngTableParams, $modal, $state, $modal, $rootScope) {
        $rootScope.title = 'Users';
        var vm = this;

        $scope.$on('$stateChangeSuccess', function (ev, to, toParams, from, fromParams) {
            if (to.name == 'activeUsers.create') {
                var modalInstance = $modal.open({
                    templateUrl: 'app/admin/user/activeUser/create/userCreateView.html',
                    controller: 'userCreateController',
                    controllerAs: 'vm',
                    backdrop: true,
                    backdropClass: 'overlay',
                    resolve: { userController: function () { return vm; } }
                }).result.finally(function () {
                    $state.go('activeUsers');
                });
            }
        });

        var data = [{ name: "Moroni", age: 50 },
                    { name: "Tiancum", age: 43 },
                    { name: "Jacob", age: 27 },
                    { name: "Nephi", age: 29 },
                    { name: "Enos", age: 34 },
                    { name: "Tiancum", age: 43 },
                    { name: "Jacob", age: 27 },
                    { name: "Nephi", age: 29 },
                    { name: "Enos", age: 34 },
                    { name: "Tiancum", age: 43 },
                    { name: "Jacob", age: 27 },
                    { name: "Nephi", age: 29 },
                    { name: "Enos", age: 34 },
                    { name: "Tiancum", age: 43 },
                    { name: "Jacob", age: 27 },
                    { name: "Nephi", age: 29 },
                    { name: "Enos", age: 34 }];

        $scope.tableParams = new ngTableParams({
            page: 1,            // show first page
            count: 10           // count per page
        }, {
            total: data.length, // length of data
            getData: function ($defer, params) {
                $defer.resolve(data.slice((params.page() - 1) * params.count(), params.page() * params.count()));
            }
        });
    }]);
