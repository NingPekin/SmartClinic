﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SmartClinic.Contact" %>
<!DOCTYPE html>
<html class="no-js"> 
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
								<li><a href="index.html">Home</a></li>
								<li><a href="service.html">Registration</a></li>
								<li><a href="blog-grid.html">Appointment</a>
								</li>
								<li><a href="contact.html"><b>Contact</b></a></li>

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
		  <h1 style="font-family: Times New Roman;!important">it is our pleasure to hearing from you</h1>
		  <p style="font-family: Times New Roman, font-size:100%;!important">Please drop your note and help us to give you better services</p>
		</div>
	  </div>
	</div>
  </div>
</section>
<!-- contact form start -->
<section class="contact-form">
	<div class="container">
		<div class="row">
			<form id="contact-form" >
				<div class="col-md-6 col-sm-12">
					<div class="block">
						
						<div class="form-group">
							<input name="user_name" type="text" class="form-control" placeholder="Your Name">
						</div>
						<div class="form-group">
							<input name="user_email" type="text" class="form-control" placeholder="Email Address">
						</div>
						<div class="form-group">
							<input name="user_subject" type="text" class="form-control" placeholder="Subject">
						</div>
					</div>
				</div>
				<div class="col-md-6 col-sm-12">
					<div class="block">
						<div class="form-group-2">
							<textarea name="user_message" class="form-control" rows="3" placeholder="Your Message"></textarea>
						</div>
							<button class="btn btn-default" type="submit">Send Message</button>
					</div>
				</div>
				<div class="error" id="error">Sorry Msg dose not sent</div>
				<div class="success" id="success">Message Sent</div>
			</form>
		</div>
		<div class=" contact-box row">
			<div class="col-md-6 col-sm-12">
				<div class="block">
					<h2>Stop By For A visit</h2>
					<ul class="address-block">
						<li>
							<i class="ion-ios-location-outline"></i>2000 Saint-Catherine St W, Montreal, QC H3H 2T3
						</li>
						<li>
							<i class="ion-ios-email-outline"></i>Email: contact@mail.com
						</li>
						<li>
							<i class="ion-ios-telephone-outline"></i>Phone:+1(514) 939-2006 
						</li>
					</ul>
					<ul class="social-icons">
						<li>
							<a href="http://www.collegelasalle.com/"><i class="ion-social-googleplus-outline"></i></a>
						</li>
						<li>
							<a href="http://www.collegelasalle.com/"><i class="ion-social-linkedin-outline"></i></a>
						</li>
						<li>
							<a href="http://www.collegelasalle.com/"><i class="ion-social-pinterest-outline"></i></a>
						</li>
						<li>
							<a href="http://www.collegelasalle.com/"><i class="ion-social-dribbble-outline"></i></a>
						</li>
						<li>
							<a href="http://www.collegelasalle.com/"><i class="ion-social-twitter-outline"></i></a>
						</li>
						<li>
							<a href="http://www.collegelasalle.com/"><i class="ion-social-facebook-outline"></i></a>
						</li>
					</ul>
				</div>
			</div>
			<div class="col-md-6 col-sm-12">
				<div class="block">
					<h2>We Also Count In Google Map</h2>
					<div class="google-map">
						<div id="map"></div>
					</div>
				</div>
			</div>
		</div>
	</div>
</section>
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
	



  </body>
  </html>
