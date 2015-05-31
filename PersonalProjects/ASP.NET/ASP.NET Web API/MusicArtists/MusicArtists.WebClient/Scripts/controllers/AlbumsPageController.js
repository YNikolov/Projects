'use strict';

musicArtistsApp.controller('AlbumsPageController',
    function AlbumsPageController($scope, musicArtistsData){
        var REPOSITORY_NAME = 'Albums';


        musicArtistsData.getCover(REPOSITORY_NAME)
            .then(function (data){
                $scope.albums = data;
            });
    });