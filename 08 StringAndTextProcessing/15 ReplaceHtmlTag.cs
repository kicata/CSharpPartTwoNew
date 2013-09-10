using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
//Sample HTML fragment:
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//To
//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

    class ReplaceHtmlTag
    {
        static void Main()
        {
            string inputTag = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            string[] forReplace={"<a href=\"","\">","</a>"};
            string[] replaceWith = { "[URL=", "]", "[/URL]" };
            for (int i = 0; i < forReplace.Length; i++)
            {
                inputTag=inputTag.Replace(forReplace[i], replaceWith[i]);
            }
            Console.WriteLine(inputTag);
        }
    }

