using NUnit.Framework.Legacy;
using BankAccountForTest;

namespace NUnitDemo.Tests;

[TestFixture]
public class BankAccountTests
{
    private BankAccount _account;

    [SetUp]
    public void Setup()
    {
        _account = new BankAccount(1000);
    }

    // Constructor Exception
    [Test]
    public void Constructor_NegativeBalance_ThrowsException()
    {
        ClassicAssert.Throws<ArgumentOutOfRangeException>(() =>
        {
            new BankAccount(-500);
        });
    }

    // Deposit Exceptions
    [Test]
    public void Deposit_ZeroAmount_ThrowsException()
    {
        ClassicAssert.Throws<ArgumentException>(() =>
        {
            _account.Deposit(0);
        });
    }

    [Test]
    public void Deposit_NegativeAmount_ThrowsException()
    {
        ClassicAssert.Throws<ArgumentException>(() =>
        {
            _account.Deposit(-100);
        });
    }

    //  Withdraw Exceptions
    [Test]
    public void Withdraw_ZeroAmount_ThrowsException()
    {
        ClassicAssert.Throws<ArgumentException>(() =>
        {
            _account.Withdraw(0);
        });
    }

    [Test]
    public void Withdraw_AmountGreaterThanBalance_ThrowsException()
    {
        ClassicAssert.Throws<InvalidOperationException>(() =>
        {
            _account.Withdraw(2000);
        });
    }

    //  Happy Path (No Exception)
    [Test]
    public void Withdraw_ValidAmount_UpdatesBalance()
    {
        _account.Withdraw(200);

        ClassicAssert.That(_account.Balance, Is.EqualTo(800));
    }
}