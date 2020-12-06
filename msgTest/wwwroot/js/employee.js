$(document).ready(function () {
    $("#btnGetEmployee").click(() => {
        let val = $("#txtEmployeeId").val();
        if (val.trim() == "") {
            getEmployees();
        } else {
            getEmployeeById(val);
        }
    })
    
    function getEmployees() {
        $("#loader").show();
        $('#employeeTable tbody').empty();
        $.ajax({
            url: "api/Employee",
            method: "GET"
        }).done((response) => {
            if (response.success && response.data != null) {
                var trHTML = '';
                $.each(response.data, function (i, item) {
                    trHTML += '<tr><td>' + item.id + '</td><td>' + item.name + '</td><td>' + item.contractTypeName + '</td><td>' + item.roleName + '</td><td>' + item.calculatedAnnualSalary + '</td></tr>';
                })
                $('#employeeTable tbody').append(trHTML);
            } else {
                showErrorMessage(response.message);
            }
            $("#loader").hide();
        }).fail(function () {            
            showErrorMessage("Request failed");
            $("#loader").hide();
        });
    }

    function getEmployeeById(id) {
        $("#loader").show();
        $('#employeeTable tbody').empty();
        $.ajax({
            url: "api/Employee/" + id,
            method: "GET"
        }).done((response) => {
            if (response.success && response.data != null) {
                var trHTML = '<tr><td>' + response.data.id + '</td><td>' + response.data.name + '</td><td>' + response.data.contractTypeName + '</td><td>' + response.data.roleName + '</td><td>' + response.data.calculatedAnnualSalary + '</td></tr>';
                $('#employeeTable tbody').append(trHTML);
            } else {
                showErrorMessage(response.message);
            }
            $("#loader").hide();
        }).fail(function () {
            showErrorMessage("Request failed");
            $("#loader").hide();
        });
    }

    function showErrorMessage(errorMessage) {
        $("#divErrorMessage").show();
        $("#errorMessage").text(errorMessage);    
    }
});