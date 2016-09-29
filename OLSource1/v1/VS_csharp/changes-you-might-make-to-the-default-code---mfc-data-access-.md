---
title: "Changes You Might Make to the Default Code  (MFC Data Access)"
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
  - "record views [C++], customizing default code"
ms.assetid: 9992ed37-a6bf-45a5-a572-5c14e42b6628
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Changes You Might Make to the Default Code  (MFC Data Access)
The [MFC Application Wizard](../VS_csharp/database-support--mfc-application-wizard.md) writes a recordset class for you that selects all records in a single table. You will often want to modify that behavior in one or more of the following ways:  
  
-   Set a filter or a sort order for the recordset. Do this in `OnInitialUpdate` after the recordset object is constructed but before its **Open** member function is called. For more information, see [Recordset: Filtering Records (ODBC)](../VS_csharp/recordset--filtering-records--odbc-.md) and [Recordset: Sorting Records (ODBC)](../VS_csharp/recordset--sorting-records--odbc-.md).  
  
-   Parameterize the recordset. Specify the actual run-time parameter value after the filter. For more information, see [Recordset: Parameterizing a Recordset (ODBC)](../VS_csharp/recordset--parameterizing-a-recordset--odbc-.md)  
  
-   Pass a customized SQL string to the [Open](../Topic/CRecordset::Open.md) member function. For a discussion of what you can accomplish with this technique , see [SQL: Customizing Your Recordset's SQL Statement (ODBC)](../VS_csharp/sql--customizing-your-recordset’s-sql-statement--odbc-.md).  
  
## See Also  
 [Using a Record View](../VS_csharp/using-a-record-view---mfc-data-access-.md)