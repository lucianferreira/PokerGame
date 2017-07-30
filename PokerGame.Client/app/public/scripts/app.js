
'use strict';


var app = angular.module('PokerGame', ['ui.router', 'ui.bootstrap']);

app.config(['$urlRouterProvider', '$stateProvider', '$locationProvider', '$httpProvider', function ($urlRouterProvider, $stateProvider, $locationProvider, $httpProvider) {
            
    // Handle unmatched routes
    $urlRouterProvider
        .when('', '/')
        .when('index.html', '/');
                        
    // State config
    $stateProvider
                
        // Catalog
        .state('main', {
            url: "/",
            views: {
                content: {
                    templateUrl: 'Content/views/game.html',
                    controller: 'gameCtrl'
                }
            }
        })        
                                       
    $locationProvider.html5Mode(true);
    
}]).run(['$rootScope', '$http', '$state', '$location',
function ($rootScope, $http, $state, $location) { 

}]);
