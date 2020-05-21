<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="WebApplication1.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .one
        {
            text-align:center;
        }
        .two
        {
            margin-top:4%;
            margin-left:25%;
        }
        .three
        {
            margin-top:2%;
            margin-left:41%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="one">
    <h2 style="font-size:40px;">Tasty Fast Food Corner</h2>
    </div>

    <div class="two">
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Items" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Offer" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Quantity" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Price" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Amount" Font-Bold="true"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="150px" Height="30px">
                    <asp:ListItem>select item</asp:ListItem>
                    <asp:ListItem>pav bhaji</asp:ListItem>
                    <asp:ListItem>burger</asp:ListItem>
                    <asp:ListItem>pizza</asp:ListItem>
                    <asp:ListItem Value="chowmein">chowmein</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" Height="30px">
                    <asp:ListItem>0%</asp:ListItem>
                    <asp:ListItem>5%</asp:ListItem>
                    <asp:ListItem>10%</asp:ListItem>
                    <asp:ListItem>15%</asp:ListItem>
                    <asp:ListItem>20%</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="100px" Height="25px"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="100px" Height="25px"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="100px" Height="25px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="More"  Width="70px" Height="25px" OnClick="Button1_Click"/>
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Finish" Width="70px" Height="25px" OnClick="Button2_Click"/>
            </td>
        </tr>

         <tr>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server" Width="150px" Height="30px" Enabled="False">
                    <asp:ListItem>select item</asp:ListItem>
                    <asp:ListItem>pav bhaji</asp:ListItem>
                    <asp:ListItem>burger</asp:ListItem>
                    <asp:ListItem>pizza</asp:ListItem>
                    <asp:ListItem Value="chowmein">chowmein</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList4" runat="server" Height="30px" Enabled="False">
                    <asp:ListItem>0%</asp:ListItem>
                    <asp:ListItem>5%</asp:ListItem>
                    <asp:ListItem>10%</asp:ListItem>
                    <asp:ListItem>15%</asp:ListItem>
                    <asp:ListItem>20%</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="More"  Width="70px" Height="25px" Enabled="False" OnClick="Button3_Click"/>
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" Text="Finish" Width="70px" Height="25px" Enabled="False" OnClick="Button4_Click"/>
            </td>
        </tr>

         <tr>
            <td>
                <asp:DropDownList ID="DropDownList5" runat="server" Width="150px" Height="30px" Enabled="False">
                    <asp:ListItem>select item</asp:ListItem>
                    <asp:ListItem>pav bhaji</asp:ListItem>
                    <asp:ListItem>burger</asp:ListItem>
                    <asp:ListItem>pizza</asp:ListItem>
                    <asp:ListItem Value="chowmein">chowmein</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList6" runat="server" Height="30px" Enabled="False">
                    <asp:ListItem>0%</asp:ListItem>
                    <asp:ListItem>5%</asp:ListItem>
                    <asp:ListItem>10%</asp:ListItem>
                    <asp:ListItem>15%</asp:ListItem>
                    <asp:ListItem>20%</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" Width="100px" Height="28px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button5" runat="server" Text="More"  Width="70px" Height="25px" Enabled="False" OnClick="Button5_Click"/>
            </td>
            <td>
                <asp:Button ID="Button6" runat="server" Text="Finish" Width="70px" Height="25px" Enabled="False" OnClick="Button6_Click"/>
            </td>
        </tr>

         <tr>
            <td>
                <asp:DropDownList ID="DropDownList7" runat="server" Width="150px" Height="30px" Enabled="False">
                    <asp:ListItem>select item</asp:ListItem>
                    <asp:ListItem>pav bhaji</asp:ListItem>
                    <asp:ListItem>burger</asp:ListItem>
                    <asp:ListItem>pizza</asp:ListItem>
                    <asp:ListItem Value="chowmein">chowmein</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList8" runat="server" Height="30px" Enabled="False">
                    <asp:ListItem>0%</asp:ListItem>
                    <asp:ListItem>5%</asp:ListItem>
                    <asp:ListItem>10%</asp:ListItem>
                    <asp:ListItem>15%</asp:ListItem>
                    <asp:ListItem>20%</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox11" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox12" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button7" runat="server" Text="More"  Width="70px" Height="25px" Enabled="False" OnClick="Button7_Click"/>
            </td>
            <td>
                <asp:Button ID="Button8" runat="server" Text="Finish" Width="70px" Height="25px" Enabled="False" OnClick="Button8_Click"/>
            </td>
        </tr>

         <tr>
            <td>
                <asp:DropDownList ID="DropDownList9" runat="server" Width="150px" Height="30px" Enabled="False">
                    <asp:ListItem>select item</asp:ListItem>
                    <asp:ListItem>pav bhaji</asp:ListItem>
                    <asp:ListItem>burger</asp:ListItem>
                    <asp:ListItem>pizza</asp:ListItem>
                    <asp:ListItem Value="chowmein">chowmein</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList10" runat="server" Height="30px" Enabled="False">
                    <asp:ListItem>0%</asp:ListItem>
                    <asp:ListItem>5%</asp:ListItem>
                    <asp:ListItem>10%</asp:ListItem>
                    <asp:ListItem>15%</asp:ListItem>
                    <asp:ListItem>20%</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:TextBox ID="TextBox13" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox14" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox15" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button10" runat="server" Text="Finish" Width="70px" Height="25px" Enabled="False" OnClick="Button10_Click"/>
            </td>
        </tr>
    </table>
    </div>

        <div class="three">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Total Rs." Width="100px" Height="25px" Enabled="False"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox16" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Service Tax" Width="100px" Height="25px" Enabled="False"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox17" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Amount to pay Rs." Width="100px" Height="25px" Enabled="False"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox18" runat="server" Width="100px" Height="25px" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button11" runat="server" Text="Calculate Amount" Width="120px" Height="25px" Enabled="False" OnClick="Button11_Click"/>
                </td>
                <td>
                    <asp:Button ID="Button12" runat="server" Text="Reset" Width="120px" Height="25px" Enabled="False" OnClick="Button12_Click" />
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
