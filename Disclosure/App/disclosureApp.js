'use strict';

angular.module('disclosureApp', ['ui.router'])
    .config(['$stateProvider', '$urlRouterProvider',
        function($stateProvider, $urlRouterProvider) {

        $urlRouterProvider.otherwise("/home");

        $stateProvider
            .state('home', {
                url: "/home",
                templateUrl: "Disclosure/Home",
                controller: "homeController"
            });
        }]);



