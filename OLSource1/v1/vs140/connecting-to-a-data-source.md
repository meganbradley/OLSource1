---
title: "Connecting to a Data Source"
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
  - "database connections [C++], ODBC"
  - "ODBC connections [C++], using"
  - "connections [C++], data source"
  - "databases [C++], connecting to"
  - "data sources [C++], connecting to"
  - "ODBC data sources [C++], connections"
  - "database connections [C++], MFC ODBC classes"
ms.assetid: ef6c8c98-5979-43a8-9fb5-5bb06fc59f36
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Connecting to a Data Source
An ODBC data source is a specific set of data, the information required to access that data, and the location of the data source, which can be described using a data-source name. From your program's point of view, the data source includes the data, the DBMS, the network (if any), and ODBC.  
  
 To access data provided by a data source, your program must first establish a connection to the data source. All data access is managed through that connection.  
  
 Data-source connections are encapsulated by class [CDatabase](../vs140/cdatabase-class.md). When a `CDatabase` object is connected to a data source, you can:  
  
-   Construct [recordsets](../vs140/crecordset-class.md), which select records from tables or queries.  
  
-   Manage [transactions](../vs140/transaction--odbc-.md), batching updates so all are committed to the data source at once (or the whole transaction is rolled back so the data source is unchanged) — if the data source supports the required level of transactions.  
  
-   Directly execute [SQL](../vs140/sql.md) statements.  
  
 When you finish working with a data-source connection, you close the `CDatabase` object and either destroy it or reuse it for a new connection. For more information about data-source connections, see [Data Source (ODBC)](../vs140/data-source--odbc-.md).  
  
## See Also  
 [ODBC and MFC](../vs140/odbc-and-mfc.md)