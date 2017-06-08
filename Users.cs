using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTapp.Models
{
   public class Users
    {

        private String UserID;
        private String UserName;
        private String UserHeight;
        private String UserWeight;
        private String UserBMI;
        private String RequiredNeutrition;

        public string UserID1
        {
            get
            {
                return UserID;
            }

            set
            {
                UserID = value;
            }
        }

        public string UserName1
        {
            get
            {
                return UserName;
            }

            set
            {
                UserName = value;
            }
        }

        public string UserHeight1
        {
            get
            {
                return UserHeight;
            }

            set
            {
                UserHeight = value;
            }
        }

        public string UserWeight1
        {
            get
            {
                return UserWeight;
            }

            set
            {
                UserWeight = value;
            }
        }

        public string UserBMI1
        {
            get
            {
                return UserBMI;
            }

            set
            {
                UserBMI = value;
            }
        }

        public string RequiredNeutrition1
        {
            get
            {
                return RequiredNeutrition;
            }

            set
            {
                RequiredNeutrition = value;
            }
        }
    }
}
