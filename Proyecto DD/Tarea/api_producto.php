<?php

// inlcuye el contenido de database.php
require_once('database.php');

class Producto
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
                if (isset($_GET['id_producto'])) {
                    echo $this->getProductoByCode($_GET['id_producto']);
                    return;
                }
                echo $this->getProducto();
                break;
            case "POST":
                echo $this->createProducto();
                break;
            case "PUT":
                echo $this->updateProducto();
                break;
            case "DELETE":
                echo $this->deleteProducto();
                break;
            default:
                echo $this->db->response(false, null, "Metodo no soportado", 400);
                break;

        }

    }

    function getProducto()
    {
        try {
            $query = "SELECT * FROM productos";

            $stmt = $this->con->prepare($query);
            $stmt->execute();

            $result = $stmt->fetchAll(PDO::FETCH_ASSOC);

            return $this->db->response(true, $result, "Listado de productos");
        } catch (PDOException $e) {
            return $this->db->response(false, null, $e->getMessage(), 500);
        }

    }

    function getProductoByCode(string $id_producto)
    {
        try {
            $query = "SELECT * FROM productos Where id_producto = :id_producto";

            $stmt = $this->con->prepare($query);
            $stmt->bindParam(":id_producto", $id_producto);
            $stmt->execute();

            $result = $stmt->fetchAll(PDO::FETCH_ASSOC);

            //prerar la respuesta para el cliente
            return $this->db->response(true, $result, "Producto encontrado");
        } catch (PDOException $e) {
            return $this->db->response(false, null, $e->getMessage(), 500);
        }

    }

    function createProducto()
    {

        $query = "INSERT INTO productos (nombre, precio) VALUES (:nombre, :precio);";

        $stmt = $this->con->prepare($query);
        $stmt->bindParam(":nombre", $_POST["nombre"]);
        $stmt->bindParam(":precio", $_POST["precio"]);
        $stmt->execute();
        return $this->db->response(true, $_POST, "Producto agregado", 201);

    }

    function updateProducto()
    {
        $query = "UPDATE productos SET nombre=:nombre, precio=:precio WHERE id_producto = :id_producto;";

        $stmt = $this->con->prepare($query);
        $stmt->bindParam(":nombre", $_POST["nombre"]);
        $stmt->bindParam(":precio", $_POST["precio"]);
        $stmt->bindParam(":id_producto", $_POST["id_producto"]);
        $stmt->execute();
        return $this->db->response(true, $_POST, "Producto actualizado", 201);
    }

    function deleteProducto()
    {
        if (isset($_POST["id_producto"]) && !empty($_POST["id_producto"])) {
            $query = "DELETE FROM productos WHERE id_producto = :id_producto;";

            $stmt = $this->con->prepare($query);
            $stmt->bindParam(":id_producto", $_POST["id_producto"]);
            $stmt->execute();
            return $this->db->response(true, $_POST, "Producto eliminado", 200);
        }
    }
}

$producto = new Producto();

?>