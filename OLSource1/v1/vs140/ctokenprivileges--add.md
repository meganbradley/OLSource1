---
title: "CTokenPrivileges::Add"
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
  - "ATL.CTokenPrivileges.Add"
  - "CTokenPrivileges.Add"
  - "ATL::CTokenPrivileges::Add"
  - "CTokenPrivileges::Add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Add method [ATL]"
ms.assetid: 8b84c8e1-1ce1-4443-8e69-2341c3c6f4dd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTokenPrivileges::Add
Adds one or more privileges to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> access token object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the name of the privilege, as defined in the WINNT.H header file.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If true, the privilege is enabled. If false, the privilege is disabled.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Reference to a [TOKEN_PRIVILEGES](http://msdn.microsoft.com/library/windows/desktop/aa379630) structure. The privileges and attributes are copied from this structure and added to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
## Return Value  
 The first form of this method returns true if the privileges are successfully added, false otherwise.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CTokenPrivileges Class](../vs140/ctokenprivileges-class.md)   
 [CTokenPrivileges::Delete](../vs140/ctokenprivileges--delete.md)   
 [CTokenPrivileges::DeleteAll](../vs140/ctokenprivileges--deleteall.md)