<!-- Conexão Banco de Dados -->

<?php 

    define('HOST', 'localhost');
    define('DATABASENAME', 'crud_php');
    define('USER', 'root');
    define('PASSWORD', 'admin');

    class Connect{
        protected $connection;

        function _construct()
        {
            $this->connectDatabase();
        }

        function connectDatabase()
        {
            try
            {
                $this->connection = new PDO('mysql:host='.HOST.';dbname='.DATABASENAME, USER, PASSWORD);
            }
            catch (PDOException $e)
            {
                echo "Error!".$e->getMessage();
                die();
            }
        }
    }

    $testConnection = new Connect();

?>