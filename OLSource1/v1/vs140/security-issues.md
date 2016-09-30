---
title: "Security Issues"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "security [Debugging SDK]"
  - "debugging [Debugging SDK], security"
ms.assetid: d6ffff0a-afb4-4f38-86d8-476c881c4e4b
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Security Issues
To debug a program using Visual Studio, the only permissions needed are the same ones a developer needs to run the program. This includes remote debugging for most situations (some situations involving other services, such as the Internet Information Service, may require a higher level of permissions).  
  
 While Visual Studio is running, the process debug manager (PDM) tracks debug processes on the local machine. Remotely, a program called msvsmon.exe is started by the developer to handle remote debugging and make the PDM available. (Note that msvsmon.exe is not a service and must be started manually to enable remote debugging on that machine.) When Visual Studio (or msvsmon.exe) is not running, no processes are tracked for debugging.  
  
 This means that a developer can debug programs he or she started with no special permissions. The developer can even debug processes started by someone else if that other person is a member of the same security group. And to enable remote debugging, it is necessary only to copy the necessary files to the remote machine and start msvsmon.exe (see [How to: Set Up Remote Debugging](../vs140/set-up-the-remote-tools-on-the-device.md) for more details).  
  
## See Also  
 [Debugging Tasks](../vs140/debugging-tasks.md)   
 [Process Debug Manager](../vs140/process-debug-manager.md)   
 [How to: Set Up Remote Debugging](../vs140/set-up-the-remote-tools-on-the-device.md)