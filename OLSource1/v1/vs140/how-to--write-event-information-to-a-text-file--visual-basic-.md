---
title: "How to: Write Event Information to a Text File (Visual Basic)"
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
  - "event logs [Visual Studio], writing event information"
  - "text files, writing event information to a text file"
  - "events [Visual Basic], writing event information to a text file"
ms.assetid: 9ca7cc03-bf99-4933-9e5e-61ee28e9a6b4
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write Event Information to a Text File (Visual Basic)
You can use the `My.Application.Log` and `My.Log` objects to log information about events that occur in your application. This example shows how to use the `My.Application.Log.WriteEntry` method to log tracing information to a log file.  
  
### To add and configure the file log listener  
  
1.  Right-click app.config in **Solution Explorer** and choose **Open**.  
  
     \- or -  
  
     If there is no app.config file:  
  
    1.  On the **Project** menu, choose **Add New Item**.  
  
    2.  From the **Add New Item** dialog box, choose **Application Configuration File**.  
  
    3.  Click **Add**.  
  
2.  Locate the `<listeners>` section in the application configuration file.  
  
     You will find the <listeners\> section in the <source\> section with the name attribute "DefaultSource", which is nested under the <system.diagnostics> section, which is nested under the top-level <configuration\> section.  
  
3.  Add this element to that `<listeners>` section:  
  
    ```  
    <add name="FileLogListener" />  
    ```  
  
4.  Locate the `<sharedListeners>` section in the `<system.diagnostics>` section, nested under the top-level `<configuration>` section.  
  
5.  Add this element to that `<sharedListeners>` section:  
  
    ```  
    <add name="FileLogListener"   
        type="Microsoft.VisualBasic.Logging.FileLogTraceListener,   
              Microsoft.VisualBasic, Version=8.0.0.0, Culture=neutral,   
              PublicKeyToken=b03f5f7f11d50a3a"  
        initializeData="FileLogListenerWriter"  
        location="Custom"  
        customlocation="c:\temp\" />  
    ```  
  
     Change the value of the `customlocation` attribute to the log directory.  
  
    > [!NOTE]
    >  To set the value of a listener property, use an attribute that has the same name as the property, with all letters in the name lowercase. For example, the `location` and `customlocation` attributes set the values of the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.Location*> and <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.CustomLocation*> properties.  
  
### To write event information to the file log  
  
-   Use the `My.Application.Log.WriteEntry` or `My.Application.Log.WriteException` method to write information to the file log. For more information, see [How to: Write Log Messages](../vs140/how-to--write-log-messages--visual-basic-.md) and [How to: Log Exceptions in Visual Basic](../vs140/how-to--log-exceptions-in-visual-basic.md).  
  
     After you configure the file log listener for an assembly, it receives all messages that `My.Application.Log` writes from that assembly.  
  
## See Also  
 <xref:Microsoft.VisualBasic.Logging.Log*?displayProperty=fullName>   
 [WriteEntry](assetId:///M:Microsoft.VisualBasic.Logging.Log.WriteEntry(System.String)?qualifyHint=False&autoUpgrade=True)   
 [WriteException](assetId:///M:Microsoft.VisualBasic.Logging.Log.WriteException(System.Exception)?qualifyHint=False&autoUpgrade=True)   
 [Working with Application Logs in Visual Basic](../vs140/working-with-application-logs-in-visual-basic.md)   
 [How to: Log Exceptions in Visual Basic](../vs140/how-to--log-exceptions-in-visual-basic.md)