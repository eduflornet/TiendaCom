'use strict';

// the storeController contains two objects:
// - store: contains the product list
// - cart: the shopping cart object
function storeController($scope, $routeParams, DataService, $http) {

    // get store and cart from service
    
    $scope.cart = DataService.cart;
    $scope.store = DataService.store;
    var path = "http://tiendacom-api.azurewebsites.net/api/Componentes";
    $http({
        method: 'GET',
        url: path
    }).then(function successCallback(response) {
        console.log("response -->" + response);
    }, function errorCallback(response) {
        console.log("response -->" + response);
    });
    


    // use routing to pick the selected product
    if ($routeParams.productSku != null) {
        // obtengo un solo producto
        $scope.product = $scope.store.getProduct($routeParams.productSku);
    }
}
