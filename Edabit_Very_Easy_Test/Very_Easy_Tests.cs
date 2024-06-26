﻿using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.ComponentModel.DataAnnotations;

namespace Edabit.Tests
{
    public class Very_Easy_Tests
    {
        [Theory]
        [InlineData(
            "If Obama resigns from office NOW, thereby doing a great service to the country—I will give him free lifetime golf at any one of my courses!",
            "f bm rsgns frm ffc NW, thrby dng  grt srvc t th cntry— wll gv hm fr lftm glf t ny n f my crss!"
        )]
        [InlineData(
            "This election is a total sham and a travesty. We are not a democracy!",
            "Ths lctn s  ttl shm nd  trvsty. W r nt  dmcrcy!"
        )]
        [InlineData(
            "I have never seen a thin person drinking Diet Coke.",
            " hv nvr sn  thn prsn drnkng Dt Ck."
        )]
        [InlineData(
            "Everybody wants me to talk about Robert Pattinson and not Brian Williams—I guess people just don’t care about Brian!",
            "vrybdy wnts m t tlk bt Rbrt Pttnsn nd nt Brn Wllms— gss ppl jst dn’t cr bt Brn!"
        )]
        public void ReturnRemoveVowels(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.RemoveVowels(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(27, false)]
        [InlineData(43, true)]
        [InlineData(14, false)]
        [InlineData(53, true)]
        [InlineData(99, true)]
        public void ReturnLargestSwap(int num, bool expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.LargestSwap(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, 3, 2)]
        [InlineData(new int[] { 2, 4, 6, 8, 10 }, 8, 3)]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, 11, -1)]
        public void ReturnSearch2(int[] arr, int item, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Search2(arr, item);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 }, 5)]
        [InlineData(new int[] { 7, 2, 3, 6, 5, 9, 1, 4, 8 }, 10)]
        [InlineData(new int[] { 7, 2, 3, 9, 4, 5, 6, 8, 10 }, 1)]
        [InlineData(new int[] { 10, 5, 1, 2, 4, 6, 8, 3, 9 }, 7)]
        [InlineData(new int[] { 1, 7, 2, 4, 8, 10, 5, 6, 9 }, 3)]
        public void ReturnMissingNum(int[] arr, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.MissingNum(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("space", "s p a c e")]
        [InlineData("far out", "f a r   o u t")]
        [InlineData("elongated musk", "e l o n g a t e d   m u s k")]
        [InlineData("long", "l o n g")]
        [InlineData("123", "1 2 3")]
        public void ReturnSpaceMeOut(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.SpaceMeOut(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 4, 0)]
        [InlineData(7, 3, 7, 2)]
        [InlineData(4, 4, 4, 3)]
        [InlineData(7, 3, 4, 0)]
        [InlineData(3, 3, 6, 2)]
        public void ReturnEqual(int a, int b, int c, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Equal(a, b, c);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, 5040)]
        [InlineData(1, 1)]
        [InlineData(9, 362880)]
        [InlineData(2, 2)]
        public void ReturnFactorial(int num, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Factorial(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("apple", "banana", "azure", true)]
        [InlineData("bookcase", "zebra", "squid", true)]
        [InlineData("shrapnel", "tapenade", "tally", true)]
        [InlineData("ostracize", "ostrich", "open", false)]
        [InlineData("bookend", "boolean", "boost", false)]
        public void ReturnIsBetween(string first, string last, string word, bool expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.IsBetween(first, last, word);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("the aardvark", "#", "th# ##rdv#rk")]
        [InlineData("minnie mouse", "?", "m?nn?? m??s?")]
        [InlineData("shakespeare", "*", "sh*k*sp**r*")]
        public void ReturnReplaceVowels(string str, string ch, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.ReplaceVowels(str, ch);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 0, -1, 2)]
        [InlineData(1, 0, 0, 1)]
        [InlineData(1, 0, 1, 0)]
        [InlineData(200, 420, 800, 0)]
        public void ReturnSolutions(int a, int b, int c, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Solutions(a, b, c);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(new object[] { "John", "Taylor" }, new object[] { "John", "Taylor", "John" })]
        [InlineData(
            new object[] { "John", "Taylor", "john" },
            new object[] { "John", "Taylor", "John", "john" }
        )]
        [InlineData(
            new object[] { "javascript", "python", "ruby", "c" },
            new object[] { "javascript", "python", "python", "ruby", "javascript", "c", "ruby" }
        )]
        public void ReturnRemoveDups(object[] expected, object[] input)
        {
            // Arrange

            // Act
            var actual = Very_Easy.RemoveDups(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("#", new int[] { 1, 0 })]
        [InlineData("+++++++", new int[] { 0, 7 })]
        [InlineData("++", new int[] { 0, 2 })]
        public void ReturnHashPlusCount(string s, int[] expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.HashPlusCount(s);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1, true)]
        [InlineData(12, 15, 10, true)]
        [InlineData(15228, 9209, 72162, true)]
        [InlineData(15, 1, 1, false)]
        [InlineData(123, 15, 10, false)]
        public void ReturnLastDig(int a, int b, int c, bool expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.LastDig(a, b, c);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 9, "11%")]
        [InlineData(2, 10, "20%")]
        [InlineData(3, 7, "43%")]
        public void ReturnImposterFormula(int i, int p, string expected)
        {
            // Arrange

            // Act
            var actual = Very_Easy.ImposterFormula(i, p);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("https://www.reddit.com/r/relationships/", "relationships")]
        [InlineData("https://www.reddit.com/r/mildlyinteresting/", "mildlyinteresting")]
        [InlineData("https://www.reddit.com/r/funny/", "funny")]
        [InlineData("https://www.reddit.com/r/CrappyDesign/", "CrappyDesign")]
        [InlineData("https://www.reddit.com/r/confession/", "confession")]
        public void ReturnSubReddit(string link, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.SubReddit(link);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello", "ehllo")]
        [InlineData("edabit", "abdeit")]
        [InlineData("hacker", "acehkr")]
        [InlineData("geek", "eegk")]
        [InlineData("javascript", "aacijprstv")]
        public void ReturnAlphabetSoup(string str, string expected)
        {
            // Arrange

            // Actual
            string actual = Very_Easy.AlphabetSoup(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("ooxx", true)]
        [InlineData("xooxx", false)]
        [InlineData("ooxXm", true)]
        [InlineData("zpzpzpp", true)]
        [InlineData("zzoo", false)]
        public void ReturnXO(string str, bool expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.XO(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(
            new string[] { "Ryan", "Kieran", "Jason", "Matt" },
            new string[] { "Ryan", "Matt" }
        )]
        [InlineData(new string[] { "Tomato", "Potato", "Pair" }, new string[] { "Pair" })]
        [InlineData(new string[] { "Kangaroo", "Bear", "Fox" }, new string[] { "Bear" })]
        public void ReturnIsFourLetters(string[] arr, string[] expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.IsFourLetters(arr);

            // Actual
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3 }, 2.55)]
        [InlineData(new int[] { 324, 543, 654, 9876 }, 2849.25)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0.0)]
        [InlineData(new int[] { 30, 40, 20, 100, 30 }, 44.0)]
        public void ReturnMean(int[] arr, double expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Mean(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 3, 5, 9 }, false)]
        [InlineData(new int[] { 1, 1, 1, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, true)]
        [InlineData(new int[] { 5, 2, 4 }, false)]
        public void ReturnIsAvgWhole(int[] arr, bool expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.IsAvgWhole(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("mice", 5, "mmmmmiiiiiccccceeeee")]
        [InlineData("hello", 3, "hhheeellllllooo")]
        [InlineData("stop", 1, "stop")]
        [InlineData("tomato", 2, "ttoommaattoo")]
        public void ReturnRepeat(string str, int num, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Repeat(str, num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(123) 456-7890")]
        [InlineData(new int[] { 5, 1, 9, 5, 5, 5, 4, 4, 6, 8 }, "(519) 555-4468")]
        [InlineData(new int[] { 3, 4, 5, 5, 0, 1, 2, 5, 2, 7 }, "(345) 501-2527")]
        [InlineData(new int[] { 6, 6, 2, 5, 8, 8, 7, 0, 4, 3 }, "(662) 588-7043")]
        public void ReturnFormatPhoneNumber(int[] numbers, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.FormatPhoneNumber(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("edabit", "TIBADE")]
        [InlineData("abc", "CBA")]
        [InlineData("hellothere", "EREHTOLLEH")]
        [InlineData("input", "TUPNI")]
        [InlineData("indubitably", "YLBATIBUDNI")]
        public void ReturnReverseCapitalize(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.ReverseCapitalize(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 2, 4, 6, 8 })]
        public void ReturnNoOdds(int[] arr, int[] expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.NoOdds(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Think different.", ".tnereffid knihT")]
        [InlineData(
            "It doesn’t make sense to hire smart people and tell them what to do; we hire smart people so they can tell us what to do.",
            ".od ot tahw su llet nac yeht os elpoep trams erih ew ;od ot tahw meht llet dna elpoep trams erih ot esnes ekam t’nseod tI"
        )]
        [InlineData(
            "Innovation is the ability to see change as an opportunity - not a threat",
            "taerht a ton - ytinutroppo na sa egnahc ees ot ytiliba eht si noitavonnI"
        )]
        [InlineData(
            "Everything is based on a simple rule: Quality is the best business plan.",
            ".nalp ssenisub tseb eht si ytilauQ :elur elpmis a no desab si gnihtyrevE"
        )]
        public void ReturnReverseString(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.ReverseString(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", 3, "Hellooo")]
        [InlineData("hey", 6, "heyyyyyy")]
        [InlineData("plsssss!1!", 5, "plsssss!1!!!!!")]
        [InlineData("gr", 2, "grr")]
        [InlineData("excuse me what?", 5, "excuse me what?????")]
        [InlineData("123", 5, "1233333")]
        [InlineData("a", 3, "aaa")]
        [InlineData("STOP", 3, "STOPPP")]
        public void ReturnModifyLast(string str, int n, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.ModifyLast(str, n);

            // Arrange
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("loop", true)]
        [InlineData("meeting", true)]
        [InlineData("yummy", true)]
        [InlineData("toodles", true)]
        [InlineData("droop", true)]
        [InlineData("loot", true)]
        public void ReturnDoubleLetters(string word, Boolean expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.DoubleLetters(word);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("maga", "zine", "Magazine")]
        [InlineData("reli", "able", "Reliable")]
        [InlineData("impl", "icit", "Implicit")]
        [InlineData("docu", "ment", "Document")]
        [InlineData("oppo", "site", "Opposite")]
        [InlineData("offi", "cial", "Official")]
        public void ReturnGetWord(string left, string right, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.GetWord(left, right);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("String", "SSttrriinngg")]
        [InlineData("Hello World!", "HHeelllloo  WWoorrlldd!!")]
        [InlineData("1234!_ ", "11223344!!__  ")]
        [InlineData("##^&%%*&%%$#@@!", "####^^&&%%%%**&&%%%%$$##@@@@!!")]
        [InlineData("scandal", "ssccaannddaall")]
        [InlineData("economics", "eeccoonnoommiiccss")]
        [InlineData(" ", "  ")]
        [InlineData("_______", "______________")]
        [InlineData("equip gallon read", "eeqquuiipp  ggaalllloonn  rreeaadd")]
        [InlineData("baby increase", "bbaabbyy  iinnccrreeaassee")]
        public void ReturnDoubleChar(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.DoubleChar(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("C:/Projects/pil_tests/ascii/edabit.txt", "edabit.txt")]
        [InlineData("C:/Users/johnsmith/Music/Beethoven_5.mp3", "Beethoven_5.mp3")]
        [InlineData("ffprobe.exe", "ffprobe.exe")]
        [InlineData("Music/Drafts/unfinished2.midi", "unfinished2.midi")]
        [InlineData("C:/Users/chad/OneDrive/Desktop/Atom.lnk", "Atom.lnk")]
        [InlineData("senoron/OneDrive/Desktop/DDLC-1.1.1-pc/lib/windows-i686/DDLC.exe", "DDLC.exe")]
        public void ReturnGetFilename(string path, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.GetFilename(path);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(17, 8, 24)]
        [InlineData(98, 3, 99)]
        [InlineData(14, 11, 22)]
        [InlineData(11, 8, 16)]
        [InlineData(450, 36, 468)]
        [InlineData(1019, 13, 1027)]
        public void ReturnDivisibleByB(int a, int b, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.DivisibleByB(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("11/12/2019", "20191211")]
        [InlineData("12/31/2019", "20193112")]
        [InlineData("01/15/2019", "20191501")]
        public void ReturnFormatDate(string date, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.FormatDate(date);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("increasing", "in... in... increasing?")]
        [InlineData("adventures", "ad... ad... adventures?")]
        [InlineData("enticing", "en... en... enticing?")]
        [InlineData("unacceptable", "un... un... unacceptable?")]
        [InlineData("accountable", "ac... ac... accountable?")]
        [InlineData("incredible", "in... in... incredible?")]
        [InlineData("exquisite", "ex... ex... exquisite?")]
        [InlineData("am", "am... am... am?")]
        [InlineData("enduring", "en... en... enduring?")]
        [InlineData("outstanding", "ou... ou... outstanding?")]
        public void ReturnStutter(string word, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Stutter(word);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello", "ell")]
        [InlineData("benefit", "enefi")]
        [InlineData("wordy", "ord")]
        [InlineData("maybe", "ayb")]
        [InlineData("to", "to")]
        [InlineData("a", "a")]
        [InlineData("", "")]
        public void ReturnRemoveFirstLast(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.RemoveFirstLast(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("soccer", 2, "soccersoccer")]
        [InlineData("ab", 3, "ababab")]
        [InlineData("this", 1, "this")]
        [InlineData("ciao", 4, "ciaociaociaociao")]
        [InlineData("charon", 5, "charoncharoncharoncharoncharon")]
        [InlineData("sa", 10, "sasasasasasasasasasa")]
        public void ReturnRepetition(string txt, int n, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Repetition(txt, n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 15)]
        [InlineData(1, 1)]
        [InlineData(12, 78)]
        public void ReturnSum(int n, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Sum(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("My friend Dylan got distracted at school", 4)]
        [InlineData("Debris was scattered all over the place.", 2)]
        [InlineData("The rodents hibernated in their den.", 3)]
        public void ReturnCountDs(string str, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.CountDs(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, "Burrrp")]
        [InlineData(5, "Burrrrrp")]
        [InlineData(9, "Burrrrrrrrrp")]
        [InlineData(10, "Burrrrrrrrrrp")]
        [InlineData(13, "Burrrrrrrrrrrrrp")]
        [InlineData(18, "Burrrrrrrrrrrrrrrrrrp")]
        [InlineData(1, "Burp")]
        public void ReturnLongBurp(int b, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.LongBurp(b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("ClaClaClaClap!", 4)]
        [InlineData("ClClClaClaClaClap!", 6)]
        [InlineData("CCClaClClap!Clap!ClClClap!", 9)]
        [InlineData(
            "ClCCClaClaClaClCClap!CClaClap!Clap!ClClClClaClaClap!Clap!ClClCClap!Clap!ClClap!ClaCClClap!ClClap!Clap!CClClaClaClaCClaCClaClClaCCCClaClap!Clap!ClaClaClap!ClaClap!CClap!Clap!ClClap!",
            61
        )]
        [InlineData(
            "Clap!ClClaClap!ClaClap!CClap!ClClClap!CClaClap!CClap!ClClap!ClaClaClClap!ClaClap!ClClCClaClaCClaCCCCClClCClap!ClaCClaClCClap!Clap!ClaClaClaCClaClap!",
            52
        )]
        public void ReturnCountClaps(string txt, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.CountClaps(txt);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5, true)]
        [InlineData(new int[] { 5, 5, 3, 4, 5 }, 3, false)]
        [InlineData(new int[] { 5, 4, 5, 6 }, 10, true)]
        [InlineData(new int[] { 1, 2, 1 }, 1, false)]
        [InlineData(new int[] { 3, 3, 3 }, 4, true)]
        [InlineData(new int[] { 4, 4 }, 3, false)]
        [InlineData(new int[] { }, 4, true)]
        public void ReturnHurdleJump(int[] hurdles, int jumpHeight, bool expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.HurdleJump(hurdles, jumpHeight);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("NNNN", false)]
        [InlineData("NENESSWW", true)]
        [InlineData("NEESSW", false)]
        [InlineData("EEWE", false)]
        [InlineData("NNSSEEEWWWEW", true)]
        public void ReturnBackToHome(string d, bool expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.BackToHome(d);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("buf-fet", 2)]
        [InlineData("beau-ti-ful", 3)]
        [InlineData("mon-u-men-tal", 4)]
        [InlineData("on-o-mat-o-poe-ia", 6)]
        [InlineData("o-ver-ly", 3)]
        [InlineData("pas-try", 2)]
        [InlineData("flu-id", 2)]
        [InlineData("syl-la-ble", 3)]
        public void ReturnNumberSyllables(string word, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.NumberSyllables(word);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2018, 31)]
        [InlineData(2, 2018, 28)]
        [InlineData(3, 2018, 31)]
        [InlineData(4, 2018, 30)]
        [InlineData(5, 2018, 31)]
        [InlineData(6, 2018, 30)]
        public void ReturnDays(int month, int year, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Days(month, year);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("It's high noon", 3)]
        [InlineData("Is this easy mode", 4)]
        [InlineData("What an easy task, right", 5)]
        [InlineData("This is a test", 4)]
        [InlineData("Just an example here move along", 6)]
        [InlineData("How are you today?", 4)]
        public void ReturnCountWords(string str, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.CountWords(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new string[] { "abc", "ghj", "banana", "grape" }, "grape", 3)]
        [InlineData(new string[] { "a", "b", "c", "d", "e", "f" }, "f", 5)]
        [InlineData(
            new string[] { "hi", "edabit.com", "tistcase", "validstring" },
            "edabit.com",
            1
        )]
        public void ReturnFindIndex(string[] arr, string str, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.FindIndex(arr, str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, "-")]
        [InlineData(2, "--")]
        [InlineData(3, "---")]
        [InlineData(4, "----")]
        [InlineData(5, "-----")]
        public void ReturnGo(int num, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Go(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("whisper...", "lower")]
        [InlineData("SHOUT!", "upper")]
        [InlineData("Indoor Voice", "mixed")]
        [InlineData("324324Indoor66453546Voice434", "mixed")]
        [InlineData("!!!!SHOUT!!!!", "upper")]
        [InlineData("......313whisper2131232...", "lower")]
        public void ReturnGetCase(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.GetCase(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, new object[] { "tt" })]
        [InlineData(4, new object[] { "lama", "tiger", 6, 3 })]
        [InlineData(1, new object[] { "love" })]
        [InlineData(4, new object[] { 1, 3, 3, 3 })]
        [InlineData(4, new object[] { new int[] { 1 }, 3, "ygg", 3 })]
        public void ReturnNumArgs(int expected, params object[] p)
        {
            // Arrange

            // Act
            var actual = Very_Easy.NumArgs(p);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 0.01)]
        [InlineData(500, 4.65)]
        [InlineData(649, 6.04)]
        [InlineData(1000, 9.3)]
        public void ReturnYenToUsd(int yen, double expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.YenToUsd(yen);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new bool[] { true, false, false, true, false }, 2)]
        [InlineData(new bool[] { false, false, false, false }, 0)]
        [InlineData(new bool[] { }, 0)]
        [InlineData(
            new bool[]
            {
                false,
                false,
                true,
                true,
                false,
                false,
                false,
                true,
                true,
                true,
                true,
                false,
                true,
                true,
                false
            },
            8
        )]
        [InlineData(new bool[] { true, false, true, true, false, false, false, false, false }, 3)]
        [InlineData(
            new bool[]
            {
                false,
                true,
                true,
                false,
                true,
                true,
                false,
                true,
                false,
                true,
                false,
                true,
                false,
                true,
                false
            },
            8
        )]
        [InlineData(
            new bool[] { true, false, true, true, true, false, true, true, false, false },
            6
        )]
        [InlineData(
            new bool[] { false, false, false, false, true, false, true, false, true, false, false },
            3
        )]
        [InlineData(
            new bool[] { true, false, false, false, true, false, false, true, false, false, false },
            3
        )]
        [InlineData(
            new bool[] { true, true, false, true, false, false, false, false, true, false },
            4
        )]
        [InlineData(
            new bool[]
            {
                true,
                false,
                true,
                true,
                false,
                true,
                true,
                true,
                true,
                false,
                true,
                false,
                true,
                false
            },
            9
        )]
        [InlineData(
            new bool[]
            {
                true,
                false,
                true,
                true,
                true,
                true,
                false,
                true,
                true,
                false,
                true,
                false,
                false,
                false,
                false
            },
            8
        )]
        [InlineData(
            new bool[]
            {
                true,
                true,
                false,
                false,
                false,
                false,
                true,
                false,
                true,
                true,
                false,
                true
            },
            6
        )]
        public void ReturnCountTrue(bool[] arr, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.CountTrue(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 5, 9 }, 855)]
        [InlineData(new int[] { 3, 4, 5 }, 216)]
        [InlineData(new int[] { 1, 1, 1 }, 3)]
        [InlineData(new int[] { 32 }, 32768)]
        public void ReturnCubesSum(int[] nums_arr, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.CubesSum(nums_arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5 }, new int[] { 2, 6, 8 }, new int[] { 1, 3, 5, 2, 6, 8 })]
        [InlineData(
            new int[] { 7, 8 },
            new int[] { 10, 9, 1, 1, 2 },
            new int[] { 7, 8, 10, 9, 1, 1, 2 }
        )]
        [InlineData(
            new int[] { 4, 5, 1 },
            new int[] { 3, 3, 3, 3, 3 },
            new int[] { 4, 5, 1, 3, 3, 3, 3, 3 }
        )]
        public void ConcatArrays(int[] arr1, int[] arr2, int[] expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.ConcatArrays(arr1, arr2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, "Edaaaaabit")]
        [InlineData(15, "Edaaaaaaaaaaaaaaabit")]
        [InlineData(-4, "")]
        [InlineData(10, "Edaaaaaaaaaabit")]
        [InlineData(23, "Edaaaaaaaaaaaaaaaaaaaaaaabit")]
        [InlineData(1, "Edabit")]
        [InlineData(0, "Edbit")]
        [InlineData(-3, "")]
        [InlineData(-8, "")]
        public void ReturnEdaabit(int n, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Edaabit(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(139.4, 93.8, 1.49)]
        [InlineData(181.2, 124.5, 1.46)]
        [InlineData(154.7, 104.3, 1.48)]
        [InlineData(218.1, 278.3, 0.78)]
        [InlineData(171.4, 171.6, 1.0)]
        [InlineData(218.0, 162.2, 1.34)]
        [InlineData(263.2, 272.7, 0.97)]
        [InlineData(199.4, 166.0, 1.2)]
        public void SmashFactor(double a, double b, double expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.SmashFactor(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 10)]
        [InlineData(13, 91)]
        [InlineData(600, 180300)]
        [InlineData(392, 77028)]
        [InlineData(53, 1431)]
        [InlineData(897, 402753)]
        [InlineData(23, 276)]
        [InlineData(1000, 500500)]
        [InlineData(738, 272691)]
        [InlineData(100, 5050)]
        [InlineData(925, 428275)]
        [InlineData(1, 1)]
        [InlineData(999, 499500)]
        [InlineData(175, 15400)]
        [InlineData(111, 6216)]
        public void ReturnAddUp(int num, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.AddUp(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 0)]
        public void ReturnFlip(int y, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Flip(y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("WHAT DO YOU MEAN WE'RE OUT OF MONEY", "WHAT DO YOU WEAN WE'RE OUT OF WONEY")]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "ABCDEFGHIJKLWNOPQRSTUVWXYZ")]
        [InlineData("1 WUMBO 2 WUMBO 3 WUMBO 4", "1 WUWBO 2 WUWBO 3 WUWBO 4")]
        public void ReturnWumbo(string words, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Wumbo(words);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnFirstLastAgain()
        {
            // Arrange

            // Actual

            // Assert
            Assert.Equal(
                new object[] { 5, 25 },
                Very_Easy.FirstLastAgain(new object[] { 5, 10, 15, 20, 25 })
            );
            Assert.Equal(
                new object?[] { "edabit", true },
                Very_Easy.FirstLastAgain(new object?[] { "edabit", 13, null, false, true })
            );
            Assert.Equal(
                new object?[] { "", null },
                Very_Easy.FirstLastAgain(new object?[] { "", 4, "6", "hello", null })
            );
            Assert.Equal(
                new object[] { "hello", "com" },
                Very_Easy.FirstLastAgain(new object[] { "hello", "edabit", "dot", "com" })
            );
            Assert.Equal(new object[] { 3, 1 }, Very_Easy.FirstLastAgain(new object[] { 3, 2, 1 }));
            Assert.Equal(
                new object[] { "one", "two" },
                Very_Easy.FirstLastAgain(new object[] { "one", "two" })
            );
            Assert.Equal(
                new object[] { false, false },
                Very_Easy.FirstLastAgain(
                    new object[] { false, false, true, false, false, true, false }
                )
            );
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, true)]
        [InlineData(new int[] { 1, 1, 2, 1, 1 }, 3, false)]
        [InlineData(new int[] { 1, 1, 2, 1, 5, 4, 7 }, 7, true)]
        [InlineData(new int[] { 1, 1, 2, 1, 5, 4, 7 }, 8, false)]
        [InlineData(new int[] { 5, 5, 5, 6 }, 5, true)]
        [InlineData(new int[0], 5, false)]
        public void ReturnCheck(int[] arr, int el, bool expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Check(arr, el);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(27, 59, "obtuse")]
        [InlineData(135, 11, "acute")]
        [InlineData(45, 45, "right")]
        [InlineData(45, 15, "obtuse")]
        [InlineData(31, 100, "acute")]
        [InlineData(35, 55, "right")]
        public void ReturnMissingAngle(int angle1, int angle2, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.MissingAngle(angle1, angle2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(67, 2)]
        [InlineData(123, 3)]
        [InlineData(55551, 5)]
        [InlineData(96456431, 8)]
        [InlineData(0, 1)]
        public void ReturnFindDigitAmount(int num, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.FindDigitAmount(num);

            // Asseert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new double[] { 1, 5, 6, 3 }, "15 ohms")]
        [InlineData(new double[] { 0.2, 0.3, 0.4 }, "0.9 ohm")]
        [InlineData(new double[] { 10, 12, 1, 10 }, "33 ohms")]
        [InlineData(new double[] { 10, 13, 3.8, 20, 10 }, "56.8 ohms")]
        [InlineData(new double[] { 0.5, 0.5 }, "1 ohm")]
        [InlineData(new double[] { 16, 30, 22.8, 4 }, "72.8 ohms")]
        [InlineData(new double[] { 20, 15, 32.5, 2 }, "69.5 ohms")]
        [InlineData(new double[] { 52, 22, 20, 30 }, "124 ohms")]
        [InlineData(new double[] { 10, 12, 32, 4.9, 5, 6, 71 }, "140.9 ohms")]
        public void ReturnSeriesResistance(double[] arr, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.SeriesResistance(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(
            new string[] { "clever", "meek", "hurried", "nice" },
            "ly",
            new string[] { "cleverly", "meekly", "hurriedly", "nicely" }
        )]
        [InlineData(
            new string[] { "new", "pander", "scoop" },
            "er",
            new string[] { "newer", "panderer", "scooper" }
        )]
        [InlineData(
            new string[] { "bend", "sharpen", "mean" },
            "ing",
            new string[] { "bending", "sharpening", "meaning" }
        )]
        [InlineData(
            new string[] { "bend", "tooth", "mint" },
            "y",
            new string[] { "bendy", "toothy", "minty" }
        )]
        [InlineData(
            new string[] { "bend", "tooth", "mint" },
            "ier",
            new string[] { "bendier", "toothier", "mintier" }
        )]
        public void ReturnAddEnding(string[] arr, string ending, string[] expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.AddEnding(arr, ending);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("edabit is amazing.", "edabit is amazing.")]
        [InlineData("Mubashir is amazing.", "Mubashir is not amazing.")]
        [InlineData("Trump is amazing.", "Trump is not amazing.")]
        [InlineData("Infinity is amazing.", "Infinity is not amazing.")]
        [InlineData("Mubashir and edabit are amazing.", "Mubashir and edabit are amazing.")]
        [InlineData("Matt is amazing.", "Matt is not amazing.")]
        [InlineData("Helen is amazing.", "Helen is not amazing.")]
        [InlineData("Python and edabit are amazing.", "Python and edabit are amazing.")]
        [InlineData("C++ is amazing.", "C++ is not amazing.")]
        [InlineData("javascript is amazing.", "javascript is not amazing.")]
        [InlineData("java is amazing.", "java is not amazing.")]
        [InlineData("ruby is amazing.", "ruby is not amazing.")]
        [InlineData("SQL is amazing.", "SQL is not amazing.")]
        [InlineData("CSS is amazing.", "CSS is not amazing.")]
        [InlineData("Pakistan is amazing. edabit", "Pakistan is amazing. edabit")]
        [InlineData("You and edabit are amazing.", "You and edabit are amazing.")]
        [InlineData("Matt and edabit are amazing.", "Matt and edabit are amazing.")]
        [InlineData("Helen and edabit are amazing.", "Helen and edabit are amazing.")]
        [InlineData("Everyone is amazing.", "Everyone is not amazing.")]
        [InlineData("Swift and edabit are amazing.", "Swift and edabit are amazing.")]
        public void ReturnAmazingEdabit(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.AmazingEdabit(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [InlineData(new int[] { 5, 6, 7 }, new int[] { 7, 6, 5 })]
        [InlineData(new int[] { 9, 9, 2, 3, 4 }, new int[] { 4, 3, 2, 9, 9 })]
        [InlineData(new int[] { 3, 3 }, new[] { 3, 3 })]
        [InlineData(new int[] { -1, -1, -1 }, new int[] { -1, -1, -1 })]
        [InlineData(new int[] { }, new int[] { })]
        public void ReturnReverse(int[] arr, int[] expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Reverse(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 5, 3 }, 5, 1)]
        [InlineData(new int[] { 9, 8, 3 }, 3, 2)]
        [InlineData(new int[] { 1, 2, 3 }, 4, -1)]
        [InlineData(new int[] { 1, 5, 3, 10, 17, 20, -6 }, 20, 5)]
        public void ReturnSearch(int[] arr, int item, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Search(arr, item);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 32)]
        [InlineData(4, 16)]
        [InlineData(3, 8)]
        [InlineData(2, 4)]
        [InlineData(1, 2)]
        [InlineData(6, 64)]
        [InlineData(7, 128)]
        [InlineData(8, 256)]
        [InlineData(9, 512)]
        [InlineData(10, 1024)]
        [InlineData(25, 33554432)]
        public void ReturnPosCom(int n, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.PosCom(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abc", "bc", true)]
        [InlineData("abc", "d", false)]
        [InlineData("samurai", "zi", false)]
        [InlineData("feminine", "nine", true)]
        [InlineData("convention", "tio", false)]
        [InlineData("cooperative", "ooper", false)]
        [InlineData("extraterrestrial", "xtraterrestrial", true)]
        [InlineData("access", "ss", true)]
        [InlineData("motorist", "is", false)]
        [InlineData("landowner", "landowner", true)]
        public void ReturnCheckEnding(string str1, string str2, bool expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.CheckEnding(str1, str2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("forza", "fa")]
        [InlineData("kali", "ki")]
        [InlineData("always", "as")]
        [InlineData("love", "le")]
        [InlineData("supernatural", "sl")]
        [InlineData("edabit", "et")]
        public void ReturnFirstLast(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.FirstLast(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 10, 4, 1, 2, 8, 91 }, 90)]
        [InlineData(new int[] { -70, 43, 34, 54, 22 }, 124)]
        public void ReturnDifferenceMaxMin(int[] arr, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.differenceMaxMin(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello", "hELLo", true)]
        [InlineData("hey", "hey", true)]
        [InlineData("venom", "VENOM", true)]
        [InlineData("maGIciAN", "magician", true)]
        [InlineData("stupIFy", "stupifY", true)]
        [InlineData("bald", "blad", false)]
        [InlineData("motive", "emotive", false)]
        [InlineData("mask", "mAskinG", false)]
        [InlineData("skim", "skimp", false)]
        [InlineData("EXCEl", "exceLs", false)]
        public void ReturnIsMatch(string s1, string s2, bool expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.match(s1, s2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(24, 100, "-", -76)]
        [InlineData(-20, -30, "+", -50)]
        [InlineData(38, 3, "*", 114)]
        [InlineData(49, 5, "%", 4)]
        [InlineData(1500, 5, "/", 300)]
        public void ReturnCalculate(int num1, int num2, string operation, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Calculate(num1, num2, operation);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 3, 0)]
        [InlineData(1, 3, 1)]
        [InlineData(5, 3, 2)]
        [InlineData(4, 5, 4)]
        [InlineData(218, 5, 3)]
        public void ReturnMod(int a, int b, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Mod(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 4, 5, 1, 3 }, 5)]
        [InlineData(new int[] { 13, 27, 18, 26 }, 27)]
        [InlineData(new int[] { 32, 35, 37, 39 }, 39)]
        [InlineData(new int[] { 1000, 1001, 857, 1 }, 1001)]
        [InlineData(new int[] { 27364, 837363, 736736, 73635 }, 837363)]
        [InlineData(new int[] { 30, 2, 40, 3 }, 40)]
        [InlineData(new int[] { 0, 1, 0, 0, 1 }, 1)]
        public void ReturnFindLargestNum(int[] arr, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.FindLargestNum(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new double[] { 34, 15, 88, 2 }, 2)]
        [InlineData(new double[] { 34, -345, -1, 100 }, -345)]
        [InlineData(new double[] { -76, 1.345, 1, 0 }, -76)]
        [InlineData(new double[] { 0.4356, 0.8795, 0.5435, -0.9999 }, -0.9999)]
        [InlineData(new double[] { 7, 7, 7 }, 7)]
        [InlineData(new double[] { 4, 6, 1, 3, 4, 5, 5, 1 }, 1)]
        [InlineData(new double[] { -4, -6, -8, -1 }, -8)]
        [InlineData(new double[] { 54, 76, 23, 54 }, 23)]
        [InlineData(new double[] { 100 }, 100)]
        [InlineData(new double[] { 0, 1, 2, 3, 4, 5 }, 0)]
        public void ReturnFindSmallestNum(double[] arr, double expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.FindSmallestNum(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("37", 37)]
        [InlineData("113", 113)]
        [InlineData("5", 5)]
        [InlineData("5231", 5231)]
        public void ReturnToInt(string str, int expected)
        {
            // Arrange

            // Act
            var actual = Very_Easy.toInt(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(37, "37")]
        [InlineData(113, "113")]
        [InlineData(5, "5")]
        [InlineData(5231, "5231")]
        public void ReturnToStr(int num, string expected)
        {
            // Arrange

            // Act
            var actual = Very_Easy.toStr(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 12, "added")]
        [InlineData(100, 76, "subtracted")]
        [InlineData(6, 4, "multiplied")]
        [InlineData(528, 22, "divided")]
        [InlineData(10, 12, "none")]
        public void ReturnOperation(int num1, int num2, string expected)
        {
            // Arrange

            // Act
            var actual = Very_Easy.Operation(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("dudes", true)]
        [InlineData("flowers", true)]
        [InlineData("checks", true)]
        [InlineData("varies", true)]
        [InlineData("efforts", true)]
        [InlineData("mood", false)]
        [InlineData("whiteboard", false)]
        [InlineData("cow", false)]
        [InlineData("word", false)]
        [InlineData("love", false)]
        public void ReturnIsPlural(string word, bool expected)
        {
            // Arrange

            // Act
            var actual = Very_Easy.IsPlural(word);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new object?[] { "Cat", "Dog", "Duck" }, "Duck")]
        [InlineData(new object?[] { 1, 2, 3 }, 3)]
        [InlineData(new object?[] { null }, (object?)null)]
        [InlineData(new object?[] { true, false, false, true }, true)]
        [InlineData(new object?[] { 7, "String", false, null, null }, (object?)null)]
        [InlineData(new object?[] { false }, false)]
        [InlineData(new object?[] { null, null, null }, null)]
        [InlineData(new object?[] { 1, 2, 3, 56, 87, 23, 65, 45 }, 45)]
        [InlineData(new object?[] { "Apple", "Orange", null }, null)]
        [InlineData(new object?[] { true, false, "Apple" }, "Apple")]
        [InlineData(new object?[] { 1 }, 1)]
        public void ReturnLastItem(object?[] arr, object? expected)
        {
            // Arrange

            // Act
            var actual = Very_Easy.GetLastItem(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 3, 2, true)]
        [InlineData(8, 3, 3, false)]
        [InlineData(24, 12, 2, true)]
        [InlineData(5, 6, 1, false)]
        [InlineData(5, 0, 100, true)]
        [InlineData(15, 2, 7, true)]
        [InlineData(15, 2, 8, false)]
        public void ReturnEqualSlices(int total, int people, int each, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.EqualSlices(total, people, each);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('E', 69)]
        [InlineData('d', 100)]
        [InlineData('a', 97)]
        [InlineData('b', 98)]
        [InlineData('i', 105)]
        [InlineData('t', 116)]
        [InlineData('.', 46)]
        [InlineData(' ', 32)]
        [InlineData('1', 49)]
        public void ReturnCharToASCII(char ch, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.CharToASCII(ch);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 2)]
        [InlineData(6000, 4)]
        [InlineData(314, 3)]
        public void ReturnNumberLength(int n, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.Length(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 2, true)]
        [InlineData(-6, -9, true)]
        [InlineData(6, -2, false)]
        [InlineData(0, 0, true)]
        [InlineData(100, 1, true)]
        [InlineData(-80, -5000, true)]
        [InlineData(6, -999, false)]
        [InlineData(-1, 2, false)]
        [InlineData(0, 2, false)]
        public void BothShouldReturnTrueIfBothMatchCriteria(int n1, int n2, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.Both(n1, n2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("apple", 5)]
        [InlineData("make", 4)]
        [InlineData("a", 1)]
        [InlineData("", 0)]
        public void Length_ReturnLengthOfString(string str, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.Length(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Foo", false)]
        [InlineData("Foo bar", true)]
        [InlineData("Foo ", true)]
        [InlineData(" Foo", true)]
        [InlineData(" ", true)]
        [InlineData("", false)]
        [InlineData(",./;'[]-=", false)]
        public void HasSpaces_ReturnTrueIfContainsSpaces(string str, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.HasSpaces(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("6", 6)]
        [InlineData("2", 2)]
        [InlineData("10", 10)]
        [InlineData("666", 666)]
        public void StringInt_TakesAStringAndReturnsAnInteger(string txt, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.StringInt(txt);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("####", true)]
        [InlineData("## ####", false)]
        [InlineData("#", true)]
        [InlineData("# #", false)]
        public void IsSafeBridge_ValidateIfBridgeIsSafe(string str, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.IsSafeBridge(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(17, true, false)]
        [InlineData(30, true, false)]
        [InlineData(24, false, true)]
        [InlineData(18, false, true)]
        [InlineData(16, false, false)]
        [InlineData(18, true, false)]
        [InlineData(17, false, false)]
        public void ShouldServeDrinks_ReturnIfShouldServeDrinks(
            int age,
            bool on_break,
            bool expected
        )
        {
            // Arrange

            // Act
            bool actual = Very_Easy.ShouldServeDrinks(age, on_break);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { -9, -8, 6, -9, 15, 6 }, 24)]
        [InlineData(new int[] { -5, 6, 18, 4, 16, -2 }, 23)]
        [InlineData(new int[] { -2, 20, -9, -9, -2, -7 }, 29)]
        [InlineData(new int[] { 4, -2, 11, -9, 15, 2 }, 24)]
        [InlineData(new int[] { 15, 10, 3, -6, 6, 19 }, 25)]
        [InlineData(new int[] { 1, 7, 18, -1, -2, 9 }, 20)]
        [InlineData(new int[] { 5, 1, -9, 7, -8, -10 }, 17)]
        [InlineData(new int[] { 4, 17, 12, 2, 10, 2 }, 15)]
        public void Diff(int[] arr, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.Diff(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("", true)]
        [InlineData(" ", false)]
        [InlineData("            ", false)]
        [InlineData("38215", false)]
        [InlineData("afjabsdf", false)]
        [InlineData("!?@&", false)]
        public void isEmpty(string str, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.isEmpty(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 7)]
        [InlineData(3, 3)]
        [InlineData(7, 8)]
        [InlineData(12, 14)]
        [InlineData(213, 248)]
        [InlineData(16, 18)]
        public void TotalCups(int n, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.TotalCups(n);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(PrintArrayData))]
        public void PrintArray_ReturnArrayNumbered1ToN(int n, int[] expected)
        {
            // https://andrewlock.net/creating-parameterised-tests-in-xunit-with-inlinedata-classdata-and-memberdata/

            // Arrange

            // Act
            List<int> actual = Very_Easy.PrintArray(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> PrintArrayData =>
            new List<object[]>
            {
                new object[] { 1, new int[] { 1 } },
                new object[] { 3, new int[] { 1, 2, 3 } },
                new object[] { 6, new int[] { 1, 2, 3, 4, 5, 6 } },
            };

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 4)]
        [InlineData(0, 0)]
        [InlineData(5, 25)]
        [InlineData(27, 729)]
        [InlineData(196, 38416)]
        [InlineData(512, 262144)]
        public void StackBoxes_ReturnTheSquareOfN(int n, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.StackBoxes(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Aiden", true)]
        [InlineData("Roxy", false)]
        [InlineData("Bert", false)]
        [InlineData("Dean", true)]
        [InlineData("Ian", true)]
        [InlineData("Brian", true)]
        [InlineData("Daniel", false)]
        public void isLastCharacterN_ChecksIfLastCharacterIsN(string word, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.isLastCharacterN(word);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("apples", true)]
        [InlineData("banana", true)]
        [InlineData("cherry", true)]
        [InlineData("mango", false)]
        [InlineData("peach", false)]
        [InlineData("pears", false)]
        public void oddOrEven_ReturnEvenOrOddBasedOnLength(string word, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.oddOrEven(word);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, "odd")]
        [InlineData(0, "even")]
        [InlineData(7, "odd")]
        [InlineData(12, "even")]
        [InlineData(6474, "even")]
        [InlineData(563, "odd")]
        [InlineData(301, "odd")]
        [InlineData(-3, "odd")]
        [InlineData(-7, "odd")]
        [InlineData(-12, "even")]
        [InlineData(-563, "odd")]
        [InlineData(-6474, "even")]
        [InlineData(-301, "odd")]
        public void IsEvenOrOdd_ReturnEvenOrOddAsString(int num, string expected)
        {
            // Arrange

            // Act
            string actual = Very_Easy.IsEvenOrOdd(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("John", "Doe", "Doe, John")]
        [InlineData("First", "Last", "Last, First")]
        [InlineData("A", "B", "B, A")]
        [InlineData(",", ",", ",, ,")]
        public void ConcatName_ReturnStringsConcatenated(
            string firstName,
            string lastName,
            string expected
        )
        {
            // Arrange

            // Act
            string actual = Very_Easy.ConcatName(firstName, lastName);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 2)]
        [InlineData(3, 4)]
        [InlineData(100, 198)]
        [InlineData(1298734, 2597466)]
        public void NthEven_ReturnsTheNthEvenNumber(int n, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.NthEven(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-3, 3)]
        [InlineData(250, 250)]
        [InlineData(0, 0)]
        [InlineData(6, 6)]
        [InlineData(1103, 1103)]
        public void Absolute_ReturnAnAbsoluteValueOfAValidNumber(int num, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.absolute(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-5, true)]
        [InlineData(-50, false)]
        [InlineData(0, false)]
        [InlineData(25, true)]
        [InlineData(-19, true)]
        [InlineData(12, false)]
        [InlineData(23, true)]
        [InlineData(-71, true)]
        public void IsOdd_ReturnTrueIfNumberIsOdd(int num, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.IsOdd(num);

            // Asert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("AB", "CD", true)]
        [InlineData("ABC", "DE", false)]
        [InlineData("hello", "edabit", false)]
        [InlineData("meow", "woof", true)]
        [InlineData("jrnvjrnnt", "cvjknfjvmfvnfjn", false)]
        [InlineData("jkvnjrt", "krnf", false)]
        [InlineData("Facebook", "Snapchat", true)]
        public void Comp_ReturnTrueIfLengthsMatch(string str1, string str2, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.Comp(str1, str2);

            // Asert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-4, -4)]
        [InlineData(212, -212)]
        [InlineData(-125, -125)]
        [InlineData(932123, -932123)]
        public void ReturnNegative_ValidNumberShouldConvertToNegative(int n, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.ReturnNegative(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(8, 5, 40)]
        [InlineData(5, 4, 20)]
        [InlineData(2, 3, 6)]
        [InlineData(10000, 10000, 100000000)]
        [InlineData(-2, -5, -1)]
        [InlineData(0, 3, -1)]
        [InlineData(5, -3, -1)]
        [InlineData(0, 1, -1)]
        [InlineData(-1, 0, -1)]
        public void Area_SimpleValuesShouldCalculate(int h, int w, int expected)
        {
            // Arrange

            // Act
            double actual = Very_Easy.area(h, w);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
