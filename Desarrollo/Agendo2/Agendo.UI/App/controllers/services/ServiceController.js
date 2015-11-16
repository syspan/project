'use strict';

define(['app'], function(app) {
    var serviceController = function($scope, $http) {
        var employees = function(serviceResp) {
            $scope.Services = serviceResp.data;

        };
        var errorDetails = function(serviceResp) {
            $scope.Error = "Ocurrio un error??";
        };

        $scope.showModal = false;
        $scope.toggleModal = function() {
            $scope.showModal = !$scope.showModal;
        };

        $http.get("api/services")
            .then(employees, errorDetails);
        $scope.Title = "Servicios";
    };
    app.controller("serviceController", serviceController);
});