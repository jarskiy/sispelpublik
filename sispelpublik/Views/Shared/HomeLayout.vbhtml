<!doctype html>
<html class="no-js" lang="zxx">

<head>
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>SIPP PKU - @ViewData("Title")</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- <link rel="manifest" href="site.webmanifest"> -->
    <link rel="shortcut icon" type="image/x-icon" href="~/Assets/Home/img/favicon.png">
    <!-- Place favicon.ico in the root directory -->
    <!-- CSS here -->
    <link rel="stylesheet" href="~/Assets/Home/css/bootstrap.min.css">
    <link rel="stylesheet" href="~/Assets/Home/css/owl.carousel.min.css">
    <link rel="stylesheet" href="~/Assets/Home/css/magnific-popup.css">
    <link rel="stylesheet" href="~/Assets/Home/css/font-awesome.min.css">
    <link rel="stylesheet" href="~/Assets/Home/css/themify-icons.css">
    <link rel="stylesheet" href="~/Assets/Home/css/nice-select.css">
    <link rel="stylesheet" href="~/Assets/Home/css/flaticon.css">
    <link rel="stylesheet" href="~/Assets/Home/css/gijgo.css">
    <link rel="stylesheet" href="~/Assets/Home/css/animate.min.css">
    <link rel="stylesheet" href="~/Assets/Home/css/slicknav.css">

    <link rel="stylesheet" href="~/Assets/Home/css/style.css">
    <!-- <link rel="stylesheet" href="~/Assets/Home/css/responsive.css"> -->
</head>

<body>
    <!--[if lte IE 9]>
            <p class="browserupgrade">You are using an <strong>outdated</strong> browser. Please <a href="https://browsehappy.com/">upgrade your browser</a> to improve your experience and security.</p>
        <![endif]-->
    <!-- header-start -->
    <header>
        <div class="header-area ">
            <div id="sticky-header" class="main-header-area">
                <div class="container-fluid ">
                    <div class="header_bottom_border">
                        <div class="row align-items-center">
                            <div class="col-xl-3 col-lg-2">
                                <div class="logo">
                                    <a href="index.html" class="text-white" style="font-size:25px; font-weight: bold;">
                                        SIPP PKU
                                    </a>
                                </div>
                            </div>
                            <div class="col-xl-6 col-lg-7">
                                <div class="main-menu  d-none d-lg-block">
                                    <nav>
                                        <ul id="navigation">
                                            <li><a href="~/home/index">Beranda</a></li>
                                            <li><a href="~/home/halaman">Tentang</a></li>
                                            <li><a href="#">Panduan Layanan</a></li>
                                            <li><a href="#">Kontak</a></li>
                                            <li>
                                                <a href="#">UPTD <i class="ti-angle-down"></i></a>
                                                <ul class="submenu">
                                                    <li><a href="blog.html">UPTD Bina Widya</a></li>
                                                    <li><a href="blog.html">UPTD Bukit Raya</a></li>
                                                    <li><a href="blog.html">UPTD Lima Puluh</a></li>
                                                    <li><a href="blog.html">UPTD Marpoyan Damai</a></li>
                                                    <li><a href="blog.html">UPTD Payung Sekaki</a></li>
                                                    <li><a href="single-blog.html">UPTD Pekanbaru Kota</a></li>
                                                    <li><a href="single-blog.html">UPTD Rumbai</a></li>
                                                    <li><a href="single-blog.html">UPTD Rumbai Barat</a></li>
                                                    <li><a href="single-blog.html">UPTD Sail</a></li>
                                                    <li><a href="single-blog.html">UPTD Senapelan</a></li>
                                                    <li><a href="single-blog.html">UPTD Sukajadi</a></li>
                                                    <li><a href="single-blog.html">UPTD Tenayan Raya</a></li>
                                                </ul>
                                            </li>
                                        </ul>
                                    </nav>
                                </div>
                            </div>
                            <div class="col-xl-3 col-lg-3 d-none d-lg-block">
                                <div class="Appointment">
                                    <div class="phone_num d-none d-xl-block">
                                        <a href="~/Admin/Login">Log in</a>
                                    </div>
                                    <div class="d-none d-lg-block">
                                        <a class="boxed-btn3" href="#">Lapor Masalah</a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-12">
                                <div class="mobile_menu d-block d-lg-none"></div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </header>
    <!-- header-end -->

    @RenderBody()

    <!-- footer start -->
    <footer class="footer">
        <div class="footer_top">
            <div class="container">
                <div class="row">
                    <div class="col-xl-3 col-md-6 col-lg-3">
                        <div class="footer_widget wow fadeInUp" data-wow-duration="1s" data-wow-delay=".3s">
                            <div class="footer_logo">
                                <a href="#">
                                    <img src="https://disdukcapil.pekanbaru.go.id/sz_templates/templatedisduk/assets/img/logo-default.png"
                                         alt="" width="auto" height="70px">
                                </a>
                            </div>
                            <p>
                                Jl. Jenderal Sudirman No. 464 Komplek MPP Pekanbaru Kel. Jadirejo, Kec. Sukajadi, Kota Pekanbaru, Riau 28121
                            </p>
                            <div class="socail_links">
                                <ul>
                                    <li>
                                        <a href="#">
                                            <i class="ti-facebook"></i>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <i class="fa fa-google-plus"></i>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <i class="fa fa-twitter"></i>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <i class="fa fa-instagram"></i>
                                        </a>
                                    </li>
                                </ul>
                            </div>

                        </div>
                    </div>
                    <div class="col-xl-2 col-md-6 col-lg-2">
                        <div class="footer_widget wow fadeInUp" data-wow-duration="1.1s" data-wow-delay=".4s">
                            <h3 class="footer_title">
                                Tentang Kami
                            </h3>
                            <ul>
                                <li><a href="#">Visi & Misi</a></li>
                                <li><a href="#">Motto</a></li>
                                <li><a href="#">Struktur Organisasi</a></li>
                                <li><a href="#">Tugas dan Fungsi</a></li>
                                <li><a href="#">Prestasi</a></li>
                                <li><a href="#">SDM</a></li>
                            </ul>

                        </div>
                    </div>
                    <div class="col-xl-3 col-md-6 col-lg-3">
                        <div class="footer_widget wow fadeInUp" data-wow-duration="1.2s" data-wow-delay=".5s">
                            <h3 class="footer_title">
                                Jam Operasional
                            </h3>
                            <ul>
                                <li>
                                    <a>
                                        Senin-Jum'at: 08:30 sd 15.00 WIB <br />
                                        Sabtu, Minggu dan Libur Nasional : Tutup
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-xl-4 col-md-6 col-lg-4">
                        <div class="footer_widget wow fadeInUp" data-wow-duration="1.3s" data-wow-delay=".6s">
                            <h3 class="footer_title">
                                Hubungi Kami
                            </h3>
                            <ul>
                                <li><i class="fab fa-whatsapp text-color-primary"></i> (0761) 35463</li>
                                <li><i class="far fa-envelope text-color-primary"></i> disdukcapilkotapekanbaru@gmail.com </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="copy-right_text wow fadeInUp" data-wow-duration="1.4s" data-wow-delay=".3s">
            <div class="container">
                <div class="footer_border"></div>
                <div class="row">
                    <div class="col-xl-12">
                        <p class="copy_right text-center">
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                            Copyright &copy;
                            <script>document.write(new Date().getFullYear());</script>. Disdukcapil Kota Pekanbaru</a>
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!--/ footer end  -->
    <!-- link that opens popup -->
    <!-- JS here -->
    <script src="assets/js/vendor/modernizr-3.5.0.min.js"></script>
    <script src="assets/js/vendor/jquery-1.12.4.min.js"></script>
    <script src="assets/js/popper.min.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
    <script src="assets/js/owl.carousel.min.js"></script>
    <script src="assets/js/isotope.pkgd.min.js"></script>
    <script src="assets/js/ajax-form.js"></script>
    <script src="assets/js/waypoints.min.js"></script>
    <script src="assets/js/jquery.counterup.min.js"></script>
    <script src="assets/js/imagesloaded.pkgd.min.js"></script>
    <script src="assets/js/scrollIt.js"></script>
    <script src="assets/js/jquery.scrollUp.min.js"></script>
    <script src="assets/js/wow.min.js"></script>
    <script src="assets/js/nice-select.min.js"></script>
    <script src="assets/js/jquery.slicknav.min.js"></script>
    <script src="assets/js/jquery.magnific-popup.min.js"></script>
    <script src="assets/js/plugins.js"></script>
    <script src="assets/js/gijgo.min.js"></script>



    <!--contact js-->
    <script src="assets/js/contact.js"></script>
    <script src="assets/js/jquery.ajaxchimp.min.js"></script>
    <script src="assets/js/jquery.form.js"></script>
    <script src="assets/js/jquery.validate.min.js"></script>
    <script src="assets/js/mail-script.js"></script>


    <script src="assets/js/main.js"></script>
</body>

</html>