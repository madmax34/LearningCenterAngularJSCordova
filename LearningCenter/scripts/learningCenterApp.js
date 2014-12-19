var learningCenterApp = angular.module('learningCenterApp', ['ngRoute', 'phonesGridController', 'phoneDetailsController', 'ui.bootstrap']);

learningCenterApp.config(['$routeProvider', function($routeProvider) {
    $routeProvider
        .when('/phones', {
            templateUrl: 'view/phonesGridView.html',
            controller: 'PhoneListController'
        })
        .when('/phones/:phoneId', {
            templateUrl: 'view/phonesDetailView.html',
            controller: 'PhoneDetailsController'
        })
        .otherwise({
            redirectTo: '/phones'
        });
}]);