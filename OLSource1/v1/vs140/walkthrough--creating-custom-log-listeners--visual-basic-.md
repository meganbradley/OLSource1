---
title: "Walkthrough: Creating Custom Log Listeners (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "custom log listeners"
  - "My.Application.Log object, custom log listeners"
ms.assetid: 0e019115-4b25-4820-afb1-af8c6e391698
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Creating Custom Log Listeners (Visual Basic)
This walkthrough demonstrates how to create a custom log listener and configure it to listen to the output of the `My.Application.Log` object.  
  
## Getting Started  
 Log listeners must inherit from the <xref:System.Diagnostics.TraceListener*> class.  
  
#### To create the listener  
  
-   In your application, create a class named `SimpleListener` that inherits from <xref:System.Diagnostics.TraceListener*>.  
  
     [!code[VbVbalrMyApplicationLog#16](../vs140/codesnippet/VisualBasic/walkthrough--creating-custom-log-listeners--visual-basic-_1.vb)]  
  
     The [Write](assetId:///M:System.Diagnostics.TraceListener.Write(System.String)?qualifyHint=False&autoUpgrade=True) and [WriteLine](assetId:///M:System.Diagnostics.TraceListener.WriteLine(System.String)?qualifyHint=False&autoUpgrade=True) methods, required by the base class, call `MsgBox` to display their input.  
  
     The <xref:System.Security.Permissions.HostProtectionAttribute*> attribute is applied to the assetId:///M:System.Diagnostics.TraceListener.Write(System.String)?qualifyHint=False&autoUpgrade=True and assetId:///M:System.Diagnostics.TraceListener.WriteLine(System.String)?qualifyHint=False&autoUpgrade=True methods so that their attributes match the base class methods. The <xref:System.Security.Permissions.HostProtectionAttribute*> attribute allows the host that runs the code to determine that the code exposes host-protection synchronization.  
  
    > [!NOTE]
    >  The <xref:System.Security.Permissions.HostProtectionAttribute*> attribute is effective only on unmanaged applications that host the common language runtime and that implement host protection, such as SQL Server.  
  
 To ensure that `My.Application.Log` uses your log listener, you should strongly name the assembly that contains your log listener.  
  
 The next procedure provides some simple steps for creating a strongly named log-listener assembly. For more information, see [Creating and Using Strong-Named Assemblies](assetId:///ffbf6d9e-4a88-4a8a-9645-4ce0ee1ee5f9).  
  
#### To strongly name the log-listener assembly  
  
1.  Have a project selected in **Solution Explorer**. On the **Project** menu, choose **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).  
  
2.  Click the **Signing** tab.  
  
3.  Select the **Sign the assembly** box.  
  
4.  Select **<New\>** from the **Choose a strong name key file** drop-down list.  
  
     The **Create Strong Name Key** dialog box opens.  
  
5.  Provide a name for the key file in the **Key file name** box.  
  
6.  Enter a password in the **Enter password** and **Confirm password** boxes.  
  
7.  Click **OK**.  
  
8.  Rebuild the application.  
  
## Adding the Listener  
 Now that the assembly has a strong name, you need to determine the strong name of the listener so that `My.Application.Log` uses your log listener.  
  
 The format of a strongly named type is as follows.  
  
 <type name\>, <assembly name\>, <version number\>, <culture\>, <strong name\>  
  
#### To determine the strong name of the listener  
  
-   The following code shows how to determine the strongly named type name for `SimpleListener`.  
  
     [!code[VbVbalrMyApplicationLog#17](../vs140/codesnippet/VisualBasic/walkthrough--creating-custom-log-listeners--visual-basic-_2.vb)]  
  
     The strong name of the type depends on your project.  
  
 With the strong name, you can add the listener to the `My.Application.Log` log-listener collection.  
  
#### To add the listener to My.Application.Log  
  
1.  Right-click on app.config in the **Solution Explorer** and choose **Open**.  
  
     -or-  
  
     If there is an app.config file:  
  
    1.  On the **Project** menu, choose **Add New Item**.  
  
    2.  From the **Add New Item** dialog box, choose **Application Configuration File**.  
  
    3.  Click **Add**.  
  
2.  Locate the `<listeners>` section, in the `<source>` section with the `name` attribute "DefaultSource", located in the `<sources>` section. The `<sources>` section is located in the `<system.diagnostics>` section, in the top-level `<configuration>` section.  
  
3.  Add this element to the `<listeners>` section:  
  
    ```  
    <add name="SimpleLog" />  
    ```  
  
4.  Locate the `<sharedListeners>` section, in the `<system.diagnostics>` section, in the top-level `<configuration>` section.  
  
5.  Add this element to that `<sharedListeners>` section:  
  
    ```  
    <add name="SimpleLog" type="SimpleLogStrongName" />  
    ```  
  
     Change the value of `SimpleLogStrongName` to be the strong name of the listener.  
  
## See Also  
 <xref:Microsoft.VisualBasic.Logging.Log*?displayProperty=fullName>   
 [Working with Application Logs in Visual Basic](../vs140/working-with-application-logs-in-visual-basic.md)   
 [How to: Log Exceptions in Visual Basic](../vs140/how-to--log-exceptions-in-visual-basic.md)   
 [How to: Write Log Messages](../vs140/how-to--write-log-messages--visual-basic-.md)   
 [Walkthrough: Changing Where My.Application.Log Writes Information](../vs140/walkthrough--changing-where-my.application.log-writes-information--visual-basic-.md)