app.controller('UserListController', ['$scope', 'ngTableParams', 'userService', function ($scope, ngTableParams, userService) {

    userService.getActiveUsers(1, 10).then(function (response) {
        console.log(response);
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