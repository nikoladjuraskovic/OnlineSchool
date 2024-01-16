<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="School.Students" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="ErrorLabel" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>

    <h3>Insert Student</h3>

    <asp:Panel ID="Panel1" runat="server" CssClass="form-group">

        <asp:Label ID="Label1" runat="server" Text="First Name:" Font-Bold="true"></asp:Label>

        <asp:TextBox ID="TextBoxFirstName" runat="server" CssClass="form-control"></asp:TextBox>

    </asp:Panel>

    <asp:Panel ID="Panel2" runat="server" CssClass="form-group">

        <asp:Label ID="Label2" runat="server" Text="Last Name:" Font-Bold="true"></asp:Label>

        <asp:TextBox ID="TextBoxLastName" runat="server" CssClass="form-control"></asp:TextBox>

    </asp:Panel>

    <asp:Panel ID="Panel3" runat="server" CssClass="form-group">

        <asp:Label ID="Label3" runat="server" Text="Year:" Font-Bold="true"></asp:Label>

        <asp:TextBox ID="TextBoxYear" runat="server" CssClass="form-control"></asp:TextBox>

    </asp:Panel>

    
    <br />
    <asp:Panel ID="Panel4" runat="server" CssClass="form-group">

        <asp:Button ID="Button1" runat="server"
            Text="Insert Student"
            CssClass="btn btn-success"
              OnClick="Button1_Click"/>

    </asp:Panel>

    <asp:Label ID="lblOutput"
        runat="server"
        Text=""
        Font-Bold="true"></asp:Label>
    

    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
        ErrorMessage="Enter Name!"
        ControlToValidate="TextBoxFirstName"       
         ForeColor="red"
         Font-Bold="true"
         EnableClientScript="false"
         Display="None"></asp:RequiredFieldValidator>   

    <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
        runat="server"
        ErrorMessage="Name can only have letters!"
        ControlToValidate="TextBoxFirstName"
        ForeColor="Red"
        Font-Bold="true"
        EnableClientScript="false"
        ValidationExpression="[a-zA-Z]+"
        Display="None"
        ></asp:RegularExpressionValidator>

    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
        ErrorMessage="Enter Last Name!"
         ControlToValidate="TextBoxLastName"
        ForeColor="red"
         Font-Bold="true"
        EnableClientScript="false"
        Display="None">

        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
        runat="server"
        ErrorMessage="Last name can only have letters!"
        ControlToValidate="TextBoxLastName"
        ForeColor="Red"
        Font-Bold="true"
        EnableClientScript="false"
        ValidationExpression="[a-zA-Z]+"
        Display="None"
        ></asp:RegularExpressionValidator>

    </asp:RequiredFieldValidator>

    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
        ErrorMessage="Enter year!"
         ControlToValidate="TextBoxYear"
        ForeColor="Red"
        Font-Bold="true"
        EnableClientScript="false"
        Display="None"
        >

    </asp:RequiredFieldValidator>

    <asp:RangeValidator ID="RangeValidator1" runat="server"
        ErrorMessage="Please enter a number between 1 and 4!"
         ControlToValidate="TextBoxYear"
         ForeColor="Red"
         Font-Bold="true"
         MaximumValue="4"
         MinimumValue="1"
         Type="Integer"
         EnableClientScript="false"
         Display="None">


    </asp:RangeValidator>


    <asp:ValidationSummary ID="ValidationSummary1" runat="server"
         DisplayMode="BulletList"
          HeaderText="Input Errors:"
         ForeColor ="red"
         Font-Bold="true"
        />


    <h3>Students in Database</h3>
   
    <asp:GridView ID="GridView1" runat="server"
        
        EmptyDataText="No Data"
        EmptyDataRowStyle-ForeColor="Red"
         AutoGenerateColumns="true"
         CssClass="table"
         ></asp:GridView>


</asp:Content>
