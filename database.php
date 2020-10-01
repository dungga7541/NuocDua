<?php
class Database {
  private static $instance = NULL;
  public static function getInstance() {
    if (!isset(self::$instance)) {
      try {
       self::$instance = new PDO('mysql:host=localhost;dbname=shopping-online', 'sonkk', '123');
      } catch (PDOException $ex) { die($ex->getMessage()); }
    }
    return self::$instance;
  }
}
?>