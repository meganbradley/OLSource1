---
title: "CDatabase::CanUpdate"
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
  - "CDatabase::CanUpdate"
  - "CDatabase.CanUpdate"
  - "CanUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanUpdate method"
  - "CDatabase class, database attributes"
ms.assetid: 0366d19d-b36f-46f7-8eac-eb359c6c2fc4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::CanUpdate
Call this member function to determine whether the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object allows updates.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object allows updates; otherwise 0, indicating either that you passed **TRUE** in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> when you opened the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object or that the data source itself is read-only. The data source is read-only if a call to the ODBC API function **SQLGetInfo** for **SQL_DATASOURCE_READ_ONLY** returns "y".  
  
## Remarks  
 Not all drivers support updates.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)