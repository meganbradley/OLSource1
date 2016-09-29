---
title: "CColumnDomainUsage, CColumnDomainUsageInfo"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "m_szTableSchema"
  - "m_szCatalog"
  - "m_nColumnPropID"
  - "CColumnDomainUsageInfo"
  - "COLUMN_GUID"
  - "DOMAIN_NAME"
  - "m_szColumnName"
  - "DOMAIN_SCHEMA"
  - "DOMAIN_CATALOG"
  - "m_szTableCatalog"
  - "m_szSchema"
  - "COLUMN_PROPID"
  - "m_guidColumn"
  - "CColumnDomainUsage"
  - "m_szTableName"
  - "m_szName"
  - "COLUMN_DOMAIN_USAGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COLUMN_PROPID"
  - "m_szSchema"
  - "DOMAIN_NAME"
  - "DOMAIN_SCHEMA"
  - "m_szTableSchema"
  - "TABLE_CATALOG"
  - "m_szCatalog"
  - "TABLE_NAME"
  - "m_nColumnPropID"
  - "CColumnDomainUsageInfo parameter class"
  - "TABLE_SCHEMA"
  - "m_szColumnName"
  - "COLUMN_NAME"
  - "m_szName"
  - "m_szTableCatalog"
  - "m_szTableName"
  - "COLUMN_DOMAIN_USAGE"
  - "COLUMN_GUID"
  - "CColumnDomainUsage typedef class"
  - "m_guidColumn"
  - "DOMAIN_CATALOG"
ms.assetid: 5ff331f1-b99c-4002-9e04-367708c5759f
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CColumnDomainUsage, CColumnDomainUsageInfo
Call the typedef class **CColumnDomainUsage** to implement its parameter class **CColumnDomainUsageInfo**.  
  
## Remarks  
 See [Schema Rowset Classes and Typedef Classes](../vs140/schema-rowset-classes-and-typedef-classes.md) for more information on using typedef classes.  
  
 This class identifies the columns, defined in the catalog, that are dependent on a domain defined in the catalog and owned by a given user.  
  
 The following table lists the class data members and their corresponding OLE DB Columns. See [COLUMN_DOMAIN_USAGE Rowset](https://msdn.microsoft.com/en-us/library/ms711240.aspx) in the *OLE DB Programmer's Reference* for more information about the schema and columns.  
  
|Data members|OLE DB columns|  
|------------------|--------------------|  
|m_szCatalog|DOMAIN_CATALOG|  
|m_szSchema|DOMAIN_SCHEMA|  
|m_szName|DOMAIN_NAME|  
|m_szTableCatalog|TABLE_CATALOG|  
|m_szTableSchema|TABLE_SCHEMA|  
|m_szTableName|TABLE_NAME|  
|m_szColumnName|COLUMN_NAME|  
|m_guidColumn|COLUMN_GUID|  
|m_nColumnPropID|COLUMN_PROPID|  
  
## Requirements  
 **Header:** atldbsch.h  
  
## See Also  
 [CRestrictions Class](../vs140/crestrictions-class.md)