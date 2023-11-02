<?php

// inlcuye el contenido de database.php
require_once('database.php');

class Usuario
{
    private $db;
    private $con;

    function __construct()
    {
        $this->db = new Database();
        $this->con = $this->db->getConnection();

        //GET, post, put, delete, options, patch....
        switch ($_SERVER["REQUEST_METHOD"]) {
            case "GET":
                if (isset($_GET['id_usuario'])) {
                    echo $this->getUsuarioByCode($_GET['id_usuario']);
                    return;
                }
                echo $this->getUsuario();
                break;
            case "POST":
                
                echo $this->createUsuario();
                break;
            case "PUT":
                echo $this->updateUsuario();
                break;
            case "DELETE":
                echo $this->deleteUsuario();
                break;
            default:
                echo $this->db->response(false, null, "Metodo no soportado", 400);
                break;

        }

    }

    function getUsuario()
    {
        try {
            $query = "SELECT * FROM usuarios";

            //preparar la consulta
            $stmt = $this->con->prepare($query);
            //la ejecución de la consulta
            $stmt->execute();

            //hacer un fetch de los datos
            $result = $stmt->fetchAll(PDO::FETCH_ASSOC);


            //prerar la respuesta para el cliente
            return $this->db->response(true, $result, "Listado de usuarios");
        } catch (PDOException $e) {
            return $this->db->response(false, null, $e->getMessage(), 500);
        }

    }

    function getUsuarioByCode(string $id_usuario)
    {
        try {
            $query = "SELECT * FROM usuarios Where id_usuario = :id_usuario";

            //preparar la consulta
            $stmt = $this->con->prepare($query);

            //asignar los parametros
            $stmt->bindParam("id_usuario", $id_usuario);

            //la ejecución de la consulta
            $stmt->execute();

            //hacer un fetch de los datos
            $result = $stmt->fetchAll(PDO::FETCH_ASSOC);

            //prerar la respuesta para el cliente
            return $this->db->response(true, $result, "Listado de usuarios");
        } catch (PDOException $e) {
            return $this->db->response(false, null, $e->getMessage(), 500);
        }

    }

    function createUsuario( )
    {
        if ( ! filter_var($_POST["correo"], FILTER_VALIDATE_EMAIL)) {
            die("Correo no valido");
        }
        
        if ($_POST["contrasena"] !== $_POST["contrasena_confirmacion"]) {
            die("Las contraseñas no coinciden");
        }
        $contrasena_hash = password_hash($_POST["contrasena"], PASSWORD_DEFAULT);
        
        $query = "INSERT INTO usuarios (correo, contrasena) VALUES (:correo, :contrasena);";

        $stmt = $this->con->prepare($query);
        $stmt->bindParam(":correo", $_POST["correo"]);
        $stmt->bindParam(":contrasena", $contrasena_hash);
        if ($stmt->execute()) {

            header("Location: signup_sucess.html");
            exit;
            
        } else {
            
            if ($mysqli->errno === 1062) {
                die("correo ya registrado");
            } else {
                die($mysqli->error . " " . $mysqli->errno);
            }
        }
        return $this->db->response(true, $_POST, "Usuario agregado", 200);

    }

    function updateUsuario()
    {
        $query = "UPDATE usuarios SET correo= :correo, contrasena= :contrasena WHERE usuarios.id_usuario = :id_usuario;";

        $stmt = $this->con->prepare($query);
        $stmt->bindParam(":correo", $_POST["correo"]);
        $stmt->bindParam(":contrasena", $_POST["contrasena"]);
        $stmt->bindParam(":id_usuario", $_POST["id_usuario"]);
        
        $stmt->execute();
        return $this->db->response(true, $_POST, "Usuario actualizado", 200);
    }

    function deleteUsuario()
    {
        if (isset($_GET["id_usuario"]) && !empty($_GET["id_usuario"])) {
            $query = "DELETE FROM usuarios WHERE id_usuario = :id_usuario;";

            $stmt = $this->con->prepare($query);
            $stmt->bindParam(":id_usuario", $_GET["id_usuario"]);
            $stmt->execute();
            return $this->db->response(true, $_GET, "Usuario eliminado", 200);
        }
    }
}

$usuario = new Usuario();

?>