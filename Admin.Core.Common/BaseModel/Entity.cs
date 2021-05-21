﻿using Admin.Core.Common.Attributes;
using FreeSql.DataAnnotations;
using System.ComponentModel;

namespace Admin.Core.Common.BaseModel
{
    public interface IEntity<TKey>
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        TKey Id { get; set; }
    }

    public interface IEntity : IEntity<long>
    {
    }


    public class Entity<TKey> : IEntity<TKey>
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        [Description("主键Id")]
        [Snowflake]
        [Column(Position = 1, IsIdentity = false, IsPrimary = true)]
        public virtual TKey Id { get; set; }
    }

    public class Entity : Entity<long>
    {

    }
}
