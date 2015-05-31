'use strict';

musicArtistsApp.controller('AddArtistPageController',
    function AddArtistPageController($scope, $routeParams, musicArtistsData){
        $scope.artistName = null;
        $scope.artistCountry = null;
        $scope.artistImageUrl = null;


        $scope.createArtist = function (){
            var artistFromUi = {
                Name: $scope.artistName,
                Country: $scope.artistCountry,
                ImageUrl: $scope.artistImageUrl
            };
            musicArtistsData
                .createArtist(artistFromUi)
                .then(function (data){
                    $scope.artist = data;
                });
        };



        //function createArtist(artistFromUi){
        //    musicArtistsData
        //        .createArtist(artistFromUi)
        //        .then(function (data){
        //            $scope.artist = data;
        //        });
        //}
    });