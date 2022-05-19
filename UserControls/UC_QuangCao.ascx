<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UC_QuangCao.ascx.cs" Inherits="UserControls_UC_QuangCao" %>


<div class="box">
    <div class="bgRed title1">QUẢNG CÁO</div>

    <div style="height:420px; overflow:hidden;">
        <asp:DataList ID="dtlQuangCao" runat="server" ShowFooter="False"
            ShowHeader="False" Width="99%" CellPadding="1" CssClass="moveTB1">
            <ItemTemplate>
                <asp:HyperLink ID="HinhQuangCao" runat="server"
                ImageUrl='<%# "~/Photos/QuangCao/" + Eval("HinhQuangCao") %>' 
                NavigateUrl='<%# Eval("DiaChiWS") %>' Target="_blank"
                ToolTip='<%# Eval("TenCongTy") %>'>Thông  tin quảng cáo</asp:HyperLink>
            </ItemTemplate>
        </asp:DataList>
    </div>

</div>