using SocialNetwork.WEB.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.WEB.ViewModels
{
    public class UserViewModel : IEditableModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ActionType ActionType { get; set; }

    }
}
