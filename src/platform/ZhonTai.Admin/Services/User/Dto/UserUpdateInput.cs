﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ZhonTai.Admin.Domain.Org;
using ZhonTai.Admin.Domain.Role;
using ZhonTai.Admin.Domain.User;

namespace ZhonTai.Admin.Services.User.Dto;

/// <summary>
/// 修改
/// </summary>
public partial class UserUpdateInput
{
    /// <summary>
    /// 主键Id
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 账号
    /// </summary>
    [Required(ErrorMessage = "请输入账号")]
    public string UserName { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    [Required(ErrorMessage = "请输入姓名")]
    public string Name { get; set; }

    /// <summary>
    /// 手机号
    /// </summary>
    public string Mobile { get; set; }

    /// <summary>
    /// 邮箱
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// 角色
    /// </summary>
    public long[] RoleIds { get; set; }

    /// <summary>
    /// 角色
    /// </summary>
    public ICollection<RoleEntity> Roles { get; set; }

    /// <summary>
    /// 所属部门
    /// </summary>
    public long[] OrgIds { get; set; }

    public ICollection<OrgEntity> Orgs { get; set; }

    /// <summary>
    /// 主属部门Id
    /// </summary>
    public long MainOrgId { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public UserStatus Status { get; set; }

    /// <summary>
    /// 员工信息
    /// </summary>
    public StaffUpdateInput Staff { get; set; }

    /// <summary>
    /// 版本
    /// </summary>
    public long Version { get; set; }
}