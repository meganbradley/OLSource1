---
title: "CDaoWorkspace::GetIsolateODBCTrans"
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
  - CDaoWorkspace::GetIsolateODBCTrans
  - GetIsolateODBCTrans
  - CDaoWorkspace.GetIsolateODBCTrans
dev_langs: 
  - C++
helpviewer_keywords: 
  - DAO [C++], isolating ODBC transactions
  - IsolateODBCTrans property
  - transactions [C++], isolating ODBC
  - workspaces [C++], isolating ODBC transactions
  - DAO [C++], getting workspace information
  - GetIsolateODBCTrans method
  - ODBC [C++], isolating transactions
  - ODBC transactions [C++]
  - ODBC transactions [C++], isolating
ms.assetid: 707d1b84-85de-4bb9-b428-39f71c4466f4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoWorkspace::GetIsolateODBCTrans
Call this member function to get the current value of the DAO IsolateODBCTrans property for the workspace.  
  
## Syntax  
  
```  
  
BOOL GetIsolateODBCTrans( );  
  
```  
  
## Return Value  
 Nonzero if ODBC transactions are isolated; otherwise 0.  
  
## Remarks  
 In some situations, you might need to have multiple simultaneous transactions pending on the same ODBC database. To do this, you need to open a separate workspace for each transaction. Keep in mind that although each workspace can have its own ODBC connection to the database, this slows system performance. Because transaction isolation is not normally required, ODBC connections from multiple workspace objects opened by the same user are shared by default.  
  
 Some ODBC servers, such as Microsoft SQL Server, do not allow simultaneous transactions on a single connection. If you need to have more than one transaction at a time pending against such a database, set the IsolateODBCTrans property to **TRUE** on each workspace as soon as you open it. This forces a separate ODBC connection for each workspace.  
  
 For related information, see the topic "IsolateODBCTrans Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::SetIsolateODBCTrans](../vs140/cdaoworkspace--setisolateodbctrans.md)