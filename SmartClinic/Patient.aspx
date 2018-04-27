<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patient.aspx.cs" Inherits="SmartClinic.Patient" %>

<!DOCTYPE html>
<html class="no-js">
<!--<![endif]-->
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta name="description" content="Aviato E-Commerce Template">

    <meta name="author" content="Themefisher.com">

    <title>Smart Clinic </title>

    <!-- Mobile Specific Meta-->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Favicon -->
    <link rel="shortcut icon" type="image/x-icon" href="img/favicon.png" />
    <!-- bootstrap.min css -->
    <link rel="stylesheet" href="plugins/bootstrap/css/bootstrap.min.css">
    <!-- Ionic Icon Css -->
    <link rel="stylesheet" href="plugins/Ionicons/css/ionicons.min.css">
    <!-- animate.css -->
    <link rel="stylesheet" href="plugins/animate-css/animate.css">
    <!-- Magnify Popup -->
    <link rel="stylesheet" href="plugins/magnific-popup/dist/magnific-popup.css">
    <!-- Owl Carousel CSS -->
    <link rel="stylesheet" href="plugins/slick-carousel/slick/slick.css">
    <link rel="stylesheet" href="plugins/slick-carousel/slick/slick-theme.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <!-- Main Stylesheet -->
    <link rel="stylesheet" href="css/style.css">
</head>

<body id="body">

    <!-- Header Start -->
    <header class="navigation">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <!-- header Nav Start -->
                    <nav class="navbar">
                        <div class="container-fluid">
                            <!-- Brand and toggle get grouped for better mobile display -->
                            <div class="navbar-header">
                                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                                    <span class="sr-only">Toggle navigation</span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                </button>
                                <a class="navbar-brand" href="index.html">
                                    <img src="images/logo.png" alt="Logo">
                                </a>
                            </div>
                            <!-- Collect the nav links, forms, and other content for toggling -->
                            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                                <ul class="nav navbar-nav navbar-right">
                                    <li><a href="Homepage.aspx"><b>Home</b></a></li>
                                    <li><a href="service.html">Registration</a></li>
                                    <li><a href="blog-grid.html">Appointment</a>
                                    </li>
                                    <li><a href="Contact.aspx">Contact</a></li>
                                </ul>
                            </div>
                            <!-- /.navbar-collapse -->
                        </div>
                        <!-- /.container-fluid -->
                    </nav>
                </div>
            </div>
        </div>
    </header>
    <!-- header close -->
    <!-- startBody-->
    <div class="jumbotron text-center">
        <h2>Samart Clinic Appointment</h2>
    </div>
    <div class="container">
        <form runat="server">
            <div class="row">
                <div class="col-sm-4">

                    <h3><b><mark>Appointments</mark></b></h3>
                    <p>Please select the Appointment from the list below.</p>
                    <b>Doctor Name:</b>
                    <br>
                    <select name="DropDownListDoctor" id="DropDownListDoctor" class="form-control">
                        <option value="0">Select Doctor</option>
                        <asp:Literal runat="server" ID="doctorsList"></asp:Literal>
                    </select><br>

                    <br>
                    <b>Date:</b>
                    <br>
                    <div class="input-group date" id="datetimepicker1">
                        <input name="SelectedDate" type="text" id="SelectedDate" class="form-control">
                        <span class="input-group-addon">
                            <span class="glyphicon glyphicon-calendar"></span>
                        </span>
                    </div>
                    <div class="row" style="padding-top: 10px;">
                        <div class="col-lg-2">
                            <input type="button" name="showAvalability" value="Show Avalibility" id="showAvalability" class="btn btn-info">
                            <img src="https://media.giphy.com/media/l3q2SWX1EW3LdD7H2/giphy.gif" width="30" id="loader" />
                            <br />
                        </div>
                    </div>
                </div>
                <div class="col-lg-8">
                    <h3>List of Avalabilities</h3>
                    <table class="table table-bordered table-hover" id="tableBodyHead">
                        <thead>
                            <tr>
                                <th>Date</th>
                                <th>Time</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                    </table>
                    <table class="table table-bordered table-hover" id="tableBody">
                        <tr></tr>
                    </table>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-3">

                    <br>
                    Doctor Name:<br>
                    <input name="DoctorId" type="text" id="DoctorId" class="form-control">
                </div>
                <div class="col-sm-3">
                    <br>
                    Date:<br>
                    <input name="Date" type="text" id="Date" class="form-control">
                </div>
                <div class="col-sm-3">
                    <br>
                    Hour:<br>
                    <input name="Hour" type="text" id="Hour" class="form-control">
                </div>
                <input type="hidden" id="doctorIdn" />
                <div class="col-sm-3" style="margin-bottom: 30px">
                    <br>
                    <br>
                    <input type="button" name="btnSave" value="Save Avalibility" id="btnSave" class="btn btn-info"><br>
                </div>
            </div>
        </form>
    </div>
    <footer class="footer">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="footer-manu">
                    </div>
                    <p class="copyright">
                        Copyright 2018 © Design &amp; Developed by <a href="http://www.collegelasalle.com/">LaSalle College</a>. All rights reserved.
                    </p>
                </div>
            </div>
        </div>
    </footer>

    <script src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.9.0/moment-with-locales.js"></script>
    <script type="text/javascript" src="https://cdn.rawgit.com/Eonasdan/bootstrap-datetimepicker/e8bddc60e73c1ec2475f827be36e1957af72e2ea/src/js/bootstrap-datetimepicker.js"></script>
    <script type="text/javascript">
        $(function () {

            $('#loader').hide();

            $('#datetimepicker1,#datetimepicker2').datetimepicker({
                format: "YYYY-MM-DD",
                minDate: moment().add(-1, 'd').toDate(),
            });

            $('#btnDelete').click(function (e) {
                return getConfirm($('#ProjectCode'));
            });

            //Ajax Request : Get Availability
            $('#showAvalability').click(function () {
                GetAvailableHours();
            });

            //On Select
            $('body').on('click', '.btnselectapp', function () {
                var sdate = $(this)[0].attributes.getNamedItem('sDate').value;
                var stime = $(this)[0].attributes.getNamedItem('sTime').value
                var sid = $(this)[0].attributes.getNamedItem('sId').value

                $('#DoctorId').val($('#DropDownListDoctor').find(":selected").text());
                $('#Date').val(sdate.replace('T00:00:00', ''));
                $('#Hour').val(stime);
                $('#doctorIdn').val(sid);
            });

            //On Save
            $('#btnSave').click(function () {
                var doctorid = $('#doctorIdn').val();
                var date = $('#Date').val();
                var hour = $('#Hour').val();

                //Send Request to Save
                $('#loader').show();
                $.get("api/mainapi.aspx", { action: "addAppointment", id: doctorid, date: date, hour: hour })
                    .done(function () {
                        GetAvailableHours();
                        $('#loader').hide();
                    }).fail(function () {
                        alert("Error on Save");
                    });
            });
        });

        //Get Available Hours
        function GetAvailableHours() {
            $('#loader').show();
            var doctorId = $('#DropDownListDoctor').find(":selected").val();
            var selectedDate = $('#SelectedDate').val();

            $.getJSON("api/mainapi.aspx", { action: "getAvailableTime", id: doctorId, date: selectedDate })
                .done(function (json) {
                    var data = json;
                    $('#tableBody tr').empty();

                    for (var i = 0; i < data.length; i++) {
                        $('#tableBody tr:last').after("<tr><td width='35%'>" + data[i].Date.replace('T00:00:00', '') + "</td><td>" + data[i].Time + "</td><td><input type='button' id='btnSelectApp" + i + "' sDate='" + data[i].Date + "' sTime='" + data[i].Time + "' sId='" + doctorId + "' class='btnselectapp btn btn-primary' value='Select' /></td></tr>");
                    }

                    $('#loader').hide();
                })
                .fail(function (jqxhr, textStatus, error) {
                    var err = textStatus + ", " + error;
                    console.log("Request Failed: " + err);
                    $('#loader').hide();
                });
        }


        function showData(a, b, c) {
            $('#ProjectCode').val(a);
            $('#ProjectTitle').val(b);
            $('#SelectedDate').val(c);
        }

        function getConfirm(a) {
            return confirm("Are you sure you want to remove this project ?");
        }
    </script>
    <!--EndBody-->

</body>

</html>
