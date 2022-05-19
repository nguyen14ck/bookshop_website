<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UC_Sach.ascx.cs" Inherits="UserControls_UC_Sach" %>
<div class="box">
    <div class="bdDRed title1 alignL">
        <asp:Label ID="tieuDe" runat="server"></asp:Label>
    </div>
    <div style="height:350px; width:99%; overflow-y:scroll">
    <asp:DataList ID="dtlSach" runat="server" RepeatColumns="3" 
        Width="100%" onitemcommand="dtlSach_ItemCommand">
        <ItemStyle BorderStyle="Inset" BorderWidth="1px" Width="33.3%" />
        <ItemTemplate>
            <asp:HyperLink ID="hplHinhbia" runat="server" CssClass="alignC" 
                ImageUrl='<%# "~/Photos/Books/"+Eval("Hinhbia") %>' NavigateUrl='<%# "~/Pages/SachCT.aspx?Sid="+Eval("SachID") %>' 
                Width="100%">HyperLink</asp:HyperLink>
            <br />
            <asp:HyperLink ID="hplTenSach" runat="server" NavigateUrl='<%# "~/Pages/SachCT.aspx?Sid="+Eval("SachID") %>' 
                Text='<%# Eval("Tensach") %>' CssClass="alignC" Height="40px" Width="100%"></asp:HyperLink>
            <p class="alignR">
                <asp:Label ID="lblGiaBan" runat="server" 
                    Text='<%# "Giá bán: "+Eval("Giaban","{0:#,##0VNĐ}") %>'></asp:Label>
                <asp:ImageButton ID="btnChonMua" runat="server" CommandName="ChonMua" 
                    ImageUrl="~/Images/cart.png" Width="35px" 
                    CommandArgument='<%# Eval("GiaBan") %>' ToolTip="Chọn mua hàng" />
            </p>
        </ItemTemplate>
    </asp:DataList>
    </div>
</div>