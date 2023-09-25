using System;
using System.Collections.Generic;
using System.Text;

namespace TravellingViajes.Servicios
{
    public static class SessionManager
    {
        public static int UserId { get; private set; }

        public static void SetUserId(int userId)
        {
            UserId = userId;
        }

        public static void ClearUserId()
        {
            UserId = 0;
        }
    }
}
