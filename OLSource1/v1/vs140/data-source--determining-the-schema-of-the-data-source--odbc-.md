---
title: "Data Source: Determining the Schema of the Data Source (ODBC)"
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
  - "ODBC data sources [C++], schema"
  - "schemas [C++], data sources"
  - "data sources [C++], determining schema"
ms.assetid: 17284acb-eb10-4f27-9944-ad1d973c0b05
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Data Source: Determining the Schema of the Data Source (ODBC)
This topic applies to the MFC ODBC classes.  
  
 To set up data members in your `CRecordset` objects, you need to know the schema of the data source to which you are connecting. Determining the schema of a data source involves obtaining a list of the tables in the data source, a list of the columns in each table, the data type of each column, and the existence of any indexes.  
  
## See Also  
 [Data Source (ODBC)](../vs140/data-source--odbc-.md)   
 [Data Source: Managing Connections (ODBC)](../vs140/data-source--managing-connections--odbc-.md)