angular.module('ONETUG', []);

angular.module('ONETUG').controller('contributorsController', ['$scope', '$http', function ($scope, $http) {
    $scope.init = function (owner, repro) {
        $http.jsonp("https://api.github.com/repos/" + owner + "/" + repro + "/contributors?callback=JSON_CALLBACK").then(function (result) {
            $scope.contributors = result.data.data;
        });
    }
}]);

angular.module('ONETUG').controller('teamController', ['$scope', '$http', function ($scope, $http) {
    $scope.init = function (url) {
        $http.get(url).then(function (result) {
            $scope.team = result.data;
        });
    }
}]);

angular.module('ONETUG').controller('eventsController', ['$scope', '$http', function ($scope, $http) {
    $scope.init = function (url) {
        //$scope.events = [{ "VenueName": "Sample event place", "VenueAddress": "15010 NE 36th Street Redmond, WA  ", "NumberRSVPedYes": 21, "MeetingDescriptionHTML": "<p>Join us for one of our regular Nerd Dinners. These are events are simply social and have no planned agenda.</p> <p>Naturally there will be .NET developers there but we welcome developers and IT professionals from all disciplines. The more diversity, the better the conversation. :-)</p>", "MeetingTime": "10/23/2014 7:00 PM - 9:00 PM", "Url": "http://msdn.microsoft.com/", "Name": "ONETUG Nerd Dinner" }]
        $http.get(url).then(function (result) {
            $scope.events = result.data;
        });
    }

    $scope.attendees = function (count) {
        return Math.max(2, count)
    }
}]);

angular.module('ONETUG').controller('sponsorsController', ['$scope', '$http', function ($scope, $http) {
    $scope.init = function (url) {
        //$scope.sponsors = [{ "Name": "Viewpost", "CompanyUrl": "https://www.onetug.org", "ImageUrl": "http://www.onetug.org/images/onetug.png", "Info": "Sample sponsor", "Details": "Sample sponsor info." }]
        $http.get(url).then(function (result) {
            $scope.sponsors = result.data;
        });
    }
}]);

angular.module('ONETUG').controller('groupController', ['$scope', '$http', function ($scope, $http) {
    $scope.init = function (url) {
        //$scope.group = { "GroupUrl": "http://www.meetup.com/ONETUG/", "ImageUrl": "http://photos1.meetupstatic.com/photos/event/e/a/4/4/600_362039972.jpeg", "Description": "<p>ONETUG was founded by Joel Martinez in 2001. Our goal is to showcase great speakers &amp; content centered around, but not restricted to, the Microsoft .NET stack. We strive to bring together developers from all platforms by holding monthly meetings, Nerd Dinners &amp; an annual Codecamp. Our vision is to collaborate with other tech groups &amp; help build Orlando into a major hub for technology companies &amp; startups.</p>", "Name": "ONETUG - Orlando .NET User Group" };
        $http.get(url).then(function (result) {
            $scope.sponsors = result.data;
        });
    }
}]);
