app.service('userService', ['$resource', '$q', function ($resource, $q) {

    var service = {
        getActiveUsers: getActiveUsers
    };

    return service;

    function getActiveUsers(page, count) {
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

        return $q(function (resolve, reject) {
            resolve(data.slice((page - 1) * count, page * count));
        });
    }
}]);