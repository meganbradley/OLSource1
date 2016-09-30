---
title: "Selecting and Manipulating Records"
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
  - "records, selecting"
  - "record selection, MFC ODBC classes"
  - "ODBC recordsets, selecting records"
ms.assetid: 7f0b3a4a-9941-4475-a612-9ec8d15b7691
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Selecting and Manipulating Records
Normally when you select records from a data source using a SQL **SELECT** statement, you get a result set, which is a set of records from a table or a query. With the database classes, you use a recordset object to select and access the result set. This is an object of an application-specific class that you derive from class [CRecordset](../vs140/crecordset-class.md). When you define a recordset class, you specify the data source to associate it with, the table to use, and the columns of the table. The MFC Application Wizard or **Add Class** (as described in [Adding an MFC ODBC Consumer](../vs140/adding-an-mfc-odbc-consumer.md)) creates a class with a connection to a specific data source. The wizards write the [GetDefaultSQL](../vs140/crecordset--getdefaultsql.md) member function of class <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to return the table name. For more information about using the wizards to create recordset classes, see [Database Support, MFC Application Wizard](../vs140/database-support--mfc-application-wizard.md) and [Adding an MFC ODBC Consumer](../vs140/adding-an-mfc-odbc-consumer.md).  
  
 Using a [CRecordset](../vs140/crecordset-class.md) object at run time, you can:  
  
-   Examine the data fields of the current record.  
  
-   Filter or sort the recordset.  
  
-   Customize the default SQL **SELECT** statement.  
  
-   Scroll through the selected records.  
  
-   Add, update, or delete records (if both the data source and the recordset are updateable).  
  
-   Test whether the recordset allows requerying and refresh the recordset's contents.  
  
 When you finish using the recordset object, you close and destroy it. For more information about recordsets, see [Recordset (ODBC)](../vs140/recordset--odbc-.md).  
  
## See Also  
 [ODBC and MFC](../vs140/odbc-and-mfc.md)