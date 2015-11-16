'use strict';

define(['app'], function (app) {

    var injectParams = ['$location', '$filter', '$window',
                        '$timeout', 'authService', 'servServices', 'modalService'];

    var servicesController = function ($location, $filter, $window,
        $timeout, authService, servServices, modalService) {

        var vm = this;

        vm.Services = [];
        vm.filteredCustomers = [];
        vm.filteredCount = 0;
        vm.orderby = 'lastName';
        vm.reverse = false;
        vm.searchText = null;
       /// vm.cardAnimationClass = '.card-animation';

        //paging
        vm.totalRecords = 0;
        vm.pageSize = 10;
        vm.currentPage = 1;

        vm.pageChanged = function (page) {
            vm.currentPage = page;
            getServicesSummary();
        };

        vm.DisplayModeEnum = {
            Card: 0,
            List: 1
        };

        vm.changeDisplayMode = function (displayMode) {
            switch (displayMode) {
                case vm.DisplayModeEnum.Card:
                    vm.listDisplayModeEnabled = false;
                    break;
                case vm.DisplayModeEnum.List:
                    vm.listDisplayModeEnabled = true;
                    break;
            }
        };

        vm.navigate = function (url) {
            $location.path(url);
        };

        vm.setOrder = function (orderby) {
            if (orderby === vm.orderby) {
                vm.reverse = !vm.reverse;
            }
            vm.orderby = orderby;
        };

        //vm.searchTextChanged = function () {
        //    filterCustomers(vm.searchText);
        //};

        function init() {
            //createWatches();
            getServicesSummary();
        }

        function getServicesSummary() {
            servServices.getServicesSummary(vm.currentPage - 1, vm.pageSize)
            .then(function (data) {
                vm.totalRecords = data.totalRecords;
                vm.Services = data.results;
                //filterServices(''); //Trigger initial filter

                $timeout(function () {
                    vm.cardAnimationClass = ''; //Turn off animation since it won't keep up with filtering
                }, 1000);

            }, function (error) {
                $window.alert('Sorry, an error occurred: ' + error.data.message);
            });
        }

        
        //function filterServices(filterText) {
        //    vm.filteredCustomers = $filter("nameCityStateFilter")(vm.customers, filterText);
        //    vm.filteredCount = vm.filteredCustomers.length;
        //}

       
        init();
    };

    servicesController.$inject = injectParams;

    app.register.controller('servicesController', servicesController);

});