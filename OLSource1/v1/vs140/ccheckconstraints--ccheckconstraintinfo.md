---
title: "CCheckConstraints, CCheckConstraintInfo"
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
  - "CCheckConstraintInfo"
  - "CHECK_CONSTRAINTS"
  - "m_szCatalog"
  - "CCheckConstraints"
  - "CONSTRAINT_NAME"
  - "m_szSchema"
  - "CHECK_CLAUSE"
  - "m_szCheckClause"
  - "m_szName"
  - "CONSTRAINT_CATALOG"
  - "CONSTRAINT_SCHEMA"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DESCRIPTION class data member"
  - "m_szSchema"
  - "CONSTRAINT_CATALOG"
  - "m_szCatalog"
  - "CONSTRAINT_NAME"
  - "CONSTRAINT_SCHEMA"
  - "CCheckConstraints typedef class"
  - "CHECK_CLAUSE"
  - "m_szName"
  - "m_szDescription"
  - "CCheckConstraintInfo parameter class"
  - "m_szCheckClause"
  - "CHECK_CONSTRAINTS"
ms.assetid: e53e79a5-01e5-42b7-aa8c-164aec94b011
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCheckConstraints, CCheckConstraintInfo
Call the typedef class **CCheckConstraints** to implement its parameter class **CCheckConstraintInfo**.  
  
## Remarks  
 See [Schema Rowset Classes and Typedef Classes](../vs140/schema-rowset-classes-and-typedef-classes.md) for more information on using typedef classes.  
  
 This class identifies the check constraints, defined in the catalog, that are owned by a given user. A check constraint specifies the data values or formats that are acceptable in one or more columns in a table.  
  
 The following table lists the class data members and their corresponding OLE DB Columns. See [CHECK_CONSTRAINTS Rowset](https://msdn.microsoft.com/en-us/library/ms712845.aspx) in the *OLE DB Programmer's Reference* for more information about the schema and columns.  
  
|Data members|OLE DB columns|  
|------------------|--------------------|  
|m_szCatalog|CONSTRAINT_CATALOG|  
|m_szSchema|CONSTRAINT_SCHEMA|  
|m_szName|CONSTRAINT_NAME|  
|m_szCheckClause|CHECK_CLAUSE|  
|m_szDescription|DESCRIPTION|  
  
## Requirements  
 **Header:** atldbsch.h  
  
## See Also  
 [CRestrictions Class](../vs140/crestrictions-class.md)