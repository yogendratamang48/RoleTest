<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBoxTest.aspx.cs" Inherits="RoleTest.CheckBoxTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin: 0 auto; text-align: center">
        <asp:ScriptManager ID="smMain" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="upgrvWorkatHouse" runat="server">
            <ContentTemplate>
                <table style="width: 1171px; border: 1px solid gray; margin: 5px auto; padding-top: 0;
                    padding-bottom: 10px;" cellpadding="4" cellspacing="0">
                    <tr>
                        <td style="width: 1171px; text-align: left; font-size: small" valign="middle">
                            तपाईको परिवारमा निम्न कार्यहरु प्राय कसले गर्दछ ? (दुवै भए दुवैमा ठिक लगाउने)
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 1171px; text-align: center">
                            <asp:GridView ID="grvWorkatHouse" runat="server" ShowFooter="True" AutoGenerateColumns="False"
                                CellPadding="2" ForeColor="#333333" Width="100%" GridLines="None" Font-Size="14px"
                                OnRowDeleting="grvWorkatHouse_RowDeleting" Style="text-align: left">
                                <Columns>
                                    <asp:BoundField DataField="RowNumber" HeaderText="क्र.सं" HeaderStyle-HorizontalAlign="Center"
                                        HeaderStyle-VerticalAlign="Middle">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Height="30" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Names="Fontasy Himali" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="कार्य" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle"
                                        ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle">
                                        <ItemTemplate>
                                            <asp:DropDownList ID="ddlgrvWorkatHouseWork" runat="server" CssClass="textBox" Height="25px"
                                                Width="300px">
                                                <asp:ListItem>------</asp:ListItem>
                                                <asp:ListItem>घर व्यवहार सम्बन्धि विषयमा निर्णय</asp:ListItem>
                                                <asp:ListItem>घरायसी काममा संलग्न</asp:ListItem>
                                                <asp:ListItem>बैंकमा खाता संचालन</asp:ListItem>
                                                <asp:ListItem>उपभोक्ता समितिमा सहभागिता</asp:ListItem>
                                                <asp:ListItem>विद्धालय व्यवस्थापनमा सहभागीता</asp:ListItem>
                                                <asp:ListItem>उद्धोग व्यापारमा सहभागीता</asp:ListItem>
                                            </asp:DropDownList>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="पुरुष" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle"
                                        ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="ckbgrvWorkatHouseMale" runat="server" Text="पुरुष" />
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="महिला" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle"
                                        ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="ckbgrvWorkatHouseFemale" runat="server" Text="महिला" />
                                        </ItemTemplate>
                                        <FooterStyle HorizontalAlign="Right" />
                                        <FooterTemplate>
                                            <asp:Button ID="grvWorkatHouseAdd" runat="server" Font-Names="Mangal" Text="थप्नुहोस्‌" Width="85px" Height="30px" BorderStyle="None" OnClick="grvWorkatHouseAdd_Click" />
                                        </FooterTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </asp:TemplateField>
                                    <asp:CommandField ShowDeleteButton="True" ButtonType="Image" DeleteImageUrl="~/Icons/Delete.gif" />
                                </Columns>
                                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                <RowStyle BackColor="#E3EAEB" />
                                <EditRowStyle BackColor="#7C6F57" />
                                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                <AlternatingRowStyle BackColor="White" />
                                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                                <SortedAscendingHeaderStyle BackColor="#246B61" />
                                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                                <SortedDescendingHeaderStyle BackColor="#15524A" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
