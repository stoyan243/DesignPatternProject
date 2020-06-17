using DesignPatternProject.Numerate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.Helpers
{

    
    //The singleton template is used here
    public class SessionHelpers
    {
        //Properties
        public PersonRole Role { get; private set; }
        public bool IsBoss { get; private set; }
        public bool IsAuthenticated { get; private set; }

        private static SessionHelpers CurrentSession { get; set; }

        private SessionHelpers()
        {

        }

        //GetCurrentSession - makes the decision you made
        public static SessionHelpers GetCurrentSession()
        {
            if (CurrentSession == null)
            {
                CurrentSession = new SessionHelpers();
            }
            return CurrentSession;
        }

        //SetSession is applying  the session  u choose is  GetCurrentSession
        public void SetSession(PersonRole role)
        {
            Role = role;
            IsBoss = role == PersonRole.Boss;
            IsAuthenticated = true;
        }

        //If you choose LougoutMe.You back to choose....
        public void LogoutMe()
        {
            Role = PersonRole.Clients;
            IsBoss= false;
            IsAuthenticated = false;
        }
    }
}

