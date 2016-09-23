---
title: "CStatistics, CStatisticInfo"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CStatistics
  - m_szTableSchema
  - CStatisticInfo
  - m_szTableCatalog
  - m_nCardinality
  - m_szTableName
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_nCardinality
  - m_szTableSchema
  - TABLE_CATALOG
  - TABLE_NAME
  - TABLE_SCHEMA
  - CStatistics typedef class
  - m_szTableCatalog
  - m_szTableName
  - CStatisticInfo parameter class
ms.assetid: 5822231c-6963-44a6-ae2f-29aca76e1600
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStatistics, CStatisticInfo
Call the typedef class **CStatistics** to implement its parameter class **CStatisticInfo**.  
  
## Remarks  
 See [Schema Rowset Classes and Typedef Classes](../vs140/schema-rowset-classes-and-typedef-classes.md) for more information on using typedef classes.  
  
 This class identifies the statistics, defined in the catalog, that are owned by a given user.  
  
 The following table lists the class data members and their corresponding OLE DB Columns. See [STATISTICS Rowset](https://msdn.microsoft.com/en-us/library/ms715957.aspx) in the *OLE DB Programmer's Reference* for more information about the schema and columns.  
  
|Data members|OLE DB columns|  
|------------------|--------------------|  
|m_szTableCatalog|TABLE_CATALOG|  
|m_szTableSchema|TABLE_SCHEMA|  
|m_szTableName|TABLE_NAME|  
|m_nCardinality|CARDINALITY|  
  
## Requirements  
 **Header:** atldbsch.h  
  
## See Also  
 [CRestrictions Class](../vs140/crestrictions-class.md)