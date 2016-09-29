---
title: "Start  the Remote Debugging Monitor"
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
  - "JScript"
helpviewer_keywords: 
  - "remote debugging, Remote Debugging Monitor"
  - "msvsmon.exe"
  - "Remote Debugging Monitor, running"
ms.assetid: 55b60ce7-834b-4e83-a10e-fe4248260a4c
caps.latest.revision: 57
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Start  the Remote Debugging Monitor
The Remote Debugging Monitor (msvsmon.exe) is a small application that [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] connects to for remote debugging. During remote debugging, [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] runs on one computer (the debugger host) and the Remote Debugging Monitor runs on a remote computer together with the applications that you are debugging.  
  
 Before you can start remote debugging, you must set up remote debugging. For more information, see [How to: Set Up Remote Debugging](../vs140/set-up-the-remote-tools-on-the-device.md).  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
 **Permissions**  
  
 The Visual Studio user must have permission to connect to the remote debugger. By default, administrators on the remote machine can connect to the remote debugger. To grant permissions to other users, see[Configuring the remote debugger](../vs140/set-up-the-remote-tools-on-the-device.md#BKMK_Configuring_the_remote_debugger).  
  
 For information about permissions for remote debugging across domains or between workgroup computers, see [Remote Debugging Across Domains](../vs140/remote-debugging-across-domains.md).  
  
### To start the remote debugging monitor  
  
1.  On the remote computer, find **Visual Studio 2013 Remote Debugger** on the **Start** menu.  
  
     -or-  
  
     Run msvsmon.exe at the Windows Command Prompt.  
  
     The **Remote Debugging Monitor** runs as a Windows application. The user interface shows that the **Remote Debugging Monitor** is running and makes remote debugging easy to set up.  
  
## Running the Remote Debugging Service (ASP.NET and Other Server Environments)  
 For debugging in [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] and other server environments, you can run the Remote Debugging Monitor as a Windows service (the Remote Debugger Service.)  
  
#### To configure the remote debugging monitor as a service  
  
1.  Find **Visual Studio Remote Debugger Configuration Wizard** on the **Start** menu.  
  
2.  Follow the steps in the wizard to set up remote debugging as a service.  
  
## See Also  
 [Debugging in Visual Studio](../vs140/debugging-in-visual-studio.md)   
 [Remote Debugging](../vs140/remote-debugging.md)   
 [How to: Set Up Remote Debugging](../vs140/set-up-the-remote-tools-on-the-device.md)   
 [Remote Debugging Across Domains](../vs140/remote-debugging-across-domains.md)   
 [Remote Debugging Errors and Troubleshooting](../vs140/remote-debugging-errors-and-troubleshooting.md)   
 [Just-In-Time Debugging](../vs140/just-in-time-debugging-in-visual-studio.md)