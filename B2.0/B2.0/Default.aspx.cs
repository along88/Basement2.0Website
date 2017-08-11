using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B2._0
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                string text = "<b>BasemEnt2.0</b>, is a New Jersey based indie game studio" +
                    " focused on developing quality and immersive interactive experiences and entertainment." +
                    "Favoring creativity and artistic integrity, BasemEnt2.0 quantifies it's philosophy through" +
                    " one simple motto that drives it's culture , 'Its not about the money!'";
               contentLabel.BorderStyle = BorderStyle.None;
                contentLabel.Text = string.Format(text);
            }

        }

        protected void aboutBtn_Click(object sender, EventArgs e)
        {
            string aboutUs = "<b>Vision</b> </br>" +
                "Our Vision is to have a vision! </br> " +
                "<b>History</b> </br>" +
                "We started this Company back in(such and such Date) </br>" +
                "<b>Philsophy</b> </br>" +
                "We believe we should make games and you should buy them!";
                contentLabel.Text = string.Format(aboutUs);
        }

        protected void projectsBtn_Click(object sender, EventArgs e)
        {
            string RingOut = "<b>Ring Out!</b> </br>" +
                "A 3D Arena Fighting Game where the goal is to knock your opponent of the ring by ANY means necessary!";
            contentLabel.Text = string.Format(RingOut);
        }

        protected void faqBtn_Click(object sender, EventArgs e)
        {
            string faq = "<b>What is Basement2dot0?</b> </br>" +
                "We are an entertainment company that makes video games and other forms of entertainment media! </br>"+
                "<b>How do you say the name?</b> </br>"+
                "Basement Two Dot OH </br>"+
                "<b>What do you guys do?</b> </br>"+
                "We make video games!";
            contentLabel.Text = string.Format(faq);
        }

        protected void contactBtn_Click(object sender, EventArgs e)
        {
            string contact = 
                "<b>Email:</b> </br>" +
                        "<a href='mailto:basement2dot0@gmail.com'> Basement2dot0@gmail.com</a> </br>" +
                              "<a href='https://www.facebook.com/BasemENT2dot0'>Facebook</a></br>" +
            "<a href='https://twitter.com/basement2dot0'>Twitter</a></br>" +
            "<a href='https://www.instagram.com/basement2dot0/'>Instagram</a></br>" +
            "<a href='http://basement2dot0.tumblr.com'>Tumblr</a></br>";

            /* 
             *          "<b>Email:</b> </br>"+
						"<li>"<a href='mailto:basement2dot0@gmail.com'>Basement2dot0@gmail.com</a> "</li>"+
						"<li><a href="https://www.facebook.com/BasemENT2dot0">Facebook</a></li>"+
						"<li><a href="https://twitter.com/basement2dot0">Twitter</a></li>"+
						"<li><a href="https://www.instagram.com/basement2dot0/">Instagram</a></li>"+
						"<li><a href="http://basement2dot0.tumblr.com">Tumblr</a></li>"+
  
					*/
            contentLabel.Text = string.Format(contact);
        }
    }
}