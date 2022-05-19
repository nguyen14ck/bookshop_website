<%@ Page Title="" Language="C#" MasterPageFile="~/Design/Site.master" AutoEventWireup="true" CodeFile="GioHang.aspx.cs" Inherits="Pages_GioHang" %>

<%@ Register src="../UserControls/UC_GioHang.ascx" tagname="UC_GioHang" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CenterContent" Runat="Server">
    <uc1:UC_GioHang ID="UC_GioHang1" runat="server" />
</asp:Content>

