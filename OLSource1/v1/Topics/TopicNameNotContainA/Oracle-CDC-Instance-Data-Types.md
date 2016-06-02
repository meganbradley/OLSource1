---
title: Oracle CDC Instance Data Types
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: eec13d8d-c15a-4542-bfc4-da66b1a6bfe0
---
# Oracle CDC Instance Data Types
  The Oracle CDC Instance supports most Oracle data types. The following sections describe the supported data types and the non\-supported data types.  
  
## Supported Data Types  
 The following table describes the Oracle data types that can be captured and their default mapping to SQL Server data types in the change tables. When adding a capture instance for a source Oracle table, you can override some of these mappings.  
  
|Oracle Database Data Type|SQL Server Data Type|  
|-------------------------------|--------------------------|  
|BINARY\_FLOAT|REAL|  
|BINARY\_DOUBLE|FLOAT|  
|CHAR|NVARCHAR|  
|DATE|DATETIME|  
|FLOAT|FLOAT|  
|INT|NUMERIC \(38\)|  
|INTERVAL|DATETIME|  
|NCHAR|NVARCHAR|  
|NUMBER|FLOAT|  
|NAVARCHAR2|NVARCHAR|  
|RAW|VARBINARY|  
|REAL|FLOAT|  
|TIMESTAMP|DATETIME2|  
|TIMESTAMP WITH TIME ZONE|VARCHAR \(37\)|  
|TIMESTAMP WITH LOCAL TIME ZONE|VARCHAR \(37\)|  
|VARCHAR2|VARCHAR|  
|XMLTYPE|NVARCHAR \(MAX\)|  
  
## Non\-Supported Data Types  
 Source Oracle tables with columns of the following Oracle data types cannot be captured. Captured columns with these data types will show as null; however, a change in their value is indicated in the change mask of the captured tables.  
  
-   LONG  
  
-   XMLTYPE  
  
-   BLOB  
  
-   CLOB  
  
 Source Oracle tables with columns of the following Oracle data types cannot be captured.  
  
-   BFILE  
  
-   ROWID  
  
-   REF  
  
-   UROWID  
  
-   Nested Table  
  
 If the following data types are present in a table they will prevent the LogMinder from getting any data for any column of the table:  
  
-   User\-defined data types  
  
-   VARRAY  
  
## See Also  
 [Change Data Capture Designer for Oracle by Attunity](../../Topics\TopicNameNotContainA/Change-Data-Capture-Designer-for-Oracle-by-Attunity.md)   
 [The Oracle CDC Instance](../../Topics\TopicNameNotContainA/The-Oracle-CDC-Instance.md)  
  
  