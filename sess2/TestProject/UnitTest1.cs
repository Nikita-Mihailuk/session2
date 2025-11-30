namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Тесты для IsValidEmail
        [Test]
        public void TestIsValidEmail_ValidEmail_ReturnsTrue()
        {
            bool act = Testing.IsValidEmail("nikmmih.9898@gmail.com");
            bool exp = true;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidEmail_ValidEmailWithHyphen_ReturnsTrue()
        {
            bool act = Testing.IsValidEmail("test-user@example.com");
            bool exp = true;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidEmail_ValidEmailWithNumbers_ReturnsTrue()
        {
            bool act = Testing.IsValidEmail("user123@domain456.com");
            bool exp = true;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidEmail_EmailWithoutAtSymbol_ReturnsFalse()
        {
            bool act = Testing.IsValidEmail("invalidemail.com");
            bool exp = false;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidEmail_EmailWithoutDomain_ReturnsFalse()
        {
            bool act = Testing.IsValidEmail("user@");
            bool exp = false;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidEmail_EmailWithoutUsername_ReturnsFalse()
        {
            bool act = Testing.IsValidEmail("@domain.com");
            bool exp = false;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidEmail_EmailWithSpaces_ReturnsFalse()
        {
            bool act = Testing.IsValidEmail("user name@domain.com");
            bool exp = false;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidEmail_EmailWithMultipleDots_ReturnsTrue()
        {
            bool act = Testing.IsValidEmail("user.name@sub.domain.com");
            bool exp = true;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidEmail_EmptyString_ReturnsFalse()
        {
            bool act = Testing.IsValidEmail("");
            bool exp = false;
            Assert.AreEqual(exp, act);
        }

        // Тесты для IsValidPhone
        [Test]
        public void TestIsValidPhone_ValidPhoneWithDigitsOnly_ReturnsTrue()
        {
            bool act = Testing.IsValidPhone("1234567890");
            bool exp = true;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidPhone_ValidPhoneWithHyphens_ReturnsTrue()
        {
            bool act = Testing.IsValidPhone("123-456-7890");
            bool exp = true;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidPhone_ValidPhoneWithParentheses_ReturnsTrue()
        {
            bool act = Testing.IsValidPhone("(123)456-7890");
            bool exp = true;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidPhone_ValidPhoneWithSpaces_ReturnsTrue()
        {
            bool act = Testing.IsValidPhone("123 456 7890");
            bool exp = true;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidPhone_ValidPhoneWithPlus_ReturnsTrue()
        {
            bool act = Testing.IsValidPhone("+1234567890");
            bool exp = true;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidPhone_PhoneWithLetters_ReturnsFalse()
        {
            bool act = Testing.IsValidPhone("123-ABC-7890");
            bool exp = false;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidPhone_EmptyString_ReturnsFalse()
        {
            bool act = Testing.IsValidPhone("");
            bool exp = false;
            Assert.AreEqual(exp, act);
        }

        [Test]
        public void TestIsValidPhone_PhoneWithSpecialCharacters_ReturnsFalse()
        {
            bool act = Testing.IsValidPhone("123@456#7890");
            bool exp = false;
            Assert.AreEqual(exp, act);
        }
    }
}