<?php
  $error = "";
  if(isset($_POST['username'],$_POST['password'])){
    $user = array(
            "user" => "demo",
            "pass"=>"demo"      
        );
    $username = $_POST['username'];
    $pass = $_POST['password'];
    if($username == $user['user'] && $pass == $user['pass']){
      session_start();
      $_SESSION['simple_login'] = $username;
      echo '{"error":0}';
    }else{
      echo '{"error":1}';
    }
    exit();
  }
?>
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <title>Login Kepo IT</title>
  <meta name="viewport" content="width=device-width, initial-scale=1">
    
  <!-- Include stylesheets for better appearance of login form -->
    
  <link href="dist/css/bootstrap.min.css" rel="stylesheet">
  <link href="dist/css/animate.css" rel="stylesheet">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css">
  <link rel="stylesheet" href="dist/css/adminlte.min.css">
  <style type="text/css">
    body{padding-top:20px;background-color:#f9f9f9;}
  </style>
  
  <script src="dist/js/jquery-1.11.3.min.js"></script>
  <script src="dist/js/bootstrap.min.js"></script>
</head>
<body>
  <div class="container">
    <div class="row">
    <div class="col-md-4 col-md-offset-4">

      <div align="center"><img src="dist/img/AdminLTELogoo.png" width="150" height="150" style="margin-top:120px"><br>
        <br>
        <h2><b>KEPO</b>IT</h2>
        <br>
      <div class="panel panel-default">
        <div class="panel-heading">
          <h3 class="panel-title">Silahkan Masuk</h3>
        </div>
        <div class="panel-body">
          <?php echo $error; ?>

       <!--    form login -->
          <form accept-charset="UTF-8" role="form" method="post" action="index.php">
            <fieldset>
       <!-- username -->
              <div class="input-group mb-3">
                <input class="form-control" placeholder="Username" name="username" type="text">
                    <div class="input-group-append">
                      <span class="input-group-text"><i class="fa fa-envelope "></i></span>
                   </div>
              </div>
    <!-- password -->
              <div class="input-group mb-3">
                    <input class="form-control" placeholder="Password" name="password" type="password" value="">
                     <div class="input-group-append">
                          <span class="input-group-text"><i class="fa fa-lock "></i></span>
                     </div>
              </div>
              <br>
      <!-- rember me -->
              <div class="row">
                 <div class="col-8">
                     <div class="checkbox icheck">
                         <label>
                            <input type="checkbox"> Remember Me
                          </label>
                      </div>
                 </div>
          <!-- login -->
              <div class="col-4">
                  <div class="submit">
                       <input class="btn btn-lg btn-success btn-block" type="submit" value="Login">
                   </div>
              </div>
          <!-- login -->
           </div>

            </fieldset>
          </form>
        </div>
      </div>
      
      <div class="row">
        <div class="col-sm-12">
          <div class="center">
            Username : demo || Password : demo
          </div>
        </div>
      </div>
    </div>
    </div>
  </div>
  <script>
    $('form').submit(function(e){
      e.preventDefault();
      $('.panel-default').removeClass('animated shake');
      $('.alert').remove();
      var submit = true;
      var btn = $(this).find('input[type="submit"]');
      if($(this).find('input[type="text"]').val() == "" || $(this).find('input[type="password"]').val() == ""){
        $('.panel-default .panel-body').prepend('<div class="alert alert-danger">Please enter username & password.</div>');
        submit = false;
        $('.panel-default').addClass('animated shake');
      }
      if(submit == true){
        btn.button('loading');
        $.post('index.php',$(this).serialize(),function(data){
          if(data.error == 1){
            $('.panel-default .panel-body').prepend('<div class="alert alert-danger">username atau password salah.</div>');
            $('.panel-default').addClass('animated shake');
          }else{
            $('.panel-default .panel-body').prepend('<div class="alert alert-success">Login successfull, redirecting...</div>');
            window.location = 'home.php';
          }
        },"JSON").error(function(){
          alert('Request not complete.');
        }).always(function(){
          btn.button('reset')
        });
      }
      setTimeout(function(){
        
      },100)
      
    });
  </script>
</body>
</html>
