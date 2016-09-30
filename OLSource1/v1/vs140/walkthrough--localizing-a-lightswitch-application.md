---
title: "Walkthrough: Localizing a LightSwitch Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ls.Internationalization"
ms.assetid: 38ee6092-6130-40d1-967b-6a542df2edf3
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Localizing a LightSwitch Application
You can create a LightSwitch application that automatically displays UI in a variety of languages through a Silverlight client, an HTML client, or both. In this walkthrough, you’ll create an application and both types of clients and then localize it into German (or another language for which you can provide translations).  
  
 To localize the application, you’ll add a resource identifier for each display string in the Screen Designer. Then, for both the client and server tiers, you'll create a resource file for the default language and one for the localized language. You can localize an application even if it has only one type of client. We've included both types so that you can practice localizing each.  
  
> [!NOTE]
>  If you are localizing only a SilverLight client, you may need to upgrade it first. On the menu bar, choose **Project**, **Upgrade Project**. If the **Upgrade Project** command doesn’t appear, the project is already upgraded.  
  
 This walkthrough shows how to accomplish the following tasks:  
  
-   [Create the Application](#CREATE)  
  
-   [Localize the Server Tier](#SERVER)  
  
-   [Localize the Silverlight Client Screen](#LOCSL)  
  
-   [Add Default Language Resources](#DEFAULT)  
  
-   [Add Localized Resources](#LOC)  
  
-   [Call a Resource From Code](#CODE)  
  
-   [Localize an HTML Client](#HTML)  
  
## Prerequisites  
 You need [!INCLUDE[lswitch_v3](../vs140/includes/lswitch_v3_md.md)] to localize a LightSwitch application.  
  
##  \<a name="CREATE"></a>  
  
#### To create the application  
  
1.  Create an application by using either the **LightSwitch HTML Application (Visual Basic)** template or the **LightSwitch HTML Application (Visual C#)** template, and then name it **Localization Sample**.  
  
2.  Add a table, name it **Contact**, and then add the following fields:  
  
    |Name|Type|Required|  
    |----------|----------|--------------|  
    |ContactName|String|Yes|  
    |ContactPhone|Phone Number|Yes|  
  
3.  In **Solution Explorer**, open the shortcut menu for the **Localization_Sample.HTML Client** node, and then choose **Add Screen**.  
  
4.  Add a **Browse Data** screen that's named **BrowseContacts**, and then choose **Contacts** as the **Screen Data**.  
  
5.  In **Solution Explorer**, open the shortcut menu for the **HTML Client** node, and then choose **Add Screen**.  
  
6.  Add a **Add/Edit Details** screen that's named **AddEditContact**, and then choose **Contact** as the **Screen Data**.  
  
7.  Open the **BrowseContacts** screen and in the Screen Designer, open the shortcut menu for the **Rows Layout &#124; Contact List** node, and then choose **Add Button**.  
  
8.  In the **Add Button** dialog box, in the **showTab** list choose **showAddEditContact**.  
  
9. In the **Contact** field enter **(New Contact)**, and then choose the **OK** button.  
  
10. In **Solution Explorer**, open the shortcut menu for the **Localization Sample** node, and then choose **Add Client**.  
  
11. Accept the default **Desktop Client**, and then choose the **OK** button.  
  
12. In **Solution Explorer**, open the shortcut menu for the **Desktop Client** node, and then choose **Add Screen**.  
  
13. Add a **New Data** screen that's named **NewContact**, and then choose **Contact** as the **Screen Data**.  
  
14. In the Screen Designer, choose the **Add** node, and then choose **Add Text**.  
  
15. In the **Edit Text** dialog box, enter `Add a new contact here`.  
  
##  \<a name="SERVER"></a>  
  
#### To localize the server tier  
  
1.  In **Solution Explorer**, expand the **Data Sources** node, and then open the **Contacts.lsml** entity.  
  
2.  In the **Entity Designer**, choose the **ContactName** field.  
  
3.  In the **Properties** window, choose the **Display Name** property, and then enter `$(ContactName)`.  
  
     The $() notation signifies that the value for the **Display Name** property is a resource identifier. At run time, LightSwitch will retrieve the actual value from a resource file.  
  
    > [!NOTE]
    >  Resource identifiers can contain only letters and numbers, not spaces.  
  
4.  In the **Entity Designer**, choose the **ContactPhone** field.  
  
5.  In the **Properties** window, choose the **Display Name** property, and then enter `$(ContactPhone)`.  
  
6.  In **Solution Explorer**,  open the shortcut menu for the **Localization Sample.Server** node, choose **Add**, and then choose **New Item**.  
  
7.  Add a **Resources File**, and then name it `Service.resx`.  
  
    > [!IMPORTANT]
    >  You must always name the server resource file for any LightSwitch application **Service.resx**, and the file must be in the root node of the server project.  
  
8.  Add the following values to the resource file:  
  
    |Name|Value|  
    |----------|-----------|  
    |ContactName|Name|  
    |ContactPhone|Phone|  
  
     The values in the **Name** column match the resource identifiers that you added earlier, but the values don't have the $() notation. The **Value** strings will appear on any screen that uses the **Contacts** entity.  
  
9. In **Solution Explorer**, open the shortcut menu for the **Localization Sample.Server** node, choose **Add**, and then choose **New Item**.  
  
10. Add a **Resources File**, and then name it `Service.de-DE.resx`.  
  
11. Add the following values to the resource file:  
  
    |Name|Value|  
    |----------|-----------|  
    |ContactName|Kontaktname|  
    |ContactPhone|Telefonnummer|  
  
     The localized **Value** string will appear on any screen that uses the Contacts entity. Now you can run the application and verify that the strings for **ContactName** and **ContactPhone** appear correctly. You can also deploy the application to a computer that's set to German and verify that the localized strings appear.  
  
    > [!TIP]
    >  As a best practice, consider localizing the strings for all entities on the server tier first. Those strings will appear on any screen that uses the entities, and you can override the strings at the screen level as needed.  
  
##  \<a name="LOCSL"></a>  
  
#### To localize the Silverlight client screen  
  
1.  In **Solution Explorer**, open the **NewContact.lsml** screen.  
  
2.  In the Screen Designer, choose the **Rows Layout &#124; New Contact** node.  
  
3.  In the **Properties** window, choose the **Display Name** property, and then enter `$(AddContact)`.  
  
4.  In the Screen Designer, open the shortcut menu for the **Text** node, and then choose **Edit Content**.  
  
5.  In the **Properties** window, replace the existing text with `$(Text)`.  
  
     If you run the application at this point, you’ll notice that the actual resource identifiers appear on the screen. Don’t worry — you’ll fix that in the next step by creating a default file for language resources.  
  
##  \<a name="DEFAULT"></a>  
  
#### To add a default file for language resources  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Localization Sample.DesktopClient** node, choose **Add**, and then choose **New Item**.  
  
2.  Add a **Resources File**, and then name it `Client.resx`.  
  
    > [!IMPORTANT]
    >  For any Silverlight client of a LightSwitch application, you must always name the default file for language resources **Client.resx**, and the file must be in the root node of the client project.  
  
3.  Add the following values to the resource file:  
  
    |Name|Value|  
    |----------|-----------|  
    |AddContact|Add Contact|  
    |Text|Add the contact information, and then choose the Save button.|  
    |||  
  
     The values in the **Name** column match the resource identifiers that you added earlier, but the values don't have the $() notation. The values in the **Value** column are the strings that will appear when a user runs the application in the language that is set as the **Default Language** in the application settings.  
  
##  \<a name="LOC"></a>  
  
#### To add a localized resource file  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Localization Sample.DesktopClient** node, choose **Add**, and then choose **New Item**.  
  
2.  Add a **Resources File**, and then name it `Client.de-DE.resx`.  
  
    > [!IMPORTANT]
    >  You must always name localized resource files **Client.***LocaleID***.resx**, where *LocaleID* is the Windows Locale ID for the language that you’re targeting, and the files must be in the root node of the client project. If you chose a language other than German, enter the Locale ID for that language instead of **de-DE**, and provide your own translations in the next step.  
  
3.  Add the following values to the resource file:  
  
    |Name|Value|  
    |----------|-----------|  
    |AddContact|Einen Newen Kontakt erstellen|  
    |Text|Fügen Sie die Kontaktinformationen hinzu und speichern Sie dann.|  
  
     These strings will appear when you run the application on a computer that's set to German (or whatever language you chose). If you want to localize into multiple languages, add a resource file for each additional language.  
  
    > [!NOTE]
    >  For a Silverlight client that’s localized into multiple languages, the active Windows language pack determines which language will appear.  
  
##  \<a name="CODE"></a>  
  
#### To call a resource from code  
  
1.  In **Solution Explorer**, open the **Service.resx** file, and then add the following values to it:  
  
    |Name|Value|  
    |----------|-----------|  
    |ErrorMessage|Name can’t contain an exclamation mark.|  
  
2.  Open the **Service.de-DE.resx** file, and then add the following values:  
  
    |Name|Value|  
    |----------|-----------|  
    |ErrorMessage|Name darf keine Ausrufezeichen enthalten.|  
  
3.  In **Solution Explorer**, open the **Contacts.lsml** entity.  
  
4.  In the Entity Designer, in the **Write Code** list, choose the **Contacts_Validate** method.  
  
    > [!NOTE]
    >  Make sure that the entity itself is selected and not an entity field. Otherwise, a build error will occur.  
  
5.  In the **Code Editor**, add an `Imports` or `using` statement:  
  
    ```vb  
    Imports My.Resources  
    ```  
  
    ```c#  
    using System;  
    using System.Collections.Generic;  
    using System.Linq;  
    using System.Reflection;  
    using System.Resources;  
    using System.Text;  
    using Microsoft.LightSwitch;  
    using Microsoft.LightSwitch.Security.Server;  
    namespace LightSwitchApplication  
    ```  
  
6.  Add the following code to the `Contacts_Validate` method:  
  
    ```vb  
    If entity.ContactName.Contains(“!”) Then  
                    results.AddEntityError(Service.ErrorMessage)  
                End If  
    ```  
  
    ```c#  
    if (entity.ContactName.Contains("!"))  
                {  
                    ResourceManager serviceResources = new ResourceManager(  
                        "LightSwitchApplication.Service", Assembly.GetExecutingAssembly());  
                results.AddEntityError(serviceResources.GetString("ErrorMessage"));  
                }  
    ```  
  
     Now you can run the application, enter a new contact name that contains an exclamation mark, save, and verify that the error message appears. You can also deploy the application to a computer that's set to German and verify that the message appears in German.  
  
##  \<a name="HTML"></a>  
  
#### To localize the HTML client  
  
1.  In **Solution Explorer**, open the **BrowseContacts.lsml** screen.  
  
2.  In the Screen Designer, choose the **Show Add Edit Contact** node.  
  
3.  In the **Properties** window, choose the **Display Name** property, and then enter `$(add)`.  
  
4.  In **Solution Explorer**, expand the **Localization Sample.HTMLClient** node, open the shortcut menu for the **Content** node, choose **Add**, and then choose **New Folder**.  
  
5.  Name the folder `Resources`.  
  
6.  Open the shortcut menu for the **Resources** node, choose **Add**, and then choose **New Item**.  
  
7.  Add a **Resources File (.resjson)** item, and then name it **client.lang-en-US.resjson**.  
  
    > [!IMPORTANT]
    >  In any HTML client for a LightSwitch application, you must always name the default file for language resources **client.lang-***LocaleID***.resjson**, where *LocaleID* is the Windows Locale ID for the language on your development computer. Unlike the Silverlight client, the HTML client doesn't have the concept of a default language.  
  
8.  In the **Code Editor**, replace the code with the following:  
  
    ```javascript  
    {  
       “add” : “Add a Contact”,  
       “errorMessage” :  “Name can’t contain an exclamation mark.“  
    }  
    ```  
  
9. Open the shortcut menu for the **Resources** node, choose **Add**, and then choose **New Item**.  
  
10. Add another **Resources File (.resjson)** item, and then name it **client.lang-de-DE.resjson**.  
  
11. In the **Code Editor**, replace the code with the following:  
  
    ```javascript  
    {  
       “add” : “Hinzufügen eines Kontakts”,  
       “errorMessage” :  “Name darf keine Ausrufezeichen enthalten.“  
  
    }  
    ```  
  
12. In **Solution Explorer**, open the shortcut menu for the **Localization Sample.HTMLClient** node, and then choose **Set as StartUp Client**.  
  
13. Open the **AddEditContact.lsml** screen, and then, in the Screen Designer, in the **Write Code** list, replace the code in the **beforeApplyChanges** method with the following:  
  
    ```javascript  
    myapp.AddEditContact.beforeApplyChanges = function (screen) {  
        if (screen.Contact.ContactName.indexOf('!') != -1) {  
            screen.findContentItem("ContactName").validationResults = [  
                new msls.ValidationResult(  
                    screen.Contact.details.properties.ContactName,  
                    WinJS.Resources.getString("/client/errorMessage").value  
                )  
            ];  
            return false;  
        }  
  
    };  
  
    ```  
  
     Now you can run the application and verify that the string for the **Add a Contact** button and the error message appear correctly. You can also deploy the application to a computer with a browser that's set to German and verify that the localized strings appear.  
  
    > [!NOTE]
    >  For an HTML client that’s localized into multiple languages, the browser language setting determines which language will appear.  
  
## Next Steps  
 That’s all you must do to localize a LightSwitch application. You may have noticed that many parts of the user interface, such as the screen command bar and the navigation menu, are localized automatically. You can override the automatic translations by adding resource identifiers to the **Display Name** or **Description** properties of the appropriate elements. In fact, you can localize just about any part of your LightSwitch application by using the techniques that you’ve just learned.  
  
## See Also  
 [Projects: The Container for Your Application](../vs140/projects--the-container-for-your-lightswitch-application.md)   
 [The Resource Fallback Process](assetId:///b224d7c0-35f8-4e82-a705-dd76795e8d16#cpconpackagingdeployingresourcesanchor1)   
 [National Language Support (NLS) API Reference](http://msdn.microsoft.com/goglobal/bb896001.aspx)