$('#btnSend').click(function () {
    finalGrade = (parseFloat($('#txtAssignments').val()) * .55) +
        (parseFloat($('#txtProjects').val()) * .05) +
        (parseFloat($('#txtQuizzes').val()) * .1) +
        (parseFloat($('#txtExams').val()) * .2) +
        (parseFloat($('#txtIntex').val()) * .1);

    if (finalGrade >= 94) {
        letterGrade = "A"
    } else if (finalGrade >= 90) {
        letterGrade = "A-"
    } else if (finalGrade >= 87) {
        letterGrade = "B+"
    } else if (finalGrade >= 84) {
        letterGrade = "B"
    } else if (finalGrade >= 80) {
        letterGrade = "B-"
    } else if (finalGrade >= 77) {
        letterGrade = "C+"
    } else if (finalGrade >= 74) {
        letterGrade = "C"
    } else if (finalGrade >= 70) {
        letterGrade = "C-"
    } else if (finalGrade >= 67) {
        letterGrade = "D+"
    } else if (finalGrade >= 64) {
        letterGrade = "D"
    } else if (finalGrade >= 60) {
        letterGrade = "D-"
    }else {
        letterGrade = "E"
    }

    alert("Your final grade is " + finalGrade + "%. You have an " + letterGrade + " in the class.");
})

