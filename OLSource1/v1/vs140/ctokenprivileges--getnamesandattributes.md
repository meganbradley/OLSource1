---
title: "CTokenPrivileges::GetNamesAndAttributes"
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
  - "ATL::CTokenPrivileges::GetNamesAndAttributes"
  - "CTokenPrivileges.GetNamesAndAttributes"
  - "ATL.CTokenPrivileges.GetNamesAndAttributes"
  - "CTokenPrivileges::GetNamesAndAttributes"
  - "GetNamesAndAttributes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNamesAndAttributes method"
ms.assetid: 179bf960-de23-4d36-ae1d-49556e9c8bca
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTokenPrivileges::GetNamesAndAttributes
Retrieves the name and attribute flags from the `CTokenPrivileges` object.  
  
## Syntax  
  
```  
  
      void GetNamesAndAttributes(  
   CNames * pNames,  
   CAttributes * pAttributes = NULL   
) const throw(...);  
```  
  
#### Parameters  
 *pNames*  
 Pointer to an array of `CString` objects. **CNames** is a typedef defined as **CAtlArray \<CString> CNames**.  
  
 `pAttributes`  
 Pointer to an array of DWORD objects. If this parameter is omitted or NULL, the attributes are not retrieved. **CAttributes** is a typedef defined as **CAtlArray \<DWORD> CAttributes**.  
  
## Remarks  
 This method will enumerate all of the privileges contained in the `CTokenPrivileges` object, placing the name and (optionally) the attribute flags into array objects.  
  
 This method retrieves the attribute name, rather than the displayable name: for example, if the attribute name is SE_REMOTE_SHUTDOWN_NAME, the system name is "SeRemoteShutdownPrivilege." To obtain the displayable name, use the method [CTokenPrivileges::GetDisplayNames](../vs140/ctokenprivileges--getdisplaynames.md).  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CTokenPrivileges Class](../vs140/ctokenprivileges-class.md)   
 [CTokenPrivileges::GetDisplayNames](../vs140/ctokenprivileges--getdisplaynames.md)   
 [CTokenPrivileges::LookupPrivilege](../vs140/ctokenprivileges--lookupprivilege.md)   
 [CTokenPrivileges::GetLuidsAndAttributes](../vs140/ctokenprivileges--getluidsandattributes.md)