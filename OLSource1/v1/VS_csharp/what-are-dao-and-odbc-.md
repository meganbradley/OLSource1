---
title: "What Are DAO and ODBC?"
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
  - "DAO (Data Access Objects), and ODBC"
  - "ODBC, about ODBC"
ms.assetid: 22cc2f75-7ff6-47bc-ac56-56a40591104c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# What Are DAO and ODBC?
Both Data Access Objects (DAOs) and Open Database Connectivity (ODBC) are APIs that give you the ability to write applications that are independent of any particular database management system (DBMS).  
  
 DAO is familiar to database programmers using Microsoft Access Basic or Microsoft Visual Basic. DAO uses the Microsoft Jet database engine to provide a set of data access objects: database objects, tabledef and querydef objects, recordset objects, and others. DAO works best with .mdb files like those created by Microsoft Access, but you can also access ODBC data sources through DAO and the Microsoft Jet database engine.  
  
 ODBC provides an API that different database vendors implement through ODBC drivers specific to a particular DBMS. Your program uses this API to call the ODBC Driver Manager, which passes the calls to the appropriate driver. The driver, in turn, interacts with the DBMS using SQL.  
  
> [!NOTE]
>  ODBC is a major part of the Microsoft Windows Open Standards Architecture (WOSA). DAO is optimized around the Microsoft Jet database engine, but you can still access ODBC and other external data sources with that engine, and the distinct ODBC API and the MFC classes based on it are still available and still have their role to play in your selection of database tools.  
  
## See Also  
 [Data Access Frequently Asked Questions](../VS_csharp/data-access-frequently-asked-questions---mfc-data-access-.md)