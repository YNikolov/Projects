'use strict';

musicArtistsApp.controller('ArtistDetailsController',
    function ArtistDetailsController($scope, $templateCache, $routeParams, musicArtistsData){
        //var baseUrl = '/Artists';

        if($routeParams.name){
            musicArtistsData
                .getArtistByName($routeParams.name)
                .then(function (data) {
                    $scope.artists = data;
                    return data.ArtistId;
                })
                .then(function (artistId) {
                    musicArtistsData
                        .getAlbumsByArtistId(artistId)
                        .then(function (data) {
                            $scope.albums = data;
                        })
                });
                //.getArtistByName($routeParams.name)                                                 //.getArtistByName($routeParams.name)
                //.then(function (data){
                //    $scope.artist = data;
                //});
        }
    });
