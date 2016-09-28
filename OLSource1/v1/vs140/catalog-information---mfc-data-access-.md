---
title: "Catalog Information  (MFC Data Access)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tables [C++], catalog information"
  - "DAO [C++], catalog information"
  - "tables [C++]"
  - "ODBC [C++], catalog information"
  - "catalog information database [C++]"
  - "databases [C++], catalog information database"
ms.assetid: c184e80f-ff17-409f-9df8-05275080bb8d
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Catalog Information  (MFC Data Access)
Information about the tables in a data source can include the names of tables and the columns in them, table privileges, names of primary and foreign keys, information about predefined queries or stored procedures, information about indexes on tables, and statistics about tables.  
  
 For more information, see [Data Source: Determining the Schema of the Data Source (ODBC)](../vs140/data-source--determining-the-schema-of-the-data-source--odbc-.md).  
  
> [!NOTE]
>  In the MFC DAO classes, you can get catalog information as follows: Use [CDaoDatabase::GetTableDefCount](../vs140/cdaodatabase--gettabledefcount.md) and [CDaoDatabase::GetTableDefInfo](../vs140/cdaodatabase--gettabledefinfo.md) to enumerate the tables in the database and obtain information for each table in a [CDaoTableDefInfo](../vs140/cdaotabledefinfo-structure.md) structure.  
  
## See Also  
 [Data Access Programming (MFC/ATL)](../vs140/data-access-programming--mfc-atl-.md)