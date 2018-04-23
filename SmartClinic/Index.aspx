<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patient.aspx.cs" Inherits="SmartClinic.Patient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <style>
        body, html {
            overflow-x: hidden;
        }
        
        h1 {
            font-family: "Times New Roman";
            color: #f40b0b;
        }

        p {
            font-family: "Times New Roman";
            color: #f40b0b;
            font-size: 20px;
            text-align: justify;
        }

        #footer {
            bottom: 0px;
            height: 40px;
            padding-bottom: 17px;
            margin-top: 5px;
            background-color: #000000;
            color: #fffefe;
            vertical-align: middle;
            padding-top: 10px;
        }

        .navbar {
            border-radius: 0px !important;
        }
    </style>
</head>
<body >
    <!-- START MENU-->
    <div class="row">
        <div class="col-lg-12">
            <nav class="navbar navbar-inverse">
                <div class="container-fluid">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" href="#">
                            <p><b>Smart Clinic</b></p>
                        </a>
                    </div>
                    <div id="navbar" class="navbar-collapse collapse">
                        <ul class="nav navbar-nav">
                            <li class="active"><a href="Index.aspx">Home</a></li>
                            <li><a href="Registeration.aspx">registration</a></li>
                            <li><a href="Patient.aspx">Appointment</a></li>

                        </ul>
                        <form class="navbar-form navbar-right">
                            <div class="form-group">
                                <input type="text" class="form-control" placeholder="" />
                            </div>
                            <button type="submit" class="btn btn-danger glyphicon glyphicon-search"></button>
                        </form>
                        <ul class="nav navbar-nav navbar-right">

                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-user"></span>&nbsp;My Account <span class="caret"></span></a>
                                <ul class="dropdown-menu">
                                    <li><a href="#">Login In/Sign Up</a></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>
    </div>
    <!--END of Menu-->
    <div class="container">
        <div class="page-header">
            <h1>Welcome to The Smart Clinic</h1>

        </div>
        </div>
</body>
</html>
