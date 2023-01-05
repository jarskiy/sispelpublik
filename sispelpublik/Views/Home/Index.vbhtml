@Code
    ViewData("Title") = "Home"
    Layout = "~/Views/Shared/HomeLayout.vbhtml"

End Code

<!-- slider_area_start -->
<div class="slider_area">
    <div class="single_slider  d-flex align-items-center slider_bg_1">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-7 col-md-6">
                    <div class="slider_text">
                        <h5 class="wow fadeInLeft" data-wow-duration="1s" data-wow-delay=".2s">
                            Selamat Datang di
                        </h5>
                        <h3 class="wow fadeInLeft" data-wow-duration="1s" data-wow-delay=".3s">
                            Sistem Informasi
                            Pelayanan Publik Kota Pekanbaru
                        </h3>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="ilstration_img wow fadeInRight d-none d-lg-block text-right" data-wow-duration="1s"
         data-wow-delay=".2s">
        <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Logo_lambang_kota_pekanbaru.png/667px-Logo_lambang_kota_pekanbaru.png"
             alt="" height="400px">
    </div>
</div>
<!-- slider_area_end -->
<!-- catagory_area -->
<div class="catagory_area">
    <div class="container">
        <div class="row cat_search">
            <div class="col-lg-3 col-md-4">
                <div class="single_input">
                    <select class="wide">
                        <option>Jenis Pencarian</option>
                        <option value="1">Data KTP</option>
                        <option value="2">Data Akta Kelahiran</option>
                        <option value="3">Data Perkawinan</option>
                    </select>
                </div>
            </div>

            <div class="col-lg-6 col-md-4">
                <div class="single_input">
                    <input type="text" placeholder="Masukkan NIK Anda">
                </div>
            </div>
            <div class="col-lg-3 col-md-12">
                <div class="job_btn">
                    <a href="#" class="boxed-btn3">Proses</a>
                </div>
            </div>
        </div>
    </div>
</div>
<!--/ catagory_area -->
<!-- popular_catagory_area_start  -->
<div class="popular_catagory_area">
    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <div class="section_title mb-40 text-center">
                    <h3>Layanan Lainnya</h3>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-4 col-xl-3 col-md-6">
                <div class="single_catagory">
                    <a href="~/Home/Form">
                        <h4>Pembuatan SKCK</h4>
                    </a>
                </div>
            </div>
            <div class="col-lg-4 col-xl-3 col-md-6">
                <div class="single_catagory">
                    <a href="jobs.html">
                        <h4>Kartu Tanda Penduduk</h4>
                    </a>
                </div>
            </div>
            <div class="col-lg-4 col-xl-3 col-md-6">
                <div class="single_catagory">
                    <a href="jobs.html">
                        <h4>Akta Kelahiran</h4>
                    </a>
                </div>
            </div>
            <div class="col-lg-4 col-xl-3 col-md-6">
                <div class="single_catagory">
                    <a href="jobs.html">
                        <h4>Akta Kematian</h4>
                    </a>
                </div>
            </div>
            <div class="col-lg-4 col-xl-3 col-md-6">
                <div class="single_catagory">
                    <a href="jobs.html">
                        <h4>Perubahan Nama</h4>
                    </a>
                </div>
            </div>
            <div class="col-lg-4 col-xl-3 col-md-6">
                <div class="single_catagory">
                    <a href="jobs.html">
                        <h4>Perpindahan Penduduk</h4>
                    </a>
                </div>
            </div>
            <div class="col-lg-4 col-xl-3 col-md-6">
                <div class="single_catagory">
                    <a href="jobs.html">
                        <h4>Pencatatan Perkawinan</h4>
                    </a>
                </div>
            </div>
            <div class="col-lg-4 col-xl-3 col-md-6">
                <div class="single_catagory">
                    <a href="jobs.html">
                        <h4>Pencatatan Perceraian</h4>
                    </a>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- job_listing_area_start  -->
<!-- featured_candidates_area_start  -->
<!-- job_searcing_wrap  -->
<div class="job_searcing_wrap overlay">
    <div class="container">
        <div class="row">
            <div class="col-lg-5 offset-lg-1 col-md-6">
                <div class="searching_text">
                    <h3>Punya saran?</h3>
                    <p>Dengan senang hati menampung dan menerima saran anda </p>
                    <a href="#" class="boxed-btn3">Kirim</a>
                </div>
            </div>
            <div class="col-lg-5 offset-lg-1 col-md-6">
                <div class="searching_text">
                    <h3>Ada Masalah?</h3>
                    <p>Kami selalu siap melayani anda</p>
                    <a href="#" class="boxed-btn3">Lapor</a>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- job_searcing_wrap end  -->
<!-- testimonial_area  -->