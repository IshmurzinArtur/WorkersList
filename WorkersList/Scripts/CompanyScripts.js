$(document).ready(function () {
    $('#delForm').on('show.bs.modal', function (event) {
        console.log("1");
        var button = $(event.relatedTarget) 
        var recipient = button.data('whatever')
        var modal = $(this)
        modal.find('.modal-title').text('Вы действительно хотите удалить эту компанию и всех ее сотрудников?')
        modal.find('#delBtn').attr("href", "../Home/Delete?id=" + recipient)
    });
    $('#editForm').on('show.bs.modal', function (event) {
        console.log("1");
        var button = $(event.relatedTarget)
        var recipient = button.data('whatever')
        console.log(recipient)
        var modal = $(this)
        var name = recipient.split(',')
        modal.find('#editInput').val(name[1])
        modal.find('#editId').val(name[0])
    });
});