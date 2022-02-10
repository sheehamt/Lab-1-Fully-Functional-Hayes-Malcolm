<%@ Page Title="" Language="C#" MasterPageFile="~/DukeGroupMasterPage.Master" AutoEventWireup="true" CodeBehind="AddMember.aspx.cs" Inherits="Lab_1_Fully_Functional.AddMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblAddMember" runat="server" Text="Add Member"></asp:Label>
    <br />
    <br />
    <asp:ListBox ID="lstMembers" runat="server"></asp:ListBox>
    <br />
    <asp:Label ID="lblMemberFName" runat="server" Text="First Name"></asp:Label> <asp:TextBox ID="txtMemberFName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblMemberLName" runat="server" Text="Last Name"></asp:Label><asp:TextBox ID="txtMemberLName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblMemberEmail" runat="server" Text="Email"></asp:Label><asp:TextBox ID="txtMemberEmail" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblMemberPhone" runat="server" Text="Phone Number"></asp:Label> <asp:TextBox ID="txtMemberPhone" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblMemberGradYear" runat="server" Text="Year Graduated"></asp:Label><asp:TextBox ID="txtMemberGradYear" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblMemberTitle" runat="server" Text="Title"></asp:Label><asp:TextBox ID="txtMemberTitle" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnMemberPopulate" runat="server" Text="Populate" OnClick="btnMemberPopulate_Click" />
    <asp:Button ID="btnMemberSave" runat="server" Text="Save" OnClick="btnMemberSave_Click" />
    <asp:Button ID="btnMemberClear" runat="server" Text="Clear" OnClick="btnMemberClear_Click" />
    <asp:Button ID="btnMemberCommit" runat="server" Text="Commit" OnClick="btnMemberCommit_Click" />
    <asp:Label ID="lblValidation" runat="server" Text=" "></asp:Label>
</asp:Content>
