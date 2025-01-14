﻿using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EvernoteClone.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [SQLite.MaxLength(50)]
        public string Name { get; set; }
        [SQLite.MaxLength(50)]
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
