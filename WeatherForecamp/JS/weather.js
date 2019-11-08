function weather() {
    this.buildTable = function() {
        var html = "";
        html += "<tr>";
        html += "<th>Name</th>";
        html += "<th>City</th>";
        html += "<th>Date</th>";
        html += "<th>Logitude</th>";
        html += "<th>Latitude</th>";
        html += "<th>Weather</th>";
        html += "</tr>";

        html += buildContent();

        $('#jsTable').append(html);
    };

    this.buildContent = function () {
        var html = "";

    }
}