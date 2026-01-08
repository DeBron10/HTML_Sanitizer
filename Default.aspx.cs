using System;
using Ganss.XSS;

namespace WebFormsSanitizerDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string userHtml = txtInput.Text;

            // Show raw input (encoded to avoid XSS)
            litRaw.Text = Server.HtmlEncode(userHtml);

            // Create sanitizer
            var sanitizer = new HtmlSanitizer();

            // 🔒 HARDENING RULES
            sanitizer.AllowedTags.Clear();
            sanitizer.AllowedTags.Add("b");
            sanitizer.AllowedTags.Add("i");
            sanitizer.AllowedTags.Add("u");
            sanitizer.AllowedTags.Add("p");
            sanitizer.AllowedTags.Add("br");
            sanitizer.AllowedTags.Add("ul");
            sanitizer.AllowedTags.Add("ol");
            sanitizer.AllowedTags.Add("li");
            sanitizer.AllowedTags.Add("strong");
            sanitizer.AllowedTags.Add("em");

            // ❌ Block images, scripts, iframes, etc.
            sanitizer.AllowedAttributes.Clear();

            string cleanHtml = sanitizer.Sanitize(userHtml);

            // SAFE to render as HTML
            litSafe.Text = cleanHtml;
        }
    }
}
