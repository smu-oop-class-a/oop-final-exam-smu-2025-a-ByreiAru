using System.Data.Common;
using Microsoft.VisualBasic.ApplicationServices;
using OOP.FinalTerm.Exam.Model;
using OOP.FinalTerm.Exam.Utils;
using SQLite;


namespace OOP.FinalTerm.Exam.Repository
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly ISQLiteConnection _dbConnection;

        public DirectorRepository() {
            _dbConnection = new SQLiteConnection(DatabaseHelper.GetDatabasePath());
            _dbConnection.CreateTable<DirectorModel>();
        }

        public void AddDirector(DirectorModel director) {
            _dbConnection.Insert(director);
        }

        public List<DirectorModel> GetAllDirectors() {
            return _dbConnection.Table<DirectorModel>().ToList();
        }

        public DirectorModel GetDirectorById(int id) {
            //var user = _dbConnection.Find<DirectorModel>(id);
            //if (user == null) {
            //    return null;
            //}
            return _dbConnection.Find<DirectorModel>(id);
        }
    }
}