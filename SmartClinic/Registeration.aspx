<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="SmartClinic.Registeration" %>

<!DOCTYPE html>
 
<html class="no-js"> 
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
  <meta name="description" content="Aviato E-Commerce Template">
  
  <meta name="author" content="Themefisher.com">

  <title>Smart Clinic</title>

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
  
  <!-- Main Stylesheet -->
  <link rel="stylesheet" href="css/style.css">

</head>

<body id="body">

	<form id="form1" runat="server">

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
								<li><a href="HomePage.aspx"><b>Home</b></a></li>
								<li><a href="Registeration.aspx">Registration</a></li>
								<li><a href="Appointment.aspx">Appointment</a>
								</li>
								<li><a href="contact.aspx">Contact</a></li>
							</ul>
							</div><!-- /.navbar-collapse -->
							</div><!-- /.container-fluid -->
						</nav>
					</div>
				</div>
			</div>
			</header><!-- header close -->

<section class="page-title bg-2">
  <div class="container">
	<div class="row">
	  <div class="col-md-12">
		<div class="block">
		  <h1>Registration</h1>
		  <p></p>
		</div>
	  </div>
	</div>
  </div>
</section>

<section class="page-wrapper">
<div class="container">
<div class="row">
<div class="col-sm-4">
<div class="block">
						
						<div class="form-group">
						<strong style="font-family:Time New Roman;font-size:20px;">First Name:</strong><br>
							<asp:TextBox id="firstName"  class="form-control" runat="server" /><br>
							<strong style="font-family:Time New Roman;font-size:20px;">Last Name:</strong><br>
							<asp:TextBox id="lastName"  class="form-control" runat="server" /><br>

						</div>
						<div class="form-group">
						<strong style="font-family:Time New Roman;font-size:20px;">Gender:</strong><br>
							<asp:RadioButton ID="RadioButton1" GroupName="Gender" Text="Male" runat="server" value="1" />
							<asp:RadioButton ID="RadioButton2" GroupName="Gender" Text="Female" runat="server" value="2" />
<%--						  <input type="checkbox" name="gender" value="Female"> Male<br>
						  <input type="checkbox" name="gender2" value="Male"> Female --%>
						</div>
						<div class="form-group">
						<strong style="font-family:Time New Roman;font-size:20px;">Description:</strong><br>
						Please specify your Allergies and your medical Issues:
					<asp:TextBox id="description"  class="form-control" runat="server" />
						</div>
						<div class="form-group">
						
<asp:Button ID="Button1" runat="server" Text="Register" OnClick="Register" />
						</div>
						
					</div>
</div>
<div class="col-sm-4">
<div class="block">
						<div class="form-group">
						<strong style="font-family:Time New Roman;font-size:20px;">Email:</strong><br>
						
						<asp:TextBox id="user_email"  class="form-control" runat="server" />
						</div>
							<div class="form-group">
						<strong style="font-family:Time New Roman;font-size:20px;">Password:</strong><br>
						
						<asp:TextBox id="password"  class="form-control" TextMode="Password" runat="server" />
						</div>
						<div class="form-group">
						<strong style="font-family:Time New Roman;font-size:20px;">Phone:</strong><br>
						
							<asp:TextBox id="phone"  class="form-control" runat="server" />

						</div>
</div>
</div>
<div class="col-sm-4">
<div class="block">
						<div class="form-group">
						<strong style="font-family:Time New Roman;font-size:20px;">Birthday::</strong><br>
				<%--		<input type="date" name="birthday">--%>
							<asp:Calendar AutoPostBack="false" ID="birthday" runat="server"></asp:Calendar>
						<%--<input type="submit">--%>
						</div>
						</div>
</div>
	
</div>
</section>
<!-- Call to action Start -->

<section class="call-to-action bg-1 section-sm overly">
	<div class="container">
		<div class="row">
			<div class="col-md-12">
				<div class="block">
					<h2>We offer delightful Health Care Services</h2>
					<p>Read more about what we do and our philosophy of medication. See for yourself The work and results <br> we’ve achieved for other clients, and meet our highly experienced Team who just love to help you.</p>
					<a class="btn btn-main btn-solid-border" href="#" >Make an Appointment</a>
				</div>
			</div>
		</div>
	</div>
</section>

<!-- Content Start -->


<!-- footer Start -->
<footer class="footer">
	<div class="container">
		<div class="row">
			<div class="col-md-12">
				<div class="footer-manu">
				</div>
				<p class="copyright">Copyright 2018 &copy; Design & Developed by <a href="http://www.collegelasalle.com/">LaSalle College</a>. All rights reserved.
				</p>
			</div>
		</div>
	</div>
</footer>


	<!-- 
	Essential Scripts
	=====================================-->
	
	<!-- <script src="js/jquery.counterup.js"></script> -->
	
	<!-- Main jQuery -->
   
	<script src="https://code.jquery.com/jquery-git.min.js"></script>
	<!-- Bootstrap 3.1 -->
	<script src="plugins/bootstrap/js/bootstrap.min.js"></script>
	<!-- Owl Carousel -->
	<script src="plugins/slick-carousel/slick/slick.min.js"></script>
	<!--  -->
	<script src="plugins/magnific-popup/dist/jquery.magnific-popup.min.js"></script>
	<!-- Mixit Up JS -->
	<script src="plugins/mixitup/dist/mixitup.min.js"></script>
	<!-- <script src="plugins/count-down/jquery.lwtCountdown-1.0.js"></script> -->
	<script src="plugins/SyoTimer/build/jquery.syotimer.min.js"></script>


	<!-- Form Validator -->
	<script src="http://cdnjs.cloudflare.com/ajax/libs/jquery.form/3.32/jquery.form.js"></script>
	<script src="http://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.11.1/jquery.validate.min.js"></script>


	
	<!-- Google Map -->
	<script src="plugins/google-map/map.js"></script>
	<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAkeLMlsiwzp6b3Gnaxd86lvakimwGA6UA&callback=initMap"></script>    

	<script src="js/script.js"></script>
	



	</form>
	



  </body>
  </html>