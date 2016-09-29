---
title: "CTokenPrivileges::GetLuidsAndAttributes"
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
  - "CTokenPrivileges::GetLuidsAndAttributes"
  - "ATL.CTokenPrivileges.GetLuidsAndAttributes"
  - "GetLuidsAndAttributes"
  - "ATL::CTokenPrivileges::GetLuidsAndAttributes"
  - "CTokenPrivileges.GetLuidsAndAttributes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLuidsAndAttributes method"
ms.assetid: 84b32749-f7ed-4fd6-8c3d-3073095477af
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTokenPrivileges::GetLuidsAndAttributes
Retrieves the locally unique identifiers (LUIDs) and attribute flags from the `CTokenPrivileges` object.  
  
## Syntax  
  
```  
  
      void GetLuidsAndAttributes(  
   CLUIDArray * pPrivileges,  
   CAttributes * pAttributes = NULL   
) const throw(...);  
```  
  
#### Parameters  
 `pPrivileges`  
 Pointer to an array of [LUID](http://msdn.microsoft.com/library/windows/desktop/aa379261) objects. **CLUIDArray** is a typedef defined as **CAtlArray<LUID\> CLUIDArray**.  
  
 `pAttributes`  
 Pointer to an array of DWORD objects. If this parameter is omitted or NULL, the attributes are not retrieved. **CAttributes** is a typedef defined as **CAtlArray <DWORD\> CAttributes**.  
  
## Remarks  
 This method will enumerate all of the privileges contained in the `CTokenPrivileges` access token object and place the individual LUIDs and (optionally) the attribute flags into array objects.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CTokenPrivileges Class](../vs140/ctokenprivileges-class.md)   
 [CTokenPrivileges::GetNamesAndAttributes](../vs140/ctokenprivileges--getnamesandattributes.md)   
 [CTokenPrivileges::LookupPrivilege](../vs140/ctokenprivileges--lookupprivilege.md)   
 [CTokenPrivileges::GetDisplayNames](../vs140/ctokenprivileges--getdisplaynames.md)   
 [LUID_AND_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379263)