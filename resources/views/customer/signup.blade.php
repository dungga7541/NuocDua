<html>
<head>
  <link href="{{ asset('css/styles.css') }}" type="text/css" rel="stylesheet" />
</head>
<body class="customer">
  @include('customer/_menu')
  @include('customer/_inform')
  <div class="align-center">
    <h2 class="text-center">SIGN-UP</h2>
    <form action="signup" method="POST">
      @csrf
      <table class="align-center">
        <tr>
          <td>Username</td>
          <td><input type="text" name="txtUsername" required /></td>
        </tr>
        <tr>
          <td>Password</td>
          <td><input type="password" name="txtPassword" pattern=".{3,}" required /></td>
        </tr>
        <tr>
          <td>Name</td>
          <td><input type="text" name="txtName" required /></td>
        </tr>
        <tr>
          <td>Phone</td>
          <td><input type="tel" name="txtPhone" pattern="0[0-9]{9}" required /></td>
        </tr>
        <tr>
          <td>Email</td>
          <td><input type="email" name="txtEmail" required /></td>
        </tr>
        <tr>
          <td></td>
          <td><input type="submit" name="btnSubmit" value="SIGN-UP" /></td>
        </tr>
      </table>
    </form>
  </div>
</body>
</html>