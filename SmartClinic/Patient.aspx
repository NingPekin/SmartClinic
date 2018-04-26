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
                        <option value="-1">Select Doctor</option>
                        <option value="2">Ning Wei</option>
                        <option value="3">Farzaneh fallahi</option>
                        <option value="4">Zohreh Moeini</option>
                        <option value="5">Abdul Sadigh</option>
                        <option value="6">Manpreet kaur</option>

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
                            <input type="submit" name="showAvalability" value="Show Avalibility" id="showAvalability" class="btn btn-info"><br>
                        </div>
                    </div>
                </div>
                <div class="col-lg-8">
                    <h3>List of Avalabilities</h3>
                    <asp:Literal runat="server" ID="grid"></asp:Literal>
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
                <div class="col-sm-3" style="margin-bottom: 30px">
                    <br>
                    <br>
                    <input type="submit" name="Button1" value="Save Avalibility" id="Button1" class="btn btn-info"><br>
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
            $('#datetimepicker1,#datetimepicker2').datetimepicker({
                format: "YYYY-MM-DD"
            });

            $('#btnDelete').click(function (e) {
                return getConfirm($('#ProjectCode'));
            });
        });

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
