var app = angular.module('MyApp', []);
app.controller('numbers', function ($scope)
{
    $scope.list = [5, 10, 15, 20, 25, 30, 35];
});
function showMap(stops) {

    if (stops && stops.length > 0) {

        var mapStops = _.map(stops, function (item) {
            return {
                lat: item.Latitude,
                long: item.Longitude,
                info: item.Name
            };
        });

        // Show Map
        travelMap.createMap({
            stops: mapStops,
            selector: "#map",
            currentStop: 1,
            initialZoom: 3
        });

    }
}