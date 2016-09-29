---
title: "The Windows Security Model"
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
  - "security, Windows Vista"
  - "User Access Control, remote debugging with"
  - "remote debugging, on Windows Vista"
  - "Windows Vista, remote debugging"
ms.assetid: d84258cf-2c08-478b-86bb-b2bcd7798208
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# The Windows Security Model
[!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] introduced a new security model for user accounts. This model, also used in [!INCLUDE[win7](../vs140/includes/win7_md.md)] and [!INCLUDE[winsvr08](../vs140/includes/winsvr08_md.md)], provides a more secure and trustworthy environment.  
  
 Like [!INCLUDE[winxp](../vs140/includes/winxp_md.md)], the new security model includes standard user accounts and administrator accounts. However, these two account types are now implemented and used in a more secure way. On [!INCLUDE[winxp](../vs140/includes/winxp_md.md)], if you ran under an administrative account, you had administrative privileges at all times. If you ran under a standard account, you did not have administrative privileges. The only way for a standard user to gain administrative privileges was to use the **Run As** command and select an administrator account.  
  
 On [!INCLUDE[winxp](../vs140/includes/winxp_md.md)], many users would run as administrator at all times, even when they performed routine, non-administrative tasks that did not require administrative privileges. The result was a vulnerability that could be exploited by malicious software.  
  
 The new security model does not grant administrative privileges at all times. Even administrators run under standard privileges when they perform non-administrative tasks that do not require elevated privileges. The result is greater security because users are no longer running with unnecessary privileges that can be maliciously exploited. This feature is known as User Access Control, or UAC.  
  
 By default, the operating system now runs in *Admin Approval Mode*. In Admin Approval Mode, the UAC dialog box appears every time that you try to perform an action that requires administrator privileges, whether you are running as a standard user or an administrator. If you are running as a standard user, the UAC dialog box prompts you to enter an Administrator account name and password, which are required to continue. If you are running as an administrator, the UAC dialog box asks you to confirm that you want to perform the procedure using you current administrator credentials. It also gives you the option of entering a new administrator account and password to continue using.  
  
 For more information about the new security model, see:  
  
-   [Windows Vista: User Account Control](http://go.microsoft.com/fwlink/?LinkId=181808)  
  
-   [Windows Vista: Security and Encryption](http://go.microsoft.com/fwlink/?LinkId=181809)  
  
## See Also  
 [How to: Set Up Remote Debugging](../vs140/set-up-the-remote-tools-on-the-device.md)