$(document).ready(function () {
    $('#delForm').on('show.bs.modal', function (event) {
        console.log("1");
        var button = $(event.relatedTarget) 
        var recipient = button.data('whatever')
        var modal = $(this)
        modal.find('.modal-title').text('Вы действительно хотите удалить эту компанию?')
        modal.find('#delBtn').attr("href", "../Home/Delete?id=" + recipient)
    });
});