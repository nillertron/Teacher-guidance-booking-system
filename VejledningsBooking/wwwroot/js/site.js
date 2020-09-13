function CreateUserSwitchType() {
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