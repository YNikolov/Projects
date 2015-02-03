'use strict';

var fitnessExerciseApp = angular
    .module('fitnessExerciseApp', ['ngResource', 'ngRoute'])
    .config(function($routeProvider) {
        $routeProvider
            .when('/home', {
                templateUrl: 'templates/home.html'
            })
            .when('/chest', {
                templateUrl: 'templates/chest.html'
            })
            .when('/back', {
                templateUrl: 'templates/back.html'
            })
            .when('/biceps', {
                templateUrl: 'templates/biceps.html'
            })
            .when('/shoulders', {
                templateUrl: 'templates/shoulders.html'
            })
            .when('/triceps', {
                templateUrl: 'templates/triceps.html'
            })
            .when('/legs', {
                templateUrl: 'templates/legs.html'
            })
            .otherwise({redirectTo: '/index.html'});
    })
    .constant('author', 'Yavor Nikolov')
    .constant('materials', 'Frederic Delavier - Strength Training Anatomy(second_edition)');