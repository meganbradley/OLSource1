---
title: "CWinApp::GetApplicationRecoveryPingInterval"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CWinApp.GetApplicationRecoveryPingInterval"
  - "CWinApp::GetApplicationRecoveryPingInterval"
  - "GetApplicationRecoveryPingInterval"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetApplicationRecoveryPingInterval method"
ms.assetid: 005df5e6-dc48-45d1-8142-e9284427303d
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::GetApplicationRecoveryPingInterval
Returns the length of time that the restart manager waits for the recovery callback function to return.  
  
## Syntax  
  
```  
virtual DWORD GetApplicationRecoveryPingInterval();  
```  
  
## Return Value  
 The length of time in milliseconds.  
  
## Remarks  
 When an application that is registered with the restart manager exits unexpectedly, the application tries to save open documents and calls the recovery callback function. The default recovery callback function is [CWinApp::ApplicationRecoveryCallback](../vs140/cwinapp--applicationrecoverycallback.md).  
  
 The length of time that the framework waits for the recovery callback function to return is the ping interval. You can customize the ping interval by overriding `CWinApp::GetApplicationRecoveryPingInterval` or by providing a custom value to `RegisterWithRestartManager`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::RegisterWithRestartManager](../vs140/cwinapp--registerwithrestartmanager.md)   
 [CWinApp::ApplicationRecoveryCallback](../vs140/cwinapp--applicationrecoverycallback.md)