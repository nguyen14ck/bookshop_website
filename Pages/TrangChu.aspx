<%@ Page Title="" Language="C#" MasterPageFile="~/Design/Site.master" AutoEventWireup="true" CodeFile="TrangChu.aspx.cs" Inherits="Pages_TrangChu" %>

<%@ Register src="../UserControls/UC_Sach.ascx" tagname="UC_Sach" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CenterContent" Runat="Server">
    <uc1:UC_Sach ID="UC_Sach1" runat="server" />
</asp:Content>

