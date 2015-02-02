'use strict';

fitnessExerciseApp.controller('ChestPageController', function ChestPageController($scope, fitnessExerciseData) {

        //fitnessExerciseData.getExercise(1, function(data) {
        //    $scope.exercise = data;
        //});        // $http



    //fitnessExerciseData       // $q
    //    .getExercise(1)
    //    .then (function(data) {
    //        $scope.exercise = data;
    //});

    $scope.exercise = fitnessExerciseData.getExercise(1); // $resource


});