using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.WEB.ViewModels.Shared
{
    public enum ActionType
    {
        MyProfile,
        NotMyProfile
    }
    interface IEditableModel
    {
        public ActionType ActionType { get; set; }
    }
}
