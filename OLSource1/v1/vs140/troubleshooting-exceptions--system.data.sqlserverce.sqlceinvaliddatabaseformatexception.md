---
title: "Troubleshooting Exceptions: System.Data.SqlServerCe.SqlCeInvalidDatabaseFormatException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "SqlCeInvalidDatabaseFormatException exception"
  - "System.Data.SqlServerCe.SqlCeInvalidDatabaseFormatException exception"
ms.assetid: f5ca1f40-4619-4523-807e-d5b20bfb05b0
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Data.SqlServerCe.SqlCeInvalidDatabaseFormatException
A `System.Data.SqlServerCe.SqlCeInvalidDatabaseFormatException` exception occurs when SQL Server Compact opens a database file that was created in an earlier version of the product.  
  
## Remarks  
 You can update the database file by using [!INCLUDE[vs_orcas_long](../vs140/includes/vs_orcas_long_md.md)] or by using the API `System.Data.SqlServerCe.SqlCeEngine.Upgrade`.  
  
 For more information, see [SQL Server Compact 3.5 Class Library](http://go.microsoft.com/fwlink/?LinkID=102595).  
  
## See Also  
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)