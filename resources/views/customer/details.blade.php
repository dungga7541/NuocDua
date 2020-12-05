<html>
<head>
  <link href="{{ asset('css/styles.css') }}" type="text/css" rel="stylesheet" />
</head>
<body class="customer">
  @include('customer/_menu')
  @include('customer/_inform')
  <div class="align-center">
    <h2 class="text-center">PRODUCT DETAILS</h2>
    <figure class="caption-right">
      <img src="data:image/jpg;base64,<?= $prod->Image ?>" width="400" height="400" />
      <figcaption>
        <form action="add2cart" method="POST">
          @csrf
          <table>
            <tr>
              <td align="right">ID:</td>
              <td><?= $prod->ID ?></td>
            <tr>
            <tr>
              <td align="right">Name:</td>
              <td><?= $prod->Name ?></td>
            <tr>
            <tr>
              <td align="right">Price:</td>
              <td><?= $prod->Price ?></td>
            <tr>
            <tr>
              <td align="right">CatID:</td>
              <td><?= $prod->CatID ?></td>
            <tr>
            <tr>
              <td align="right">Quantity:</td>
              <td><input type="number" name="txtQuantity" value="1" min="1" max="99" required /></td>
            <tr>
            <tr>
              <td><input type="hidden" name="txtID" value="<?= $prod->ID ?>" /></td>
              <td><input type="submit" value="ADD TO CART" /></td>
            </tr>
          </table>
        </form>
      </figcaption>
    </figure>
  </div>
</body>
</html>