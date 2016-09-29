---
title: "Sids::NetworkService"
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
  - "Sids.NetworkService"
  - "NetworkService"
  - "Sids::NetworkService"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NetworkService function"
ms.assetid: 28da06a1-04ae-4829-af20-01879127ec9c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Sids::NetworkService
Returns the SECURITY_NETWORK_SERVICE_RID SID.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
CSid NetworkService() throw(...);  
```  
  
## Remarks  
 Use NetworkService to enable the NT AUTHORITY\NetworkService user to read a CPerfMon security object. NetworkService adds a SecurityAttribute to the ATLServer code which will allow the DLL to login under the NetworkService account on [!INCLUDE[WinXpFamily](../vs140/includes/winxpfamily_md.md)] and greater operating system.  
  
 When custom log counters are created with ATLServer CPerfMon class in the Perfmon MMC, the counters may not appear when viewing the log file although they will appear correctly in the realtime view. CPerfMon custom performance counters don't have the necessary permissions to run under the "Performance Logs and Alerts" service (smlogsvc.exe) on [!INCLUDE[WinXpFamily](../vs140/includes/winxpfamily_md.md)] (or greater) operating systems. This service runs under the "NT AUTHORITY\NetworkService" account.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [Security Identifier Global Functions](../vs140/security-identifier-global-functions.md)