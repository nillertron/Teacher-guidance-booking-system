﻿function CreateUserSwitchType() {
    var picker = document.getElementById("selectCreateType");
    var type = picker.options[picker.selectedIndex].text;
        var element = document.getElementById("CreateForm");
    if (type == "Student") {
        var teacherElement = document.getElementById("speciality")
        if (teacherElement)
            teacherElement.remove();
    }
        else if (type == "Teacher") {
        if (!document.getElementById("speciality")) {
            var textfield = CreateTextFieldForForm('speciality', "Teacher.Speciality", "Speciality")
            
            element.insertBefore(textfield, element.getElementsByTagName('button'));
            }

        }
    }

function CreateTextFieldForForm(id, name, placeholder) {
    var textfield = document.createElement("input");
    textfield.type = "Text";
    textfield.setAttribute("name", name);
    textfield.id = id;
    textfield.classList.add("form-control");
    textfield.placeholder = placeholder;
    return textfield;
}


    function PostWithoutRefresh(buttonClicked, modal) {
        var $form = $(buttonClicked).parents('form');
        $.ajax({
        type: "POST",
            url: $form.attr('action'),
            data: $form.serialize(),
            error: function (xhr, status, errorcode) {
                console.log(xhr.responseText)
                var result = JSON.parse(xhr.responseText);


                document.getElementById(modal).innerHTML += result.message;
            },
            success: function (response) {
        window.parent.location.reload();
            }
        });
    }
    function retrieveId(id) {
        var storedId = id.id;
        document.getElementById('TimeslotHiddenId').value = storedId;
        ajaxGetTimeslot(storedId);
    }
    function ToggleModal(modalToToggle) {
        $('#' + modalToToggle).modal({
            show: true
        });
    }

function ajaxGetTimeslot(id) {
    $.ajax({
        type: "GET",
        url: "../Booking/TimeslotAjaxGet?id=" + id,
        contentType: 'json',
        success: function (response) {
            var dt1 = GetDateTimeFromString(response.theTimeslot.startDateTime);
            var dt2 = GetDateTimeFromString(response.theTimeslot.endDateTime);

            var printableStartDate = dt1.getDate() + '/' + dt1.getMonth() + '/' + dt1.getFullYear() + ' ' + dt1.getHours() + ':' + dt1.getMinutes();
            var printableEndDate = dt2.getDate() + '/' + dt2.getMonth() + '/' + dt2.getFullYear() + ' ' + dt2.getHours() + ':' + dt2.getMinutes();


            document.getElementById('bookStartTime').innerHTML = printableStartDate;
            document.getElementById('bookEndTime').innerHTML = printableEndDate;
            document.getElementById('hiddenbookStartTime').value = printableStartDate;
            document.getElementById('hiddenbookEndTime').value = printableEndDate;
            document.getElementById('rowVersion').innerHTML = response.theTimeslot.rowVersion;
            document.getElementById('lblFirstnameTeacher').innerHTML = response.thePerson.firstName;



        }
    });
}
function GetDateTimeFromString(input) {
    var dt = input.replace(/[^0-9 :]/g, '');
    var year = dt.substring(0, 4);
    var month = dt.substring(4, 6);
    var date = dt.substring(6, 8);
    var hour = dt.substring(8, 10);
    var minute = dt.substring(11, 13);
    var dateTimeToReturn = new Date();
    dateTimeToReturn.setFullYear(year, month, date);
    dateTimeToReturn.setHours(hour, minute, 0);
    return dateTimeToReturn;
}