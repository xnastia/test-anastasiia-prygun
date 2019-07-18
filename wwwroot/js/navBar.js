function onNavBtnClick(id) {
    $(".nav-btn-active").addClass('nav-btn').removeClass('nav-btn-active');
    $("#" + id).addClass('nav-btn-active').removeClass('nav-btn');
}