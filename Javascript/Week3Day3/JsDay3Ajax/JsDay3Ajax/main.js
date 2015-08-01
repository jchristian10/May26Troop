//var xhr = new XMLHttpRequest();

//    xhr.addEventListener('load', function (e) {
//    var data = JSON.parse(xhr.responseText);
//    console.dir(data);
//});

//xhr.open('GET', '/products.json');
//xhr.send();
////-------------------------------------------------------

//var request = new XMLHttpRequest();

//request.open('GET', '/products.json');

//request.onload = function () {
//    var data = JSON.parse(this.response);
//    console.dir(data);
//}

//request.send();
$('#submit').click(function () {
    var userName = $('#userName').val();
    var repoURL = 'https://api.github.com/users/' + userName + '/repos';
    $.getJSON(repoURL).done(function (data) {
        console.log(data);
        //data.forEach(function (item) {
        //    $('#infoTable').prepend('<tr><td>' + item.val() + '</td></tr>');
        //});
    });
});

//$('a').click(function () {
//    $('#myTable tbody').append('<tr class="child"><td>blahblah</td></tr>');
//});


//var data = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

//var html = '<table><thead><tr>...</tr></thead><tbody>';
//for (var i = 0, len = data.length; i < len; ++i) {
//    html += '<tr>';
//    for (var j = 0, rowLen = data[i].length; j < rowLen; ++j) {
//        html += '<td>' + data[i][j] + '</td>';
//    }
//    html += "</tr>";
//}
//html += '</tbody><tfoot><tr>....</tr></tfoot></table>';

//$(html).appendTo('#div1');

//items.push('<li><a href="yourlink?id=' + item.UserID + '">' + item.Username + '</a></li>');