'use strict';

musicArtistsApp.factory('musicArtistsData',
    function ($resource, $http, $q){
       var url = 'http://localhost:56795/api/';

        function getCover(repositoryName){
            var deferred = $q.defer();

            $http({ method: 'GET',
                url: url + repositoryName + '/All'})
                .success(function (data, status, headers, config){
                    deferred.resolve(data);
                })
                .error(function (err) {
                    return err;
                });

            return deferred.promise;
        }

        function getArtistByName(inputArtist) {                //function getArtistByName(inputArtist){
            var deferred = $q.defer();

            $http({
                method: 'GET',
                url: url + 'Artists/ByName',
                params: {
                    inputArtist: inputArtist
                }
            })
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                })
                .error(function (data, status, headers, config){
                    deferred.reject(data);
                });

            return deferred.promise;
        }

        function createArtist(artist){
            var deferred = $q.defer();

            $http({
                method: 'POST',
                url: url + 'Artists/CreateArtist',
                params:{
                    Name: artist.Name,
                    Country: artist.Country,
                    ImageUrl: artist.ImageUrl
                }
            })
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                })
                .error(function (data, status, headers, config){
                    deferred.reject(data);
                });
            return deferred.promise;
        }

        function createAlbum(album){
            var deferred = $q.defer();

            $http({
                method: 'POST',
                url: url + 'Albums/Create',
                params:{
                    Name: album.Name,
                    Genre: album.Genre,
                    ImageUrl: album.ImageUrl,
                    Producer: album.Producer,
                    ArtistId: album.ArtistId
                }
            })
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                })
                .error(function (data, status, headers, config) {
                   deferred.$reject(data);
                });
            return deferred.promise;
        }
        function createSong(song){
            var deferred = $q.defer();

            $http({
                method: 'POST',
                url: url + 'Songs/CreateSong',
                params:{
                    Name: song.Name,
                    Genre: song.Genre,
                    ImageUrl: song.ImageUrl,
                    AlbumId: song.AlbumId
                }
            })
            .success(function (data, status, headers, config) {
                    deferred.resolve(data);
            })
            .error(function (data, status, headers, config) {
                deferred.reject(data);
            });
            return deferred.promise;
        }

        function getAlbumByName(albName){
            var deferred = $q.defer();

            $http({
                method: 'GET',
                url: url + 'Albums/ByAlbumsName?albName=' + albName // test with params: nAme: albName.Name.......
            })
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                })
                .error(function (data, status, headers, config) {
                    deferred.reject(data);
                });
            return deferred.promise;
        }

        function getAlbumsByArtistId(id){
            var deferred = $q.defer();

            $http({
                method: 'GET',
                url: url + 'Albums/ArtistId/' + id
            })
                .success(function(data, status, headers, confid){
                    deferred.resolve(data);
                })
                .error(function(data, status, headers, config){
                   deferred.reject(data);
                });
            //api/Albums/ArtistId/{id}
            return deferred.promise;
        }
        function addAlbumToArtist(artist, album){
            var deferred = $q.defer();

            $http({
                method: 'POST',
                url: url + 'Artists/AddAlbum?artist=' + artist + '&album=' + album
            })
                .success(function(data, status, headers, config){
                    deferred.resolve(data);
                })
                .error(function(data, status, headers, config){
                   deferred.reject(data);
                });
            return deferred.promise;
        }

        function addSongToAlbum(album, song){
            var deferred = $q.defer();

            $http({
                method: 'POST',
                url: url + 'Albums/AddSong?albName=' + album + '&songName=' + song
            })
            .success(function (data, status, headers, config){
            deferred.resolve(data);
            })
            .error(function (data, status, headers, config){
                deferred.reject(data);
            });
            return deferred.promise;
        }

        return {
            getCover: function(repositoryName){
                return getCover(repositoryName);
            },
            getArtistByName: function (inputArtist){
                return getArtistByName(inputArtist);
            },
            getAlbumsByArtistId: function (artistId){
                return getAlbumsByArtistId(artistId);
            },
            createArtist: function (artist){
                return createArtist(artist);
            },
            createAlbum: function (album) {
                return createAlbum(album);
            },
            addAlbumToArtist: function (artist, album){
                return addAlbumToArtist(artist, album);
            },
            createSong: function (song){
                return createSong(song);
            },
            addSongToAlbum: function (album, song){
                return addSongToAlbum(album, song);
            },
            getAlbumByName: function (albName){
                return getAlbumByName(albName);
            }
        };
    });

