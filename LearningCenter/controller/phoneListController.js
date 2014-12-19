var phonesGridController = angular.module('phonesGridController', []);

phonesGridController.controller('PhoneListController', ['$scope', '$log', 'Phone', function ($scope, $log, Phone) {

    $scope.$log = $log;
    $scope.phoneList = Phone.query();
    
    $scope.query = '';

    $scope.getUrl = function (image) {
        return 'http://newphonelisttestwebapi.azurewebsites.net/jsonData/' + image;
    };
}]);