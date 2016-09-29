---
title: "Record Field Exchange (RFX)"
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
  - "RFX (ODBC) [C++]"
  - "data [MFC], moving between sources and recordsets"
  - "database classes [C++], RFX"
  - "data [MFC]"
  - "ODBC [C++], RFX"
ms.assetid: f5ddfbf0-2901-48d7-9848-4fb84de3c7ee
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Record Field Exchange (RFX)
The MFC ODBC database classes automate moving data between the data source and a [recordset](../VS_csharp/recordset--odbc-.md) object. When you derive a class from [CRecordset](../VS_csharp/crecordset-class.md) and do not use bulk row fetching, data is transferred by the record field exchange (RFX) mechanism.  
  
> [!NOTE]
>  If you have implemented bulk row fetching in a derived `CRecordset` class, the framework uses the bulk record field exchange (Bulk RFX) mechanism to transfer data. For more information, see [Recordset: Fetching Records in Bulk (ODBC)](../VS_csharp/recordset--fetching-records-in-bulk--odbc-.md).  
  
 RFX is similar to dialog data exchange (DDX). Moving data between a data source and the field data members of a recordset requires multiple calls to the recordset's [DoFieldExchange](../Topic/CRecordset::DoFieldExchange.md) function and considerable interaction between the framework and [ODBC](../VS_csharp/odbc-basics.md). The RFX mechanism is type-safe and saves you the work of calling ODBC functions such as **::SQLBindCol**. For more information about DDX, see [Dialog Data Exchange and Validation](../VS_csharp/dialog-data-exchange-and-validation.md).  
  
 RFX is mostly transparent to you. If you declare your recordset classes with the MFC Application Wizard or **Add Class** (as described in [Adding an MFC ODBC Consumer](../VS_csharp/adding-an-mfc-odbc-consumer.md)), RFX is built into them automatically. Your recordset class must be derived from the base class `CRecordset` supplied by the framework. The MFC Application Wizard lets you create an initial recordset class. **Add Class** lets you add other recordset classes as you need them. For more information and examples, see [Adding an MFC ODBC Consumer](../VS_csharp/adding-an-mfc-odbc-consumer.md).  
  
 You must manually add a small amount of RFX code in three cases, when you want to:  
  
-   Use parameterized queries. For more information, see [Recordset: Parameterizing a Recordset (ODBC)](../VS_csharp/recordset--parameterizing-a-recordset--odbc-.md).  
  
-   Perform joins (using one recordset for columns from two or more tables). For more information, see [Recordset: Performing a Join (ODBC)](../VS_csharp/recordset--performing-a-join--odbc-.md).  
  
-   Bind data columns dynamically. This is less common than parameterization. For more information, see [Recordset: Dynamically Binding Data Columns (ODBC)](../VS_csharp/recordset--dynamically-binding-data-columns--odbc-.md).  
  
 If you need a more advanced understanding of RFX, see [Record Field Exchange: How RFX Works](../VS_csharp/record-field-exchange--how-rfx-works.md).  
  
 The following topics explain the details of using recordset objects:  
  
-   [Record Field Exchange: Using RFX](../VS_csharp/record-field-exchange--using-rfx.md)  
  
-   [Record Field Exchange: Using the RFX Functions](../VS_csharp/record-field-exchange--using-the-rfx-functions.md)  
  
-   [Record Field Exchange: How RFX Works](../VS_csharp/record-field-exchange--how-rfx-works.md)  
  
## See Also  
 [Open Database Connectivity (ODBC)](../VS_csharp/open-database-connectivity--odbc-.md)   
 [Recordset (ODBC)](../VS_csharp/recordset--odbc-.md)   
 [MFC ODBC Consume](../VS_csharp/adding-an-mfc-odbc-consumer.md)   
 [Database Support, MFC Application Wizard](../VS_csharp/database-support--mfc-application-wizard.md)   
 [CRecordset Class](../VS_csharp/crecordset-class.md)