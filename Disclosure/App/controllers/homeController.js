'use strict';

angular.module('disclosureApp')
    .controller('homeController', ['$scope','authenticationService', 'newsService',
        function ($scope, authenticationService, newsService) {

            $scope.getUser = function () {
                return authenticationService.getUser();
            };

            $scope.login = function (loginModel) {

                authenticationService.login(loginModel).then(
                    function (response) {
                    },
                    function (response) {
                    });
            };

            $scope.register = function (registerModel) {
                autheticationService.register(registerModel).then(
                    function (response) {

                        var loginModel = {userName : registerModel.userName, password: registerModel.password};
                        authenticationService.login(loginModel).then(
                            function (response) {
                            },
                            function (response) {
                            });
                    },
                    function(response){
                    }
                    )
            };

            function getNews() {

                newsService.getNews().then(
                    function (response) {
                        $scope.news = response.data;
                    },
                    function (response) {
                    }
                );
            }

            function init() {
                $scope.news = [];
                getNews();
            }

            init();
        }
    ]);