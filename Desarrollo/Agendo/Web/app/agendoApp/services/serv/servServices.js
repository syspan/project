'use strict';

define(['app'], function (app) {

    var injectParams = ['$http', '$q'];

    var servicesFactory = function ($http, $q) {
        var serviceBase = '/api/service/',
            factory = {};

        factory.getServicesSummary = function (pageIndex, pageSize) {
            return getPagedResource('ServicesSummary', pageIndex, pageSize);
        };

      
        function getPagedResource(baseResource, pageIndex, pageSize) {
            var resource = baseResource;
            resource += (arguments.length == 3) ? buildPagingUri(pageIndex, pageSize) : '';
            return $http.get(serviceBase + resource).then(function (response) {
                var custs = response.data;
               // extendCustomers(custs);
                return {
                    totalRecords: parseInt(response.headers('X-InlineCount')),
                    results: custs
                };
            });
        }

        function buildPagingUri(pageIndex, pageSize) {
            var uri = '?$top=' + pageSize + '&$skip=' + (pageIndex * pageSize);
            return uri;
        }

        return factory;
    };

    servicesFactory.$inject = injectParams;

    app.factory('servServices', servicesFactory);

});