---
title: "SQL: Making Direct SQL Calls (ODBC)"
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
  - "SQL, direct calls from ODBC"
  - "SQL, calling directly from ODBC"
  - "ODBC, SQL calls"
  - "SQL calls"
  - "direct SQL calls from ODBC"
ms.assetid: 091988d2-f5a5-4c2d-aa09-8779a9fb9607
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SQL: Making Direct SQL Calls (ODBC)
This topic explains:  
  
-   When to use direct SQL calls.  
  
-   [How you make direct SQL calls to the data source](#_core_making_direct_sql_function_calls).  
  
> [!NOTE]
>  This information applies to the MFC ODBC classes. If you are working with the MFC DAO classes, see the topic "Comparison of Microsoft Jet Database Engine SQL and ANSI SQL" in DAO Help.  
  
##  \<a name="_core_when_to_call_sql_directly">\</a> When to Call SQL Directly  
 To create new tables, drop (delete) tables, alter existing tables, create indexes, and perform other SQL functions that change the [Data Source (ODBC)](../vs140/data-source--odbc-.md) schema, you must issue a SQL statement directly to the data source using Database Definition Language (DDL). When you use a wizard to create a recordset for a table (at design time), you can choose which columns of the table to represent in the recordset. This does not allow for columns you or another user of the data source add to the table later, after your program has been compiled. The database classes do not support DDL directly, but you can still write code to bind a new column to your recordset dynamically, at run time. For information about how to do this binding, see [Recordset: Dynamically Binding Data Columns (ODBC)](../vs140/recordset--dynamically-binding-data-columns--odbc-.md).  
  
 You can use the DBMS itself to alter the schema or another tool that lets you perform DDL functions. You can also use ODBC function calls for sending SQL statements, such as calling a predefined query (stored procedure) that does not return records.  
  
##  \<a name="_core_making_direct_sql_function_calls">\</a> Making Direct SQL Function Calls  
 You can directly execute a SQL call using a [CDatabase Class](../vs140/cdatabase-class.md) object. Set up your SQL statement string (usually in a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>) and pass it to the [CDatabase::ExecuteSQL](../vs140/cdatabase--executesql.md) member function of your <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object. If you use ODBC function calls to send a SQL statement that normally returns records, the records are ignored.  
  
## See Also  
 [SQL](../vs140/sql.md)