using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IoTWebApi.Controllers
{
    public class IoTController : ApiController
    {
        Models.madukaIoTSqlDbEntities db = new Models.madukaIoTSqlDbEntities();

        /// <summary>
        /// 取得設定值
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public string Get([FromUri] string config)
        {
            return db.Config.Where(x => x.ConfigName == config).Select(c=>c.ConfigValue).FirstOrDefault();
        }

        /// <summary>
        /// 寫入從裝置過來的資料到資料庫之中
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Post(Models.RaspberrySensorData data)
        {
            bool blIsSuccess = true;

            try
            {
                string strSql = "Insert Into RaspberrySensorData Values (@DeviceId, @SendDateTime, @Temperature, @Humidity)";

                db.Database.ExecuteSqlCommand(strSql, new SqlParameter("@DeviceId", data.DeviceId),
                    new SqlParameter("@SendDateTime", DateTime.Now),
                    new SqlParameter("@Temperature", data.Temperature),
                    new SqlParameter("@Humidity", data.Humidity));

                db.SaveChanges();
            }
            catch (Exception e)
            {
                blIsSuccess = false;
            }

            return blIsSuccess;
        }
    }
}
