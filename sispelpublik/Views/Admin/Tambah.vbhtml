@Code
    ViewData("Title") = "Halaman Tambah Data"
    Layout = "~/Views/Shared/AdminLayout.vbhtml"
End Code


<!-- partial -->
<div class="main-panel">
    <div class="content-wrapper">
        <div class="page-header">
            <h3 class="page-title">@ViewData("Title") </h3>
            <nav aria-label="breadcrumb">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="#">Admin</a></li>
                    <li class="breadcrumb-item active" aria-current="page">@ViewData("Title")</li>
                </ol>
            </nav>
        </div>
        <div class="row">
            <div class="col-md-12 grid-margin stretch-card">
                <div class="card">
                    <div class="card-body">
                        <form class="forms-sample">
                            <div class="form-group">
                                <label for="exampleInputUsername1">Text Disini</label>
                                <input type="text" class="form-control" id="exampleInputUsername1" placeholder="Masukkan text anda">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputUsername1">Text Disini</label>
                                <input type="text" class="form-control" id="exampleInputUsername1" placeholder="Masukkan text anda">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputUsername1">Text Disini</label>
                                <input type="text" class="form-control" id="exampleInputUsername1" placeholder="Masukkan text anda">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputUsername1">Text Disini</label>
                                <input type="text" class="form-control" id="exampleInputUsername1" placeholder="Masukkan text anda">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputUsername1">Text Disini</label>
                                <input type="text" class="form-control" id="exampleInputUsername1" placeholder="Masukkan text anda">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputUsername1">Text Disini</label>
                                <input type="text" class="form-control" id="exampleInputUsername1" placeholder="Masukkan text anda">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputUsername1">Text Disini</label>
                                <input type="text" class="form-control" id="exampleInputUsername1" placeholder="Masukkan text anda">
                            </div>
                            <button type="submit" class="btn btn-primary mr-2">Simpan</button>
                            <button class="btn btn-dark">Batal</button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    <!-- content-wrapper ends -->
