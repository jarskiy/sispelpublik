@Code
    Layout = "~/Views/Shared/AuthLayout.vbhtml"
End Code

<!DOCTYPE html>

                <div class="content-wrapper full-page-wrapper d-flex align-items-center auth login-bg">
                    <div class="card col-lg-4 mx-auto">
                        <div class="card-body px-5 py-5">
                            <h3 class="card-title text-left mb-3">Login Admin</h3>
                            <form>
                                <div class="form-group">
                                    <input type="text" class="form-control p_input" placeholder="Masukkan email">
                                </div>
                                <div class="form-group">
                                    <input type="text" class="form-control p_input" placeholder="Masukkan password">
                                </div>
                                <div class="form-group d-flex align-items-center justify-content-between">
                                    <div class="form-check">
                                        <label class="form-check-label">
                                            <input type="checkbox" class="form-check-input"> Ingat Saya
                                        </label>
                                    </div>
                                </div>
                                <div class="text-center">
                                    <a class="btn btn-primary btn-block enter-btn" href="~/Admin/Index">Masuk</a>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
                <!-- content-wrapper ends -->