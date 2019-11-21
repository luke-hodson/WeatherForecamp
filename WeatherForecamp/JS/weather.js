function weather(data) {
    //this is called from inside Index.cshtml
    //this data is the serialized data passed through
    this.data = data;
    this.filteredResults = [];
    this.useFilter = false;

    //a method to build the table structure dynamically
    this.buildTable = function () {                         
        //this is dynamic html
        var html = "<table>";
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

        //this created a new empty javascript object (look it up)
        var festObj = {};       

        //if(this.useFilter) is the same as if(this.useFilter == true)
        if (this.useFilter) {
            //on the first run this is false (see at the top its assigned to false)
            //if this.useFilter is true, apply the filtered results to the oject
            festObj = this.filteredResults;
        }
        else {
            //if this.use filter is false (like on the first time this is ran)
            //take the JSON data (look it up) and deserialize it in objects
            //this is done so we can access the data and use it
            festObj = JSON.parse(this.data);
        }

        //debugger; //you can use debuggers to breakpoint JS code in the browser, uncomment this line and refresh the page with Inspect element open, then hover over festObj to see the object structure

        //so right now our data is an array of objects (a list of data about festivals)
        //as it's an array of something, we can loop through the data
        for (var i = 0; i < festObj.length; i++) {
            //i is the index of the loop, so this accesses the element in the array at index i
            //so if i=0, festobj[0] is the first item in the array (indexes start at base 0)
            //so festItem is an object containing information about the first festival in the list
            var festItem = festObj[i];

            //here we build more dynamic html, festItem.Name is the name of the first item in the array if i=0 (e.g. Reading festival)
            html += '<tr style="border-bottom: 2px solid black">';
            html += '<td>' + festItem.Name + '</td>';
            html += '<td>' + festItem.City + '</td>';
            html += '<td>' + festItem.Date + '</td>';
            html += '<td>' + festItem.Longitude + '</td>';
            html += '<td>' + festItem.Latitude + '</td>';
            html += '<td>';

            //inside the festItem object, there is another array of objects that contains weather data
            //so we loop through this weather data to also display this in each of the festival rows
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
                html += 'Wind speed - ' + weatherItem.WindSpeed;
                html += '</p>';
            }          

            //close of the table
            html += '</td>';
            html += '</tr>';            
        }

        html += '</table>';

        //return the dynamic html
        return html;          
    };

    //this method is called when you start typing in the search box
    this.filterList = function () {
        //grab the search term
        var searchTerm = $('#filter-box').val();

        //get the data from the serialized JSON into an array of objects
        var dataObj = JSON.parse(this.data);

        //if there is something in the search term
        if (searchTerm != "") {
            //this method just filters down the array of items
            this.filteredResults = dataObj.filter(function (el) {
                //basically is grabs out the names of the festivals and changes them to uppercase (so you can search for reading and READING and it'll work)
                var name = el.Name.toUpperCase();
                return name.indexOf(searchTerm.toUpperCase()) >= 0; //then it returns the data if it finds a match
            });
        }
        else {
            //if no search term, reset the list and return everything
            this.filteredResults = dataObj.slice();
        }               

        //as this method has been called we went to use a filter, so set the boolean to true
        this.useFilter = true;

        //clear the html in the table
        $("#jsTable table").remove(); 

        //as we have filtered down the data and assigned it to this.filteredResults, let's build the table again
        this.buildTable();
    };
}
