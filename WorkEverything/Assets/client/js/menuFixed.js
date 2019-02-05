(function ($) {
    var defaults = {
        min: 75,
        containerClass: 'fixed'
    },
        settings = $.extend(defaults);

    $(window).scroll(function () {
        var sd = $(window).scrollTop();
        if (typeof document.body.style.maxHeight === "undefined") {
            $(containerIDhash).css({
                'position': 'absolute',
                'top': sd + $(window).height() - 50
            });
        }
        if (sd > settings.min) {
            console.log("Lon");
            $(".main-top").addClass(settings.containerClass);
        }
        else {
            console.log("Nho");
            $(".main-top").removeClass(settings.containerClass);
        }
    });
})(jQuery);