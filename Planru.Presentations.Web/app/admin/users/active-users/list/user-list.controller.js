app.controller('UserListController', ['$scope', 'ngTableParams', 'userService', function ($scope, ngTableParams, userService) {

    $scope.tableParams = new ngTableParams({
        page: 1,
        count: 10
    }, {
        total: 0,
        getData: function ($defer, params) {
            userService.getActiveUsers(params.page() - 1, params.count()).then(function (response) {
                params.total(response.TotalItems);
                $defer.resolve(response.Items);
            });
        }
    });
}]);