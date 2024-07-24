using NUnit.Framework;

namespace TDD_Examples.Tests
{
  [TestFixture]
  public class UserAccountTests
  {
    private UserAccount _userAccount;

    [SetUp]
    public void SetUp()
    {
      _userAccount = new UserAccount();
    }
  }
}
