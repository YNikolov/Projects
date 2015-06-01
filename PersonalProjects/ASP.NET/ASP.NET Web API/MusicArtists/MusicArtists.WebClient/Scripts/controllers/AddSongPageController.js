'use strict';

musicArtistsApp.controller('AddSongPageController',
    function AddSongPageController($scope, musicArtistsData) {
        $scope.songName = null;
        $scope.songGenre = null;
        $scope.songImageUrl = null;
        $scope.songsAlbum = null;

        $scope.createSong = function (){
            var sName = $scope.songName,
                sAlbum = $scope.songsAlbum,
                song = {
                Name: $scope.songName,
                Genre: $scope.songGenre,
                ImageUrl: $scope.songImageUrl
            };

            if(sName){
                if(sAlbum !== null){
                    musicArtistsData
                        .createSong(song)
                        .then(function(){
                            musicArtistsData
                                .addSongToAlbum(sAlbum, sName);
                        });
                } else {
                    musicArtistsData
                        .createSong(song)
                        .then(function(data){
                            $scope.song = data;
                        });
                }
            }
        }
    }
);