'use strict';

musicArtistsApp.controller('SongsPageController',
    function SongsPageController($scope, musicArtistsData){
       var REPOSITORY_NAME = 'Songs';

        musicArtistsData.getCover(REPOSITORY_NAME)
            .then(function (data){
                $scope.songs = data;
            })
    });
