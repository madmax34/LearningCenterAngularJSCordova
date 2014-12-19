var phoneDetailsController = angular.module('phoneDetailsController', []);

phoneDetailsController.controller('PhoneDetailsController', ['$scope', '$http', '$routeParams', function ($scope, $http, $routeParams) {
    $scope.phoneId = $routeParams.phoneId;

    $scope.phone = null;

    $http.get('http://newphonelisttestwebapi.azurewebsites.net/jsonData/phones/' + $scope.phoneId + '.json')
        .success(function (data) {
            $scope.phone = data;
        });
}]);