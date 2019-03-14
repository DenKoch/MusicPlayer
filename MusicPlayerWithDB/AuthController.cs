using System.Configuration;
using System.Data;

namespace MusicPlayerWithDB
{
    class AuthController
    {
        private string connString = ConfigurationManager.ConnectionStrings["MusicPlayerDatabaseConnectionString"].ConnectionString;
        private DataSetMainTableAdapters.UsersTableAdapter userTA;
        private DataSetMainTableAdapters.PlaylistsTableAdapter playlistTA;

        private DataSetMainTableAdapters.TableAdapterManager TableAdapter;
        private DataSetMain ds;

        public AuthController()
        {
            ds = new DataSetMain();
            userTA = new DataSetMainTableAdapters.UsersTableAdapter();
            playlistTA = new DataSetMainTableAdapters.PlaylistsTableAdapter();
            TableAdapter = new DataSetMainTableAdapters.TableAdapterManager();
        }

        //Confirm Login
        public int ConfirmLogin(string username, string password)
        {
            if (userTA.GetDataByUsernamePassword(username, password) == null)
                return -1;

            int user_id = userTA.GetDataByUsernamePassword(username, password).Rows[0].Field<int>(0);
            return user_id;
        }

        //Confirm Registration
        public int ConfirmSignup(string username, string password)
        {
            if (userTA.GetDataByUsername(username).Rows.Count != 0)
                return -1;

            userTA.Insert(username, password);
            int user_id = userTA.GetDataByUsername(username).Rows[0].Field<int>(0);
            playlistTA.Insert("fav_songs", user_id);

            TableAdapter.UpdateAll(ds);
            return user_id;
        }
    }
}
