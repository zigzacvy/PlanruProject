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
            templateUrl: 'app/dashboard/dashboard.view.html',
            controller: 'DashboardController'
        })
        .state('active-users', {
            url: '/active-users',
            templateUrl: 'app/admin/users/active-users/active-user.view.html',
            controller: 'UserController'
        })
        .state('active-users.create', {
            url: '/create'
        });
  }])
  .run(function ($rootScope) {
      $rootScope.$on('$stateChangeSuccess', function (ev, to, toParams, from, fromParams) {
          $rootScope.previousState = from.name;
      });
  });