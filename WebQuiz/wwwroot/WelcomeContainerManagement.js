// Clicking Welcome Submit will hide welcomeContainer and show infoContainer
$('#welcomeSubmit').click(
    function (e) {
    document.getElementById("welcomeContainer").style.display = "none";
    document.getElementById("infoContainer").style.display = "block";
});