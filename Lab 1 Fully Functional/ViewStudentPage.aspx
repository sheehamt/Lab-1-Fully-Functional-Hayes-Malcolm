<%@ Page Title="Student Page" Language="C#" MasterPageFile="~/DukeGroupMasterPage.Master" AutoEventWireup="true" CodeBehind="ViewStudentPage.aspx.cs" Inherits="Lab_1_Fully_Functional.StudentPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblHeaderStudent" runat="server" Text="View Student Page"></asp:Label>
    <br />
    <br />
    <asp:DropDownList ID="ddlViewStudents" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceStudents" DataTextField="FullName" DataValueField="StudentID"></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSourceStudents" runat="server" ConnectionString="<%$ ConnectionStrings:Lab1DBConnectionString %>" 
        SelectCommand="SELECT FirstName + ' ' + LastName AS FullName, StudentID FROM DBO.Students"></asp:SqlDataSource>
    <br />
    <br />
</asp:Content>
