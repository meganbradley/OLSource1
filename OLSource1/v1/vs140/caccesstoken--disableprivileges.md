---
title: "CAccessToken::DisablePrivileges"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - DisablePrivileges
  - ATL::CAccessToken::DisablePrivileges
  - CAccessToken.DisablePrivileges
  - ATL.CAccessToken.DisablePrivileges
  - CAccessToken::DisablePrivileges
dev_langs: 
  - C++
helpviewer_keywords: 
  - DisablePrivileges method
ms.assetid: 8cffe2ac-3973-42c1-b2f3-f44c80f7a21c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAccessToken::DisablePrivileges
Call this method to disable one or more privileges in the `CAccessToken` object.  
  
## Syntax  
  
```  
  
      bool DisablePrivileges(  
   const CAtlArray< LPCTSTR >& rPrivileges,  
   CTokenPrivileges* pPreviousState = NULL  
) throw(...);  
```  
  
#### Parameters  
 `rPrivileges`  
 Pointer to an array of strings containing the privileges to disable in the `CAccessToken` object.  
  
 `pPreviousState`  
 Pointer to a `CTokenPrivileges` object which will contain the previous state of the privileges.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::DisablePrivilege](../vs140/caccesstoken--disableprivilege.md)   
 [CAccessToken::EnablePrivileges](../vs140/caccesstoken--enableprivileges.md)