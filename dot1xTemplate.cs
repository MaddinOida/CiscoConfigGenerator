using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.CodeDom;

namespace CiscoConfigGeneratorTest01
{
    internal class dot1xTemplate
    {
        FileStream TemplateStream;
        List<string> PortTemplateList;
        string type = string.Empty;

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

        public void loadTemplate(string type)
        {


            if (type == "%n%")
                TemplateStream = new FileStream(@".\.\PortTemplate.txt", FileMode.Open);
            else if (type == "%a%")
                TemplateStream = new FileStream(@".\.\PortTemplateAP.txt", FileMode.Open);
            else //fallback to normal
                TemplateStream = new FileStream(@".\.\PortTemplate.txt", FileMode.Open);


            PortTemplateList = new List<string>();


            //Template einlesen
            StreamReader readTemplate = new StreamReader(TemplateStream);

            while (readTemplate.Peek() != -1)
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

            ToModify = ToModify.Replace("$$$", PortRange[0].Substring(3));
            ToModify2 = ToModify2.Replace("$$$", PortRange[0].Substring(3));

            PortTemplateList[0] = ToModify;
            PortTemplateList[1] = ToModify2;


            foreach (string elem in PortTemplateList)
            {
                output = output + elem + Environment.NewLine;
            }


            return output;

        }

        public string insertPortRange(List<string> PortRange, string type)
        {
            //this.type = type;

            //this.type = this.type.Substring(0, 2);

            loadTemplate(type);

            string output = string.Empty;

            string ToModify = PortTemplateList[0];
            string ToModify2 = PortTemplateList[1];

            ToModify = ToModify.Replace("$$$", PortRange[0].Substring(3));
            ToModify2 = ToModify2.Replace("$$$", PortRange[0].Substring(3));

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
                string temptype = string.Empty;

                temptype = elem.Substring(0, 3);

                List<string> temp = new List<string>();
                temp.Add(elem);

                MultipleTemplates.Add(insertPortRange(temp, temptype));


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
