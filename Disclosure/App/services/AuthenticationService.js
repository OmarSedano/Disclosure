'use strict';

angular.module('disclosureApp')
    .service('authenticationService', 
        function ($http, localStorageService) {

            var user = {
                isAuthenticated: false,
                userName: null
            };

            this.getUser = function () {
                return user;
            };

            this.login = function (loginModel) {

                var grantType = 'password';
                var data = 'grant_type=' + grantType + '&username=' + loginModel.userName + '&password=' + loginModel.password;
                var configuration = { 
                    headers: {
                        'Content-Type': 'application/x-www-form-urlencoded' 
                    }
                };

                return $http.post('/token', data, configuration).then(
                    function (response) {
                        var token = response.data.access_token;
                        var userName = response.data.userName;
                        
                        var authorizationDataModel = {
                            token: token
                        };

                        localStorageService.set('authorizationData', authorizationDataModel);

                        user.isAuthenticated = true;
                        user.userName = userName;

                        return response;
                    })
            };

            this.logOut = function () {

                localStorageService.remove('authorizationData');
                user.isAuthenticated = false;
                user.userName = null;
            };

            this.register = function (registerModel) {
                return $http.post('/api/account/register', registerModel);
            };
        });