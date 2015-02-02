'use strict';

fitnessExerciseApp.controller('TricepsPageController', function TricepsPageController($scope, fitnessExerciseData) {
    $scope.exercise = fitnessExerciseData.getExercise(6);
});