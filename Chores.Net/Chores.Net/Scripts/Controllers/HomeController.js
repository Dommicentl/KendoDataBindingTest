var app = angular.module('choresApp', []);

app.controller('homeController', function($scope) {
    $scope.surName = 'fill in your surName';
    $scope.name = 'fill in your name';

    $scope.changeValue = function() {
        $scope.surName = 'changed';
    };
});