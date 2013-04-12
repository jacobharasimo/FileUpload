<%@ WebHandler Language="C#" Class="SampleUploadHandler" %>

using System;
using System.Web;
using System.IO; 
using Telerik.Windows;

public class SampleUploadHandler : RadUploadHandler
{
    public override void ProcessStream()
    {
        base.ProcessStream();
        if (this.IsFinalFileRequest())
        {
            // your custom logic for insert in DB/rename/etc.. goes here  
        }
    }  

}