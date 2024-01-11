<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="aboutus.aspx.cs" Inherits="LibraryManagementSystem.aboutus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .add {
        font-family:Montserrat;
        font-size:30px;
        color:#6E2A54
        }
        .main {
        font-family:Poltawski Nowy;
        font-size:20px;
        }



        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder10" runat="server">
 <div class="container">
  <div class="row">
    <div class="col-4 border" >
     <h1 class="add">Address</h1>
        <h3 class="main">Archive Library, Ganesh Tower, near Bus Depo, Kannamwar Nagar 1, Vikhroli(East), Mumbai-400083</h3>

         <h1 class="add">Contact no</h1>
        <h3 class="main">8657278229</h3>

         <h1 class="add">Email ID</h1>
        <h3 class="main">archivelibrary@gmail.com</h3>
    </div>
    <div class="col-8 border">
      <img width="800px" height="400px" src="imgs/library1.jpg" />
    </div>
  </div>
   </div>
</asp:Content>
