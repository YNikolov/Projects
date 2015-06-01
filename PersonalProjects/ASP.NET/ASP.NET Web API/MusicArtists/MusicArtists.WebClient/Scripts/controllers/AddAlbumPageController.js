'use strict';

musicArtistsApp.controller('AddAlbumPageController',
    function AddAlbumPageController($scope, $routeParams, musicArtistsData) {
        $scope.albumName = null;
        $scope.albumGenre = null;
        $scope.albumProducer = null;
        $scope.albumImageUrl = null;
        $scope.albumsArtist = null;


            $scope.createAlbum = function () {
                var albumsArtist = $scope.albumsArtist,
                    albName = $scope.albumName,
                    albumFromUI = {
                    Name: $scope.albumName,
                    Genre: $scope.albumGenre,
                    Producer: $scope.albumProducer,
                    ImageUrl: $scope.albumImageUrl
                };

                if(albName){
                if (albumsArtist !== null) {
                    musicArtistsData
                        .createAlbum(albumFromUI)
                        .then(function () {
                            musicArtistsData
                                .addAlbumToArtist(albumsArtist, albName);
                                $scope.createdAlbum = data;
                        });

                } else {
                    musicArtistsData
                        .createAlbum(albumFromUI)
                        .then(function (data) {
                            $scope.createdAlbum = data;
                        });
                }
            }
        }
    });