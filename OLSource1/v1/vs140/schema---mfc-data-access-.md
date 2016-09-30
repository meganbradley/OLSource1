---
title: "Schema  (MFC Data Access)"
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
  - "structures [C++], database"
  - "databases [C++], schema"
  - "database schema [C++], about database schemas"
  - "database schema [C++]"
  - "schemas [C++], database"
  - "structures [C++]"
ms.assetid: 7d17e35f-1ccf-4853-b915-5b8c7a45b9ee
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Schema  (MFC Data Access)
A database schema describes the current structure of the tables and database views in the database. In general, wizard-generated code assumes that the schema for the table or tables accessed by a recordset will not change, but the database classes can deal with some schema changes, such as adding, reordering, or deleting unbound columns. If a table changes, you must manually update the recordset for the table, then recompile your application.  
  
 You can also supplement the wizard-generated code to deal with a database whose schema is not entirely known at compile time. For more information, see [Recordset: Dynamically Binding Data Columns (ODBC)](../vs140/recordset--dynamically-binding-data-columns--odbc-.md).  
  
## See Also  
 [Data Access Programming (MFC/ATL)](../vs140/data-access-programming--mfc-atl-.md)   
 [SQL](../vs140/sql.md)   
 [Recordset (ODBC)](../vs140/recordset--odbc-.md)