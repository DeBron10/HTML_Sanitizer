<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="WebFormsSanitizerDemo.Default"
    ValidateRequest="false" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>HTML Sanitizer Demo</title>
    <style>
        body { font-family: Arial; margin: 40px; }
        textarea { width: 100%; height: 150px; }
        .box { border: 1px solid #ccc; padding: 15px; margin-top: 15px; }
        .unsafe { background: #ffe6e6; }
        .safe { background: #e6ffe6; }
    </style>
</head>
<body>
<form id="form1" runat="server">

    <h2>Enter HTML (Unsafe Input)</h2>

    <asp:TextBox
        ID="txtInput"
        runat="server"
        TextMode="MultiLine"
        />

    <br /><br />

    <asp:Button
        ID="btnSubmit"
        runat="server"
        Text="Sanitize HTML"
        OnClick="btnSubmit_Click" />

    <h3>Raw Input</h3>
    <div class="box unsafe">
        <asp:Literal ID="litRaw" runat="server" />
    </div>

    <h3>Sanitized Output</h3>
    <div class="box safe">
        <asp:Literal ID="litSafe" runat="server" />
    </div>

</form>
</body>
</html>
