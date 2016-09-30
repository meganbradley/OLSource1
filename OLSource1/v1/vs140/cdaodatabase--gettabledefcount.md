---
title: "CDaoDatabase::GetTableDefCount"
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
  - "GetTableDefCount"
  - "CDaoDatabase.GetTableDefCount"
  - "CDaoDatabase::GetTableDefCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tables [C++]"
  - "tables [C++], counting"
  - "GetTableDefCount method"
  - "DAO [C++], getting information about tables"
  - "counting tables"
  - "tabledefs [C++], counting"
  - "databases [C++], getting counts of tables"
ms.assetid: 98c70230-e447-448b-b99c-4451f8179389
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::GetTableDefCount
Call this member function to retrieve the number of tables defined in the database.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of tabledefs defined in the database.  
  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is useful if you need to loop through all tabledefs in the database's TableDefs collection. To obtain information about a given table in the collection, see [GetTableDefInfo](../vs140/cdaodatabase--gettabledefinfo.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)