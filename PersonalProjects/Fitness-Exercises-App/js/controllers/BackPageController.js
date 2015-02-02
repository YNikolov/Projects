'use strict';

fitnessExerciseApp.controller('BackPageController', function BackPageController($scope, fitnessExerciseData) {
    $scope.exercise = fitnessExerciseData.getExercise(2);
});