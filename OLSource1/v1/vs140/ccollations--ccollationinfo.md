---
title: "CCollations, CCollationInfo"
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
  - "COLLATION_CATALOG"
  - "m_szCatalog"
  - "CCollationInfo"
  - "CCollations"
  - "CHARACTER_SET_NAME"
  - "CHARACTER_SET_SCHEMA"
  - "m_szCharSetName"
  - "m_szSchema"
  - "CHARACTER_SET_CATALOG"
  - "m_szCharSetSchema"
  - "m_szCharSetCatalog"
  - "m_szPadAttribute"
  - "COLLATION_NAME"
  - "COLLATION_SCHEMA"
  - "m_szName"
  - "COLLATIONS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_szSchema"
  - "COLLATION_SCHEMA"
  - "m_szCharSetCatalog"
  - "m_szCatalog"
  - "COLLATIONS recordset"
  - "COLLATION_CATALOG"
  - "CCollationInfo parameter class"
  - "m_szName"
  - "COLLATION_NAME"
  - "m_szPadAttribute"
  - "CHARACTER_SET_NAME"
  - "m_szCharSetName"
  - "CHARACTER_SET_SCHEMA"
  - "CHARACTER_SET_CATALOG"
  - "m_szCharSetSchema"
  - "CCollations typedef class"
ms.assetid: d8b43c4d-9dd5-4043-b4c8-38c03bfa0c72
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCollations, CCollationInfo
Call the typedef class **CCollations** to implement its parameter class **CCollationInfo**.  
  
## Remarks  
 See [Schema Rowset Classes and Typedef Classes](../vs140/schema-rowset-classes-and-typedef-classes.md) for more information on using typedef classes.  
  
 This class identifies the character collations, defined in the catalog, that are accessible to a given user.  
  
 The following table lists the class data members and their corresponding OLE DB Columns. See [COLLATIONS Rowset](https://msdn.microsoft.com/en-us/library/ms715783.aspx) in the *OLE DB Programmer's Reference* for more information about the schema and columns.  
  
|Data members|OLE DB columns|  
|------------------|--------------------|  
|m_szCatalog|COLLATION_CATALOG|  
|m_szSchema|COLLATION_SCHEMA|  
|m_szName|COLLATION_NAME|  
|m_szCharSetCatalog|CHARACTER_SET_CATALOG|  
|m_szCharSetSchema|CHARACTER_SET_SCHEMA|  
|m_szCharSetName|CHARACTER_SET_NAME|  
|m_szPadAttribute|PAD_ATTRIBUTE|  
  
## Requirements  
 **Header:** atldbsch.h  
  
## See Also  
 [CRestrictions Class](../vs140/crestrictions-class.md)