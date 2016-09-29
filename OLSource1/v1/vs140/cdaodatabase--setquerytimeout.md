---
title: "CDaoDatabase::SetQueryTimeout"
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
  - "CDaoDatabase.SetQueryTimeout"
  - "SetQueryTimeout"
  - "CDaoDatabase::SetQueryTimeout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "time-outs [C++], setting query"
  - "query time-outs [C++], default"
  - "databases [C++], setting query time-outs"
  - "SetQueryTimeout method, when to call"
  - "query time-outs [C++], setting"
  - "SetQueryTimeout method"
  - "DAO [C++], time-outs"
ms.assetid: d7649daf-ec04-464a-88ec-6ad88bdf4bd0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::SetQueryTimeout
Call this member function to override the default number of seconds to allow before subsequent operations on the connected database time out.  
  
## Syntax  
  
```  
  
      void SetQueryTimeout(   
   short nSeconds    
);  
```  
  
#### Parameters  
 `nSeconds`  
 The number of seconds to allow before a query attempt times out.  
  
## Remarks  
 An operation might time out because of network access problems, excessive query processing time, and so on. Call `SetQueryTimeout` before opening your recordset or before calling the recordset's [AddNew](../vs140/cdaorecordset--addnew.md), [Update](../vs140/cdaorecordset--update.md), or [Delete](../vs140/cdaorecordset--delete.md) member functions if you want to change the query timeout value. The setting affects all subsequent [Open](../vs140/cdaorecordset--open.md), `AddNew`, **Update**, and **Delete** calls to any recordsets associated with this `CDaoDatabase` object. Changing the query timeout value for a recordset after opening does not change the value for the recordset. For example, subsequent [Move](../vs140/cdaorecordset--move.md) operations do not use the new value.  
  
 The default value for query timeouts is 60 seconds. Not all databases support the ability to set a query timeout value. If you set a query timeout value of 0, no timeout occurs; the communication with the database may stop responding. This behavior may be useful during development.  
  
 For related information, see the topic "QueryTimeout Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::SetLoginTimeout](../vs140/cdaoworkspace--setlogintimeout.md)