var app = angular
  .module('planruApp', [
    'ngRoute',
    'ngTable',
    'ui.router',
    'bootstrapModal'
  ])
  .config(['$stateProvider', function ($stateProvider) {
      $stateProvider
        .state('dashboard', {
            url: '/',
            templateUrl: 'app/dashboard/dashboardView.html',
            controller: 'dashboardController'
        })
        .state('users', {
            url: '/users',
            templateUrl: 'app/admin/user/userView.html',
            controller: 'userController'
        })
        .state('users.create', {
            url: '/create',
            templateUrl: 'app/admin/user/partials/create.html',
            controller: 'userController'
        });
  }]);