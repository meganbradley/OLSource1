---
title: "CDaoWorkspace::Open"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDaoWorkspace.Open
  - CDaoWorkspace::Open
dev_langs: 
  - C++
helpviewer_keywords: 
  - DAO workspaces [C++]
  - workspaces [C++], opening
  - DAO workspaces [C++], initializing
  - Open method
  - workspaces [C++], initializing
  - CDaoWorkspace class, functions callable before Open
ms.assetid: 30bbd102-0d6e-411b-ab97-3377d3379a6f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoWorkspace::Open
Explicitly opens a workspace object associated with DAO's default workspace.  
  
## Syntax  
  
```  
  
      virtual void Open(   
   LPCTSTR lpszName = NULL    
);  
```  
  
#### Parameters  
 `lpszName`  
 The name of the DAO workspace object to open — a string with up to 14 characters that uniquely names the workspace. Accept the default value **NULL** to explicitly open the default workspace. For naming requirements, see the `lpszName` parameter for [Create](../vs140/cdaoworkspace--create.md). For related information, see the topic "Name Property" in DAO Help.  
  
## Remarks  
 After constructing a `CDaoWorkspace` object, call this member function to do one of the following:  
  
-   Explicitly open the default workspace. Pass **NULL** for `lpszName`.  
  
-   Open an existing `CDaoWorkspace` object, a member of the Workspaces collection, by name. Pass a valid name for an existing workspace object.  
  
 **Open** puts the workspace object into an open state and also initializes the database engine if it has not already been initialized for your application.  
  
 Although many `CDaoWorkspace` member functions can only be called after the workspace has been opened, the following member functions, which operate on the database engine, are available after construction of the C++ object but before a call to **Open**:  
  
||||  
|-|-|-|  
|[Create](../vs140/cdaoworkspace--create.md)|[GetVersion](../vs140/cdaoworkspace--getversion.md)|[SetDefaultUser](../vs140/cdaoworkspace--setdefaultuser.md)|  
|[GetIniPath](../vs140/cdaoworkspace--getinipath.md)|[Idle](../vs140/cdaoworkspace--idle.md)|[SetIniPath](../vs140/cdaoworkspace--setinipath.md)|  
|[GetLoginTimeout](../vs140/cdaoworkspace--getlogintimeout.md)|[SetDefaultPassword](../vs140/cdaoworkspace--setdefaultpassword.md)|[SetLoginTimeout](../vs140/cdaoworkspace--setlogintimeout.md)|  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::IsOpen](../vs140/cdaoworkspace--isopen.md)   
 [CDaoWorkspace::CDaoWorkspace](../vs140/cdaoworkspace--cdaoworkspace.md)   
 [CDaoWorkspace::Create](../vs140/cdaoworkspace--create.md)   
 [CDaoWorkspace::Close](../vs140/cdaoworkspace--close.md)