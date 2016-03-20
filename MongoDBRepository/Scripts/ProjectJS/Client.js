$(document).ready(function () {
    var source =
          {
              datatype: "json",
              datafields: [
                    { name: 'ClientId', type: 'string' },

                   { name: 'Name', type: 'string' },
                   { name: 'Address', type: 'string' },
                   { name: 'Phone', type: 'string' },
                   { name: 'Mobile', type: 'string' },
              ],
              url: ' Client/GetEmployees'
          };
    var dataAdapter = new $.jqx.dataAdapter(source);
    // initialize jqxGrid
    $("#gridClient").jqxGrid(
        {
            width: "100%",
            source: dataAdapter,
            columns: [
                { text: "Name", datafield: "Name" },
                { text: "Address", datafield: "Address" },
                   { text: "Phone", datafield: "Phone" },
                   { text: "Mobile", datafield: "Mobile" },
            ]
        });
})

///Add
$('#btnAdd').click(function () {


})