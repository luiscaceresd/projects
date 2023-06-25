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
    <?php
        $movies = [
            [
                'name' => 'IT',
                'director' => 'Andy Muschetti',
                'purchaseUrl' => 'www.google.com',
                'releaseDate' => 2017
            ],
	        [
		        'name' => 'The Flash',
		        'director' => 'Andy Muschetti',
		        'purchaseUrl' => 'www.google.com',
                'releaseDate' => 2023
	        ],
	        [
		        'name' => 'Barbie',
		        'director' => 'Greta',
		        'purchaseUrl' => 'www.google.com',
			    'releaseDate' => 2023
	        ]
        ];

        function filterByReleaseDate($movies, $year) {
            $filteredMovies = [];

            foreach ($movies as $movie) {
                if ($movie['releaseDate'] > $year) {
                    $filteredMovies[] = $movie;
                }
            }

            return $filteredMovies;
        }
    ?>

    <ul>
        <?php foreach(filterByReleaseDate($movies, 2020) as $movie) : ?>
            <a href="<?= $movie['purchaseUrl'] ?>">
                <li><?= "{$movie['name']} - {$movie['releaseDate']} - By {$movie['director']}"; ?></li>
            </a>
        <?php endforeach; ?>
    </ul>

</body>
</html>