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
    <h1>Recommended Books</h1>

    <?php
        $books = [
                "book1",
                "book2",
                "book3",
        ]
    ?>

    <ul>
        <?php foreach($books as $book) : ?>
            <li><?= $book ?></li>
        <?php endforeach; ?>
    </ul>
</body>
</html>