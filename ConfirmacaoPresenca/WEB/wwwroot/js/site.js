$('form').submit(function (event) {
    $('#Telefone').unmask();
    alert($('#Telefone').val());
});