using System;
using System.Collections.Generic;

namespace TDD_Examples
{

  public class UserAccount
  {
    private Dictionary<string, string> userDatabase = new Dictionary<string, string>();
    private string loggedInUser;

    /// <summary>
    /// Registers a new user with the specified username and password.
    /// </summary>
    /// <param name="username">The desired username for the new user.</param>
    /// <param name="password">The desired password for the new user.</param>
    /// <returns>
    /// <c>true</c> if the registration is successful (i.e., the username does not already exist); otherwise, <c>false</c>.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when either the username or password is null, empty, or consists only of whitespace.
    /// </exception>

    public bool Register(string username, string password)
    {
      // TODO
      return false;
    }

    /// <summary>
    /// Authenticates a user with the specified username and password.
    /// </summary>
    /// <param name="username">The username of the user trying to log in.</param>
    /// <param name="password">The password of the user trying to log in.</param>
    /// <returns>
    /// <c>true</c> if the login is successful (i.e., the username exists and the password matches); otherwise, <c>false</c>.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when either the username or password is null, empty, or consists only of whitespace.
    /// </exception>

    public bool Login(string username, string password)
    {
      // TODO
      return false; // Invalid username or password
    }

    /// <summary>
    /// Logs out the currently logged-in user by clearing the logged-in user information.
    /// </summary>
    public void Logout()
    {
      loggedInUser = null;
    }

    /// <summary>
    /// Retrieves the username of the currently logged-in user.
    /// </summary>
    /// <returns>
    /// The username of the currently logged-in user, or <c>null</c> if no user is logged in.
    /// </returns>
    public string GetLoggedInUser()
    {
      return loggedInUser;
    }
  }
}
