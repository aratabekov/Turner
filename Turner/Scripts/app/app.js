(function () {
    var app = angular.module('gemStore', []);

    app.controller('StoreController', ['$http', function ($http) {
        var store = this;
        store.titles = [];

        $http.get('/api/titles').success(function (data) {
            store.titles = data;
        });
    }]);

    
    app.controller("TabController", function ($scope,$http) {
        this.tab = 1;

        this.isSet = function (checkTab) {
            return this.tab === checkTab;
        };

        this.setTab = function (setTab, currentTitle) {
            this.tab = setTab;
            if (setTab == 3) {
               
                $http.get('/api/storylines/' +currentTitle).success(function (data) {
                    $scope.storylines = data;
                });
            }
            else if (setTab == 2) {
                $http.get('/api/awards/' + currentTitle).success(function (data) {
                    $scope.awards = data;
                });
            }
            else if (setTab == 4) {
                $http.get('/api/titleparticipants/' + currentTitle).success(function (data) {
                    $scope.participants = data;
                });
            }
        };
    });

})();