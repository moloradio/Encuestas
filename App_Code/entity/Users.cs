using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Users
/// </summary>
public class Users
{

    private int idUsers;
    private String user;
    private String password;
    private DateTime hinicio;
    private DateTime hfin;

	public Users()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int IdUsers
    {
        get { return idUsers; }
        set { idUsers = value; }
    }
    public String User
    {
        get { return user; }
        set { user = value; }
    }
    public String Password
    {
        get { return password; }
        set { password = value; }
    }
    public DateTime Hinicio
    {
        get { return hinicio; }
        set { hinicio = value; }
    }
    public DateTime Hfin
    {
        get { return hfin; }
        set { hfin = value; }
    }

}