---
title: "Walkthrough: Changing Where My.Application.Log Writes Information (Visual Basic)"
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
  - "My.Application.Log object, walkthroughs"
  - "event logs, changing output location"
ms.assetid: ecc74f95-743c-450d-93f6-09a30db0fe4a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Changing Where My.Application.Log Writes Information (Visual Basic)
You can use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> objects to log information about events that occur in your application. This walkthrough shows how to override the default settings and cause the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object to write to other log listeners.  
  
## Prerequisites  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object can write information to several log listeners. You need to determine the current configuration of the log listeners before changing the configurations. For more information, see [Walkthrough: Determining Where My.Application.Log Writes Information](../vs140/walkthrough--determining-where-my.application.log-writes-information--visual-basic-.md).  
  
 You may want to review [How to: Write Event Information to a Text File](../vs140/how-to--write-event-information-to-a-text-file--visual-basic-.md) or [How to: Write Event Information to an Application Event Log](../vs140/how-to--write-to-an-application-event-log--visual-basic-.md).  
  
### To add listeners  
  
1.  Right-click app.config in **Solution Explorer** and choose **Open**.  
  
     \- or -  
  
     If there is no app.config file:  
  
    1.  On the **Project** menu, choose **Add New Item**.  
  
    2.  From the **Add New Item** dialog box, select **Application Configuration File**.  
  
    3.  Click **Add**.  
  
2.  Locate the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> section, under the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> section with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute "DefaultSource", in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> section. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> section is in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> section, in the top-level <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> section.  
  
3.  Add these elements to that <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> section.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  Uncomment the log listeners that you want to receive <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> messages.  
  
5.  Locate the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> section, in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> section, in the top-level <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> section.  
  
6.  Add these elements to that <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> section.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
7.  The content of the app.config file should be similar to the following XML:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### To reconfigure a listener  
  
1.  Locate the listener's <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> element from the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> section.  
  
2.  The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> attribute gives the name of the listener type. This type must inherit from the \<xref:System.Diagnostics.TraceListener*> class. Use the strongly named type name to ensure that the right type is used. For more information, see the "To reference a strongly named type" section below.  
  
     Some types that you can use are:  
  
    -   A \<xref:Microsoft.VisualBasic.Logging.FileLogTraceListener*?displayProperty=fullName> listener, which writes to a file log.  
  
    -   A \<xref:System.Diagnostics.EventLogTraceListener*?displayProperty=fullName> listener, which writes information to the computer event log specified by the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter.  
  
    -   The \<xref:System.Diagnostics.DelimitedListTraceListener*?displayProperty=fullName> and \<xref:System.Diagnostics.XmlWriterTraceListener*?displayProperty=fullName> listeners, which write to the file specified in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter.  
  
    -   A \<xref:System.Diagnostics.ConsoleTraceListener*?displayProperty=fullName> listener, which writes to the command-line console.  
  
     For information about where other types of log listeners write information, consult that type's documentation.  
  
3.  When the application creates the log-listener object, it passes the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> attribute as the constructor parameter. The meaning of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> attribute depends on the trace listener.  
  
4.  After creating the log listener, the application sets the listener's properties. These properties are defined by the other attributes in the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> element. For more information on the properties for a particular listener, see the documentation for that listener's type.  
  
### To reference a strongly named type  
  
1.  To ensure that the right type is used for your log listener, make sure to use the fully qualified type name and the strongly named assembly name. The syntax of a strongly named type is as follows:  
  
     \<*type name*>, \<*assembly name*>, \<*version number*>, \<*culture*>, \<*strong name*>  
  
2.  This code example shows how to determine the strongly named type name for a fully qualified type—"System.Diagnostics.FileLogTraceListener" in this case.  
  
     [!code[VbVbalrMyApplicationLog#15](../vs140/codesnippet/VisualBasic/walkthrough--changing-where-my.application.log-writes-information--visual-basic-_1.vb)]  
  
     This is the output, and it can be used to uniquely reference a strongly named type, as in the "To add listeners" procedure above.  
  
     <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Logging.Log*?displayProperty=fullName>   
 \<xref:System.Diagnostics.TraceListener*>   
 \<xref:Microsoft.VisualBasic.Logging.FileLogTraceListener*?displayProperty=fullName>   
 \<xref:System.Diagnostics.EventLogTraceListener*?displayProperty=fullName>   
 [How to: Write Event Information to a Text File](../vs140/how-to--write-event-information-to-a-text-file--visual-basic-.md)   
 [How to: Write Event Information to an Application Event Log](../vs140/how-to--write-to-an-application-event-log--visual-basic-.md)