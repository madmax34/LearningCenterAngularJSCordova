var learningCenterServices = angular.module('phoneServices', ['ngResource']);

learningCenterServices.factory('Phone', ['$resource', function($resource) {
    return $resource('http://newphonelisttestwebapi.azurewebsites.net/jsonData/phones/:phoneId.json', {}, {
        query: {
            method: 'GET',
            params: { phoneId: 'phones' },
            isArray:true
        }
    });
}]);