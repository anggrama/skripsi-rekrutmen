<%@ Page Title="" Language="C#" MasterPageFile="~/MainDefault.Master" AutoEventWireup="true" CodeBehind="Beranda.aspx.cs" Inherits="RekrutmenTNI.Beranda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
     <script>
         $(document).ready(function () {
             // camera
             $('#camera_wrap').camera({
                 //thumbnails: true
                 autoAdvance: true,
                 mobileAutoAdvance: true,
                 fx: 'random',
                 height: '60%',
                 hover: false,
                 loader:'bar',
                 navigation: true,
                 navigationHover: false,
                 mobileNavHover: false,
                 playPause: false,
                 pauseOnClick: false,
                 pagination: true,
                 time: 7000,
                 transPeriod: 1000,
                 minHeight: '200px'
             });

             //	carouFredSel
             $('#slider3 .carousel.main ul').carouFredSel({
                 auto: {
                     timeoutDuration: 8000
                 },
                 responsive: true,
                 prev: '.prev3',
                 next: '.next3',
                 width: '100%',
                 scroll: {
                     items: 1,
                     duration: 1000,
                     easing: "easeOutExpo"
                 },
                 items: {
                     width: '350',
                     height: 'variable',	//	optionally resize item-height			  
                     visible: {
                         min: 1,
                         max: 4
                     }
                 },
                 mousewheel: false,
                 swipe: {
                     onMouse: true,
                     onTouch: true
                 }
             });
             $(window).bind("resize", updateSizes_vat).bind("load", updateSizes_vat);
             function updateSizes_vat() {
                 $('#slider3 .carousel.main ul').trigger("updateSizes");
             }
             updateSizes_vat();

             // carufredsel testimonials
             $('#caroufredsel').carouFredSel({
                 auto: {
                     timeoutDuration: 9000
                 },
                 responsive: true,
                 direction: "left",
                 //prev: '.prev',
                 //next: '.next',
                 width: '100%',
                 scroll: {
                     items: 1,
                     duration: 1000,
                     easing: "easeOutExpo",
                     fx: "fade"
                 },
                 items: {
                     width: '1000',
                     height: 'variable',	//	optionally resize item-height			  
                     visible: {
                         min: 1,
                         max: 1
                     }
                 },
                 mousewheel: false,
                 swipe: {
                     onMouse: false,
                     onTouch: false
                 },
                 pagination: ".paginations2"


             });

         }); //
         $(window).load(function () {
             //

         }); //
    </script>
        
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMain" runat="server">
    <div id="slider_wrapper">
			<div id="slider" class="clearfix">
				<div id="camera_wrap">
                    <div data-src="images/slide-tni-01-edit.jpg"></div>	
                    <div data-src="images/slide-tni-02-edit.jpg"></div>	
					<div data-src="images/slide-tni-03-edit.jpg"></div>
					<div data-src="images/slide-tni-04-edit.jpg"></div>
                    <div data-src="images/slide-tni-05-edit.jpg"></div>
					<div data-src="images/slide-tni-06-edit.jpg"></div>	
				</div>	
			</div>	
		</div> 
</asp:Content>
