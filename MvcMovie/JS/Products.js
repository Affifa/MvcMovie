var uri = '/products/GetProduct';

$(document).ready(function () {
    // Send an AJAX request
    $.getJSON(uri)
        .done(function (data) {
            // On success, 'data' contains a list of products.
            $.each(data, function (key, item) {
                // Add a list item for the product.
                $('<li>', { text: formatItem(item) }).appendTo($('#products'));
            });
        });
});

function formatItem(item) {
    return item.Name + ': $' + item.price;
}

function find() {

    var id = $('#prodId').val();

    $.getJSON(uri + '/' + id)
        .done(function (data) {
            console.log(data);
            $('#product').text(formatItem(data));
        })
        .fail(function (jqXHR, textStatus, err) {
            console.log('error');
            $('#product').text('Error: ' + err);
        });
}