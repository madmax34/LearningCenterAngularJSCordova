var learningCenterApp = angular.module('learningCenterApp', ['ui.bootstrap']);

learningCenterApp.controller('PhoneListController', function ($scope, $log, $http) {

    $scope.$log = $log;
    $scope.phoneList = [];
    $scope.filteredPhones = [];
    $scope.query = '';

    //$http.get('data/modelData.js').success(function(data) {
    //    $scope.phoneList = data;
    //});

    //$scope.itemsPerPage = 10;
    //$scope.currentPage = 1;

    $http.get('http://newphonelisttestwebapi.azurewebsites.net/api/phones').success(function (data) {
        $scope.phoneList = JSON.parse(data);

        //$scope.totalItems = $scope.phoneList.length;
    }).error(function (data, status, headers, config) {
        $scope.$log('error: ' + data + ' ' + status + ' ' + headers + ' ' + JSON.stringify(config));
    });

    //$scope.pageChanged = function (page) {
    //    console.log(page);
    //    $scope.currentPage = page;
    //    var begin = (($scope.currentPage - 1) * $scope.itemsPerPage),
    //          end = begin + $scope.itemsPerPage;

    //    $scope.filteredPhones = $scope.phoneList.slice(begin, end);
    //};
});