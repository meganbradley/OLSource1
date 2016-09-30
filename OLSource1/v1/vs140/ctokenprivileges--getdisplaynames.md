---
title: "CTokenPrivileges::GetDisplayNames"
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
  - "CTokenPrivileges::GetDisplayNames"
  - "CTokenPrivileges.GetDisplayNames"
  - "ATL.CTokenPrivileges.GetDisplayNames"
  - "GetDisplayNames"
  - "ATL::CTokenPrivileges::GetDisplayNames"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CNames typedef"
  - "GetDisplayNames method"
ms.assetid: c686de70-eddc-41d3-9ea8-fe89b4d383eb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTokenPrivileges::GetDisplayNames
Retrieves display names for the privileges contained in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> access token object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to an array of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects. **CNames** is defined as a typedef: **CTokenPrivileges::CAtlArray\<CString>**.  
  
## Remarks  
 The parameter <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a pointer to an array of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects which will receive the display names corresponding to the privileges contained in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. This method retrieves display names only for the privileges specified in the Defined Privileges section of WINNT.H.  
  
 This method retrieves a displayable name: for example, if the attribute name is SE_REMOTE_SHUTDOWN_NAME, the displayable name is "Force shutdown from a remote system." To obtain the system name, use [CTokenPrivileges::GetNamesAndAttributes](../vs140/ctokenprivileges--getnamesandattributes.md).  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CTokenPrivileges Class](../vs140/ctokenprivileges-class.md)   
 [CTokenPrivileges::GetNamesAndAttributes](../vs140/ctokenprivileges--getnamesandattributes.md)   
 [CTokenPrivileges::LookupPrivilege](../vs140/ctokenprivileges--lookupprivilege.md)   
 [CTokenPrivileges::GetLuidsAndAttributes](../vs140/ctokenprivileges--getluidsandattributes.md)