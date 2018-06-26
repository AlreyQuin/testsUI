using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupDeleteTests : BaseTest
    {
        [Test]
        public void TestGroupdelete()
        {

            GroupData newGroup = new GroupData()
            {
                Name = "test"
            };
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            if (oldGroups.Count == 0)
            {
                app.Groups.AddGroup(newGroup);
            }

            app.Groups.DeleteGroup(0);
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
