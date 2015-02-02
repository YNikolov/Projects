'use strict';

fitnessExerciseApp.controller('BicepsPageController', function BicepsPageController($scope, fitnessExerciseData) {
    $scope.exercise = fitnessExerciseData.getExercise(3);
});
