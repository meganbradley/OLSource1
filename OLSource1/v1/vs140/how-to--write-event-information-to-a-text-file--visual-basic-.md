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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write Event Information to a Text File (Visual Basic)
You can use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects to log information about events that occur in your application. This example shows how to use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method to log tracing information to a log file.  
  
### To add and configure the file log listener  
  
1.  Right-click app.config in **Solution Explorer** and choose **Open**.  
  
     \- or -  
  
     If there is no app.config file:  
  
    1.  On the **Project** menu, choose **Add New Item**.  
  
    2.  From the **Add New Item** dialog box, choose **Application Configuration File**.  
  
    3.  Click **Add**.  
  
2.  Locate the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> section in the application configuration file.  
  
     You will find the \<listeners> section in the \<source> section with the name attribute "DefaultSource", which is nested under the \<system.diagnostics> section, which is nested under the top-level \<configuration> section.  
  
3.  Add this element to that <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> section:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  Locate the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> section in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> section, nested under the top-level <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> section.  
  
5.  Add this element to that <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> section:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     Change the value of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute to the log directory.  
  
    > [!NOTE]
    >  To set the value of a listener property, use an attribute that has the same name as the property, with all letters in the name lowercase. For example, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> attributes set the values of the \<xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.Location*> and \<xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.CustomLocation*> properties.  
  
### To write event information to the file log  
  
-   Use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method to write information to the file log. For more information, see [How to: Write Log Messages](../vs140/how-to--write-log-messages--visual-basic-.md) and [How to: Log Exceptions in Visual Basic](../vs140/how-to--log-exceptions-in-visual-basic.md).  
  
     After you configure the file log listener for an assembly, it receives all messages that <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> writes from that assembly.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Logging.Log*?displayProperty=fullName>   
 \<xref:Microsoft.VisualBasic.Logging.Log.WriteEntry*>   
 \<xref:Microsoft.VisualBasic.Logging.Log.WriteException*>   
 [Working with Application Logs in Visual Basic](../vs140/working-with-application-logs-in-visual-basic.md)   
 [How to: Log Exceptions in Visual Basic](../vs140/how-to--log-exceptions-in-visual-basic.md)