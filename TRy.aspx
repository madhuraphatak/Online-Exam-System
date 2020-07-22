<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TRy.aspx.cs" Inherits="TRy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <h2>Online Examination</h2>  
           <hr />
            Welcome <asp:Label ID="Label10" runat="server"></asp:Label>
            <br />
            <input id="Id" name="Id" type="hidden" value="1" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>&ensp;
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="a"/>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="a" />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><br />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="a" />
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label><br />
            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="a" />
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label><br />
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Back" BorderStyle="Ridge" Font-Size="Small" ForeColor="#660066" OnClick="Back" />
            &emsp;&emsp;&emsp;&emsp;
            <asp:Button ID="Button3" runat="server" Text="Save" BorderStyle="Ridge" Font-Size="Small" ForeColor="#660066" OnClick="Save" />
            &emsp;&emsp;&emsp;&emsp;
            <asp:Button ID="Button2" runat="server" Text="Next" BorderStyle="Ridge" Font-Size="Small" ForeColor="#660066" OnClick="Next" />
            
        </div>
    </form>
    
</body>
</html>
