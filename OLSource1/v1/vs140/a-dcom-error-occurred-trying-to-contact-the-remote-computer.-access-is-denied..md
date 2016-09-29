---
title: "A DCOM error occurred trying to contact the remote computer. Access is denied."
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.remote.dcom_access_denied"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
helpviewer_keywords: 
  - "remote debugging, DCOM error"
  - "remote DCOM access denied error"
  - "DCOM, access errors"
ms.assetid: 9d7dfc1b-9fe0-4f54-9c50-9c0e0f8358c5
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A DCOM error occurred trying to contact the remote computer. Access is denied.
Remote debugging uses DCOM to communicate between the local and remote computers in the following situations:  
  
-   The debugger is set to **Native Compatibility Mode** or **Managed Compatibility Mode** is checked in the **Tools / Options / Debugging** page  
  
-   You are debugging managed C++ (C++/CLI) code.  
  
-   In Visual Studio 2013, when **Enable native Edit and Continue** is checked in the **Tools / Options / Debugging** page  
  
-   Some third party debugging scenarios  
  
 This error occurs when the Visual Studio process cannot authenticate itself (or the supplied credentials were deemed insufficient) to the remote debugger process over DCOM. One or more of the following workarounds might resolve the issue:  
  
-   Turn off  **Native Compatibility Mode** and **Managed Compatibility Mode**.  
  
-   In Visual Studio 2013, turn off **Enable native Edit and Continue**.  
  
-   Reboot both computers.  
  
-   If remote debugging requires entering credentials, check the option to save the credentials.  
  
## See Also  
 [Remote Debugging Errors and Troubleshooting](../vs140/remote-debugging-errors-and-troubleshooting.md)   
 [Remote Debugging](../vs140/remote-debugging.md)