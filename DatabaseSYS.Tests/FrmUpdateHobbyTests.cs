using System.Reflection;
using System.Windows.Forms;
using DatabaseConnect;

namespace DatabaseSYS.Tests;

[TestClass]
public class FrmUpdateHobbyTests
{
    [STATestMethod]
    public void Constructor_HidesUpdateGroupAndCreatesHobbySelector()
    {
        using var parent = new frmMainMenu();
        using var form = new frmUpdateHobby(parent);

        ComboBox hobbySelector = GetField<ComboBox>(form, "cboHobbyID");
        GroupBox updateGroup = GetField<GroupBox>(form, "grpUpdateHobby");

        Assert.IsNotNull(hobbySelector);
        Assert.AreEqual(-1, hobbySelector.SelectedIndex);
        Assert.IsFalse(updateGroup.Visible);
    }

    [STATestMethod]
    public void ResetForm_HidesEditorClearsFieldsAndResetsSelection()
    {
        using var parent = new frmMainMenu();
        using var form = new frmUpdateHobby(parent);
        ComboBox hobbySelector = GetField<ComboBox>(form, "cboHobbyID");
        GroupBox updateGroup = GetField<GroupBox>(form, "grpUpdateHobby");
        TextBox description = GetField<TextBox>(form, "txtDescription");
        TextBox playerCount = GetField<TextBox>(form, "txtPlayerNum");
        TextBox price = GetField<TextBox>(form, "txtPrice");

        hobbySelector.Items.Add("01 - Board Games");
        updateGroup.Visible = true;
        description.Text = "Board Games";
        playerCount.Text = "4";
        price.Text = "12.50";

        InvokePrivate(form, "ResetForm");

        Assert.IsFalse(updateGroup.Visible);
        Assert.AreEqual(-1, hobbySelector.SelectedIndex);
        Assert.AreEqual(string.Empty, description.Text);
        Assert.AreEqual(string.Empty, playerCount.Text);
        Assert.AreEqual(string.Empty, price.Text);
    }

    [STATestMethod]
    public void BackMenuItem_ClosesUpdateFormAndShowsParent()
    {
        using var parent = new frmMainMenu { Visible = false };
        using var form = new frmUpdateHobby(parent);

        InvokePrivate(form, "mnuBack_Click", null!, EventArgs.Empty);

        Assert.IsTrue(parent.Visible);
        Assert.IsTrue(form.IsDisposed);
    }

    private static T GetField<T>(object instance, string name) where T : class
    {
        return (T)(typeof(frmUpdateHobby)
            .GetField(name, BindingFlags.Instance | BindingFlags.NonPublic)!
            .GetValue(instance)!);
    }

    private static void InvokePrivate(object instance, string name, params object[] arguments)
    {
        typeof(frmUpdateHobby)
            .GetMethod(name, BindingFlags.Instance | BindingFlags.NonPublic)!
            .Invoke(instance, arguments);
    }
}
