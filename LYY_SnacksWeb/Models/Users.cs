//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LYY_SnacksWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Users
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="用户类型不为空。")]
        public string Usertype { get; set; }
        [Required(ErrorMessage ="用户名是必须的。")]
        [StringLength(10,MinimumLength =3)]
        public string UserName { get; set; }
        [StringLength(12,MinimumLength =6)]
        [Required(ErrorMessage ="用户密码必须包含6个字符。")]
        public string PassWord { get; set; }
        [Required(ErrorMessage ="请选择你的头像。")]
        public string Photo { get; set; }
        [Required(ErrorMessage ="请选择你的性别。")]
        public string Sex { get; set; }
        [Required(ErrorMessage ="请填写你的地址。")]
        [StringLength(20,MinimumLength =6)]
        public string Address { get; set; }
        public bool RememberMe { get; set; }
    }
}
