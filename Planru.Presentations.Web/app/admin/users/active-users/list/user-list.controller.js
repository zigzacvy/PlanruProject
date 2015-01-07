app.controller('UserListController', ['$scope', 'ngTableParams', 'userService', function ($scope, ngTableParams, userService) {



    $scope.tableParams = new ngTableParams({
        page: 0,
        count: 10
    }, {
        total: 0,
        getData: function ($defer, params) {
            userService.getActiveUsers(params.page(), params.count()).then(function (data) {
                console.log(data);
                params.total(data.total);
                $defer.resolve(data);
            });
        }
    });
}]);