<?php

$books = [
    [
        'name' => 'IT',
        'author' => 'Andy Muscheti',
        'purchaseUrl' => 'www.google.com',
        'releaseYear' => 2015
    ],
    [
        'name' => 'IT2',
        'author' => 'Stephen King',
        'purchaseUrl' => 'www.google.com',
        'releaseYear' => 1944
    ],
    [
        'name' => 'IT3',
        'author' => 'Stephen King',
        'purchaseUrl' => 'www.google.com',
        'releaseYear' => 2023
    ]
];

$filteredBooks = array_filter($books,function($book) {
    return $book['releaseYear'] <= 2020 && $book['releaseYear'] >= 1950;
});

require "index.view.php";
