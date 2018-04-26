<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Appointment.aspx.cs" Inherits="SmartClinic.Appointment" %>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Receptionist.aspx.cs" Inherits="SmartClinic.Receptionist" %>

<!DOCTYPE html>

<html class="no-js">
<head  runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
  <meta name="description" content="Aviato E-Commerce Template">
  
  <meta name="author" content="Themefisher.com">

  <title>Smart clinic</title>

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
                                <li><a href="index.html"><b>Home</b></a></li>
								<li><a href="service.html">Registration</a></li>
								<li><a href="blog-grid.html">Appointment</a>
								</li>
								<li><a href="contact.html">Contact</a></li>
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
          <h1 style="font-family: Time new roman">Appointment</h1>
          <p>Make your Appointment by <strong>YOUR-SELF</strong> </p>
        </div>
      </div>
    </div>
  </div>
</section>
      <!--joinusModal-->
      <div class="modal fade bs-example-modal-lg" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel">
        <div class="modal-dialog modal-md" role="document">
          <form method="get" action="blog-grid.html">
          <div class="modal-content">
              <div class="modal-header">
                  <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                  <h4 class="modal-title" id="myModalLabel">Login</h4>
                </div>
                <div class="modal-body">
                  <label class="label label-default" >Enter your Email</label>
                  <input type="email" id="email" name="email" class="form-control"/>
				  <label class="label label-default" >Enter your Password</label>
                  <input type="text" id="password" name="Password" class="form-control" />
                </div>
                <div class="modal-footer">
                  <div id="total" style="font-size:20px; color:darkblue; float:left;"></div>
                  <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
                  <button type="submit" class="btn btn-success" id="subscribebtn" action="onclick()" value="2">Login</button>
                </div>
          </div>
        </form>
      </div>
    </div>
      <!--EndjoinusModal-->

<div class="page-wrapper">
	<div class="container">
		<div class="row">
      		<div class="col-md-6 ">
		        <div class="post">
		          <img class="img-responsive" src="images/blog/blog-post-1.jpg" alt=""><br>
		          <p> Make or Change schedule for a week or for each doctor in any departments</P><br>
		          <a href="#" data-toggle="modal" data-target=".bs-example-modal-lg" class="btn btn-info">Login</a>
			   </div>
				</div>
        	
			<div class="col-md-6 ">
		        <div class="post">
	            <img class="img-responsive" src="images/blog/blog-post-2.jpg" alt=""><br>
				<p> feel free to Make your appointment based on your schedule</P><br>
	            <a href="#" data-toggle="modal" data-target=".bs-example-modal-lg" class="btn btn-info">Login</a>
				<a href="" class="btn btn-info">SignUp</a>
		    </div>
	      	</div>
		</div>	
      	</div>
</div>



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
    <script>
	function onclick()
{
    var UserName=document.getElementById("email").value;
	var Password=document.getElementById("password").value;
	var Type=document.getElementById("submit").value;
    if( ExistEmail(Username,Type)&& isValidCredential(Username,Password,Type)){
	if(Type==1){
	
	    location.href="blog-grid-Patient.html";
		
		}
		else{
		
		location.href="blog-grid-Receptionist.html";
		
		}
	}
   
    else
    {
        alert( "validation failed" );
        location.href="blog-grid.html";
    }
	}
	
	</script>



  </body>
  </html>

