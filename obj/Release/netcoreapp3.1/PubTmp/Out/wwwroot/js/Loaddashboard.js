$(document).ready(function () {
    $("#employeeDropDownList").change(function () {
        $.ajax({
            type: 'GET',
            url: '/LoanDashBoard/GetEmployees',
            datatype: 'JSON',
            data: { 'country': $(this).val() },
            beforeSend: () => {
                $("#loader").show();
            },
            complete: () => {
                $("#loader").hide();
            },
            success: function (data) {
                $('#ld tbody').empty();
                $.each(data, function (i, item) {
                    var rows = "<tr>" +
                        "<td>" + item.LoanID + "</td>" +
                        "<td>" + item.LoanDate + "</td>" +
                        "<td>" + item.LoanUserName + "</td>" +
                        "<td>" + item.TotalLoanAmount + "</td>" +
                        "<td>" + item.TotalPaidEmi + "</td>" +
                        "<td>" + item.TatlBalanceEmi + "</td>" +
                        "<td>" + item.TotalEmi + "</td>" +
                        "<td>" + item.TotalLoanAmount * item.TotalEmi + "</td>" +
                        "</tr>";
                    $('#ld tbody').append(rows);
                });
            },
            error: function (data) { alert(data.responseText); }
        });
    });


    // Stocks search by Number

    function load_data(query) {
        
        $.ajax({
            url: "/StocksDashBoard/Getsearchwithstocks",
            method: "GET",
            data: { stockcount: query },
            beforeSend: () => {
                $("#loader").show();
            },
            complete: () => {
                $("#loader").hide();
            },
            success: function (data) {
                $('#stocktab tbody').empty();
                $.each(data, function (i, item) {
                   
                    var rows = "<tr>" +
                        "<td>" + item.BrokerName + "</td>" +
                        "<td>" + item.StockName + "</td>" +
                        "<td>" + item.BuyPrice + "</td>" +
                        "<td>" + item.TotalShare + "</td>" +
                        "<td>" + item.TotalInvestment + "</td>" +
                        "<td>" + item.Month + "</td>" +
                        "<td>" + item.Year + "</td>" +
                        "</tr>";
                    $('#stocktab tbody').append(rows);
                });
            }
        });
    }


    $("#stockDropDownList").change(function () {
        debugger
        var search = $(this).val();
        $.isNumeric(search);
        Math.floor(search) == search
        if (search != '') {
            load_data(search);
        }
        else {
            load_data();
        }
    });

});