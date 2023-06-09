$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblTable').DataTable({
        "ajax": { url: '/admin/Konsultimet/getall' },
        "columns": [
            { data: 'Ktitle',"width":"15" },
            { data: 'Lname', "width": "15" },
            { data: 'salary', "width": "15" },
            { data: 'office', "width": "15" }
        ]
    });
}