

function confirmDelete(uniqueId, isdeleteClicked) {
    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;

    if (isdeleteClicked) {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    }
    else {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}



$(document).ready(function () {
    ShowEmployeeData();
    
    $("input").change(function () {

        var stockid = document.getElementById("stockid").value;
        var divamount = document.getElementById("divamount").value;
        if (stockid == "") {
            $("#stockid").css("border", "2px solid red");
            $("#stockid").focus();
        }
        if (divamount == "") {
            $("#divamount").css("border", "2px solid red");
            $("#divamount").focus();
        }
        else {
            $("#divamount").css("border", "2px solid black");
            $("#divamount").focus();
            $("#stockid").css("border", "2px solid black");
            $("#stockid").focus();
        }

    });
   
    $("select").change(function () {
        debugger
        var stockid = document.getElementById("stockid").value;
        var divamount = document.getElementById("divamount").value;
        if (stockid == "") {
            $("#stockid").css("border", "2px solid red");
            $("#stockid").focus();
        }
       
        else {
           
            $("#stockid").css("border", "2px solid black");
            $("#stockid").focus();
        }

    });

});

function ShowEmployeeData() {
   
    $.ajax({
        url: '/StockAdmin/DiviidendInfoListRead',
        type: 'Get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            var total = 0;
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + item.stockname + '</td>';
                object += '<td>' + item.dividendAmount + '</td>';
                object += '<td>' + item.year + '</td>';
                object += '<td><a href="#" class="btn btn-primary">Edit</a>||<a href="#" class="btn btn-danger">Delete</a></td>';
                object += '</tr>';
                if (!isNaN(item.dividendAmount))
                    total = total + item.dividendAmount;
            })
            $('#table_data').html(object);
            $('#tfoot').html(total);
            

        },
        error: function() {
            Alert('no data');
        }
       
    })
}

$('#adddividend').click(function () {
  /*  $("#dividendmodal").modal('show',{ backdrop: 'static', keyboard: false });*/
    $('#dividendmodal').modal('show');
    
})

$('#modalclose').click(function () {
    debugger
    $('#dividendmodal').modal('hide');
    ClearText();
    $("#divamount").css("border", "2px solid black");
    $("#divamount").focus();
    $("#stockid").css("border", "2px solid black");
    $("#stockid").focus();
   
 })


//close HideModalPopUp
function HideModalPopUp() {
        $('#dividendmodal').modal('hide');
}

//clear textboxes from Adddividend

function ClearText() {
    $('#stockid').val('');
    $('#divamount').val('');
}

function successmsg() {
    $('#sucmsg').show();
}

function Validate() {
    var stockid = document.getElementById("stockid").value;
    var divamount = document.getElementById("divamount").value;
    if (stockid == "") {
        $("#stockid").css("border", "2px solid red");
        $("#stockid").focus();
    }
    if (divamount == "") {
        $("#divamount").css("border", "2px solid red");
        $("#divamount").focus();
    }
   
    return;
}

//Add dividend

function AddDividend() {
   
    var objData = { 
        stockname: $('#stockid').val(),
        dividendAmount: $('#divamount').val(),
        year: $('#yr').val()
    }
    $.ajax({
        url: '/StockAdmin/AddDividend',
        type: 'Post',
        data: objData,
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: 'json',
        success: function (result) {
            //alert(result);
            if (result.success === true) {
                toastr.success(result.message, 'Success Alert', { timeOut: 3000 });
            }
            else {
                toastr.error(result.message, 'Error Alert', { timeOut: 3000 });
                Validate();
            }
            ShowEmployeeData();
            /* HideModalPopUp();*/
            ClearText();
        },
        error: function() {
            alert('Error');
        }
    })
}



// To get the add Extra stocks

//To show Modal Popup
$('#addextrastocks').click(function () {
    /*  $("#dividendmodal").modal('show',{ backdrop: 'static', keyboard: false });*/
    var url = "/StockAdmin/Addextrastock";
    $('#myModalBodyDiv1').load(url, function () {
        $('#mymodal1').modal("show");
    })
   

})

//function Addextrastocks() {
//    var url = "/StockAdmin/Addextrastock";
//    $('#myModalBodyDiv1').load(url, function () {
//        $('#mymodal1').modal("show");
//    })
//}

//To close Modal Popup
$('#extrastockmodalclose').click(function () {
    debugger
    $('#mymodal1').modal('hide');
})

// add extrastock
function Addextrastock() {
    debugger
    var objData = {
        brokerid: $('#brokerid').val(),
        stockid: $('#id').val(),
        buyprice: $('#buyprice').val(),
        totalshare: $('#totalshare').val(),
        totalinvestment: $('#totalinvestment').val(),
        month: $('#month').val(),
        year: $('#year').val()
    }
    $.ajax({
        url: '/StockAdmin/Addextrastock',
        type: 'Post',
        data: objData,
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: 'json',
        success: function (result) {
            //alert(result);
            if (result.success === true) {
                debugger
                toastr.success(result.message, 'Success Alert', { timeOut: 3000 });
            }
            else {
                toastr.error(result.message, 'Error Alert', { timeOut: 3000 });
               
            }
        },
        error: function () {
            alert('Error');
        }
    })
}

////// Add Income Loss ////////////////////////
function Adddailyprofitloss() {
    var url = "/StockAdmin/AddDailyIncomeLoss";
    $('#myModalBodyDiv2').load(url, function () {
        $('#mymodal2').modal("show");
    })
}

//To close Modal Popup
$('#CloseDailyProfitLoss').click(function () {
    debugger
    $('#mymodal2').modal('hide');
})


function AddDailyIncomeLoss() {
    debugger
    var objData = {
        option: $('#option').val(),
        incomeloss: $('#incomeloss').val(),
        createat: $('#createat').val(),
      
    }
    $.ajax({
        url: '/StockAdmin/AddDailyIncomeLoss',
        type: 'Post',
        data: objData,
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: 'json',
        success: function (result) {
            //alert(result);
            if (result.success === true) {
                debugger
                toastr.success(result.message, 'Success Alert', { timeOut: 3000 });
            }
            else {
                toastr.error(result.message, 'Error Alert', { timeOut: 3000 });

            }
        },
        error: function () {
            alert('Error');
        }
    })
}