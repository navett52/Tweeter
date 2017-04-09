using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    List<string> tweets = new List<string>();
    // creating the object of SpeechSynthesizer class  
    SpeechSynthesizer sp = new SpeechSynthesizer();

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnVoice_Click(object sender, EventArgs e)
    {
        //tweets = //Justin's code here;
        //foreach (string tweet in tweets)
        //{
            //tweet to SpeakAsync method
            //setting volume   
            sp.Volume = 100;
            sp.SpeakAsync(txtHashTag.Text);
        //}

    }
}