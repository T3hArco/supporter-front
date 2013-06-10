using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

/*
 * Copyright 2013 Arnaud Coel. All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification, are
 * permitted provided that the following conditions are met:
 * 
 *    1. Redistributions of source code must retain the above copyright notice, this list of
 *       conditions and the following disclaimer.
 * 
 *    2. Redistributions in binary form must reproduce the above copyright notice, this list
 *       of conditions and the following disclaimer in the documentation and/or other materials
 *       provided with the distribution.
 * 
 * THIS SOFTWARE IS PROVIDED BY ARNAUD COEL ''AS IS'' AND ANY EXPRESS OR IMPLIED
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
 * FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL ARNAUD COEL OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
 * ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
 * ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * The views and conclusions contained in the software and documentation are those of the
 * authors and should not be interpreted as representing official policies, either expressed
 * or implied, of ARNAUD COEL.
 */

namespace Utility
{
    class WebrequestHandler
    {
        private String url;
        private String parameters;
        private int type; // 0 = POST, 1 = GET

        public WebrequestHandler(String url, String parameters, int type)
        {
            this.url = url;
            this.parameters = parameters;
            this.type = type;
        }

        public String request()
        {
            String htmlResult;

                if (type == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        // I should probably switch to the method below, but I'm currently too lazy

                        wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                        htmlResult = wc.UploadString(url, parameters);
                    }
                }
                else if (type == 1)
                {
                    String constructed = url + parameters; // Construct out URL, will ya? Just concats the URL and the parameters required

                    CookieContainer cookies = new CookieContainer();
                    HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(constructed);
                    getRequest.CookieContainer = cookies;
                    getRequest.Method = "GET";
                    HttpWebResponse form = (HttpWebResponse)getRequest.GetResponse();

                    using (StreamReader response =
                    new StreamReader(form.GetResponseStream(), Encoding.UTF8))
                    {
                        htmlResult = response.ReadToEnd();
                    }
                }
                else
                {
                    htmlResult = "Incorrect type given!";
                }

            return htmlResult;
        }
    }
}
