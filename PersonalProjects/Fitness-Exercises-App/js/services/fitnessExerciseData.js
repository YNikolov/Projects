'use strict';

//fitnessExerciseApp.factory('fitnessExerciseData', function($http) {
//    return {
//        getExercise: function(id, successcb) {
//            $http({method: 'GET', url: '/data/fitness-exercises/' + id})
//                .success(function (data, status, headers, config) {
//                    successcb(data);
//                })
//                .error(function (data, status, headers, config) {
//                    $log.error(data);
//                });
//
//        }
//    }



fitnessExerciseApp.factory('fitnessExerciseData', function($resource) {

    var resource = $resource('/data/fitness-exercises/:id', { id: '@id' });

    return {
        getExercise: function (id) {
            return resource.get({id: id});
        }
    }


//fitnessExerciseApp.factory('fitnessExerciseData', function($http, $q) {
//     return {
//         getExercise: function(id) {
//            var defer = $q.defer();
//
//            $http({method: 'GET', url: '/data/fitness-exercises/' + id})
//                .success(function (data, status, headers, config) {
//                    defer.resolve(data);
//         })
//         .error(function (data, status, headers, config) {
//            defer.reject(data);
//         });
//            return defer.promise;
//         }
//    }
});