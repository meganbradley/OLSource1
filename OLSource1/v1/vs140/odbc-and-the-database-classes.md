---
title: "ODBC and the Database Classes"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - database classes [C++], ODBC
  - ODBC API functions [C++]
  - ODBC classes [C++], MFC database classes
  - MFC [C++], ODBC and
ms.assetid: b166f82d-6f85-4556-aac8-fb851235d22c
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ODBC and the Database Classes
The MFC ODBC database classes encapsulate the ODBC API function calls you would normally make yourself in the member functions of the [CDatabase](../vs140/cdatabase-class.md) and [CRecordset](../vs140/crecordset-class.md) classes. For example, the complex ODBC call sequences, binding of returned records to storage locations, handling of error conditions, and other operations are managed for you by the database classes. As a result, you use a considerably simpler class interface to manipulate records through a recordset object.  
  
> [!NOTE]
>  ODBC data sources are accessible through the MFC ODBC classes, as described in this TOPIC, or through the MFC Data Access Object (DAO) classes.  
  
 Although the database classes encapsulate ODBC functionality, they do not provide a one-to-one mapping of ODBC API functions. The database classes provide a higher level of abstraction, modeled after data-access objects found in Microsoft Access and Microsoft Visual Basic. For more information, see [What Is the MFC Database Programming Model?](../vs140/what-is-the-mfc-database-programming-model-.md).  
  
## See Also  
 [ODBC Basics](../vs140/odbc-basics.md)