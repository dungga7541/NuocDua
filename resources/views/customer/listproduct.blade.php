<html>
<head>
  <link href="{{ asset('css/styles.css') }}" type="text/css" rel="stylesheet" />
</head>
<body class="customer">
  @include('customer/_menu')
  @include('customer/_inform')
  <div class="text-center">
    <h2 class="text-center">LIST PRODUCTS</h2>
    <?php foreach ($prods as $prod) { ?>
      <div class="inline">
        <figure>
          <a href="details?id=<?= $prod->ID ?>"><img src="data:image/jpg;base64,<?= $prod->Image ?>" width="300" height="300" /></a>
          <figcaption class="text-center"><?= $prod->Name ?><br />Price: <?= $prod->Price ?></figcaption>
        </figure>
      </div>
    <?php } ?>
  </div>
</body>
</html>