---
title: "CDaoWorkspace::GetUserName"
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
  - "GetUserName"
  - "CDaoWorkspace.GetUserName"
  - "CDaoWorkspace::GetUserName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUserName method"
  - "SYSTEM.MDA file"
  - "workspaces [C++], getting information about"
  - "workspaces [C++], users"
  - "DAO [C++], getting workspace information"
  - "DAO [C++], user names"
  - "user names [C++]"
  - "names [C++], getting user"
ms.assetid: be1b50c2-d930-492e-af30-71eb767f113b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::GetUserName
Call this member function to obtain the name of the owner of the workspace.  
  
## Syntax  
  
```  
  
CString GetUserName( );  
  
```  
  
## Return Value  
 A [CString](../vs140/cstringt-class.md) that represents the owner of the workspace object.  
  
## Remarks  
 To get or set the permissions for the workspace owner, call DAO directly to check the Permissions property setting; this determines what permissions that user has. To work with permissions, you need a SYSTEM.MDA file.  
  
 For information about calling DAO directly, see [Technical Note 54](../vs140/tn054--calling-dao-directly-while-using-mfc-dao-classes.md). For related information, see the topic "UserName Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::SetDefaultUser](../vs140/cdaoworkspace--setdefaultuser.md)