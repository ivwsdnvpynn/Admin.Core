﻿namespace ZhonTai.Admin.Services.Document.Dto
{
    public class DocumentUpdateGroupInput : DocumentAddGroupInput
    {
        /// <summary>
        /// 编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        public long Version { get; set; }
    }
}