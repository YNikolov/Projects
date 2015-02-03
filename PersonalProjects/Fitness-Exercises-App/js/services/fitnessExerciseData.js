'use strict';

fitnessExerciseApp.factory('fitnessExerciseData', function($resource) {

    var resource = $resource('/data/fitness-exercises/:id', { id: '@id' });

    return {
        getExercise: function (id) {
            return resource.get({id: id});
        }
    }
});