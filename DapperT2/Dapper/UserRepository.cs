﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DapperT2.Dapper
{
    public class UserRepository : IUserRepository
    {
        private IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        public List<DapperKategori> GetAll()
        {
            return this._db.Query<DapperKategori>("SELECT * FROM DapperKategori").ToList();
        }

        public User Find(int id)
        {
            //return this._db.Query<User>("SELECT * FROM Users WHERE UserID = @UserID", new { id }).SingleOrDefault();
            return new User();
        }

        public User Add(User user)
        {
            //var sqlQuery = "INSERT INTO Users (FirstName, LastName, Email) VALUES(@FirstName, @LastName, @Email); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            //var userId = this._db.Query<int>(sqlQuery, user).Single();
            //user.UserID = userId;
            //return user; 
            return new User();
        }

        public User Update(User user)
        {
            return new User();
            //var sqlQuery =
            //    "UPDATE Users " +
            //    "SET FirstName = @FirstName, " +
            //    "    LastName  = @LastName, " +
            //    "    Email     = @Email " +
            //    "WHERE UserID = @UserID";
            //this._db.Execute(sqlQuery, user);
            //return user;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserInformatiom(int id)
        {
            //using (var multipleResults = this._db.QueryMultiple("GetUserByID", new { Id = id }, commandType: CommandType.StoredProcedure))
            //{
            //    var user = multipleResults.Read<User>().SingleOrDefault();

            //    var addresses = multipleResults.Read<Address>().ToList();
            //    if (user != null && addresses != null)
            //    {
            //        user.Address.AddRange(addresses);
            //    }

            //    return user;
            //}
            return new User();
        }
    }
}