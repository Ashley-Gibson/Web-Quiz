// Set button name value to determine correct answers
$(window).onload(function () {
    document.getElementById("answerOne").name = "incorrect";
    document.getElementById("answerThree").name = "correct";
})

// Clicking Answer One will show a sucess message
$('#answerOne').click(
        function (e) {
        // Change answer button colour
        this.style.backgroundColor = "red";

    // Disable other answer options
    document.getElementById("answerTwo").disabled = "disabled";
    document.getElementById("answerThree").disabled = "disabled";
    document.getElementById("answerFour").disabled = "disabled";

    // Show success label
            document.getElementById("failLabel").style.display = "block";
});

// Clicking Answer Two will show a sucess message
$('#answerTwo').click(
        function (e) {
        // Change answer button colour
        this.style.backgroundColor = "red";

    // Disable other answer options
    document.getElementById("answerOne").disabled = "disabled";
    document.getElementById("answerThree").disabled = "disabled";
    document.getElementById("answerFour").disabled = "disabled";

    // Show fail label
            document.getElementById("failLabel").style.display = "block";
});

// Clicking Answer Three will show a sucess message
$('#answerThree').click(
        function (e) {
        // Change answer button colour
        this.style.backgroundColor = "green";

    // Disable other answer options
    document.getElementById("answerOne").disabled = "disabled";
    document.getElementById("answerTwo").disabled = "disabled";
    document.getElementById("answerFour").disabled = "disabled";

    document.getElementById("answerThree").name = "correct";


    // Show fail label
    document.getElementById("successLabel").style.display = "block";
});

// Clicking Answer Four will show a sucess message
$('#answerFour').click(
        function (e) {
        // Change answer button colour
        this.style.backgroundColor = "red";

    // Disable other answer options
    document.getElementById("answerOne").disabled = "disabled";
    document.getElementById("answerTwo").disabled = "disabled";
    document.getElementById("answerThree").disabled = "disabled";

    // Show fail label
    document.getElementById("failLabel").style.display = "block";
});