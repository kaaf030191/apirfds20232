﻿using _0._0.DataTransferLayer.Objects;
using _4._0.RepositoryLayer.Repository;
using _5._0.DataAccessLayer.Connection;
using _5._0.DataAccessLayer.Entities;

namespace _5._0.DataAccessLayer.Query
{
    public class QUser : RepoUser
    {
        public int delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<DtoUser> getAll()
        {
            using DataBaseContext dbc = new();

            List<User> listUser = dbc.Users.ToList();

            List<DtoUser> listDtoUser = new List<DtoUser>();

            for(int i = 0; i < listUser.Count; i++)
            {
                DtoUser dtoUser = new();

                dtoUser.idUser = listUser[i].idUser;
                dtoUser.username = listUser[i].username;
                dtoUser.firstName = listUser[i].firstName;
                dtoUser.surName = listUser[i].surName;
                dtoUser.dni = listUser[i].dni;
                dtoUser.birthDate = listUser[i].birthDate;
                dtoUser.gender = listUser[i].gender;
                dtoUser.registerDate = listUser[i].registerDate;
                dtoUser.modificationDate = listUser[i].modificationDate;

                listDtoUser.Add(dtoUser);
            }

            return listDtoUser;
        }

        public DtoUser getByPk(string pk)
        {
            using DataBaseContext dbc = new();

            User user = dbc.Users.Find(pk);

            DtoUser dtoUser = null;

            if (user is not null)
            {
                dtoUser = new();

                dtoUser.idUser = user.idUser;
                dtoUser.username = user.username;
                dtoUser.firstName = user.firstName;
                dtoUser.surName = user.surName;
                dtoUser.dni = user.dni;
                dtoUser.birthDate = user.birthDate;
                dtoUser.gender = user.gender;
                dtoUser.registerDate = user.registerDate;
                dtoUser.modificationDate = user.modificationDate;
            }

            return dtoUser;
        }

        public int insert(DtoUser dto)
        {
            throw new NotImplementedException();
        }

        public int update(DtoUser dto)
        {
            throw new NotImplementedException();
        }
    }
}