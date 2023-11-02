<?php

session_start();

if (isset($_SESSION["user_id"])) {
    
    $mysqli = require __DIR__ . "/db_connection.php";
    
    $sql = "SELECT * FROM usuarios WHERE id_usuario = {$_SESSION["user_id"]}";
            
    $result = $mysqli->query($sql);
    
    $user = $result->fetch_assoc();
}

?>
<!DOCTYPE html>
<html>
<head>
    <title>INICIO</title>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/water.css@2/out/water.css">
</head>
<body>
    
    <h1>INICIO</h1>
    
    <?php if (isset($user)): ?>
        
        <p>Hello <?= htmlspecialchars($user["correo"]) ?></p>
        
        <p><a href="logout.php">Cerrar sesión</a></p>

        <h1>Lista de productos</h1>
        <ul>
        <?php
        $api_url = 'http://localhost/tarea/api_producto.php';
        $response = file_get_contents($api_url);

        if ($response) {
            $data = json_decode($response, true);

            if (isset($data['ok']) && $data['ok'] === true) {
                $productos = $data['data'];
    
                echo '<ul>';
                foreach ($productos as $producto) {
                    echo '<li>' . $producto['nombre'] . ' - ' . $producto['precio'] . ' LPS</li>';
                }
                echo '</ul>';
            } else {
                echo 'Error en la respuesta de la API: ' . $data['message'];
            }
        } else {
            echo 'No se pudo obtener la respuesta de la API.';
        }
        ?>
    </ul>
    <br>
    <form action="api_producto" method="GET" >
        <input type="text" name="id_producto" placeholder="Id del producto" required><br>
        <button type="submit">Seleccionar</button>
    </form> 
    <br><br>
    <form action="api_producto" method="POST" >
        <input type="text" name="nombre" placeholder="Nombre" required><br>
        <input type="text" name="precio" placeholder="Precio" required><br>
        <button type="submit">Agregar</button>
    </form>
    <br><br>
    <form action="api_producto" method="PUT" >
        <input type="text" name="id_producto" placeholder="Id del producto" required><br>
        <input type="text" name="nombre" placeholder="Nombre" required><br>
        <input type="text" name="precio" placeholder="Precio" required><br>
        <button type="submit">Actualizar</button>
    </form> 
    <br><br>
    <form action="api_producto" method="DELETE" >
        <input type="text" name="id_producto" placeholder="Id del producto" required><br>
        <button type="submit">Eliminar</button>
    </form> 
    <?php else: ?>
        
        <p><a href="login.php">Iniciar sesión</a> or <a href="signup.html">Registrarse</a></p>
        
    <?php endif; ?>
    
</body>
</html>