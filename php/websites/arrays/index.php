<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>
    <h1>Recommended Books</h1>

    <?php
        $books = [
          "Book 1",
          "Book 2",
          "Book 3"
        ];
    ?>

    <ul>
        <?php foreach ($books as $book) :  ?>
            <li><?= $book ?></li>
        <?php endforeach; ?>
    </ul>
</body>
</html>