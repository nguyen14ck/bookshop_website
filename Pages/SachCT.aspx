<%@ Page Title="" Language="C#" MasterPageFile="~/Design/Site.master" AutoEventWireup="true" CodeFile="SachCT.aspx.cs" Inherits="Pages_SachCT" %>

<%@ Register src="../UserControls/UC_SachCT.ascx" tagname="UC_SachCT" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CenterContent" Runat="Server">
    <uc1:UC_SachCT ID="UC_SachCT1" runat="server" />
</asp:Content>

