    <%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="LibraryManagementSystem.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
        $(function () {
            $('.imgSlider img:gt(0)').hide();
            setInterval(function () {
                $('.imgSlider :first-child').fadeOut(2500).next
                    ('img').fadeIn(2500).end().appendTo(' .slide');
            }, 2500);
        });

    </script>

     <style>
       #styling{
           font-family:Times New Roman;
           font-weight:100;
           font-size:25px;
         }
        #styling2{
           font-family:Berlin Sans FB;
           font-weight:100;
           font-size:25px;
         }
       </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder10" runat="server">
      <div>
      <img src="imgs/newBanner1.png" class="img-fluid" /> 
          </div>
   <section>
      <div  class="container">
         <div class="row">
            <div class="col-12">
               <center id="styling">
                  <h2>Our Process</h2>
                  <p><b>We have a Simple 3 Step Process</b></p>
               </center>
            </div>
         </div>
         <div id="styling2" class="row">
            <div class="col-md-4">
               <center>
                  <img width="150px" src="imgs/signup.png" />
                  <h4>Sign Up</h4>  
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="150px" src="imgs/search-online.png"/>
                  <h4>Search Books</h4>
                 
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="150px" src="imgs/library.png"/>
                  <h4>Visit Us</h4>
                 
               </center>
            </div>
         </div>
      </div>
   </section>
</asp:Content>

