var phoneDetailsController = angular.module('phoneDetailsController', []);

phoneDetailsController.controller('PhoneDetailsController', ['$scope', 'Phone', '$routeParams', function ($scope, Phone, $routeParams) {
    $scope.phoneId = $routeParams.phoneId;

    $scope.phone = Phone.get({
        phoneId: $routeParams.phoneId
    },
        function (phone) {
            $scope.mainImageUrl = phone.images[0];
        });


    $scope.setImage = function (image) {
        $scope.mainImageUrl = image;
    };

    $scope.getUrl = function (image) {
        return 'http://newphonelisttestwebapi.azurewebsites.net/jsonData/' + image;
    };
}]);