'use strict';

fitnessExerciseApp.controller('PageController',
    function PageController($scope, author, materials) {
        $scope.author = author;
        $scope.materials = materials;

    }
);