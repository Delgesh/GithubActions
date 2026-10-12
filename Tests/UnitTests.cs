namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_AlHayder()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_AlHayder()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_AlHayder()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}

[TestClass]
public class Subtraction
{
	[TestMethod]
	public void Subtract_Valid_AlHayder()
	{
		Assert.AreEqual(1, Program.Subtract("3", "2"));
		Assert.AreEqual(-5, Program.Subtract("3", "8"));
		Assert.AreEqual(0, Program.Subtract("7", "7"));
	}

	[TestMethod]
	public void Subtract_Invalid_AlHayder()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
	}

	[TestMethod]
	public void Subtract_Null_AlHayder()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
	}
}

[TestClass]
public class Multiplication
{
	[TestMethod]
	public void Multiply_Valid_AlHayder()
	{
		Assert.AreEqual(6, Program.Multiply("2", "3"));
		Assert.AreEqual(0, Program.Multiply("9", "0"));
		Assert.AreEqual(-20, Program.Multiply("4", "-5"));
	}

	[TestMethod]
	public void Multiply_Invalid_AlHayder()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
	}

	[TestMethod]
	public void Multiply_Null_AlHayder()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
	}
}

[TestClass]
public class Division
{
	[TestMethod]
	public void Divide_Valid_AlHayder()
	{
		Assert.AreEqual(2.5, Program.Divide("5", "2"));
		Assert.AreEqual(4, Program.Divide("12", "3"));
		Assert.AreEqual(-3, Program.Divide("9", "-3"));
	}

	[TestMethod]
	public void Divide_ByZero_AlHayder()
	{
		Assert.AreEqual(double.PositiveInfinity, Program.Divide("1", "0"));
		Assert.AreEqual(double.NegativeInfinity, Program.Divide("-1", "0"));
	}

	[TestMethod]
	public void Divide_Invalid_AlHayder()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
	}

	[TestMethod]
	public void Divide_Null_AlHayder()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
	}
}

[TestClass]
public class Exponentiation
{
	[TestMethod]
	public void Power_Valid_AlHayder()
	{
		Assert.AreEqual(8, Program.Power("2", "3"));
		Assert.AreEqual(1, Program.Power("7", "0"));
		Assert.AreEqual(0.25, Program.Power("2", "-2"));
	}

	[TestMethod]
	public void Power_Invalid_AlHayder()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
	}

	[TestMethod]
	public void Power_Null_AlHayder()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
	}
}
