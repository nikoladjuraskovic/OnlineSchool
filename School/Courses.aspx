<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="School.Courses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="Red" Font-Bold="true"></asp:Label>

    <h1>School Courses</h1>

    <br />

    <asp:GridView ID="GridView1" runat="server" CssClass="table"></asp:GridView>

</asp:Content>
