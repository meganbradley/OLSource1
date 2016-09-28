---
title: "CTokenPrivileges::Delete"
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
  - "CTokenPrivileges.Delete"
  - "ATL::CTokenPrivileges::Delete"
  - "ATL.CTokenPrivileges.Delete"
  - "CTokenPrivileges::Delete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Delete method"
ms.assetid: 99dc761f-72e3-4f66-b321-68a258b82733
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTokenPrivileges::Delete
Deletes a privilege from the `CTokenPrivileges` access token object.  
  
## Syntax  
  
```  
  
      bool Delete(  
   LPCTSTR pszPrivilege   
) throw( );  
```  
  
#### Parameters  
 `pszPrivilege`  
 Pointer to a null-terminated string that specifies the name of the privilege, as defined in the WINNT.H header file. For example, this parameter could specify the constant SE_SECURITY_NAME, or its corresponding string, "SeSecurityPrivilege."  
  
## Return Value  
 Returns true if the privilege was successfully deleted, false otherwise.  
  
## Remarks  
 This method is useful as a tool for creating restricted tokens under Windows 2000.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CTokenPrivileges Class](../vs140/ctokenprivileges-class.md)   
 [CTokenPrivileges::DeleteAll](../vs140/ctokenprivileges--deleteall.md)   
 [CTokenPrivileges::Add](../vs140/ctokenprivileges--add.md)   
 [CAccessToken::CreateRestrictedToken](../vs140/caccesstoken--createrestrictedtoken.md)