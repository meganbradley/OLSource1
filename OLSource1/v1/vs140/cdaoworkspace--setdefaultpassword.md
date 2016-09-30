---
title: "CDaoWorkspace::SetDefaultPassword"
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
  - "CDaoWorkspace::SetDefaultPassword"
  - "SetDefaultPassword"
  - "CDaoWorkspace.SetDefaultPassword"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO [C++], default passwords"
  - "default passwords, setting"
  - "workspaces [C++], password"
  - "SetDefaultPassword method"
  - "default passwords"
  - "passwords [C++], setting default"
  - "defaults [C++], passwords"
ms.assetid: 22674fb1-1bc4-495d-a678-bdcc8db1828c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::SetDefaultPassword
Call this member function to set the default password that the database engine uses when a workspace object is created without a specific password.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The default password. A password can be up to 14 characters long and can contain any character except ASCII 0 (null). Passwords are case-sensitive.  
  
## Remarks  
 The default password that you set applies to new workspaces you create after the call. When you create subsequent workspaces, you do not need to specify a password in the [Create](../vs140/cdaoworkspace--create.md) call.  
  
 To use this member function:  
  
1.  Construct a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object but do not call **Create**.  
  
2.  Call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and, if you like, [SetDefaultUser](../vs140/cdaoworkspace--setdefaultuser.md).  
  
3.  Call **Create** for this workspace object or subsequent ones, without specifying a password.  
  
 By default, the DefaultUser property is set to "admin" and the DefaultPassword property is set to an empty string ("").  
  
 For more about security, see the topic "Permissions Property" in DAO Help. For related information, see the topics "DefaultPassword Property" and "DefaultUser Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)