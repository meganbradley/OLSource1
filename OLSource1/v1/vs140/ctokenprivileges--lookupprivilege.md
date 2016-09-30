---
title: "CTokenPrivileges::LookupPrivilege"
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
  - "LookupPrivilege"
  - "ATL.CTokenPrivileges.LookupPrivilege"
  - "CTokenPrivileges::LookupPrivilege"
  - "ATL::CTokenPrivileges::LookupPrivilege"
  - "CTokenPrivileges.LookupPrivilege"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LookupPrivilege method"
ms.assetid: e799456a-b7b2-4fa3-a591-8f2200c9061e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTokenPrivileges::LookupPrivilege
Retrieves the attribute associated with a given privilege name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the name of the privilege, as defined in the WINNT.H header file. For example, this parameter could specify the constant SE_SECURITY_NAME, or its corresponding string, "SeSecurityPrivilege."  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a variable that receives the attributes.  
  
## Return Value  
 Returns true if the attribute is successfully retrieved, false otherwise.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CTokenPrivileges Class](../vs140/ctokenprivileges-class.md)   
 [CTokenPrivileges::GetNamesAndAttributes](../vs140/ctokenprivileges--getnamesandattributes.md)   
 [CTokenPrivileges::GetDisplayNames](../vs140/ctokenprivileges--getdisplaynames.md)   
 [CTokenPrivileges::GetLuidsAndAttributes](../vs140/ctokenprivileges--getluidsandattributes.md)