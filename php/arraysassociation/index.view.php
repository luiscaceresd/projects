<!doctype html>
<html lang="en">
	<head>
		<meta charset="UTF-8">
		<meta name="viewport"
		      content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
		<meta http-equiv="X-UA-Compatible" content="ie=edge">
		<title>Document</title>
	</head>
	<body>
	<h1>Recommended Book</h1>

	<ul>
		<?php foreach($filteredBooks as $item) : ?>
			<a href="<?= $item['purchaseUrl'] ?>">
				<li><?= "{$item['name']} - {$item['releaseYear']} - By {$item['author']}"; ?></li>
			</a>
		<?php endforeach; ?>
	</ul>

	</body>
	</html>