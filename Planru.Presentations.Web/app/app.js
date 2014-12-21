var app = angular
  .module('planruApp', [
    'ngRoute',
    'ngTable',
    'bootstrapModal'
  ])
  .config(function ($routeProvider) {
      $routeProvider
        .when('/', {
            templateUrl: 'app/dashboard/dashboard.html',
            controller: 'dashboardCtrl'
        })
        .when('/users', {
            templateUrl: 'app/admin/user/user.html',
            controller: 'userCtrl'
        })
        .otherwise({
            redirectTo: '/'
        });
  });