<?php 
require_once('./models/Client.php');

class clientsController{
    private $model;

    function __construct()
    {
        $this->model = new ClientModel;
    }

    function getAll()
    {
        $resultData = $this->model->getAll();
        print_r($resultData);
    }
}





?>