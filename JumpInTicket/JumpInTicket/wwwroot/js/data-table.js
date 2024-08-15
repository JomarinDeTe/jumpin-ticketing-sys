(function($) {
  'use strict';
    $(function () {

        $('#tickets-table').DataTable({
            //"aLengthMenu": [
            //    [5, 10, 15, -1],
            //    [5, 10, 15, "All"]
            //],
            dom: 'Qlfrtip',
            language: {
                searchBuilder: {
                    title: 'Search Builder Title',

                }
            },
            buttons: [
                {
                    extend: 'searchBuilder',
                    config: {
                        depthLimit: 2
                    },
               
                }
            ],
            "iDisplayLength": 10,
            "language": {
                search: ""
            },
            //searchBuilder: {
            //    columns: [1, 4, 5]
            //}
        });
        $('#tickets-table').each(function () {
            var datatable = $(this);
            // SEARCH - Add the placeholder for Search and Turn this into in-line form control
            var search_input = datatable.closest('.dataTables_wrapper').find('div[id$=_filter] input');
            search_input.attr('placeholder', 'Search');
            search_input.removeClass('form-control-sm');
            // LENGTH - Inline-Form control
            var length_sel = datatable.closest('.dataTables_wrapper').find('div[id$=_length] select');
            length_sel.removeClass('form-control-sm');
        });


        $('#order-listing').DataTable({
      "aLengthMenu": [
        [5, 10, 15, -1],
        [5, 10, 15, "All"]
      ],
      "iDisplayLength": 10,
      "language": {
        search: ""
      }
    });
    $('#order-listing').each(function() {
      var datatable = $(this);
      // SEARCH - Add the placeholder for Search and Turn this into in-line form control
      var search_input = datatable.closest('.dataTables_wrapper').find('div[id$=_filter] input');
      search_input.attr('placeholder', 'Search');
      search_input.removeClass('form-control-sm');
      // LENGTH - Inline-Form control
      var length_sel = datatable.closest('.dataTables_wrapper').find('div[id$=_length] select');
      length_sel.removeClass('form-control-sm');
    });



  });
})(jQuery);