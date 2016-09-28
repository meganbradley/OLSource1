---
title: "Transaction Object Interfaces"
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
  - "interfaces, OLE DB"
  - "transaction object interfaces"
  - "OLE DB, interfaces"
  - "OLE DB providers, transaction support"
  - "OLE DB provider templates, object interfaces"
  - "interfaces, list of"
ms.assetid: d2ce99ce-6f7a-4ff9-bc6e-acda3633d5c8
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Transaction Object Interfaces
The transaction object defines an atomic unit of work on a data source and determines how those units of work relate to each other. This object is not directly supported by the OLE DB provider templates (that is, you must create your own object).  
  
 The following table shows the mandatory and optional interfaces defined by OLE DB for a transaction object.  
  
|Interface|Required?|Implemented by OLE DB templates?|  
|---------------|---------------|--------------------------------------|  
|[IConnectionPointContainer](http://msdn.microsoft.com/library/windows/desktop/ms683857)|Mandatory|No|  
|[ITransaction](https://msdn.microsoft.com/en-us/library/ms723053.aspx)|Mandatory|No|  
|[ISupportErrorInfo](https://msdn.microsoft.com/en-us/library/ms715816.aspx)|Optional|No|  
  
## See Also  
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)