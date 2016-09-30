---
title: "Walkthrough: Filtering My.Application.Log Output (Visual Basic)"
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
  - "My.Log object, filtering output"
  - "My.Application.Log object, filtering output"
  - "application event logs, output filtering"
ms.assetid: 2c0a457a-38a4-49e1-934d-a51320b7b4ca
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Filtering My.Application.Log Output (Visual Basic)
This walkthrough demonstrates how to change the default log filtering for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object, to control what information is passed from the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object to the listeners and what information is written by the listeners. You can change the logging behavior even after building the application, because the configuration information is stored in the application's configuration file.  
  
## Getting Started  
 Each message that <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> writes has an associated severity level, which filtering mechanisms use to control the log output. This sample application uses <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> methods to write several log messages with different severity levels.  
  
#### To build the sample application  
  
1.  Open a new [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] Windows Application project.  
  
2.  Add a button named Button1 to Form1.  
  
3.  In the \<xref:System.Windows.Forms.Control.Click*> event handler for Button1, add the following code:  
  
     [!code[VbVbcnMyApplicationLogFiltering#1](../vs140/codesnippet/VisualBasic/walkthrough--filtering-my.application.log-output--visual-basic-_1.vb)]  
  
4.  Run the application in the debugger.  
  
5.  Press **Button1**.  
  
     The application writes the following information to the application's debug output and log file.  
  
     <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
6.  Close the application.  
  
     For information on how to view the application's debug output window, see [Output Window](../vs140/output-window.md). For information on the location of the application's log file, see [Walkthrough: Determining Where My.Application.Log Writes Information](../vs140/walkthrough--determining-where-my.application.log-writes-information--visual-basic-.md).  
  
    > [!NOTE]
    >  By default, the application flushes the log-file output when the application closes.  
  
     In the example above, the second call to the \<xref:Microsoft.VisualBasic.Logging.Log.WriteEntry*> method and the call to the \<xref:Microsoft.VisualBasic.Logging.Log.WriteException*> method produces log output, while the first and last calls to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method do not. This is because the severity levels of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are "Information" and "Error", both of which are allowed by the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object's default log filtering. However, events with "Start" and "Stop" severity levels are prevented from producing log output.  
  
## Filtering for All My.Application.Log Listeners  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object uses a \<xref:System.Diagnostics.SourceSwitch*> named <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to control which messages it passes from the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> methods to the log listeners. You can configure <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> in the application's configuration file by setting its value to one of the \<xref:System.Diagnostics.SourceLevels*> enumeration values. By default, its value is "Information".  
  
 This table shows the severity level required for Log to write a message to the listeners, given a particular <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> setting.  
  
|||  
|-|-|  
|DefaultSwitch Value|Message severity required for output|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|All messages are allowed.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|All messages are blocked.|  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> methods each have an overload that does not specify a severity level. The implicit severity level for the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> overload is "Information", and the implicit severity level for the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> overload is "Error".  
  
 This table explains the log output shown in the previous example: with the default <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> setting of "Information", only the second call to the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> method and the call to the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> method produce log output.  
  
#### To log only activity tracing events  
  
1.  Right-click app.config in the **Solution Explorer** and select **Open**.  
  
     -or-  
  
     If there is no app.config file:  
  
    1.  On the **Project** menu, choose **Add New Item**.  
  
    2.  From the **Add New Item** dialog box, choose **Application Configuration File**.  
  
    3.  Click **Add**.  
  
2.  Locate the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> section, which is in the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> section, which is in the top-level <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> section.  
  
3.  Find the element that adds <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to the collection of switches. It should look similar to this element:  
  
     <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  
4.  Change the value of the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> attribute to "ActivityTracing".  
  
5.  The content of the app.config file should be similar to the following XML:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
6.  Run the application in the debugger.  
  
7.  Press **Button1**.  
  
     The application writes the following information to the application's debug output and log file:  
  
     <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  
8.  Close the application.  
  
9. Change the value of the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> attribute back to "Information".  
  
    > [!NOTE]
    >  The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> switch setting controls only <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>. It does not change how the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] \<xref:System.Diagnostics.Trace*?displayProperty=fullName> and \<xref:System.Diagnostics.Debug*?displayProperty=fullName> classes behave.  
  
## Individual Filtering For My.Application.Log Listeners  
 The previous example shows how to change the filtering for all <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> output. This example demonstrates how to filter an individual log listener. By default, an application has two listeners that write to the application's debug output and the log file.  
  
 The configuration file controls the behavior of the log listeners by allowing each one to have a filter, which is similar to a switch for <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>. A log listener will output a message only if the message's severity is allowed by both the log's <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> and the log listener's filter.  
  
 This example demonstrates how to configure filtering for a new debug listener and add it to the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object. The default debug listener should be removed from the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object, so it is clear that the debug messages come from the new debug listener.  
  
#### To log only activity-tracing events  
  
1.  Right-click app.config in the **Solution Explorer** and choose **Open**.  
  
     -or-  
  
     If there is no app.config file:  
  
    1.  On the **Project** menu, choose **Add New Item**.  
  
    2.  From the **Add New Item** dialog box, choose **Application Configuration File**.  
  
    3.  Click **Add**.  
  
2.  Right-click app.config in **Solution Explorer**. Choose **Open**.  
  
3.  Locate the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> section, in the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> section with the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> attribute "DefaultSource", which is under the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> section. The <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> section is under the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> section, in the top-level <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> section.  
  
4.  Add this element to the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> section:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  Locate the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> section, in the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> section, in the top-level <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> section.  
  
6.  Add this element to that <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> section:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     The \<xref:System.Diagnostics.EventTypeFilter*> filter takes one of the \<xref:System.Diagnostics.SourceLevels*> enumeration values as its <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> attribute.  
  
7.  The content of the app.config file should be similar to the following XML:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
8.  Run the application in the debugger.  
  
9. Press **Button1**.  
  
     The application writes the following information to the application's log file:  
  
     <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  
     The application writes less information to the application's debug output because of the more restrictive filtering.  
  
     <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
  
10. Close the application.  
  
 For more information about changing log settings after deployment, see [Working with Application Logs in Visual Basic](../vs140/working-with-application-logs-in-visual-basic.md).  
  
## See Also  
 [Walkthrough: Determining Where My.Application.Log Writes Information](../vs140/walkthrough--determining-where-my.application.log-writes-information--visual-basic-.md)   
 [Walkthrough: Changing Where My.Application.Log Writes Information](../vs140/walkthrough--changing-where-my.application.log-writes-information--visual-basic-.md)   
 [Walkthrough: Creating Custom Log Listeners](../vs140/walkthrough--creating-custom-log-listeners--visual-basic-.md)   
 [How to: Write Log Messages](../vs140/how-to--write-log-messages--visual-basic-.md)   
 [Trace Switches](assetId:///8ab913aa-f400-4406-9436-f45bc6e54fbe)   
 [Logging Information from the Application](../vs140/logging-information-from-the-application--visual-basic-.md)