(function () {
    var employeesController = function ($scope, $http) {
        var employees = function (serviceResp) {
            $scope.Employees = serviceResp.data;
           
        };
        var errorDetails = function (serviceResp) {
            $scope.Error = "Something went wrong ??";
        };
        $http.get("http://localhost:2525/api/services")
            .then(employees, errorDetails);
        $scope.Title = "Employee Details Page";
    };
    app.controller("employeesController", employeesController);
}());