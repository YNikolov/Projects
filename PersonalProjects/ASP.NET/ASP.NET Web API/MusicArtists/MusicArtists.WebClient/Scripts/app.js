'use strict';

var musicArtistsApp = angular.module('musicArtistsApp', ['ngResource', 'ngRoute'])
    .config(function($routeProvider){
        $routeProvider
            .when('/', {
                templateUrl: 'Templates/home-page.html'
            })
            .when('/Artists',{
                templateUrl: 'Templates/artists.html'
            })
            .when('/Artists/:name', {
                templateUrl: 'Templates/artist-details.html'
            })
            .when('/Add-Artist',
            {
                templateUrl: 'Templates/add-artist.html'
            })
            .when('/Albums',{
                templateUrl: 'Templates/albums.html'
            })
            .when('/Add-Album',{
                templateUrl: 'Templates/add-album.html'
            })
            .when('/Songs', {
                templateUrl: 'Templates/songs.html'
            })
            .when('/Add-Song',{
                templateUrl: 'Templates/add-song.html'
            })
            .otherwise({redirectTo: '/'});
    });