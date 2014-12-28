var app = angular
  .module('planruApp', [
    'ngTable',
    'ui.router',
    'ui.bootstrap',
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
            url: '/create'
        });
  }])
  .run(function ($rootScope) {
      $rootScope.$on('$stateChangeSuccess', function (ev, to, toParams, from, fromParams) {
          $rootScope.previousState = from.name;
      });
  });