<html>
<head>
  <link href="{{ asset('css/styles.css') }}" type="text/css" rel="stylesheet" />
</head>
<body class="customer">
  @include('customer/_menu')
  @include('customer/_inform')
  <div class="align-center">
    <h2 class="text-center">CUSTOMER LOGIN</h2>
    <form action="login" method="POST">
      @csrf
      <table class="align-center">
        <tr>
          <td>Username</td>
          <td><input type="text" name="txtUsername" required /></td>
        </tr>
        <tr>
          <td>Password</td>
          <td><input type="password" name="txtPassword" required /></td>
        </tr>
        <tr>
          <td></td>
          <td><input type="submit" name="btnSubmit" value="LOGIN" /></td>
        </tr>
        <tr>
          <td></td>
          <td><a href="signup">Sign-up</a> for a new account</td>
        </tr>
      </table>
    </form>
  </div>
</body>
</html>