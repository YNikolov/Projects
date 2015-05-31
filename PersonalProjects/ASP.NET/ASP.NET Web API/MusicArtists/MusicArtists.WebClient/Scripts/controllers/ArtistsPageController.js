'use strict';

musicArtistsApp.controller('ArtistsPageController',
    function ArtistsPageController($scope, musicArtistsData){
        var ARTISTS_REPOSITORY = 'Artists';
            //ALBUMS_REPOSITORY = 'Albums';

    getCover(ARTISTS_REPOSITORY);
    //getCover(ALBUMS_REPOSITORY);
        function getCover(sourceName){
            musicArtistsData.getCover(sourceName)
                .then(function (data) {
                    $scope[sourceName] = data;
                });
        }
    });
