<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UC_ChuDe.ascx.cs" Inherits="UserControls_UC_ChuDe" %>
<div class = "box">
    <div class = "bgBlue title1">
        CHỦ ĐỀ SÁCH
    </div>
    <div style = "overflow-y:scroll; width:98%; height:240px">
        <asp:DataList ID="dtlChuDe" runat="server" Width="100%">
            <ItemTemplate>
                <asp:HyperLink ID="TenChuDe" runat="server" 
                    NavigateUrl='<%# "~/Pages/TrangChu.aspx?Cid="+Eval("ChuDeID") %>' 
                    Text='<%# Eval("TenChuDe") %>'></asp:HyperLink>
            </ItemTemplate>
        </asp:DataList>
    </div>
</div>