---
title: "How to: Write to an Application Event Log (Visual Basic)"
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
  - "Computer.EventLog element"
  - "WriteEntry method"
  - "My.Computer.EventLog element"
  - "event logs, writing to"
ms.assetid: cadbc8c1-87af-4746-934e-55b79a4f6e2b
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write to an Application Event Log (Visual Basic)
You can use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects to write information about events that occur in your application. This example shows how to configure an event log listener so <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> writes tracing information to the Application event log.  
  
 You cannot write to the Security log. In order to write to the System log, you must be a member of the LocalSystem or Administrator account.  
  
 To view an event log, you can use **Server Explorer** or **Windows Event Viewer**. For more information, see [ETW Events in the .NET Framework](assetId:///d186276f-6afb-4dfd-bf3c-4251edc2c299).  
  
> [!NOTE]
>  Event logs are not supported on Windows 95, Windows 98, or Windows Millennium Edition.  
  
### To add and configure the event log listener  
  
1.  Right-click app.config in **Solution Explorer** and choose **Open**.  
  
     \- or -  
  
     If there is no app.config file,  
  
    1.  On the **Project** menu, choose **Add New Item**.  
  
    2.  From the **Add New Item** dialog box, choose **Application Configuration File**.  
  
    3.  Click **Add**.  
  
2.  Locate the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> section in the application configuration file.  
  
     You will find the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> section in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> section with the name attribute "DefaultSource", which is nested under the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> section, which is nested under the top-level <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> section.  
  
3.  Add this element to that <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> section:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  Locate the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> section, in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> section, in the top-level <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> section.  
  
5.  Add this element to that <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> section:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     Replace <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> with the name of your application.  
  
    > [!NOTE]
    >  Typically, an application writes only errors to the event log. For information on filtering log output, see [Walkthrough: Filtering My.Application.Log Output](../vs140/walkthrough--filtering-my.application.log-output--visual-basic-.md).  
  
### To write event information to the event log  
  
-   Use the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method to write information to the event log. For more information, see [How to: Write Log Messages](../vs140/how-to--write-log-messages--visual-basic-.md) and [How to: Log Exceptions in Visual Basic](../vs140/how-to--log-exceptions-in-visual-basic.md).  
  
     After you configure the event log listener for an assembly, it receives all messages that <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> writes from that assembly.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Logging.Log*?displayProperty=fullName>   
 \<xref:Microsoft.VisualBasic.Logging.Log.WriteEntry*>   
 \<xref:Microsoft.VisualBasic.Logging.Log.WriteException*>   
 [Working with Application Logs in Visual Basic](../vs140/working-with-application-logs-in-visual-basic.md)   
 [How to: Log Exceptions in Visual Basic](../vs140/how-to--log-exceptions-in-visual-basic.md)   
 [Walkthrough: Determining Where My.Application.Log Writes Information](../vs140/walkthrough--determining-where-my.application.log-writes-information--visual-basic-.md)