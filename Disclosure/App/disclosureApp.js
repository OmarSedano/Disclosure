'use strict';

angular.module('disclosureApp', ['ui.router','LocalStorageModule'])
    .config(['$stateProvider', '$urlRouterProvider',
        function($stateProvider, $urlRouterProvider) {

        $urlRouterProvider.otherwise("/home");

        $stateProvider
            .state('home', {
                url: "/home",
                templateUrl: "Templates/Home",
                controller: "homeController"
            });
        }]);



