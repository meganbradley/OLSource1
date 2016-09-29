---
title: "CDaoWorkspace::SetLoginTimeout"
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
  - "CDaoWorkspace::SetLoginTimeout"
  - "CDaoWorkspace.SetLoginTimeout"
  - "SetLoginTimeout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoginTimeout property"
  - "workspaces [C++], login time-outs"
  - "time-outs [C++], login"
  - "ODBC connections [C++], login timeout"
  - "SetLoginTimeout method"
  - "ODBC [C++], time-out values"
  - "DAO [C++], time-outs"
ms.assetid: b26194a2-7620-4578-ba50-748ffd3e5511
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::SetLoginTimeout
Call this member function to set the value of the DAO LoginTimeout property for the workspace.  
  
## Syntax  
  
```  
  
      static void PASCAL SetLoginTimeout(   
   short nSeconds    
);  
```  
  
#### Parameters  
 `nSeconds`  
 The number of seconds before an error occurs when you attempt to log in to an ODBC database.  
  
## Remarks  
 This value represents the number of seconds before an error occurs when you attempt to log in to an ODBC database. The default LoginTimeout setting is 20 seconds. When LoginTimeout is set to 0, no timeout occurs and the communication with the data source might stop responding.  
  
 When you are attempting to log in to an ODBC database, such as Microsoft SQL Server, the connection may fail as a result of network errors or because the server is not running. Rather than waiting for the default 20 seconds to connect, you can specify how long the database engine waits before it produces an error. Logging on to the server happens implicitly as part of a number of different events, such as running a query on an external server database. The timeout value is determined by the current setting of the LoginTimeout property.  
  
 For related information, see the topic "LoginTimeout Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::GetLoginTimeout](../vs140/cdaoworkspace--getlogintimeout.md)