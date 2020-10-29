<form action="hello" method='POST'>
    <?php echo csrf_field(); ?>
    <input type="text" name='name' placeholder = 'Ener your name' />
    <input type="submit" name='submit' value='Say' />   
</form>

<h1>Hello <?= $name?>!</h1>;<?php /**PATH D:\laravel\quocbao\resources\views/hello.blade.php ENDPATH**/ ?>