---
title: "Walkthrough: Inserting Data with the ServerApplicationContext"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 9d140748-7653-4219-aada-0f63db4c4035
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Inserting Data with the ServerApplicationContext
The ServerApplicationContext API lets you access the middle tier (a.k.a. the server tier) of your LightSwitch application from other clients such as web applications that don't understand OData. In this walkthrough you’ll create two .aspx pages to add and view data for a LightSwitch application.  
  
### To create the LightSwitch application  
  
1.  On the menu bar, choose **File**, **New**, **Project**.  
  
2.  In the **New Project** dialog, expand the **Visual Basic** or **Visual C#** node, choose **LightSwitch**, and then choose the **LightSwitch HTML Application** template.  
  
3.  In the **Name** text box, enter `BirthdayTracker`, and then choose the **OK** button.  
  
4.  In **Solution Explorer**, open the shortcut menu for the **Data Sources** node and choose **Add Table**.  
  
5.  In the entity designer, choose the title bar, and then in the **Properties** window choose the **Name** property and enter `Birthday`.  
  
6.  In the entity designer, add the following fields:  
  
    |Name|Type|Required|  
    |----------|----------|--------------|  
    |Name|String|Yes|  
    |BirthDate|Date|Yes|  
  
7.  On the **Perspective** bar choose **HTMLClient**, and then on the toolbar choose the **Screen** button.  
  
8.  In the **Add New Screen** dialog box choose the **Common Screen Set** template, name it `Birthdays` and in the **Screen Data** list choose **Birthdays**, and then choose the **OK** button.  
  
### To add a data entry page  
  
1.  In **Solution Explorer**, open the shortcut menu for the **BirthdayTracker.Server** node and choose **Add**, **Web Form**.  
  
2.  In the **Specify Name for Item** dialog box, enter `AddBirthday.aspx`, and then choose the **OK** button.  
  
3.  In the **AddBirthday.aspx** designer, add the following between the <div\> and </div\> tags:  
  
    ```html  
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
            <asp:Button ID="Button1" runat="server" Text="Add" />  
    ```  
  
4.  On the menu bar, choose **View**, **Code**.  
  
5.  In the Code Editor, replace the existing code with the following code:  
  
    ```vb  
    Public Class AddBirthday  
        Inherits System.Web.UI.Page  
  
        Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click  
            Using Context As ServerApplicationContext = ServerApplicationContext.CreateContext()  
  
                Dim b As Birthday = Context.DataWorkspace.ApplicationData.Birthdays.AddNew()  
                b.Name = TextBox1.Text  
                b.BirthDate = Date.Today  
                Context.DataWorkspace.ApplicationData.SaveChanges()  
            End Using  
        End Sub  
  
    End Class  
    ```  
  
    ```c#  
    public class AddBirthday : System.Web.UI.Page  
    {  
  
    protected void Button1_Click(object sender, EventArgs e)  
    {  
    using (ServerApplicationContext Context = ServerApplicationContext.CreateContext()) {  
  
    Birthday b = Context.DataWorkspace.ApplicationData.Birthdays.AddNew();  
    b.Name = TextBox1.Text;  
    b.BirthDate = System.DateTime.Today;  
    Context.DataWorkspace.ApplicationData.SaveChanges();  
    }  
    }  
  
    }  
  
    ```  
  
     The code calls the `CreateContext()` method to create a temporary instance of the `ServerApplicationContext`, and then the `AddNew()` and **SaveChanges()** methods of the context are called to add data to the **Birthdays** entity.  
  
### To add a display page  
  
1.  In **Solution Explorer**, open the shortcut menu for the **BirthdayTracker.Server** node and choose **Add**, **Web Form**.  
  
2.  In the **Specify Name for Item** dialog box, enter `TodaysBirthdays.aspx`, and then choose the **OK** button.  
  
3.  On the menu bar, choose **View**, **Code**.  
  
4.  In the Code Editor, replace the existing code with the following code:  
  
    ```vb  
    Public Class TodaysBirthdays  
        Inherits System.Web.UI.Page  
  
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load  
            Response.Write("Celebrating their birthday today are:" + "<br>" + vbCrLf)  
            Using Context As ServerApplicationContext = ServerApplicationContext.CreateContext()  
                For Each b As Birthday In Context.DataWorkspace.ApplicationData.Birthdays  
                    If b.BirthDate = Date.Today Then  
                        Response.Write(b.Id.ToString() + " " + b.Name + " " + b.BirthDate + "<br>" + vbCrLf)  
                    End If  
                Next  
            End Using  
        End Sub  
  
    End Class  
    ```  
  
    ```c#  
    public class TodaysBirthdays : System.Web.UI.Page  
    {  
  
    protected void Page_Load(object sender, System.EventArgs e)  
    {  
    Response.Write("Celebrating their birthday today are:" + "<br>" + Constants.vbCrLf);  
    using (ServerApplicationContext Context = ServerApplicationContext.CreateContext()) {  
    foreach (Birthday b in Context.DataWorkspace.ApplicationData.Birthdays) {  
    if (b.BirthDate == System.DateTime.Today) {  
    Response.Write(b.Id.ToString() + " " + b.Name + " " + b.BirthDate + "<br>" + Constants.vbCrLf);  
    }  
    }  
    }  
    }  
    public TodaysBirthdays()  
    {  
    Load += Page_Load;  
    }  
  
    }  
  
    ```  
  
     The code calls the `CreateContext()` method to create a temporary instance of the `ServerApplicationContext`, and then loops through the **Birthdays** collection to return all records where the **BirthDate** equals today’s date.  
  
### To test the application  
  
1.  Run the application, and in the address bar of the browser, copy the port number portion of the URL, for example: http://localhost:**12345**/HTMLClient/.  
  
2.  Open a new browser tab and enter `http://localhost:`*12345*`/AddBirthday.aspx`, replacing *12345* with the port number.  
  
3.  On the **AddBirthday** web page, choose the text box and enter a name, and then choose the **Add** button.  
  
4.  In the text box, replace the name that you just entered with another name, and then choose the **Add** button.  
  
5.  Switch back to the **BirthdaysSet** application and refresh the page.  
  
     You should see the two names that you just entered.  
  
6.  Choose the **Add** button, and in the **Birthdays** dialog box enter a name and a birthdate other than the current date, and then choose the **Save** button.  
  
7.  Open a new browser tab and enter `http://localhost:`*12345*`/TodaysBirthdays.aspx`, replacing *12345* with the port number.  
  
     You should see two entries for the names that you entered on the **AddBirthday** web page, but not the one you entered in the application itself.  
  
## Next Steps  
  
## See Also  
 [LightSwitch ServerApplicationContext](../vs140/lightswitch-serverapplicationcontext.md)   
 [ServerApplicationContext API Reference](../vs140/serverapplicationcontext-api-reference.md)