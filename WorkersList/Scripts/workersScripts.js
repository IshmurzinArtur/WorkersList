$(document).ready(function () {
    $('#workersTable').DataTable({});
    $('#delForm').on('show.bs.modal', function (event) {
        console.log("1");
        var button = $(event.relatedTarget)
        var recipient = button.data('whatever')
        var modal = $(this)
        modal.find('.modal-title').text('Вы действительно хотите удалить этого сотрудника?')
        modal.find('#delBtn').attr("href", "../Worker/Delete?id=" + recipient)
    });
    $('#editForm').on('show.bs.modal', function (event) {
        console.log("1");
        var button = $(event.relatedTarget)
        var recipient = button.data('whatever')
        console.log(recipient)
        var modal = $(this)
        var name = recipient.split(',')
        modal.find('#name').val(name[1])
        modal.find('#description').val(name[2])
        modal.find('#company').val(name[3])
        modal.find('#age').val(name[4])
        modal.find('#Id').val(name[0])
    });
});