---
title: "CDatabase::SetQueryTimeout"
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
  - "SetQueryTimeout"
  - "CDatabase.SetQueryTimeout"
  - "CDatabase::SetQueryTimeout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDatabase class, database attributes"
  - "SetQueryTimeout method"
ms.assetid: 91bbaa0c-75fd-4549-88cd-7249aa6d9017
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::SetQueryTimeout
Call this member function to override the default number of seconds to allow before subsequent operations on the connected data source time out.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The number of seconds to allow before a query attempt times out.  
  
## Remarks  
 An operation might time out due to network access problems, excessive query processing time, and so on. Call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> prior to opening your recordset or prior to calling the recordset's <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, **Update** or **Delete** member functions if you want to change the query timeout value. The setting affects all subsequent **Open**, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, **Update**, and **Delete** calls to any recordsets associated with this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. Changing the query timeout value for a recordset after opening does not change the value for the recordset. For example, subsequent **Move** operations do not use the new value.  
  
 The default value for query timeouts is 15 seconds. Not all data sources support the ability to set a query timeout value. If you set a query timeout value of 0, no timeout occurs; the communication with the data source may stop responding. This behavior may be useful during development. If the data source does not support timeout, you get trace output but not an exception.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::SetLoginTimeout](../vs140/cdatabase--setlogintimeout.md)