using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aim_reflex_training_project
{
    internal class sqlConnect
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-T54ECK5;Initial Catalog=AimReflexTraining;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
      
    }
}
