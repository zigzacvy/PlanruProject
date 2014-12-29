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
        .state('activeUsers', {
            url: '/active-users',
            templateUrl: 'app/admin/user/activeUser/activeUserView.html',
            controller: 'userController'
        })
        .state('activeUsers.create', {
            url: '/create'
        });
  }])
  .run(function ($rootScope) {
      $rootScope.$on('$stateChangeSuccess', function (ev, to, toParams, from, fromParams) {
          $rootScope.previousState = from.name;
      });
  });