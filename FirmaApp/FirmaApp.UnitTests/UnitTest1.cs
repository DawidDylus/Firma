using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirmaApp.ViewModels;

namespace FirmaApp.UnitTests
{
    [TestClass]
    public class ViewModelTests
    {
        [TestMethod]
        public void WorkersOnList_WorkersMoreThanOne_ReturnsTrue()
        {
            var workerViewModel = new WorkerViewModel();

            int count = workerViewModel.GetWorkerCount();
            Assert.IsTrue(count >= 1);


        }
    }
}
