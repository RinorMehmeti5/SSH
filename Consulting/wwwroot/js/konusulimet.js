var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblTable').DataTable({
        "ajax": { url: '/admin/Konsultimet/getall' },
        "columns": [
            { data: 'ktitle', "width": "auto" },
            { data: 'kpershkrimi', "width": "auto" },
            { data: 'lendet.lname', "width": "auto" },
            { data: 'kkohaEFillimit', "width": "auto" },
            { data: 'kkohaEMbarimit', "width": "auto" },
            {
                data: 'kid',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/Admin/Konsultimet/Upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                     <a onClick=Delete('/Admin/Konsultimet/Delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Detele</a></div>`
                },
                "width": "auto"
            },
        ],
        "autoWidth": true
    });
}


function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {

            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })

        }
    })
}