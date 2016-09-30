---
title: "CDaoQueryDef::Create"
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
  - "CDaoQueryDef.Create"
  - "CDaoQueryDef::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryDef objects, naming"
  - "Create method [C++]"
  - "names [C++], querydef object"
  - "SQL strings, querydef object"
  - "CDaoQueryDef class, and SetName"
  - "QueryDef objects, setting SQL strings"
  - "SQL strings"
  - "CDaoQueryDef class, creating"
  - "CDaoQueryDef class, and SetSQL"
  - "QueryDef objects, creating"
ms.assetid: b17c072a-f6ad-4011-a093-7904f6815b42
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::Create
Call this member function to create a new saved query or a new temporary query.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The unique name of the query saved in the database. For details about the string, see the topic "CreateQueryDef Method" in DAO Help. If you accept the default value, an empty string, a temporary querydef is created. Such a query is not saved in the QueryDefs collection.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The SQL string that defines the query. If you accept the default value of **NULL**, you must later call [SetSQL](../vs140/cdaoquerydef--setsql.md) to set the string. Until then, the query is undefined. You can, however, use the undefined query to open a recordset; see Remarks for details. The SQL statement must be defined before you can append the querydef to the QueryDefs collection.  
  
## Remarks  
 If you pass a name in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, you can then call [Append](../vs140/cdaoquerydef--append.md) to save the querydef in the database's QueryDefs collection. Otherwise, the object is a temporary querydef and is not saved. In either case, the querydef is in an open state, and you can either use it to create a [CDaoRecordset](../vs140/cdaorecordset-class.md) object or call the querydef's [Execute](../vs140/cdaoquerydef--execute.md) member function.  
  
 If you do not supply a SQL statement in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, you cannot run the query with **Execute** but you can use it to create a recordset. In that case, MFC uses the recordset's default SQL statement.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::Open](../vs140/cdaoquerydef--open.md)   
 [CDaoQueryDef::CDaoQueryDef](../vs140/cdaoquerydef--cdaoquerydef.md)   
 [CDaoRecordset::GetSQL](../vs140/cdaorecordset--getsql.md)