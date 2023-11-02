<?php
header("Content-Type: application/json; charset=UTF-8");

class Database
{
    private $host = "localhost";
    private $db_name = "tienda";
    private $user = "root";
    private $password = "";

    private $connection;

    function __construct()
    {
        try {
            $this->connection = new PDO(
                "mysql:host=$this->host;dbname=$this->db_name",
                $this->user,
                $this->password
            );

            //habilita el modo de errores y arroja excepciones
            $this->connection->setAttribute(
                PDO::ATTR_ERRMODE,
                PDO::ERRMODE_EXCEPTION
            );

        } catch (PDOException $exception) {
            header("HTTP/1.1 500 Internal Server Error");
            die("Connection error: " . $exception->getMessage());
        }

    }

    function __destruct()
    {
        //destruir la conexión
        $this->connection = null;
    }

    function getConnection()
    {
        return $this->connection;
    }

    function response($ok, $data, $message, $code = 200)
    {
        header("HTTP/1.1 $code");
        return json_encode([
            "ok" => $ok,
            "message" => $message,
            "data" => $data
        ]);
    }

}

?>