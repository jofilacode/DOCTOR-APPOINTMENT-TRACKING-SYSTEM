$(document).ready(function () {

    $(".buy").click(function (evt) {
      
        evt.preventDefault();
        window.location.replace("product.aspx");
    });

    $(".personal img").click(function () {

        $(".dropbox").slideToggle();

    });

    setTimeout(fade_out, 6000);

    function fade_out() {
        $(".msg").fadeOut(9000).empty();

    }

    });