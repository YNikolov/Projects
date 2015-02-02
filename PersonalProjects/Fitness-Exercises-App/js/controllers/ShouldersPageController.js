'use strict';

fitnessExerciseApp.controller('ShouldersPageController', function ShouldersPageController($scope, fitnessExerciseData) {
    $scope.exercise = fitnessExerciseData.getExercise(5);
});