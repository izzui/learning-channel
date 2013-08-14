<!DOCTYPE html>
<html lang="en" ng-app>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta name="description" content="">
	<meta name="author" content="">

	<title>Demo - Learning Channels</title>

	<!-- Bootstrap core CSS -->
	<link rel="stylesheet" type="text/css" href="css/font-awesome.css">
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/demo-izzui.css">
</head>
<body>
	<div id="fb-root"></div>
	<!-- facebook script -->
	<script>
		window.fbAsyncInit = function () {
			// init the FB JS SDK
			FB.init({
				appId: '212553442202383',                        // App ID from the app dashboard
				//channelUrl: '//WWW.YOUR_DOMAIN.COM/channel.html', // Channel file for x-domain comms
				status: true,                                 // Check Facebook Login status
				xfbml: true                                  // Look for social plugins on the page
			});

			// Additional initialization code such as adding Event Listeners goes here
			FB.Canvas.setAutoGrow();
		};


		// Load the SDK asynchronously
		(function (d, s, id) {
			var js, fjs = d.getElementsByTagName(s)[0];
			if (d.getElementById(id)) { return; }
			js = d.createElement(s); js.id = id;
			js.src = "//connect.facebook.net/en_US/all.js";
			fjs.parentNode.insertBefore(js, fjs);
		}(document, 'script', 'facebook-jssdk'));
	</script>
	<!-- navbar -->
	<div class="navbar">
		<!--  navbar-fixed-top -->
		<div class="container">
			<div class="col-lg-3">
				<a class="navbar-brand logo-holder" href="#">
					<div class="logo"><span class="logo-description">Learning Channel</span></div>
				</a>
			</div>
			<div class="col-lg-2">
				<button id="btn-topicos" type="button" class="btn btn-primary navbar-btn" data-toggle="popover" data-placement="bottom" data-content="Todos, Artes e Ofícios,Dicas do dia a dia, Educação, Esportes, Estilo de vida, Gastronomia, Gestão e negócios, Jogos, Línguas, Moda, Música, Saúde, Tecnologia" data-original-title="" title="Tópicos">Tópicos</button>
			</div>

			<!-- Search -->
			<div class="col-lg-4">
				<form class="navbar-form search">
					<div class="input-group">
						<input type="text" class="form-control search-input">
						<span class="input-group-btn">
							<button class="btn btn-default" type="submit"><i class="icon-search"></i></button>
						</span>
					</div>
				</form>
				<!-- /navbar-form-->
			</div>

			<!-- User menu -->
			<div class="col-lg-3 dropdown">
				<a class="btn btn-default navbar-btn dropdown-toggle pull-right" data-toggle="dropdown" href="#">User<span class="caret far"></span>
				</a>
				<ul class="dropdown-menu pull-right">
					<li><a href="#">Information</a></li>
					<li><a href="#">Trophies</a></li>
					<li><a href="#">My Courses</a></li>
					<li><a href="#">Enrolled courses</a></li>
					<li><a href="#">Friends</a></li>
					<li><a href="#">Permissions</a></li>
				</ul>
			</div>
		</div>
	</div>
	<!-- /navbar -->

	<div class="container">
		<div class="col-12 col-sm-9 col-lg-9">
			<h1 class="clearfix"><i class="title-icon icon-check"></i>Enrolled courses<a href="#" class="btn btn-link pull-right">see all</a></h1>
			<div class="row">

				<!-- card-model-01 -->
				<div class="col-12 col-sm-4 col-lg-4">
					<div class="thumbnail card-model-01">
						<img src="http://placehold.it/350" alt="thumb">
						<div class="caption">
							<h3 ng-controller="NomeDoCurso">{{nomeCurso}}</h3>
							<h5 class="text-center">Free</h5>
							<div class="text-center">
								<img src="http://placehold.it/120x20" alt="rating">
							</div>
							<div class="extra-info clearfix">
								<div class="extra-info-group pull-left">
									<i class="icon-eye-open extra-info-icon" alt="visualizations"></i>
									<span class="extra-info-value">10330</span>
								</div>
								<!-- /visualization -->

								<div class="extra-info-group pull-right">
									<i class="icon-ok-circle extra-info-icon" alt="visualizations"></i>
									<span class="extra-info-value">1033</span>
								</div>
								<!-- /enrolled students -->
							</div>
							<!-- /extra-info -->
						</div>
						<!-- /caption -->
					</div>
					<!-- /thumbnail -->
				</div>
				<!-- col-sm-3 -->
				<!-- /card-model-01 -->

				<!-- card-model-01 -->
				<div class="col-12 col-sm-4 col-lg-4">
					<div class="thumbnail card-model-01">
						<img src="http://placehold.it/350" alt="thumb">
						<div class="caption">
							<h3>Thumbnail label</h3>
							<h5 class="text-center">Free</h5>
							<div class="text-center">
								<img src="http://placehold.it/120x20" alt="rating">
							</div>
							<div class="extra-info clearfix">
								<div class="extra-info-group pull-left">
									<i class="icon-eye-open extra-info-icon" alt="visualizations"></i>
									<span class="extra-info-value">10330</span>
								</div>
								<!-- /visualization -->

								<div class="extra-info-group pull-right">
									<i class="icon-ok-circle extra-info-icon" alt="visualizations"></i>
									<span class="extra-info-value">1033</span>
								</div>
								<!-- /enrolled students -->
							</div>
							<!-- /extra-info -->
						</div>
						<!-- /caption -->
					</div>
					<!-- /thumbnail -->
				</div>
				<!-- col-sm-3 -->
				<!-- /card-model-01 -->

				<!-- card-model-01 -->
				<div class="col-12 col-sm-4 col-lg-4">
					<div class="thumbnail card-model-01">
						<img src="http://placehold.it/350" alt="thumb">
						<div class="caption">
							<h3>Thumbnail label</h3>
							<h5 class="text-center">Free</h5>
							<div class="text-center">
								<img src="http://placehold.it/120x20" alt="rating">
							</div>
							<div class="extra-info clearfix">
								<div class="extra-info-group pull-left">
									<i class="icon-eye-open extra-info-icon" alt="visualizations"></i>
									<span class="extra-info-value">10330</span>
								</div>
								<!-- /visualization -->

								<div class="extra-info-group pull-right">
									<i class="icon-ok-circle extra-info-icon" alt="visualizations"></i>
									<span class="extra-info-value">1033</span>
								</div>
								<!-- /enrolled students -->
							</div>
							<!-- /extra-info -->
						</div>
						<!-- /caption -->
					</div>
					<!-- /thumbnail -->
				</div>
				<!-- col-sm-3 -->
				<!-- /card-model-01 -->

			</div>
			<!-- /row -->
			<h1 class="clearfix"><i class="title-icon icon-time"></i>Recent added <a href="#" class="btn btn-link pull-right">see all</a></h1>
			<div class="row">

				<!-- card-model-01 -->
				<div class="col-12 col-sm-4 col-lg-4">
					<div class="thumbnail card-model-01">
						<img src="http://placehold.it/350" alt="thumb">
						<div class="caption">
							<h3>Thumbnail label</h3>
							<h5 class="text-center">Free</h5>
							<div class="text-center">
								<img src="http://placehold.it/120x20" alt="rating">
							</div>
							<div class="extra-info clearfix">
								<div class="extra-info-group pull-left">
									<i class="icon-eye-open extra-info-icon" alt="visualizations"></i>
									<span class="extra-info-value">10330</span>
								</div>
								<!-- /visualization -->

								<div class="extra-info-group pull-right">
									<i class="icon-ok-circle extra-info-icon" alt="visualizations"></i>
									<span class="extra-info-value">1033</span>
								</div>
								<!-- /enrolled students -->
							</div>
							<!-- /extra-info -->
						</div>
						<!-- /caption -->
					</div>
					<!-- /thumbnail -->
				</div>
				<!-- col-sm-3 -->
				<!-- /card-model-01 -->

				<!-- card-model-01 -->
				<div class="col-12 col-sm-4 col-lg-4">
					<div class="thumbnail card-model-01">
						<img src="http://placehold.it/350" alt="thumb">
						<div class="caption">
							<h3>Thumbnail label</h3>
							<h5 class="text-center">Free</h5>
							<div class="text-center">
								<img src="http://placehold.it/120x20" alt="rating">
							</div>
							<div class="extra-info clearfix">
								<div class="extra-info-group pull-left">
									<i class="icon-eye-open extra-info-icon" alt="visualizations"></i>
									<span class="extra-info-value">10330</span>
								</div>
								<!-- /visualization -->

								<div class="extra-info-group pull-right">
									<i class="icon-ok-circle extra-info-icon" alt="visualizations"></i>
									<span class="extra-info-value">1033</span>
								</div>
								<!-- /enrolled students -->
							</div>
							<!-- /extra-info -->
						</div>
						<!-- /caption -->
					</div>
					<!-- /thumbnail -->
				</div>
				<!-- col-sm-3 -->
				<!-- /card-model-01 -->

				<!-- card-model-01 -->
				<div class="col-12 col-sm-4 col-lg-4">
					<div class="thumbnail card-model-01">
						<img src="http://placehold.it/350" alt="thumb">
						<div class="caption">
							<h3>Thumbnail label</h3>
							<h5 class="text-center">Free</h5>
							<div class="text-center">
								<img src="http://placehold.it/120x20" alt="rating">
							</div>
							<div class="extra-info clearfix">
								<div class="extra-info-group pull-left">
									<i class="icon-eye-open extra-info-icon" alt="visualizations"></i>
									<span class="extra-info-value">10330</span>
								</div>
								<!-- /visualization -->

								<div class="extra-info-group pull-right">
									<i class="icon-ok-circle extra-info-icon" alt="visualizations"></i>
									<span class="extra-info-value">1033</span>
								</div>
								<!-- /enrolled students -->
							</div>
							<!-- /extra-info -->
						</div>
						<!-- /caption -->
					</div>
					<!-- /thumbnail -->
				</div>
				<!-- col-sm-3 -->
				<!-- /card-model-01 -->

			</div>
			<!-- /row -->
		</div>
		<!-- col-sm-9 -->

		<div class="col-12 col-sm-3 col-lg-3 light-gray-bg leaderboard-col">
			<div class="text-center leaderboard-header">
				<i class="icon-trophy icon-4x"></i>
				<h2 class="leaderboard-title">Leaderboard</h2>
			</div>
			<ul class="nav nav-tabs clearfix" id="tab-leaderboard">
				<li><a href="#weekly" data-toggle="tab">weekly</a></li>
				<li><a href="#all-time" data-toggle="tab">all time</a></li>
			</ul>
			<div class="tab-content box-white">
				<div class="tab-pane active" id="weekly">
					<table class="table table-condensed table-striped">
						<thead>
							<tr>
								<th>Pos.</th>
								<th>Name</th>
								<th class="clearfix">
									<div class="btn-group pull-right">
										<button type="button" class="btn btn-default btn-xs dropdown-toggle"
											data-toggle="dropdown">
											Points<span class="caret mid"></span></button>
										<ul class="dropdown-menu pull-right">
											<li><a href="#">Level</a></li>
											<li><a href="#">Badges</a></li>
											<li><a href="#">Friends</a></li>
											<li><a href="#">Completed courses</a></li>
										</ul>
									</div>
								</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td>1</td>
								<td>Chuck Norris</td>
								<td class="text-right">3459</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>2</td>
								<td>Ryan Tester</td>
								<td class="text-right">3200</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>3</td>
								<td>Jon Jones</td>
								<td class="text-right">3102</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>4</td>
								<td>Chuck Lidel</td>
								<td class="text-right">3004</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>5</td>
								<td>Hulk Hogan</td>
								<td class="text-right">2990</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>6</td>
								<td>Rocky Balboa</td>
								<td class="text-right">2920</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>7</td>
								<td>Liu Kang</td>
								<td class="text-right">2878</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>8</td>
								<td>Bart Simpson</td>
								<td class="text-right">2340</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>9</td>
								<td>Fred Flintstone</td>
								<td class="text-right">2145</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>10</td>
								<td>Marty McFly</td>
								<td class="text-right">2005</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td colspan="3">...</td>
							</tr>
							<tr class="bolder warning">
								<td>348</td>
								<td>You!</td>
								<td class="text-right">798</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td colspan="3">
									<button type="button" class="btn btn-primary btn-block btn-xs">see whole board</button>
								</td>
							</tr>
						</tbody>
					</table>
				</div>
				<!-- /weekly -->
				<div class="tab-pane active" id="all-time">
					<table class="table table-condensed table-striped">
						<thead>
							<tr>
								<th>Pos.</th>
								<th>Name</th>
								<th>
									<div class="btn-group pull-right">
										<button type="button" class="btn btn-default btn-xs dropdown-toggle"
											data-toggle="dropdown">
											Points<span class="caret mid"></span></button>
										<ul class="dropdown-menu pull-right">
											<li><a href="#">Level</a></li>
											<li><a href="#">Badges</a></li>
											<li><a href="#">Friends</a></li>
											<li><a href="#">Completed courses</a></li>
										</ul>
									</div>
								</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td>1</td>
								<td>Chuck Norris</td>
								<td class="text-right">3459</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>2</td>
								<td>Demetrius Nunes</td>
								<td class="text-right">3200</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>3</td>
								<td>Jon Jones</td>
								<td class="text-right">3102</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>4</td>
								<td>Chuck Lidel</td>
								<td class="text-right">3004</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>5</td>
								<td>Hulk Hogan</td>
								<td class="text-right">2990</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>6</td>
								<td>Rocky Balboa</td>
								<td class="text-right">2920</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>7</td>
								<td>Liu Kang</td>
								<td class="text-right">2878</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>8</td>
								<td>Bart Simpson</td>
								<td class="text-right">2340</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>9</td>
								<td>Fred Flintstone</td>
								<td class="text-right">2145</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td>10</td>
								<td>Marty McFly</td>
								<td class="text-right">2005</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td colspan="3">...</td>
							</tr>
							<tr class="bolder warning">
								<td>848</td>
								<td>You!</td>
								<td class="text-right">798</td>
							</tr>
							<!-- /student line -->
							<tr>
								<td colspan="3">
									<button type="button" class="btn btn-primary btn-block btn-xs">see whole board</button>
								</td>
							</tr>
						</tbody>
					</table>
				</div>
				<!-- /all-time -->
			</div>
			<!-- tab-content -->
		</div>
		<!-- col-sm-3 -->

	</div>
	<!-- /container -->
	<footer id="footer" class="footer light-gray-bg">
		<div class="container aired-v">
			<div class="col-12 col-sm-3 col-lg-3">
				<img src="http://placehold.it/200x120" alt="Brand logo" />
			</div>
			<!-- /logo placement-->
			<div class="col-12 col-sm-9 col-lg-9">
				<ul class="list-unstyled clearfix">
					<li class="pull-left link-list">
						<h5>Follow Us</h5>
						<ul class="list-unstyled">
							<li><a href="#">Facebook</a></li>
							<li><a href="#">Twitter</a></li>
							<li><a href="#">Google+</a></li>
							<li><a href="#">Linkedin</a></li>
						</ul>
					</li>
					<li class="pull-left link-list">
						<h5>Legal</h5>
						<ul class="list-unstyled">
							<li><a href="#">Privacy</a></li>
							<li><a href="#">Terms</a></li>
							<li><a href="#">DMCA</a></li>
						</ul>
					</li>
					<li class="pull-left link-list">
						<h5>Support</h5>
						<ul class="list-unstyled">
							<li><a href="#">Knowledge base</a></li>
							<li><a href="#">Share an idea</a></li>
							<li><a href="#">Give feedback</a></li>
						</ul>
					</li>
					<li class="pull-left">
						<h5>Payment Methods</h5>
						<!--
						<h6>credit card</h6>
						-->
						<div>
							<img src="http://placehold.it/50x30" alt="CC" />
							<img src="http://placehold.it/50x30" alt="CC" />
							<img src="http://placehold.it/50x30" alt="CC" />
							<img src="http://placehold.it/100x30" alt="PP" />
						</div>
						<!--					
						<div>
							<img src="http://placehold.it/100x30" alt="PP" />
						</div><!-- /row -- >
						-->
					</li>
				</ul>
			</div>
			<!-- /aired-v -->
	</footer>
	<script type="text/javascript" src="//code.jquery.com/jquery-1.10.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<script type="text/javascript" src="js/angular.min.js"></script>
	<script>
		//used for "Topics" bt
		$('#btn-topicos').popover();

		//used for "Leaderboards" tabs
		$('#tab-leaderboard a:first').tab('show');

		//Fill courses names
		function NomeDoCurso($scope) {
			$scope.nomeCurso = "Course Title with Two Lines";
		}
	</script>
</body>
</html>
