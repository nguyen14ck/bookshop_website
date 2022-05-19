<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UC_SachCT.ascx.cs" Inherits="UserControls_UC_SachCTl" %>
<div class = "box">
    <div class = "bgBlue title1">
        GIỚI THIỆU NỘI DUNG SÁCH
    </div>
    <div style = " width:98%; height:240px">
        <asp:DataList ID="dtlSach" runat="server" onitemdatabound="dtlSach_ItemDataBound" Width="100%">
        <ItemTemplate>
            <asp:Label ID="lblTensach" runat="server" Font-Size="1.2em" ForeColor="#FF3300" 
        Height="30px" Width="99.5%"></asp:Label>

    <div style="width:100%; margin:10px 0px">
        <div style="float:left; text-align:center; width:25%">
            <asp:Image ID="imgHinhbia" runat="server" 
                ImageUrl='<%# "~/Photos/Books/"+Eval("Hinhbia") %>' />
        </div>

        <div style="float:right; text-align:center; width:74.98%">
            <asp:Label ID="Label2" runat="server" Text="Tác giả:" Font-Bold="True" 
                Font-Italic="True" Font-Size="13pt" ForeColor="#CC0066"></asp:Label>
            <asp:BulletedList ID="dsTacGia" runat="server" BulletStyle="Numbered">
            </asp:BulletedList>
            <br />
            <span class="style1"><strong><em>Nhà xuất bản:                
        </em></strong></span>
        <asp:Label ID="lblTenNhaxuatban" runat="server" Font-Size="13pt" 
                Text='<%# Eval("Tennhaxuatban") %>'></asp:Label>
            <br />
            <strong><em>Giá bán:
        </em></strong>
            <asp:Label ID="lblGiaban" runat="server" Font-Size="13pt" 
                Text='<%# Eval("Giaban","{0:#,##0VNĐ}") %>' Font-Italic="True" 
                ForeColor="#0066FF"></asp:Label>
        </div>
    </div>

    <asp:Label ID="Label1" runat="server" Text="Giới thiệu nội dung sách:" 
        Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="Blue" 
        Width="99%"></asp:Label>
        <br />
    <asp:TextBox ID="txtMota" runat="server" ReadOnly="True" Rows="10" 
        TextMode="MultiLine" Width="99.8%" Text='<%# Eval("MoTa") %>'></asp:TextBox>
        </ItemTemplate>
    </asp:DataList>   
    </div>
</div>