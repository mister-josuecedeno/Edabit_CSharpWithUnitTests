using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.ComponentModel.DataAnnotations;

namespace Edabit.Tests
{
    public class Medium_Test
    {
        [Theory]
        [InlineData("#CD5C5C", true)]
        [InlineData("#EAECEE", true)]
        [InlineData("#eaecee", true)]
        [InlineData("#CD5C58C", false)]
        [InlineData("#CD5C5Z", false, "Alphabetic characters not in A-F.")]
        [InlineData("#CD5C&C", false, "Unacceptable character.")]
        [InlineData("CD5C5C", false, "Does not start with #.")]
        [InlineData("#123CCCD", false, "Length exceeds 6.")]
        [InlineData("#123456", true)]
        [InlineData("#987654", true)]
        [InlineData("#9876543", false, "Length exceeds 6.")]
        [InlineData("#CCCCCC", true)]
        [InlineData("#ZCCZCC", false, "Not acceptable alphabetic characters.")]
        [InlineData("#Z88Z99", false, "Not acceptable alphabetic characters.")]
        [InlineData("#Z88!99", false, "Unacceptable character.")]
        public void  IsValidHexCode(string str, bool expected, string description = "")
        {
            // Arrange
            // Actual
            var actual = Medium.IsValidHexCode(str);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 31, 33, 1)]
        [InlineData(4, 250, 1300, 3)]
        [InlineData(2, 49, 65, 2)]
        [InlineData(3, 1, 27, 3)]
        [InlineData(10, 1, 5, 1)]
        [InlineData(1, 1, 5, 5)]
        [InlineData(2, 1, 100, 10)]
        public void PowerRanger(int power, int min, int max, int expected)
        {
            // Arrange
            // Actual
            var actual = Medium.PowerRanger(power, min, max);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, 0, 25, new double[] { 0, 25d })]
        [InlineData(1, 10, 25, new double[] { -5d, 0d })]
        [InlineData(8, 4, 0, new double[] { -0.25d, -0.5d })]
        [InlineData(4, -200, 1000, new double[] { 25d, -1500d })]
        [InlineData(1, -50, -1000, new double[] { 25d, -1625d })]
        [InlineData(-1, 20, 600, new double[] { 10d, 700d })]
        [InlineData(5, 1, 20, new double[] { -0.1d, 19.95d })]
        public void FindVertex(int a, int b, int c, double[] expected)
        {
            // Arrange
            // Actual
            var actual = Medium.FindVertex(a, b, c);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Marta appreciated deep perpendicular right trapezoids", true)]
        [InlineData("Someone is outside the doorway", false)]
        [InlineData("She eats super righteously", true)]
        [InlineData("Ben naps so often", true)]
        [InlineData("Cute triangles are cute", false)]
        public void IsSmooth(string sentence, bool expected)
        {
            // Arrange
            // Actual
            var actual = Medium.IsSmooth(sentence);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Wh*r* d*d my v*w*ls g*?", "eeioeo", "Where did my vowels go?")]
        [InlineData("abcd", "", "abcd")]
        [InlineData("*PP*RC*S*", "UEAE", "UPPERCASE")]
        [InlineData("Ch**s*, Gr*mm*t -- ch**s*", "eeeoieee", "Cheese, Grommit -- cheese")]
        [InlineData("*l*ph*nt", "Eea", "Elephant")]
        public void Uncensor(string txt, string vowels, string expected)
        {
            // Arrange
            // Actual
            var actual = Medium.Uncensor(txt, vowels);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Cat, dog, and mouse.", ".at, dog, and mouseC")]
        [InlineData("Anna, Banana", "anna, BananA")]
        [InlineData("[]", "][")]
        [InlineData("", "Incompatible.")]
        [InlineData(new int[] { 1, 2, 3 }, "Incompatible.")]
        [InlineData("dfdkf49824fdfdfjhd", "Two's a pair.")]
        [InlineData("#343473847#", "Two's a pair.")]
        public void FlipEndChars(object str, string expected)
        {
            // Arrange
            // Actual
            var actual = Medium.FlipEndChars(str);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2, 6, 7, 9, 3 }, "Boom!")]
        [InlineData(new int[] { 33, 68, 400, 5 }, "there is no 7 in the array")]
        [InlineData(new int[] { 86, 48, 100, 66 }, "there is no 7 in the array")]
        [InlineData(new int[] { 76, 55, 44, 32 }, "Boom!")]
        [InlineData(new int[] { 35, 4, 9, 37 }, "Boom!")]
        public void SevenBoom(int[] arr, string expected)
        {
            // Arrange
            // Actual
            var actual = Medium.SevenBoom(arr);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new string[] { "OOOOO---OOOOO", "---OOOOOOOOOO", "O---OOOOOOOOO", "O---OOOOOOOOO", "---OOOOOOOOOO", "OOOOOOOO---OO", "OO---OOOOOOOO" }, 5011082)]
        [InlineData(new string[] { "OOOOOO---OOOO", "OOOOOO---OOOO", "OOOO---OOOOOO", "OOOOOOO---OOO", "O---OOOOOOOOO", "OOOOOOO---OOO", "OOOOOOO---OOO" }, 6647177)]
        [InlineData(new string[] { "---OOOOOOOOOO", "---OOOOOOOOOO", "---OOOOOOOOOO", "OO---OOOOOOOO", "O---OOOOOOOOO", "---OOOOOOOOOO", "OOOOOOOOO---O" }, 2109)]
        [InlineData(new string[] { "O---OOOOOOOOO", "OOO---OOOOOOO", "OOOOOOO---OOO", "---OOOOOOOOOO", "OOOOOOOO---OO", "OO---OOOOOOOO", "OOOOOOO---OOO" }, 1370827)]
        [InlineData(new string[] { "---OOOOOOOOOO", "OOOOOOOOO---O", "OOO---OOOOOOO", "---OOOOOOOOOO", "OO---OOOOOOOO", "OOOOOO---OOOO", "OOOOO---OOOOO" }, 930265)]
        [InlineData(new string[] { "---OOOOOOOOOO", "OOOOOO---OOOO", "OOOOOOO---OOO", "OOOOOOO---OOO", "---OOOOOOOOOO", "---OOOOOOOOOO", "OOOOOOOO---OO" }, 677008)]
        public void Schoty(string[] frame, int expected)
        {
            // Arrange
            // Actual
            var actual = Medium.Schoty(frame);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("alternating caps", "AlTeRnAtInG cApS")]
        [InlineData("What is your name?", "WhAt Is YoUr NaMe?")]
        [InlineData("Lorem ipsum dolor sit amet consectetur adipisicing elit.", "LoReM iPsUm DoLoR sIt AmEt CoNsEcTeTuR aDiPiSiCiNg ElIt.")]
        [InlineData("OMG this website is awesome!", "OmG tHiS wEbSiTe Is AwEsOmE!")]
        [InlineData("The quick brown fox jumps over the lazy dog", "ThE qUiCk BrOwN fOx JuMpS oVeR tHe LaZy DoG")]
        [InlineData("The intent is to provide players with a sense of pride and accomplishment for unlocking different heroes.", "ThE iNtEnT iS tO pRoViDe PlAyErS wItH a SeNsE oF pRiDe AnD aCcOmPlIsHmEnT fOr UnLoCkInG dIfFeReNt HeRoEs.")]

        public void ReturnAlternatingCaps(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.AlternatingCaps(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }, 3, "yes")]
        [InlineData(new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }, 4, "no")]
        [InlineData(new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }, 67, "yes")]
        [InlineData(new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }, 36, "no")]
        public void  IsPrime(int[] primes, int num, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.IsPrime(primes, num);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new string[] { "mavis", "senaida", "letty" }, new string[] { "Mavis", "Senaida", "Letty" })]
        [InlineData(new string[] { "samuel", "MABELLE", "letitia", "meridith" }, new string[] { "Samuel", "Mabelle", "Letitia", "Meridith" })]
        [InlineData(new string[] { "Slyvia", "Kristal", "Sharilyn", "Calista" }, new string[] { "Slyvia", "Kristal", "Sharilyn", "Calista" })]
        [InlineData(new string[] { "krisTopher", "olIva", "herminiA" }, new string[] { "Kristopher", "Oliva", "Herminia" })]
        [InlineData(new string[] { "luke", "marsha", "stanford" }, new string[] { "Luke", "Marsha", "Stanford" })]
        [InlineData(new string[] { "kara" }, new string[] { "Kara" })]
        [InlineData(new string[] { "mARIANN", "jOI", "gEORGEANN" }, new string[] { "Mariann", "Joi", "Georgeann" })]
        public void CapMe(string[] arr, string[] expected)
        {
            // Arrange

            // Actual
            var actual = Medium.CapMe(arr);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 17)]
        [InlineData(new int[] { 2, 3, 4, 11, 20, 50, 71 }, 87)]
        [InlineData(new int[] { 19, 21, 24, 27, 30, 37 }, 56)]
        [InlineData(new int[] { 69, 79, 87, 97, 101 }, 277)]
        [InlineData(new int[] { 53, 59, 28, 50, 45, 33, 61 }, 173)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 11, 11, 11, 11, 11, 22, 22, 22 }, 55)]
        [InlineData(new int[] { 67, 24, 58, 28, 71, 73, 99 }, 211)]
        public void ReturnSumPrimes(int[] arr, int expected)
        {
            // Arrange

            // Actual
            var actual = Medium.SumPrimes(arr);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("123-647-EYES", "123-647-3937")]
        [InlineData("(325)444-TEST", "(325)444-8378")]
        [InlineData("653-TRY-THIS", "653-879-8447")]
        [InlineData("435-224-7613", "435-224-7613")]
        [InlineData("(33D)ONT-FAIL", "(333)668-3245")]
        [InlineData("(025)445-6741", "(025)445-6741")]
        public void ReturnTextToNum(string phone, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.TextToNum(phone);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(1)]
        [InlineData(0)]
        public void TestSquarePatch(int n)
        {
            int[,] patch = Medium.SquarePatch(n);

            // For n == 0, expect an empty array.
            if (n == 0)
            {
                Assert.Equal(0, patch.GetLength(0));
                Assert.Equal(0, patch.GetLength(1));
            }
            else
            {
                // Check that the dimensions are n x n.
                Assert.Equal(n, patch.GetLength(0));
                Assert.Equal(n, patch.GetLength(1));

                // Check that every element equals n.
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Assert.Equal(n, patch[i, j]);
                    }
                }
            }
        }

        [Theory]
        [InlineData(6, true)]
        [InlineData(16, false)]
        [InlineData(24, true)]
        [InlineData(36, false)]
        [InlineData(120, true)]
        [InlineData(721, false)]
        public void ReturnIsFactorial(int n, bool expected)
        {
            // Arrange

            // Actual
            var actual = Medium.isFactorial(n);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Sausage fests are like salami fests", "Wurst fests are like Wurst fests")]
        [InlineData("Add the kielbasa and the reserved potatoes and stir through", "Add the Wurst and the reserved potatoes and stir through")]
        [InlineData("Salami sandwiches, salami and cheese, salami on crackers— I couldn't get enough of the salty, spicy sausage", "Wurst sandwiches, Wurst and cheese, Wurst on crackers— I couldn't get enough of the salty, spicy Wurst")]
        [InlineData("sich die Wurst vom Brot nehmen lassen", "sich die Wurst vom Brot nehmen lassen")]
        public void ReturnWurstIsBetter(string str, string expected)
        {
            // Arrange

            // Actual 
            var actual = Medium.WurstIsBetter(str);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 0, 0, -3, -2 }, 10)]
        [InlineData(new int[] { -4, -8, -12, -3, 4, 7, 1, 3, 0, 0, 0, 0 }, -27)]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 1, 2, -3 }, 5)]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 11)]
        [InlineData(new int[] { 0 }, 1)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { -1 }, -1)]
        [InlineData(new int[] { 10, -12, 4, 0, -3, -7, -91, 45 }, -113)]
        [InlineData(new int[] { 0, 1, 0, 1, 0, 1, 0, 1, 0 }, 5)]
        public void ReturnMajorSum(int[] arr, int expected)
        {
            // Arrange

            // Actual
            var actual = Medium.MajorSum(arr);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("house", "fly", 11)]
        [InlineData("sharp", "sharq", 1)]
        [InlineData("abcde", "bcdef", 5)]
        [InlineData("abcde", "a", 4)]
        [InlineData("abcde", "e", 8)]
        [InlineData("abcde", "Abcde", 32)]
        [InlineData("abcde", "A", 36)]
        [InlineData("very", "fragile", 67)]
        public void ReturnLetterDistance(string str1, string str2, int expected)
        {
            // Arrange

            // Actual
            var actual = Medium.LetterDistance(str1, str2);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(43, "Oddish")]
        [InlineData(373, "Oddish")]
        [InlineData(55551, "Oddish")]
        [InlineData(694, "Oddish")]
        [InlineData(4433, "Evenish")]
        [InlineData(11, "Evenish")]
        [InlineData(211112, "Evenish")]
        public void ReturnOddishOrEvenish(int num, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.OddishOrEvenish(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 90)]
        [InlineData(2, 240)]
        [InlineData(3, 450)]
        [InlineData(4, 720)]
        [InlineData(5, 1050)]
        public void GuessSequence(int num, int expected)
        {
            // Arrange

            // Actual
            var actual = Medium.GuessSequence(num);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1+1", 2)]
        [InlineData("7*4-2", 26)]
        [InlineData("1+1+1+1+1", 5)]
        public void  Equation(string s, int expected)
        {
            // Arrange

            // Actual
            var actual = Medium.Equation(s);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Reverse", "esreveR")]
        [InlineData("This is a typical sentence.", "This is a lacipyt .ecnetnes")]
        [InlineData("The dog is big.", "The dog is big.")]
        [InlineData("Reverse the order of every word greater than or equal to five characters.", "esreveR the redro of yreve word retaerg than or lauqe to five .sretcarahc")]
        [InlineData("Lets all be unique together until we realise we are all the same.", "Lets all be euqinu rehtegot litnu we esilaer we are all the .emas")]
        public void ReturnReverse(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.Reverse(str);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!", true)]
        [InlineData("Neuquen", true)]
        [InlineData("Not a palindrome", false)]
        public void IsPalindrome(string str, bool expected)
        {
            // Arrange

            // Actual
            var actual = Medium.IsPalindrome(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 10, 10 }, 23)]
        [InlineData(new int[] { 3, 3 }, 7)]
        [InlineData(new int[] { -10, -9 }, 22)]
        [InlineData(new int[] { -1, -4 }, 5)]
        [InlineData(new int[] { -10, -2 }, 14)]
        [InlineData(new int[] { 3, 30 }, 39)]
        [InlineData(new int[] { 40, 1 }, 49)]
        [InlineData(new int[] { 3, 5 }, 9)]
        public void  NumberOfDays(int[] coordinates, int expected)
        {
            // Arrange

            // Actual
            var actual = Medium.NumberOfDays(coordinates);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abcd", "A-Bb-Ccc-Dddd")]
        [InlineData("RqaEzty", "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy")]
        [InlineData("cwAt", "C-Ww-Aaa-Tttt")]
        [InlineData("VgyCdnQa", "V-Gg-Yyy-Cccc-Ddddd-Nnnnnn-Qqqqqqq-Aaaaaaaa")]
        [InlineData("nRBSdNOsMl", "N-Rr-Bbb-Ssss-Ddddd-Nnnnnn-Ooooooo-Ssssssss-Mmmmmmmmm-Llllllllll")]
        public void ReturnAccum(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.Accum(str);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("potato", 1)]
        [InlineData("potatopotatocherry", 2)]
        [InlineData("potatopotatopotatoorange", 3)]
        [InlineData("potatopotatobananapotatopotato", 4)]
        [InlineData("potatopotatomangopotatopotatopotato", 5)]
        [InlineData("potatocucumberpotatopotatopotatopotatopotato", 6)]
        public void Potatoes(string potato, int expected)
        {
            // Arrange

            // Actual 
            var actual = Medium.Potatoes(potato);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("karaca", "0c0r0kaca")]
        [InlineData("burak", "k0r3baca")]
        [InlineData("alpaca", "0c0pl0aca")]
        [InlineData("banana", "0n0n0baca")]
        [InlineData("hello", "2ll1haca")]
        public void ReturnEncrypt(string word, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.Encrypt(word);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
    	[InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 })]
        [InlineData(new int[] { 5, 3, 2, 1, 4 }, new int[] { 5, 3, 2, 4 })]
        [InlineData(new int[] { 2, 2, 1, 2, 1 }, new int[] { 2, 2, 2, 1 })]
        [InlineData(new int[] { 3, 1, 6, 7, 3, 7, 6 }, new int[] { 3, 6, 7, 3, 7, 6 })]
        [InlineData(new int[] { 4, 4, 4, 1 }, new int[] { 4, 4, 4 })]
        [InlineData(new int[] { 5, 4, 5, 3, 1, 1 }, new int[] { 5, 4, 5, 3, 1 })]
        [InlineData(new int[] { 1, 5, 3 }, new int[] { 5, 3 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 6, 2, 5, 4, 8, 6, 3, 2, 7 }, new int[] { 6, 5, 4, 8, 6, 3, 2, 7 })]
        [InlineData(new int[] { 3 }, new int[] { })]
        public void ReturnRemoveSmallest(int[] values, int[] expected)
        {
        // Arrange

        // Actual
        var actual = Medium.RemoveSmallest(values);
        
        // Assert
        Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("I am a title", "I Am A Title")]
        [InlineData("I AM A TITLE", "I AM A TITLE")]
        [InlineData("i aM a tITLE", "I AM A TITLE")]
        [InlineData("the first letter of every word is capitalized", "The First Letter Of Every Word Is Capitalized")]
        public void ReturnMakeTitle(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.MakeTitle(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("@edabit.com", false)]
        [InlineData("@edabit", false)]
        [InlineData("matt@edabit.com", true)]
        [InlineData("", false)]
        [InlineData("hello.gmail@com", false)]
        [InlineData("bill.gates@microsoft.com", true)]
        public void ReturnValidateEmail(string str, bool expected)
        {
            // Arrange

            // Actual
            var actual = Medium.ValidateEmail(str);

            // Actual
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("What went wrong?????????", "What went wrong?")]
        [InlineData("Oh my goodness!!!", "Oh my goodness!")]
        [InlineData("WHAT!", "WHAT!")]
        [InlineData("WHAT?", "WHAT?")]
        [InlineData("Oh my goodness!", "Oh my goodness!")]
        [InlineData("I just cannot believe it.", "I just cannot believe it.")]
        [InlineData("I just!!! can!!! not!!! believe!!! it!!!", "I just!!! can!!! not!!! believe!!! it!")]
        [InlineData("That's a ton!! of cheese!!!!", "That's a ton!! of cheese!")]
        public void NoYelling(string phrase, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.NoYelling(phrase);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(152, 10)]
        [InlineData(832, 48)]
        [InlineData(5511, 25)]
        [InlineData(19, 9)]
        [InlineData(133, 9)]
        public void ReturnMysteryFunc(int num, int expected)
        {
            // Arrange

            // Actual
            var actual = Medium.MysteryFunc(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4", 2, true)]
        [InlineData("387420489", 9, true)]
        [InlineData("302875106592253", 13, true)]
        [InlineData("341427877364219557396646723584", 22, true)]
        [InlineData("1330877630632711998713399240963346255985889330161650994325137953641", 41, true)]
        public void ReturnKToK(string n, int k, bool expected)
        {
            // Arrange

            // Actual
            var actual = Medium.KToK(n, k);
            
            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
