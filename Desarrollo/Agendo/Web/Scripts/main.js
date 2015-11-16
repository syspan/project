require.config({
    baseUrl: 'app',
    urlArgs: 'v=1.1'
});

require(
    [
        'agendoApp/animations/listAnimations',
        'app',
        'agendoApp/directives/wcUnique',
        'agendoApp/services/routeResolver',
        'agendoApp/services/config',
        'agendoApp/services/customersBreezeService',
        'agendoApp/services/authService',
        'agendoApp/services/customersService',
        'agendoApp/services/dataService',
        'agendoApp/services/modalService',
        'agendoApp/services/serv/servServices',
        'agendoApp/services/httpInterceptors',
        'agendoApp/filters/nameCityStateFilter',
        'agendoApp/filters/nameProductFilter',
        'agendoApp/controllers/navbarController',
        'agendoApp/controllers/orders/orderChildController',
    ],
    function () {
        angular.bootstrap(document, ['agendoApp']);
    });
