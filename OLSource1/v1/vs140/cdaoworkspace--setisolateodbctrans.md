---
title: "CDaoWorkspace::SetIsolateODBCTrans"
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
  - "CDaoWorkspace.SetIsolateODBCTrans"
  - "CDaoWorkspace::SetIsolateODBCTrans"
  - "SetIsolateODBCTrans"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO [C++], isolating ODBC transactions"
  - "SetIsolateODBCTrans method"
  - "IsolateODBCTrans property"
  - "workspaces [C++], isolating ODBC transactions"
  - "ODBC [C++], isolating transactions"
  - "ODBC transactions [C++]"
  - "ODBC transactions [C++], isolating"
ms.assetid: e5e11704-eafb-4a39-801f-9e79bbbe1d5c
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::SetIsolateODBCTrans
Call this member function to set the value of the DAO IsolateODBCTrans property for the workspace.  
  
## Syntax  
  
```  
  
      void SetIsolateODBCTrans(   
   BOOL bIsolateODBCTrans    
);  
```  
  
#### Parameters  
 *bIsolateODBCTrans*  
 Pass **TRUE** if you want to begin isolating ODBC transactions. Pass **FALSE** if you want to stop isolating ODBC transactions.  
  
## Remarks  
 In some situations, you might need to have multiple simultaneous transactions pending on the same ODBC database. To do this, you need to open a separate workspace for each transaction. Although each workspace can have its own ODBC connection to the database, this slows system performance. Because transaction isolation is not normally required, ODBC connections from multiple workspace objects opened by the same user are shared by default.  
  
 Some ODBC servers, such as Microsoft SQL Server, do not allow simultaneous transactions on a single connection. If you need to have more than one transaction at a time pending against such a database, set the IsolateODBCTrans property to **TRUE** on each workspace as soon as you open it. This forces a separate ODBC connection for each workspace.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::GetIsolateODBCTrans](../vs140/cdaoworkspace--getisolateodbctrans.md)