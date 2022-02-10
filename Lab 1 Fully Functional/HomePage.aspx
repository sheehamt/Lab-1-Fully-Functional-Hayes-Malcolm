<%@ Page Title="" Language="C#" MasterPageFile="~/DukeGroupMasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Lab_1_Fully_Functional.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblAddEntity" runat="server" Text="Add Student"></asp:Label>
    <asp:LinkButton ID="lnkbtnAddPage" runat="server" PostBackUrl="~/AddStudent.aspx" BorderColor="Black" BorderStyle="Solid">Enter -></asp:LinkButton>
    <br />
    <br />
    <asp:Label ID="lblEditPage" runat="server" Text="View Students"></asp:Label>
    <asp:LinkButton ID="lnkbtnEdit" runat="server" PostBackUrl="~/ViewStudentPage.aspx" BorderColor="Black" BorderStyle="Solid">Enter -></asp:LinkButton>
    <br />
    <br />
    <asp:Label ID="lblAssociate" runat="server" Text="Associate Entities"></asp:Label>
    <asp:LinkButton ID="lnkbtnAssociate" runat="server" PostBackUrl="~/AssociatePage.aspx">Enter -></asp:LinkButton>
    <br />
    <br />
</asp:Content>

