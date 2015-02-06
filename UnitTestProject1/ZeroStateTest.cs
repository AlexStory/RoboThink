using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.Factory;
using TestStack.White.UIItems.WindowItems;
using RoboThink;
using System.IO;

namespace UnitTestProject1 {
  [TestClass]
  public class UITests {
    private static TestContext test_context;
    private static Window window;
    private static Application application;

    [ClassInitialize]
    public static void Setup(TestContext _context) {
      test_context = _context;
      var applicationDir = _context.DeploymentDirectory;
      var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\UnitTestProject1\\bin\\Debug\\RoboThink");
      application = Application.Launch(applicationPath);
      window = application.GetWindow("MainWindow", InitializeOption.NoCache);

    }

    [TestMethod]


    public void TestZeroState() {
      Button NSSButton = window.Get<Button>("NSS");
      Button VIMButton = window.Get<Button>("VIM");

            string SelectedTab ="NSS";


      Assert.AreEqual(SelectedTab, "NSS");
      Assert.IsTrue(NSSButton.Enabled);
      Assert.IsTrue(VIMButton.Enabled);

    }

    [ClassCleanup]
    public static void TearDown() {
      window.Close();
      application.Close();
    }
  }
}
