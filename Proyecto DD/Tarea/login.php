<?php
$is_invalid = false;

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    
    $mysqli = require __DIR__ . "/db_connection.php";

    $sql = sprintf("SELECT * FROM usuarios WHERE correo = '%s'", $mysqli->real_escape_string($_POST["correo"]));
    
    $result = $mysqli->query($sql);
    
    $user = $result->fetch_assoc();
    
    if ($user) {
        
        if (password_verify($_POST["contrasena"], $user["contrasena"])) {
            
            session_start();
            
            session_regenerate_id();
            
            $_SESSION["user_id"] = $user["id_usuario"];
            
            header("Location: index.php");
            exit;
        }
    }
    
    $is_invalid = true;
}

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/water.css@2/out/water.css">
</head>
<body>
    <h1>Iniciar sesión</h1>
    <br>
    <form action="" method="POST">
        <input type="text" name="correo" placeholder="Usuario" required><br><br>
        <input type="password" name="contrasena" placeholder="Contraseña" required><br><br>
        <button type="submit">Iniciar sesión</button>
    </form>
</body>
</html>