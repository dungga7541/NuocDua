<?php
namespace App\Http\Controllers;

class HelloController extends Controller
{
    public function hello()
    {
        if(isset($_POST['submit']))
        {
            $name = $_POST['name'];
            return view('hello', ['name' => $name]);
        }
        else //GET
        {
            return view('hello', ['name' => 'baby']);
        }
    }
}