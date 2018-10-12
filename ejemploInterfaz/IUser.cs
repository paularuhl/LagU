using System;

namespace Interfaces{
    public interface IUser{
        void SetName(string name);
        void SetLastName(string lastname);
        string GetFullName();

    }
}