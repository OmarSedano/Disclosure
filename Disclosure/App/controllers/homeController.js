'use strict';

angular.module('disclosureApp')
    .controller('homeController', ['$scope',
        function($scope) {
            $scope.welcome = "Hello world";
        }
    ]);