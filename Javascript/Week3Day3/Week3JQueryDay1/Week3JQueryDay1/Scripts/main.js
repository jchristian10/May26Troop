$('button').click(function (e) {

    if ($(this).html === "Show") {
        $(this).html === 'Hide';
    } else {
        $(this).html === 'Show';
    }

    e.preventDefault();
    $('#message').fadeToggle('slow');
    if ($(this).html === "Show") {
        $(this).html === 'Hide';
    } else {
        $(this).html === 'Show';
    }


});


//this.innerHTML = this.innerHTML === "OPEN" ? "CLOSE" : "OPEN"
//$(".pushme").toggle(function() {
//    $(this).text("DON'T PUSH ME");
//}, function() {
//    $(this).text("PUSH ME");
//});

//$(function () {
//    $(".pushme").click(function () {
//        $(this).text(function (i, text) {
//            return text === "PUSH ME" ? "DON'T PUSH ME" : "PUSH ME";
//        })
//    });
//})