['''''''''''''''''''''''''''''''''''''''''''''''''''''']<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <title>Document</title>
  <style>
       body {
            display: grid;
            place-items: center;
            height: 100vh;
            margin: 0px;
            font-family: sans-serif;
        }
  </style>
</head>
<body>
  <?php
      $name = "Dark Matter";
      $read = false;
      $read ? $message = "You have read $name" : $message = "You haven't read $name";
  ?>
  <h1>
      <?= $message ?>
  </h1>
</body>
</html>