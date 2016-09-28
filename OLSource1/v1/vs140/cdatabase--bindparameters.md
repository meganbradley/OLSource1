---
title: "CDatabase::BindParameters"
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
  - "BindParameters"
  - "CDatabase::BindParameters"
  - "CDatabase.BindParameters"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "binding parameters with CDatabase"
  - "BindParameters method"
  - "parameters, binding with CDatabase"
  - "CDatabase class, binding parameters"
ms.assetid: 24521342-18ee-45c3-a4ff-7c9441a27250
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::BindParameters
Override `BindParameters` when you need to bind parameters before calling [CDatabase::ExecuteSQL](../vs140/cdatabase--executesql.md).  
  
## Syntax  
  
```  
  
      virtual void BindParameters(  
   HSTMT hstmt   
);  
```  
  
#### Parameters  
 `hstmt`  
 The ODBC statement handle for which you want to bind parameters.  
  
## Remarks  
 This approach is useful when you do not need the result set from a stored procedure.  
  
 In your override, call **SQLBindParameters** and related ODBC functions to bind the parameters. MFC calls your override before your call to `ExecuteSQL`. You do not need to call **SQLPrepare**; `ExecuteSQL` calls **SQLExecDirect** and destroys the **hstmt**, which is used only once.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)