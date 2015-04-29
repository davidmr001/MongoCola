﻿using Common;
using MongoUtility.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MongoCola.Config
{
    [Serializable]
    public class MongoConfig
    {
        /// <summary>
        ///     配置文件名称
        /// </summary>
        public static string MongoConfigFilename = "MongoConfig.xml";
        /// <summary>
        ///     AppPath
        /// </summary>
        public static string AppPath = string.Empty;

        /// <summary>
        ///     连接配置列表(管理用）
        /// </summary>
        [XmlIgnore]
        public Dictionary<string, MongoConnectionConfig> ConnectionList =
            new Dictionary<string, MongoConnectionConfig>();
        /// <summary>
        ///     连接配置列表(保存用）
        /// </summary>
        public List<MongoConnectionConfig> SerializableConnectionList = new List<MongoConnectionConfig>();
        /// <summary>
        ///     ReadPreference
        /// </summary>
        public string ReadPreference;
        /// <summary>
        ///     WriteConcern
        /// </summary>
        public string WriteConcern;
        /// <summary>
        ///     WaitQueueSize;
        /// </summary>
        /// <remarks></remarks>
        public int WaitQueueSize;
        /// <summary>
        ///     wtimeoutMS
        /// </summary>
        /// <remarks>The driver adds { wtimeout : ms } to the getlasterror command. Implies safe=true.</remarks>
        public double WtimeoutMs;
        /// <summary>
        ///     添加链接
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public static void AddConnection(MongoConnectionConfig con)
        {
            SystemManager.MongoConfig.ConnectionList.Add(con.ConnectionName, con);
        }
        /// <summary>
        ///     写入配置
        /// </summary>
        /// <param name="configFileName"></param>
        public void SaveMongoConfig()
        {
            SystemManager.MongoConfig.SerializableConnectionList.Clear();
            foreach (var item in SystemManager.MongoConfig.ConnectionList.Values)
            {
                SystemManager.MongoConfig.SerializableConnectionList.Add(item);
            }
            Utility.SaveObjAsXml(AppPath + MongoConfigFilename,this);
        }
        /// <summary>
        ///     
        /// </summary>
        public static void LoadFromConfigFile()
        {
            SystemManager.MongoConfig = Utility.LoadObjFromXml<MongoConfig>(AppPath + MongoConfigFilename);
            SystemManager.MongoConfig.ConnectionList.Clear();
            foreach (var item in SystemManager.MongoConfig.SerializableConnectionList)
            {
                SystemManager.MongoConfig.ConnectionList.Add(item.ConnectionName, item);
            }
        }
    }
}
