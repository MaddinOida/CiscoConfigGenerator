using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace CiscoConfigGeneratorTest01
{
    internal class dot1xTemplate
    {
        FileStream TemplateStream;
        List<string> PortTemplateList;

        public void loadTemplate()
        {
            TemplateStream = new FileStream(@".\.\PortTemplate.txt", FileMode.Open);

            PortTemplateList = new List<string>();


            //Template einlesen
            StreamReader readTemplate = new StreamReader(TemplateStream);

            while(readTemplate.Peek() != -1)
            {
                PortTemplateList.Add(readTemplate.ReadLine());
            }

            readTemplate.Close();

        }


        public string insertPortRange(List<string> PortRange)
        {
            loadTemplate();

            string output = string.Empty;

            string ToModify = PortTemplateList[0];
            string ToModify2 = PortTemplateList[1];

            ToModify = ToModify.Replace("$$$", PortRange[0]);
            ToModify2 = ToModify2.Replace("$$$", PortRange[0]);

            PortTemplateList[0] = ToModify;
            PortTemplateList[1] = ToModify2;


            foreach (string elem in PortTemplateList)
            {
                output = output + elem + Environment.NewLine;
            }


            return output;

        }


        public string insertMultiplePortRange(List<string> PortRange)
        {
            string output = string.Empty;
            List<string> MultipleTemplates = new List<string>();


            foreach(string elem in PortRange)
            {
                List<string> temp = new List<string>();
                temp.Add(elem);

                MultipleTemplates.Add(insertPortRange(temp));


                temp.Clear();
            }

            foreach (string elem in MultipleTemplates)
                output = output + elem;



            return output;
        }



        public string readList()
        {
            string output = string.Empty;

            foreach(string elem in PortTemplateList)
            {
                output = output + elem + Environment.NewLine;
            }



            return output;
        }



        public dot1xTemplate()
        {
            return;
        }


        public void closeStream()
        {
            TemplateStream.Close();


            return;
        }
    }
}
