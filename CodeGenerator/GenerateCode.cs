using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;
using Antlr.StringTemplate;
using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;

namespace CodeGenerator
{
    public class GenerateCode : Task
    {
        [Required]
        public string Input
        {
            get;
            set;
        }

        [Required]
        public string Template
        {
            get;
            set;
        }

        [Required]
        [Output]
        public string Output
        {
            get;
            set;
        }

        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.High, "Generating {0} from {1}...", Output, Input);

            try
            {
                //Load the events XML document and parse it via LINQ
                XDocument inputXML = XDocument.Load(Input);

                int startID = (int?)inputXML.Element("StartId") ?? 1;

                var events = (from evnt in inputXML.Descendants("Event")
                              select new
                              {
                                  SdkName = (string)evnt.Element("Name"),
                                  Name = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(evnt.Element("Name").Value.ToLower()).Substring(3).Replace("_", ""),
                                  Comment = (string)evnt.Element("Comment") ?? string.Empty
                              }).ToArray();

                var callbacks = (from callback in inputXML.Descendants("Callback")
                                 select new
                                 {
                                     SdkName = (string)callback.Element("Name"),
                                     Name = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(callback.Element("Name").Value.ToLower()).Substring(3).Replace("_", ""),
                                     Comment = (string)callback.Element("Comment") ?? string.Empty
                                 }).ToArray();

                //Load the template and prepare it for generating the code output.
                StringTemplate strTemplate = new StringTemplate();
                strTemplate.Reset();
                strTemplate.Template = File.ReadAllText(Template);
                strTemplate.SetAttribute("events", events);
                strTemplate.SetAttribute("callbacks", callbacks);

                File.WriteAllText(Output, strTemplate.ToString());
            }
            catch (Exception ex)
            {
                Log.LogMessage(MessageImportance.High, "Code generation failed!");
                Log.LogErrorFromException(ex);
                return false;
            }

            return true;
        }
    }
}
