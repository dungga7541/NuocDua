<html>
<head>
  <link href="{{ asset('css/styles.css') }}" type="text/css" rel="stylesheet" />
</head>
<body class="customer">
  @include('customer/_menu')
  @include('customer/_inform')
  <div class="align-center">
    <h2 class="text-center">NEW PRODUCTS</h2>
    <?php foreach ($newprods as $prod) { ?>
      <div class="inline">
        <figure>
          <a href="details?id=<?= $prod->ID ?>"><img src="data:image/jpg;base64,<?= $prod->Image ?>" width="300px" height="300px" /></a>
          <figcaption class="text-center"><?= $prod->Name ?><br />Price: <?= $prod->Price ?></figcaption>
        </figure>
      </div>
    <?php } ?>
  </div>
  <?php if ($hotprods) { ?>
    <div class="align-center">
      <h2 class="text-center">HOT PRODUCTS</h2>
      <?php foreach ($hotprods as $prod) { ?>
        <div class="inline">
          <figure>
            <a href="details?id=<?= $prod->ID ?>"><img src="data:image/jpg;base64,<?= $prod->Image ?>" width="300px" height="300px" /></a>
            <figcaption class="text-center"><?= $prod->Name ?><br />Price: <?= $prod->Price ?></figcaption>
          </figure>
        </div>
      <?php } ?>
    </div>
  <?php } ?>
</body>
</html>