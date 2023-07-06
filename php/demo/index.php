<?php

require 'functions.php';
//require 'router.php';

//connect to our MYSQL database
$dsn = "mysql:host=localhost;port=3306;dbname=myapp;charset=utf8mb4";

$pdo = new PDO($dsn, "root", "Eminem1057.");

$statement = $pdo->prepare("SELECT * FROM posts");
$statement->execute();

$posts = $statement->fetchAll(PDO::FETCH_ASSOC);

foreach ($posts as $post) {
	echo "<li>" . $post['title'] . "</li>";
}

dd($posts);