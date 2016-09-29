---
title: "Remote Debugging Across Domains"
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
  - "remote debugging, security restrictions"
  - "domains, remote debugging"
  - "Terminal Server, remote debugging across domains"
  - "remote debugging, across domains"
  - "TCP/IP, remote debugging"
  - "DCOM, remote debugging"
ms.assetid: 8e697ce1-55e8-4ab0-a05f-f87225e2f29b
caps.latest.revision: 35
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Remote Debugging Across Domains
Remote debugging involves two-way communication between the [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] debugger and the Visual Studio Remote Debugging Monitor (`msvsmon.exe`). For remote debugging to work, it is important which user runs Visual Studio and also which user runs msvsmon.exe.  
  
 To connect to `msvsmon`, you must run Visual Studio under the same user account as `msvsmon` or under an administrator account. (You can also configure `msvsmon` to accept connections from other users.)  
  
 Visual Studio accepts connections from `msvsmon` if `msvsmon` is running as a user who can be authenticated on the Visual Studio computer. (The user must have a local account on the Visual Studio computer.)  
  
 With these restrictions, remote debugging works in various scenarios, including the following:  
  
-   Two domains without two-way trust.  
  
-   Two computers on a workgroup.  
  
-   One computer on a workgroup, and the other on a domain.  
  
-   Running the remote debugging monitor (`msvsmon`) or Visual Studio as a local account.  
  
 Therefore, you must have a local user account on each computer, and both accounts must have the same user name and password. If you want to run `msvsmon` and Visual Studio under different user accounts, you must have two user accounts on each computer.  
  
 You can run Visual Studio under a domain account if the domain account has the same name and password as a local account. You must still have local accounts that have the same user name and password on each computer.  
  
 For Windows XP Professional computers on a workgroup, the local security setting may prevent remote debugging. The policy must be set to **Classic** for remote debugging to work. (This concern does not apply to Windows XP computers that are joined to a domain or to computers that are running Windows Server 2003 or more recent versions of Windows Server, Windows Vista, or Windows 7.  
  
### To change the security policy to allow remote debugging between domains (Windows XP Professional)  
  
1.  On the local computer, choose **Control Panel** on the **Start** menu.  
  
2.  In Control Panel, double-click **Administrator tools**.  
  
3.  In the **Administrative tools** window, double-click **Local Security Policy**.  
  
4.  Under **Security Settings**, open the **Local Policies** folder.  
  
5.  In the **Local Policies** folder, select **Security Options**.  
  
6.  In the **Policy** column, find **Network access: sharing and security model for local accounts** and double-click it.  
  
7.  In the **Network access: sharing and security model for local accounts** dialog box, change the setting from **Guest only - local users authenticate as Guest** to **Classic - local users authenticate as themselves** and click **OK**.  
  
8.  Close the window and restart the computer.  
  
9. Repeat steps 1 to 8 on the remote computer.  
  
     You can now do remote debugging using the same user name on both computers.  
  
    > [!CAUTION]
    >  Changing the security model to Classic can result in unexpected access to shared files and DCOM components. If you make this change, a remote user can authenticate with your local user account instead of Guest. If a remote user matches your user name and password, that user will be able to access any folder or DCOM object you have shared out. If you use this security model, make sure that all user accounts on the computer have strong passwords or set up an isolated network island for the debugging and debugged computers to prevent unauthorized access.  
  
## See Also  
 [Remote Debugging](../vs140/remote-debugging.md)