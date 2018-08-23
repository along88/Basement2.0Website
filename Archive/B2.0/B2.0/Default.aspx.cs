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

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            string feed = string.Format(@"<a href=""https://twitter.com/basement2dot0"" class=""twitter-follow-button"" data-size=""large"" data-show-count=""false"">Follow @Basement2dot0</a><script async src=""//platform.twitter.com/widgets.js"" charset=""utf-8""></script>");
                feed += string.Format(@"<a class=""twitter-timeline"" href=""https://twitter.com/basement2dot0"">Basement2dot0 Feed</a> <script async src=""//platform.twitter.com/widgets.js"" charset=""utf-8""></script>");
            contentLabel.Text = string.Format(feed);
        }

        protected void aboutBtn_Click(object sender, EventArgs e)
        {
            string aboutUs = "<b>Vision</b> </br>" +
                "! </br> " +
                "<b>History</b> </br>" +
                "We started this Company back in(such and such Date) </br>" +
                "<b>Philsophy</b> </br>" +
                "We believe we should make games and you should buy them!";
                contentLabel.Text = string.Format(aboutUs);
        }

        protected void projectsBtn_Click(object sender, EventArgs e)
        {
            string RingOut = "<b>Ring Out!</b> </br>" +
                "A colorful and sometimes off-beat 3D Arena Fighting Game where the goal is to knock your opponent of the ring by ANY means necessary!";
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

        protected void donateBtn_Click(object sender, EventArgs e)
        {
            string donate = "Interested in supporting our development efforts? Here at basement2dot0 we aren't comfortable"+
                "just taking your money, so we've thought long and hard about how to give back to those who supported us early on"+
                "So we started a Patreon page! Patreon is a great platform for supports like you to support content creators like us"+
                "to continue to create more content for you! By being a patron of Basement2dot0 you will be rewarded with cool behind the"+
                "scenes access to our development where your voice and opinions can directly reach the team during phases of development and"+
                "help drive the direction of the games we make for you! You're also promised a copy of the game upon release at in additional to a"+
                "butt load of other cool rewards! Head over to our Patreon page <a href='https://www.patreon.com/basement2dot0'>here</a> to become a member!" +
                "<br> If you don't care about the rewards or just simply want to donate to our cause without becoming a member we also accept"+
                "Paypal donations! Note: For all Paypal donations, basement2dot0 will be providing a thank you gift to all paypal supports"+
                "when the company launches it's KickStarter Campaign in the near future.</br>";
            contentLabel.Text = string.Format(donate);
        }
    }
}