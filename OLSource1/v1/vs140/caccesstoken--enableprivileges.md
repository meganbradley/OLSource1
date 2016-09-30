---
title: "CAccessToken::EnablePrivileges"
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
  - "CAccessToken.EnablePrivileges"
  - "CAccessToken::EnablePrivileges"
  - "ATL.CAccessToken.EnablePrivileges"
  - "ATL::CAccessToken::EnablePrivileges"
  - "EnablePrivileges"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnablePrivileges method"
ms.assetid: 8d5ca12e-b704-45f6-881d-1884dfd02a51
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::EnablePrivileges
Call this method to enable one or more privileges in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to an array of strings containing the privileges to enable in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object which will contain the previous state of the privileges.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::EnablePrivilege](../vs140/caccesstoken--enableprivilege.md)   
 [CAccessToken::DisablePrivileges](../vs140/caccesstoken--disableprivileges.md)