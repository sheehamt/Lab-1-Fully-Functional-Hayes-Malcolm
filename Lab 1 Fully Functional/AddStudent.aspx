<%@ Page Title="" Language="C#" MasterPageFile="~/DukeGroupMasterPage.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="Lab_1_Fully_Functional.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblAddStudent" runat="server" Text="Fill out student info:"></asp:Label>
    <br />
    <br />
    <asp:ListBox ID="lstStudentList" runat="server" Width="303px"></asp:ListBox>
    <br />
    <asp:Label ID="lbladdstudentFname" runat="server" Text="First Name"></asp:Label> <asp:TextBox ID="txtAddStudentfirstName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbladdStudentLname" runat="server" Text="Last Name"></asp:Label> <asp:TextBox ID="txtAddStudentLastName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbladdStudentEmail" runat="server" Text="Email Address"></asp:Label> <asp:TextBox ID="txtAddStudentEmail" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbladdStudentPhone" runat="server" Text="Phone Number"></asp:Label> <asp:TextBox ID="txtAddStudentPhone" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbladdStudentEGY" runat="server" Text="Expected Grad Year"></asp:Label> <asp:TextBox ID="txtAddStudentExpectedGY" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbladdStudentMajor" runat="server" Text="Major"></asp:Label> <asp:TextBox ID="txtAddStudentMajor" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbladdStudentUniYear" runat="server" Text="University Year"></asp:Label> <asp:TextBox ID="txtAddStudentUniYear" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbladdStudentInternship" runat="server" Text="Internship"></asp:Label> <asp:TextBox ID="txtAddStudentInternship" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbladdStudentEmploymentStatus" runat="server" Text="Employment Status"></asp:Label> <asp:TextBox ID="txtAddStudentEmployStat" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnAddStudentPopulate" runat="server" Text="Populate" OnClick="btnAddStudentPopulate_Click" />
    <asp:Button ID="btnAddStudentSave" runat="server" Text="Save" OnClick="btnAddStudentSave_Click" Width="107px" />
    <asp:Button ID="btnAddStudentClear" runat="server" Text="Clear" OnClick="btnAddStudentClear_Click" />
     <asp:Button ID="btnCommit" runat="server" Text="Commit ->" OnClick="btnCommit_Click" />
    <asp:Label ID="lblValidation" runat="server" Text=" "></asp:Label>
</asp:Content>
