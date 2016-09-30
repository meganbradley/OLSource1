---
title: "CDaoWorkspace::GetLoginTimeout"
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
  - "CDaoWorkspace::GetLoginTimeout"
  - "GetLoginTimeout"
  - "CDaoWorkspace.GetLoginTimeout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLoginTimeout method"
  - "LoginTimeout property"
  - "workspaces [C++], login time-outs"
  - "time-outs [C++], login"
  - "workspaces [C++], getting information about"
  - "DAO [C++], getting workspace information"
ms.assetid: 1265d979-2066-4143-9c15-96561f95600d
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::GetLoginTimeout
Call this member function to get the current value of the DAO LoginTimeout property for the workspace.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of seconds before an error occurs when you attempt to log in to an ODBC database.  
  
## Remarks  
 This value represents the number of seconds before an error occurs when you attempt to log in to an ODBC database. The default LoginTimeout setting is 20 seconds. When LoginTimeout is set to 0, no timeout occurs and the communication with the data source might stop responding.  
  
 When you are attempting to log in to an ODBC database, such as Microsoft SQL Server, the connection may fail as a result of network errors or because the server is not running. Rather than waiting for the default 20 seconds to connect, you can specify how long the database engine waits before it produces an error. Logging in to the server happens implicitly as part of a number of different events, such as running a query on an external server database.  
  
 For related information, see the topic "LoginTimeout Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::SetLoginTimeout](../vs140/cdaoworkspace--setlogintimeout.md)