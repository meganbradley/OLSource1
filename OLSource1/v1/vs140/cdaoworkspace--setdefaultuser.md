---
title: "CDaoWorkspace::SetDefaultUser"
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
  - "SetDefaultUser"
  - "CDaoWorkspace.SetDefaultUser"
  - "CDaoWorkspace::SetDefaultUser"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "defaults [C++], users"
  - "workspaces [C++], users"
  - "users [C++], setting default"
  - "DAO [C++], user names"
  - "SetDefaultUser method"
  - "default users"
  - "default users, setting"
ms.assetid: 30aec420-d2da-402e-9c4b-08f51af78134
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::SetDefaultUser
Call this member function to set the default user name that the database engine uses when a workspace object is created without a specific user name.  
  
## Syntax  
  
```  
  
      static void PASCAL SetDefaultUser(   
   LPCTSTR lpszDefaultUser    
);  
```  
  
#### Parameters  
 `lpszDefaultUser`  
 The default user name. A user name can be 1 – 20 characters long and include alphabetic characters, accented characters, numbers, spaces, and symbols except for: " (quotation marks), / (forward slash), \ (backslash), [ ] (brackets), : (colon), &#124; (pipe), \< (less-than sign), > (greater-than sign), + (plus sign), = (equal sign), ; (semicolon), , ( comma), ? (question mark), * (asterisk), leading spaces, and control characters (ASCII 00 to ASCII 31). For related information, see the topic "UserName Property" in DAO Help.  
  
## Remarks  
 The default user name that you set applies to new workspaces you create after the call. When you create subsequent workspaces, you do not need to specify a user name in the [Create](../vs140/cdaoworkspace--create.md) call.  
  
 To use this member function:  
  
1.  Construct a `CDaoWorkspace` object but do not call **Create**.  
  
2.  Call `SetDefaultUser` and, if you like, [SetDefaultPassword](../vs140/cdaoworkspace--setdefaultpassword.md).  
  
3.  Call **Create** for this workspace object or subsequent ones, without specifying a user name.  
  
 By default, the DefaultUser property is set to "admin" and the DefaultPassword property is set to an empty string ("").  
  
 For related information, see the topics "DefaultUser Property" and "DefaultPassword Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)