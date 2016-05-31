'use strict';

angular.module('disclosureApp')
    .service('newsService',
        function ($http) {
            this.getNews = function () {
                return $http.get('/api/News');
            }
        });