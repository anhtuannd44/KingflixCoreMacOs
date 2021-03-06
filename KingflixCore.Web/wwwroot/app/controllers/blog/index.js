var BlogController = function () {
    this.initialize = function () {
        loadData();
        registerEvents();
        registerControls();
    }

    function registerEvents() {
        //Init validation
        $('#frmMaintainance').validate({
            errorClass: 'red',
            ignore: [],
            lang: 'en',
            rules: {
                txtNameM: { required: true },
                txtAliasM: { required: true }
            }
        });

        $('#txt-search-keyword').keypress(function (e) {
            if (e.which === 13) {
                e.preventDefault();
                loadData();
            }
        });
        $("#btn-search").on('click', function () {
            loadData();
        });

        $("#ddl-show-blog").on('change', function () {
            kingflix.configs.blogSize = $(this).val();
            kingflix.configs.blogIndex = 1;
            loadData(true);
        });

        $("#btn-create").on('click', function () {
            resetFormMaintainance();
            $('#modal-add-edit').modal('show');

        });

        $('body').on('click', '.btn-edit', function (e) {
            e.preventDefault();
            var that = $(this).data('id');
            $.ajax({
                type: "GET",
                url: "/Admin/Page/GetById",
                data: { id: that },
                dataType: "json",
                beforeSend: function () {
                    kingflix.startLoading();
                },
                success: function (response) {
                    var data = response;
                    $('#hidIdM').val(data.Id);
                    $('#txtNameM').val(data.Name);

                    $('#txtAliasM').val(data.Alias);
                    CKEDITOR.instances.txtContentM.setData(data.Content);
                    $('#ckStatusM').prop('checked', data.Status === 1);

                    $('#modal-add-edit').modal('show');
                    kingflix.stopLoading();

                },
                error: function () {
                    kingflix.notify('C?? l???i x???y ra', 'error');
                    kingflix.stopLoading();
                }
            });
        });

        $('#btnSaveM').on('click', function (e) {
            if ($('#frmMaintainance').valid()) {
                e.preventDefault();
                var id = $('#hidIdM').val();
                var name = $('#txtNameM').val();
                var seoAlias = $('#txtAliasM').val();
                var content = CKEDITOR.instances.txtContentM.getData();
                var status = $('#ckStatusM').prop('checked') === true ? 1 : 0;

                $.ajax({
                    type: "POST",
                    url: "/Admin/Page/SaveEntity",
                    data: {
                        Id: id,
                        Name: name,
                        Content: content,
                        Status: status,
                        Alias: seoAlias
                    },
                    dataType: "json",
                    beforeSend: function () {
                        kingflix.startLoading();
                    },
                    success: function () {
                        kingflix.notify('Update blog successful', 'success');
                        $('#modal-add-edit').modal('hide');
                        resetFormMaintainance();

                        kingflix.stopLoading();
                        loadData(true);
                    },
                    error: function () {
                        kingflix.notify('Have an error in progress', 'error');
                        kingflix.stopLoading();
                    }
                });
                return false;
            }
            return false;
        });

        $('body').on('click', '.btn-delete', function (e) {
            e.preventDefault();
            var that = $(this).data('id');
            kingflix.confirm('Are you sure to delete?', function () {
                $.ajax({
                    type: "POST",
                    url: "/Admin/Page/Delete",
                    data: { id: that },
                    dataType: "json",
                    beforeSend: function () {
                        kingflix.startLoading();
                    },
                    success: function () {
                        kingflix.notify('Delete blog successful', 'success');
                        kingflix.stopLoading();
                        loadData();
                    },
                    error: function () {
                        kingflix.notify('Have an error in progress', 'error');
                        kingflix.stopLoading();
                    }
                });
            });
        });
    };

    function resetFormMaintainance() {
        $('#hidIdM').val(0);
        $('#txtNameM').val('');
        $('#txtAliasM').val('');
        CKEDITOR.instances.txtContentM.setData('');
        $('#ckStatusM').prop('checked', true);

    }

    function registerControls() {
        var editorConfig = {
            filebrowserImageUploadUrl: '/Admin/Upload/UploadImageForCKEditor?type=Images'
        }
        CKEDITOR.replace('txtContentM', editorConfig);
        //Fix: cannot click on element ck in modal
        $.fn.modal.Constructor.prototype.enforceFocus = function () {
            $(document)
                .off('focusin.bs.modal') // guard against infinite focus loop
                .on('focusin.bs.modal', $.proxy(function (e) {
                    if (
                        this.$element[0] !== e.target && !this.$element.has(e.target).length
                        // CKEditor compatibility fix start.
                        && !$(e.target).closest('.cke_dialog, .cke').length
                        // CKEditor compatibility fix end.
                    ) {
                        this.$element.trigger('focus');
                    }
                }, this));
        };
    }

    function loadData(isPageChanged) {
        $.ajax({
            type: "GET",
            url: "/admin/blog/GetAllPaging",
            data: {
                keyword: $('#txt-search-keyword').val(),
                blog: kingflix.configs.blogIndex,
                blogSize: kingflix.configs.blogSize
            },
            dataType: "json",
            beforeSend: function () {
                kingflix.startLoading();
            },
            success: function (response) {
                var template = $('#table-template').html();
                var render = "";
                if (response.RowCount > 0) {
                    $.each(response.Results, function (i, item) {
                        render += Mustache.render(template, {
                            Name: item.Name,
                            Alias: item.Alias,
                            Id: item.Id,
                            Status: kingflix.getStatus(item.Status)
                        });
                    });
                    $("#lbl-total-records").text(response.RowCount);
                    if (render != undefined) {
                        $('#tbl-content').html(render);

                    }
                    wrapPaging(response.RowCount, function () {
                        loadData();
                    }, isPageChanged);


                }
                else {
                    $('#tbl-content').html('');
                }
                kingflix.stopLoading();
            },
            error: function (status) {
                console.log(status);
            }
        });
    };

    function wrapPaging(recordCount, callBack, changePageSize) {
        var totalsize = Math.ceil(recordCount / kingflix.configs.blogSize);
        //Unbind pagination if it existed or click change blogsize
        if ($('#paginationUL a').length === 0 || changePageSize === true) {
            $('#paginationUL').empty();
            $('#paginationUL').removeData("twbs-pagination");
            $('#paginationUL').unbind("blog");
        }
        //Bind Pagination Event
        $('#paginationUL').twbsPagination({
            totalPages: totalsize,
            visiblePages: 7,
            first: '?????u',
            prev: 'Tr?????c',
            next: 'Ti???p',
            last: 'Cu???i',
            onPageClick: function (event, p) {
                kingflix.configs.blogIndex = p;
                setTimeout(callBack(), 200);
            }
        });
    }
}