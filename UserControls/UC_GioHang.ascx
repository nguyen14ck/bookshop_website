<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UC_GioHang.ascx.cs" Inherits="UserControls_GioHang" %>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="View1" runat="server">
        <asp:GridView ID="grwGioHang" runat="server" AutoGenerateColumns="False" 
            Width="100%" onrowcancelingedit="grwGioHang_RowCancelingEdit" 
            onrowediting="grwGioHang_RowEditing" onrowcommand="grwGioHang_RowCommand" 
            onrowupdating="grwGioHang_RowUpdating">
            <Columns>
                <asp:BoundField DataField="TenSach" HeaderText="Tên Sách" ReadOnly="True" />
                <asp:BoundField DataField="Soluong" HeaderText="Số lượng" >
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="Giaban" HeaderText="Đơn giá" ReadOnly="True" 
                    DataFormatString="{0:#,##0 VNĐ}" >
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="ThanhTien" HeaderText="Thành tiền" ReadOnly="True" 
                    DataFormatString="{0:#,##0 VNĐ}" >
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:CommandField HeaderText="Hiệu Chỉnh" ShowEditButton="True" EditText="Sửa" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:CommandField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        <asp:ImageButton ID="imgXoa" runat="server" CommandName="xoa" 
                            ImageUrl="~/Images/delete.png" Width="24px" />
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkChon" runat="server" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        Tổng tiền :
        <asp:Label ID="lblTongtien" runat="server"></asp:Label>
        <br />
        Số lượng mặt hàng:
        <asp:Label ID="lblTongMH" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnDatmua" runat="server" onclick="btnDatmua_Click" 
            Text="Đặt mua" />
        <br />

    </asp:View>
    <asp:View ID="View2" runat="server">
        <asp:Label ID="lblTongThongbao" runat="server"></asp:Label>
    </asp:View>
    <br />
</asp:MultiView>

