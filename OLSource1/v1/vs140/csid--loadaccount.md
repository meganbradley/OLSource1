---
title: "CSid::LoadAccount"
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
  - "ATL::CSid::LoadAccount"
  - "CSid::LoadAccount"
  - "LoadAccount"
  - "ATL.CSid.LoadAccount"
  - "CSid.LoadAccount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadAccount method"
ms.assetid: 40de7fec-2c1a-4083-8d02-660518fe38cb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::LoadAccount
Updates the `CSid` object given the account name and domain, or an existing SID (security identifier) structure.  
  
## Syntax  
  
```  
bool LoadAccount(  
   LPCTSTR pszAccountName,  
   LPCTSTR pszSystem = NULL   
) throw(...);  
bool LoadAccount(  
   const SID * pSid,  
   LPCTSTR pszSystem = NULL   
) throw(...);  
```  
  
#### Parameters  
 `pszAccountName`  
 The account name.  
  
 `pszSystem`  
 The system name. This string can be the name of a remote computer. If this string is NULL, the local system is used instead.  
  
 `pSid`  
 A pointer to a [SID](http://msdn.microsoft.com/library/windows/desktop/aa379594\(v=vs.85\).aspx) structure.  
  
## Return Value  
 Returns **true** on success, **false** on failure. To get extended error information, call `GetLastError`.  
  
## Remarks  
 `LoadAccount` attempts to find a security identifier for the specified name. See [LookupAccountSid](http://msdn.microsoft.com/library/windows/desktop/aa379166\(v=vs.85\).aspx) for more details.  
  
## Requirements  
 Header: atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)