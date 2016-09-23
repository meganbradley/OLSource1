---
title: "How to: Correct Run-Time Errors with the Exception Assistant"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - JScript
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - debugging [C#], Exception Assistant
  - run-time errors, correcting
  - debugging [J#], Exception Assistant
  - exceptions, correcting
  - Exception Assistant, enabling
  - debugging [Visual Studio], Exception Assistant
  - debugging [Visual Basic], Exception Assistant
  - Exception Assistant, run-time exceptions
ms.assetid: 23b08d45-7b20-42c9-bdc9-fb3157ad823b
caps.latest.revision: 31
robots: noindex,nofollow
---
# How to: Correct Run-Time Errors with the Exception Assistant
The **Exception Assistant**, which appears whenever a run-time exception occurs in the debugger, shows the type of exception, troubleshooting tips, and corrective actions that may be applied through the **Exception Assistant**.  
  
 An exception is an object that inherits from the <xref:System.Exception?qualifyHint=False> class. An exception is thrown by code whenever a problem occurs; it is passed up the stack until the application handles it or the program fails.  
  
> [!NOTE]
>  The options available in dialog boxes, and the names and locations of menu commands you see, might differ from what is described in Help, depending on your active settings or edition. This Help page was written for users who have selected **General Development Settings**. To change your settings, select **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
 The following table lists the actions that may appear in the **Exception Assistant Actions** pane:  
  
|Action|Description|  
|------------|-----------------|  
|**Find out more about the exception**|Displays the properties of the exception object, which can be copied to the Clipboard.|  
|**Add permission**.|Adds necessary security permissions.|  
  
### To enable or disable Exception Assistant  
  
1.  On the **Tools** menu, click **Options**.  
  
2.  In the **Options** dialog box, open the **Debugging** node and click **General**.  
  
3.  In the **General** box, select or clear **Enable the exception assistant**.  
  
### To apply an action from the Exception Assistant Actions pane  
  
-   Click the action you want to perform.  
  
## See Also  
 [Exception Assistant Dialog Box](../vs140/exception-assistant-dialog-box.md)   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)   
 [Choosing When to Use Structured and Unstructured Exception Handling (Visual Basic)](assetId:///e897d7ca-07e8-45dd-8a6d-a5b2a2fc9b9a)   
 [Handling and Throwing Exceptions](assetId:///f99a1d29-a2a8-47af-9707-9909f9010735)