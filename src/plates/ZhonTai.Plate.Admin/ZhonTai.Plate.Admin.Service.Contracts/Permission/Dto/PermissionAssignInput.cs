using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZhonTai.Plate.Admin.Service.Permission.Dto
{
    public class PermissionAssignInput
    {
        [Required(ErrorMessage = "��ɫ����Ϊ�գ�")]
        public long RoleId { get; set; }

        [Required(ErrorMessage = "Ȩ�޲���Ϊ�գ�")]
        public List<long> PermissionIds { get; set; }
    }
}