<html>
<head>
  <link href="{{ asset('css/styles.css') }}" type="text/css" rel="stylesheet" />
</head>
<body class="customer">
  @include('customer/_menu')
  @include('customer/_inform')
  <?php if (isset($orders)) { ?>
    <div class="align-center">
      <h2 class="text-center">ORDER LIST</h2>
      <table class="datatable" border="1">
        <tr class="datatable">
          <th>OrderID</th>
          <th>CustName</th>
          <th>Creation date</th>
          <th>Total</th>
          <th>Status</th>
        </tr>
        <?php foreach ($orders as $item) { ?>
          <tr class="datatable" onclick="window.location='myorders?id=<?= $item->ID ?>'">
            <th><?= $item->ID ?></th>
            <td><?= $item->Name ?></td>
            <td><?= date("d/m/Y - H:i:s", ($item->CDate / 1000)) ?></td>
            <td><?= $item->Total ?></td>
            <td><?= $item->Status ?></td>
          </tr>
        <?php } ?>
      </table>
    </div>
  <?php } ?>
  <?php if (isset($odetails)) { ?>
    <div class="align-center">
      <h2 class="text-center">ORDER DETAIL</h2>
      <table class="datatable" border="1">
        <tr class="datatable">
          <th>OrderID</th>
          <th>ProdID</th>
          <th>Quantity</th>
        </tr>
        <?php foreach ($odetails as $item) { ?>
          <tr class="datatable">
            <td><?= $item->OrderID ?></td>
            <td><?= $item->ProdID ?></td>
            <td><?= $item->Quantity ?></td>
          </tr>
        <?php } ?>
      </table>
    </div>
  <?php } ?>
</body>
</html>