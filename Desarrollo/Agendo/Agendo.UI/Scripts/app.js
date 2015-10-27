var app = angular.module('AgendoModule', ['ngRoute']);
app.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/Servicios', {
            templateUrl: 'Views/Services/Index.html',
            controller: 'serviceController'
        }).
        otherwise({
            redirectTo: '/home1'
        });
  }]);