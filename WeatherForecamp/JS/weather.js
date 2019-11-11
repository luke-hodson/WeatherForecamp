function weather(data) {
    //this is called from inside Index.cshtml
    //this data is the serialized data passed through
    this.data = data;

    //a method to build the table structure dynamically
    this.buildTable = function () {

        //this is dynamic html
        var html = "";
        html += "<tr>";
        html += "<th>Name</th>";
        html += "<th>City</th>";
        html += "<th>Date</th>";
        html += "<th>Logitude</th>";
        html += "<th>Latitude</th>";
        html += "<th>Weather</th>";
        html += "</tr>";

        //grab the content
        html += this.buildContent();

        //add to the page
        $('#jsTable').append(html);
    };

    //method to build the content
    this.buildContent = function () {
        var html = "";

        //get the JSON data into an JS object so we can access the data        
        var festObj = JSON.parse(this.data);
        //debugger; //you can use debuggers to breakpoint JS code in the browser, uncomment this line and refresh the page with Inspect element open, then hover over festObj to see the object structure


        //loop through the data
        for (var i = 0; i < festObj.length; i++) {
            var festItem = festObj[i];
            html += '<tr style="border-bottom: 2px solid black">';
            html += '<td>' + festItem.Name + '</td>';
            html += '<td>' + festItem.City + '</td>';
            html += '<td>' + festItem.Date + '</td>';
            html += '<td>' + festItem.Longitude + '</td>';
            html += '<td>' + festItem.Latitude + '</td>';
            html += '<td>';

            //inside the fesitval object we have an array of 'Weather' object (a list of weather over the year for this festival) - so let's loop through
            for (var j = 0; j < festItem.Weather.length; j++) {
                //get the current item we're looking through
                var weatherItem = festItem.Weather[j];

                //build more html
                html += '<p><b>';
                html += weatherItem.Year + '</b>,';
                html += 'Temperature - ' + weatherItem.Temperature + ',';
                html += 'Feels like - ' + weatherItem.FeelsLikeTemp + ',';
                html += 'Humidity - ' + weatherItem.Humidity + ',';
                html += 'Visibility - ' + weatherItem.Visibility + ',';
                html += 'Wind direction - ' + weatherItem.WindDirection + ',';
                html += 'Wind speed - ' + - weatherItem.WindSpeed;
                html += '</p>';
            }          

            //close of the table
            html += '</td>';
            html += '</tr>';
        }

        //return the dynamic html
        return html;          
    };
}