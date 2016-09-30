---
title: "CCatalogs, CCatalogInfo"
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
  - "CCatalogs"
  - "m_szName"
  - "CCatalogInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DESCRIPTION class data member"
  - "CCatalogInfo parameter class"
  - "CCatalogs typedef class"
  - "m_szName"
  - "m_szDescription"
ms.assetid: 8362cbbd-2f00-4272-8518-fc235c4de193
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCatalogs, CCatalogInfo
Call the typedef class **CCatalogs** to implement its parameter class **CCatalogInfo**.  
  
## Remarks  
 See [Schema Rowset Classes and Typedef Classes](../vs140/schema-rowset-classes-and-typedef-classes.md) for more information on using typedef classes.  
  
 This class identifies the physical attributes associated with catalogs accessible from the DBMS.  
  
 The following table lists the class data members and their corresponding OLE DB Columns. See [CATALOGS Rowset](https://msdn.microsoft.com/en-us/library/ms721241.aspx) in the *OLE DB Programmer's Reference* for more information about the schema and columns.  
  
|Data members|OLE DB columns|  
|------------------|--------------------|  
|m_szName|CATALOG_NAME|  
|m_szDescription|DESCRIPTION|  
  
## Requirements  
 **Header:** atldbsch.h  
  
## See Also  
 [CRestrictions Class](../vs140/crestrictions-class.md)