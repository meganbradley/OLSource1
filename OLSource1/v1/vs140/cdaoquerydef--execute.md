---
title: "CDaoQueryDef::Execute"
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
  - "CDaoQueryDef::Execute"
  - "CDaoQueryDef.Execute"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "queries [C++], SQL pass-through"
  - "dbFailOnError option, querydef Execute"
  - "SQL pass-through queries [C++], running"
  - "pass-through queries [C++], running"
  - "QueryDef objects, executing"
  - "queries [C++], action"
  - "dbConsistent option, querydef Execute"
  - "dbSQLPassThrough option, querydef Execute"
  - "SQL pass-through queries [C++]"
  - "queries [C++], executing"
  - "dbInconsistent option, querydef Execute"
  - "dbSeeChanges option, querydef Execute"
  - "action queries [C++], running"
  - "Execute method"
  - "CDaoQueryDef class, executing"
  - "dbDenyWrite option, querydef Execute"
ms.assetid: 7b0588a5-02bd-4b34-a579-4ebd0a386134
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::Execute
Call this member function to run the query defined by the querydef object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An integer that determines the characteristics of the query. For related information, see the topic "Execute Method" in DAO Help. You can use the bitwise-OR operator (**&#124;**) to combine the following constants for this argument:  
  
-   **dbDenyWrite** Deny write permission to other users.  
  
-   **dbInconsistent** Inconsistent updates.  
  
-   **dbConsistent** Consistent updates.  
  
-   **dbSQLPassThrough** SQL pass-through. Causes the SQL statement to be passed to an ODBC database for processing.  
  
-   **dbFailOnError** Default value. Roll back updates if an error occurs and report the error to the user.  
  
-   **dbSeeChanges** Generate a run-time error if another user is changing data you are editing.  
  
> [!NOTE]
>  For an explanation of the terms "inconsistent" and "consistent," see the topic "Execute Method" in DAO Help.  
  
## Remarks  
 Querydef objects used for execution in this manner can only represent one of the following query types:  
  
-   Action queries  
  
-   SQL pass-through queries  
  
 **Execute** does not work for queries that return records, such as select queries. **Execute** is commonly used for bulk operation queries, such as **UPDATE**, **INSERT**, or **SELECT INTO**, or for data definition language (DDL) operations.  
  
> [!TIP]
>  The preferred way to work with ODBC data sources is to attach tables to a Microsoft Jet (.MDB) database. For more information, see the topic "Accessing External Databases with DAO" in DAO Help.  
  
 Call the [GetRecordsAffected](../vs140/cdaoquerydef--getrecordsaffected.md) member function of the querydef object to determine the number of records affected by the most recent **Execute** call. For example, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns information about the number of records deleted, updated, or inserted when executing an action query. The count returned will not reflect changes in related tables when cascade updates or deletes are in effect.  
  
 If you include both **dbInconsistent** and **dbConsistent** or if you include neither, the result is the default, **dbInconsistent**.  
  
 **Execute** does not return a recordset. Using **Execute** on a query that selects records causes MFC to throw an exception of type [CDaoException](../vs140/cdaoexception-class.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)