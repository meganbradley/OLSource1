---
title: "Client-Side Script Debugging"
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
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging [Visual Studio], client-side scripts"
  - "client-side scripts, debugging"
ms.assetid: bb668527-2288-47bd-a6c8-cecbad76dde2
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Client-Side Script Debugging
The Visual Studio  debugger provides a comprehensive debugging environment for finding and correcting errors in client-side scripts in ASP.NET pages.  
  
## Opening Script Documents  
 You can see lists of server-side and client-side script documents in the **Solution Explorer** to view . You can open any script document from **Solution Explorer**. For more information, see [How to: View Script Documents](../vs140/how-to--view-script-documents.md).  
  
## Breakpoint Mapping  
 In Visual Studio, you cannot directly debug server-side code, but you can set a breakpoint in a server-side file. Visual Studio automatically maps the breakpoint to a corresponding location in the client-side file and creates a mapped breakpoint in the client-side code.  
  
## Manually or Automatically Attaching to Script  
 To begin debugging script in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], the debugger must attach to the script you want to debug. This can happen manually or automatically.  
  
 You can manually attach by using the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] debugger interface to choose a running script process you want to attach to. For more information, see [How to: Attach to Script](../vs140/how-to--attach-to-script.md).  
  
 The debugger automatically attaches to script when one of the following things occurs:  
  
-   You hit a breakpoint set in script.  
  
-   You hit a VBScript `Stop` statement or JScript `debugger` statement in your script code.  
  
-   The browser or server encounters a syntax or run time error in your script. When this occurs, a dialog box appears and have the option to begin debugging.  
  
 When you manually attach to script, the script process continues to run until it is somehow halted. You can halt it by choosing **Break** on the **Debug** menu.  
  
 When the debugger attaches automatically, script execution is halted at the line where the breakpoint, `Stop` statement or `debugger` statement, or error occurred, or at the point where you chose to start debugging in Internet Explorer.  
  
 At that point, you can use the normal debugger facilities to begin debugging. For example, you can use **Step** commands to continue to execute your code line by line. You can use the **Call Stack** window to view and control script flow. You can use the variable windows or **Immediate** window to view or change variables and properties.  
  
## Enhanced Error Messages for Script Debugging  
 Visual Studio provides enhanced error messages for common script debugging problems. These messages do not appear unless you attach to Internet Explorer manually. If you encounter an error condition when Internet Explorer is opened automatically, try manually attaching so that you can see the error messages.  
  
## Debugging AJAX Script Applications  
 AJAX-enabled Web applications make heavy use of script code and pose special debugging challenges. For information about AJAX debugging techniques, see  
  
 [Debugging and Tracing AJAX Applications Overview](assetId:///92684ea0-7bb4-4a34-9203-3aa6394ce375).  
  
## See Also  
 [Debugging ASP.NET and AJAX Applications](../vs140/debugging-asp.net-and-ajax-applications.md)   
 [Limitations on Script Debugging](../vs140/limitations-on-script-debugging.md)   
 [Variable Windows](../vs140/variable-windows.md)   
 [Immediate Window](../vs140/immediate-window.md)   
 [Debugging and Tracing AJAX Applications Overview](assetId:///92684ea0-7bb4-4a34-9203-3aa6394ce375)