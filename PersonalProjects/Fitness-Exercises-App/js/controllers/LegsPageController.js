'use strict';

fitnessExerciseApp.controller('LegsPageController', function LegsPageController($scope, fitnessExerciseData) {
    $scope.exercise = fitnessExerciseData.getExercise(4);
});