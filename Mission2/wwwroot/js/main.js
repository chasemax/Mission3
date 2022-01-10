// Assign the following function to the "calculate" button
$("#calculate").click(function () {

    // First, grab all the grades that the user has entered into the site
    var a_grade_weighted = $("#a_grade").val() * 0.55;
    var g_grade_weighted = $("#g_grade").val() * 0.05;
    var q_grade_weighted = $("#q_grade").val() * 0.10;
    var e_grade_weighted = $("#e_grade").val() * 0.20;
    var i_grade_weighted = $("#i_grade").val() * 0.10;

    // Next, calculate their final grade
    var final_grade = Math.round(a_grade_weighted + g_grade_weighted + q_grade_weighted + e_grade_weighted + i_grade_weighted);

    // Select the letter grade that matches their final grade
    var final_letter_grade = 'A';

    if (final_grade < 90) {
        final_letter_grade = 'B';
    }
    if (final_grade < 80) {
        final_letter_grade = 'C';
    }
    if (final_grade < 70) {
        final_letter_grade = 'D';
    }
    if (final_grade < 60) {
        final_letter_grade = 'F';
    }

    // Update the page to show the user their final grade and grade letter
    $("#final_grade").html("Your final grade is: " + final_grade + "% (" + final_letter_grade + ")");

});

