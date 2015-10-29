var app = angular.module('AgendoModule', ['ngRoute']);
app.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider
        .when("/Home", {
             templateUrl: "/Index.html"
         })

        .when('/Servicios', {
            templateUrl: 'Views/Services/Index.html',
            controller: 'serviceController'
        }).
        otherwise({
            redirectTo: '/Home1'
        });
  }]);