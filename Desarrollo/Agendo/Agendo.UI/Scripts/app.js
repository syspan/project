var app = angular.module('AgendoModule', ['ngRoute']);
app.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/Servicios', {
            templateUrl: 'Services/Index.html',
            controller: 'employeesController'
        }).
        otherwise({
            redirectTo: '/home1'
        });
  }]);
