@Code
    ViewData("Title") = "Form"
    Layout = "~/Views/Shared/HomeLayout.vbhtml"
End Code

<div class="bradcam_area bradcam_bg_1">
    <div class="container">
        <div class="row">
            <div class="col-xl-12">
                <div class="bradcam_text">
                    <h3>@ViewData("Title")</h3>
                </div>
            </div>
        </div>
    </div>
</div>


<div class="job_details_area">
    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <div class="apply_job_form white-bg">
                    <form action="#">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="input_field">
                                    <input type="text" placeholder="Your name">
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="input_field">
                                    <input type="text" placeholder="Your name">
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="input_field">
                                    <input type="text" placeholder="Your name">
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="input-group">
                                    <div class="input-group-prepend">
                                        <button type="button" id="inputGroupFileAddon03">
                                            <i class="fa fa-cloud-upload" aria-hidden="true"></i>
                                        </button>
                                    </div>
                                    <div class="custom-file">
                                        <input type="file" class="custom-file-input" id="inputGroupFile03" aria-describedby="inputGroupFileAddon03">
                                        <label class="custom-file-label" for="inputGroupFile03">Upload KTP</label>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="input_field">
<textarea name="#" id="" cols="30" rows="10" placeholder="Alamat"></textarea>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="submit_btn">
                                    <button class="boxed-btn3 w-100" type="submit">Proses   </button>
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
           
        </div>
    </div>
</div>