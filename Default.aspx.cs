using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string tweetToRead =  "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnVoice_Click(object sender, EventArgs e)
    {
        // creating the object of SpeechSynthesizer class  
        SpeechSynthesizer sp = new SpeechSynthesizer();
        //setting volume   
        sp.Volume = 100;
        //ing text box text to SpeakAsync method   
        sp.SpeakAsync(txtMsg.Text);
    }
}