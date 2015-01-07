﻿app.service('userService', ['$resource', '$q', function ($resource, $q) {
    var User = $resource('/par-api/api/user/:userId', { userId: '@id' });

    var service = {
        getActiveUsers: getActiveUsers,
        addUser: addUser,
        removeUser: removeUser,
        getUser: getUser,
        updateUser: updateUser
    };

    return service;

    function getActiveUsers(page, count) {
        return User.get({page: page, count: count}).$promise;
    }

    function addUser(user) {

    }

    function removeUser(id) {

    }

    function getUser(id) {

    }

    function updateUser(user) {

    }

    function getDeletedUsers() {

    }
}]);