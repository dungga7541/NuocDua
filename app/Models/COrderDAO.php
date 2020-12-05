<?php
namespace App\Models;

use Illuminate\Support\Facades\DB;

class COrderDAO {
  static function insert($order) {
    $id = DB::table('COrder')->insertGetId(['CDate' => $order->CDate, 'Total' => $order->Total, 'Status' => $order->Status, 'CustID' => $order->CustID]);
    return $id;
  }
  static function selectByCustID($custid) {
    $orders = DB::table('COrder')->join('Customer', 'COrder.CustID', '=','Customer.ID')
                                 ->select('COrder.*', 'Customer.Name')->where('CustID', $custid)->get();
    return $orders;
  }
  static function selectAll() {
    $orders = DB::table('COrder')->join('Customer', 'COrder.CustID', '=','Customer.ID')
                                 ->select('COrder.*', 'Customer.Name')->get();
    return $orders;
  }
  static function update($id, $status) {
    $affected = DB::table('COrder')->where('ID', $id)->update(['Status' => $status]);
    if ($affected > 0) return true;
    return false;
  }
}

?>