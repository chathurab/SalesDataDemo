
$(document).ready(function () {
    $("#myGrid").jqGrid({
        url: '@Url.Action("GetSales")',
        datatype: 'json',
        myType: 'GET',
        colNames: ['Salary','FirstName'],
        colModel: [
            { name: 'Name', index: 'Name' },
            { name: 'Salary', index: 'Salary' }
        ],
        jsonReader: {
            root: 'Data',
            id: 'id',
            repeatitems: false
        },
        pager: $('#myPager'),
        rowNum: 5,
        rowList: [2, 5, 10],
        width: 600,
        viewrecords: true,
        caption: 'Jqgrid MVC Tutorial'
    });
});

