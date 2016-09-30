---
title: "How to: Use the Exception Assistant"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "exception object"
  - "exceptions, correcting"
  - "debugging [Visual Studio], Exception Assistant"
  - "Exception Assistant, about Exception Assistant"
  - "exceptions, Exception Assistant"
ms.assetid: e0a78c50-7318-4d54-af51-40c00aea8711
caps.latest.revision: 25
robots: noindex,nofollow
---
# How to: Use the Exception Assistant
The **Exception Assistant**, which appears whenever a run-time exception occurs, shows the type of exception, troubleshooting tips, and corrective actions. The **Exception Assistant** can also be used to see the details of an exception object.  
  
 An exception is an object that inherits from the \<xref:System.Exception*> class. An exception is thrown by code when a problem occurs, and it is passed up the stack until the application handles it or the program fails.  
  
> [!NOTE]
>  The options available in dialog boxes, and the names and locations of menu commands you see, might differ from what is described in Help, depending on your active settings or edition. This Help page was written with **General Development Settings** in mind. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
 The following table lists and describes an exception object's properties. Depending on the type of exception, not all may appear.  
  
|Property|Description|  
|--------------|-----------------|  
|Data|An \<xref:System.Collections.IDictionary*> object that contains user-defined key/value pairs. The default is an empty collection.|  
|FileName|Name of the file causing the exception.|  
|FusionLog|Log file that describes why an assembly load failed.|  
|\<xref:System.Exception.HelpLink*>|Link to the help file associated with the exception.|  
|\<xref:System.Exception.HResult*>|Coded numerical value assigned to a specific exception.|  
|\<xref:System.Exception.InnerException*>|\<xref:System.Exception*> instance that caused the current exception. It is sometimes useful to catch an exception thrown in a helper routine and throw a new exception more indicative of the error, thereby providing more information. In such cases, the \<xref:System.Exception.InnerException*> property is set to the original exception.|  
|\<xref:System.Exception.Message*>|Message associated with the exception. This is displayed in the language specified by the \<xref:System.Threading.Thread.CurrentUICulture*> property of the thread that throws the exception.|  
|\<xref:System.Exception.Source*>|Name of the application or object that caused the exception. If \<xref:System.Exception.Source*> is not set, the name of the assembly where the exception originated is returned.|  
|\<xref:System.Exception.StackTrace*>|String representation of the method calls on the call stack at the time the current exception was thrown. The stack trace includes the source-file name and program line number if debugging information is available. \<xref:System.Exception.StackTrace*> may not report as many method calls as expected, due to code transformations that occur during optimization. The stack trace is captured immediately before an exception is thrown.|  
|\<xref:System.Exception.TargetSite*>|Method that throws the current exception. If the method that throws the exception is not available and the stack trace is not a null reference (`Nothing` in Visual Basic), \<xref:System.Exception.TargetSite*> obtains the method from the stack trace. If the stack trace is a null reference, \<xref:System.Exception.TargetSite*> also returns a null reference.|  
  
### To find out more about an exception object  
  
-   Click **View Details** in the **Actions** pane. A dialog box appears showing the properties of the exception.  
  
## See Also  
 [How to: Map HRESULTs and Exceptions](assetId:///610b364b-2761-429d-9c4a-afbc3e66f1b9)   
 [Exception Assistant Dialog Box](../vs140/exception-assistant-dialog-box.md)   
 [How to: Correct Run-Time Errors with the Exception Assistant](../vs140/how-to--correct-run-time-errors-with-the-exception-assistant.md)   
 [Choosing When to Use Structured and Unstructured Exception Handling (Visual Basic)](assetId:///e897d7ca-07e8-45dd-8a6d-a5b2a2fc9b9a)   
 [Handling and Throwing Exceptions](assetId:///f99a1d29-a2a8-47af-9707-9909f9010735)   
 [How to: Check an Exception's Inner Exception (Visual Basic)](assetId:///c15abdfc-ddf5-4e2e-beb1-41786a9a0157)