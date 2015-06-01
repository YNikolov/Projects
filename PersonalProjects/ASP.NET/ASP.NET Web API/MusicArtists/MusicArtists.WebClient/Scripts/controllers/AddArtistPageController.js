'use strict';

musicArtistsApp.controller('AddArtistPageController',
    function AddArtistPageController($scope, $routeParams, musicArtistsData){
        $scope.artistName = null;
        $scope.artistCountry = null;
        $scope.artistImageUrl = null;
        $scope.artist = null;


            $scope.createArtist = function (){
                var artName = $scope.artistName;

                if(artName){
                var artistFromUi = {
                    Name: $scope.artistName,
                    Country: $scope.artistCountry,
                    ImageUrl: $scope.artistImageUrl
                };
                $scope.artist = artistFromUi;
                musicArtistsData
                    .createArtist(artistFromUi);
                    //.then(function (data){
                    //    $scope.artist = data;
                    //    return data.Name;
                    //});
            }
        };



        //function createArtist(artistFromUi){
        //    musicArtistsData
        //        .createArtist(artistFromUi)
        //        .then(function (data){
        //            $scope.artist = data;
        //        });
        //}
    });