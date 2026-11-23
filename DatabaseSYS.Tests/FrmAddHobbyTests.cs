using System.Reflection;
using System.Windows.Forms;
using DatabaseConnect;

namespace DatabaseSYS.Tests;

[TestClass]
public class FrmAddHobbyTests
{
    [STATestMethod]
    public void Constructor_CreatesExpectedInputControls()
    {
        using var parent = new frmMainMenu();
        using var form = new frmAddHobby(parent);

        Assert.IsNotNull(GetField<TextBox>(form, "txtHobbyID"));
        Assert.IsNotNull(GetField<TextBox>(form, "txtDescription"));
        Assert.IsNotNull(GetField<TextBox>(form, "txtPlayerNum"));
        Assert.IsNotNull(GetField<TextBox>(form, "txtPrice"));
        Assert.AreEqual("Add Hobby", GetField<GroupBox>(form, "grpAddHobby").Text);
    }

    [STATestMethod]
    public void BackMenuItem_ClosesAddFormAndShowsParent()
    {
        using var parent = new frmMainMenu { Visible = false };
        using var form = new frmAddHobby(parent);

        InvokePrivate(form, "mnuBack_Click", null!, EventArgs.Empty);

        Assert.IsTrue(parent.Visible);
        Assert.IsTrue(form.IsDisposed);
    }

    private static T GetField<T>(object instance, string name) where T : class
    {
        return (T)(typeof(frmAddHobby)
            .GetField(name, BindingFlags.Instance | BindingFlags.NonPublic)!
            .GetValue(instance)!);
    }

    private static void InvokePrivate(object instance, string name, params object[] arguments)
    {
        typeof(frmAddHobby)
            .GetMethod(name, BindingFlags.Instance | BindingFlags.NonPublic)!
            .Invoke(instance, arguments);
    }
}
