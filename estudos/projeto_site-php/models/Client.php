<!-- Consultas e regras de negocios -->

<?php 

    require_once('./configuration/connect.php');
                    // (extends) heranca da connect //
    class ClientModel extends Connect {
        private $table;

        function __construct()
        {
            parent::_construct();
            $this->table = 'clients';
        }

        function getAll()
        {
            $sqlSelect = $this->connection->query("SELECT * FROM $this->table");
            $resultQuery = $sqlSelect->fetchAll();
            return $resultQuery;
        }

        

    }



?>