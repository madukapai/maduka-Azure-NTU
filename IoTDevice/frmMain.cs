using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace IoTDevice
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 執行送出的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            RaspberrySensorData data = new RaspberrySensorData()
            {
                DeviceId = txtDeviceId.Text,
                Humidity = double.Parse(txtHumidity.Text),
                Temperature = double.Parse(txtTemperature.Text),
            };

            // 呼叫API作送出的動作
            HttpStatusCode code = HttpStatusCode.OK;
            string strUrl = "http://localhost:8298/api/IoT";
            string strResponse = CallAPI(strUrl, "POST", JsonConvert.SerializeObject(data), out code);

            if (code == HttpStatusCode.OK)
            {
                MessageBox.Show(strResponse);
            }
        }

        /// <summary>
        /// 呼叫API執行資料的新增
        /// </summary>
        /// <param name="strUrl"></param>
        /// <param name="strHttpMethod"></param>
        /// <param name="strPostContent"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        protected string CallAPI(string strUrl, string strHttpMethod, string strPostContent, out HttpStatusCode code)
        {
            HttpWebRequest request = HttpWebRequest.Create(strUrl) as HttpWebRequest;
            request.Method = strHttpMethod;
            code = HttpStatusCode.OK;

            if (strPostContent != "" && strPostContent != string.Empty)
            {
                request.KeepAlive = true;
                request.ContentType = "application/json";

                byte[] bs = Encoding.UTF8.GetBytes(strPostContent);
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(bs, 0, bs.Length);
            }

            string strReturn = "";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var respStream = response.GetResponseStream();
                strReturn = new StreamReader(respStream).ReadToEnd();
            }
            catch (Exception e)
            {
                strReturn = e.Message;
                code = HttpStatusCode.NotFound;
            }

            return strReturn;
        }

        private class RaspberrySensorData
        {
            public string DeviceId { get; set; }
            public double Temperature { get; set; }
            public double Humidity { get; set; }
        }
    }
}
