<?php

$host = "localhost";
$db_name = "tienda";
$user = "root";
$password = "";

$mysqli = new mysqli(hostname: $host,username: $user,password: $password,database: $db_name);
                     
if ($mysqli->connect_errno) {
    die("Connection error: " . $mysqli->connect_error);
}

return $mysqli;


?>

