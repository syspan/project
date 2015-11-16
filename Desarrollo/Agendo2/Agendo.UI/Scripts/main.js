require.config({
    baseUrl: 'app',
    urlArgs: 'v=1.0'
});

require(
    [
        'app',
        'controllers/services/ServiceController'
    ],
    function () {
        angular.bootstrap(document, ['AgendoModule']);
    });
