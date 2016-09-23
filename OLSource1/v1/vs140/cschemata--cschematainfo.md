---
title: "CSchemata, CSchemataInfo"
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
  - DEFAULT_CHARACTER_SET_CATALOG
  - DEFAULT_CHARACTER_SET_SCHEMA
  - m_szCharName
  - CSchemataInfo
  - m_szCatalog
  - m_szCharCatalog
  - m_szOwner
  - m_szCharSchema
  - CSchemata
  - m_szName
  - DEFAULT_CHARACTER_SET_NAME
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_szCharName
  - CSchemata typedef class
  - DEFAULT_CHARACTER_SET_NAME
  - m_szOwner
  - CSchemataInfo parameter class
  - DEFAULT_CHARACTER_SET_CATALOG
  - m_szCharSchema
  - m_szCatalog
  - m_szName
  - m_szCharCatalog
  - DEFAULT_CHARACTER_SET_SCHEMA
ms.assetid: 9d06d65a-c27b-446d-bc42-c7e487b0d9c5
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSchemata, CSchemataInfo
Call the typedef class **CSchemata** to implement its parameter class **CSchemataInfo**.  
  
## Remarks  
 See [Schema Rowset Classes and Typedef Classes](../vs140/schema-rowset-classes-and-typedef-classes.md) for more information on using typedef classes.  
  
 This class identifies the schemas that are owned by a given user.  
  
 The following table lists the class data members and their corresponding OLE DB Columns. See [SCHEMATA Rowset](https://msdn.microsoft.com/en-us/library/ms716887.aspx) in the *OLE DB Programmer's Reference* for more information about the schema and columns.  
  
|Data members|OLE DB columns|  
|------------------|--------------------|  
|m_szCatalog|CATALOG_NAME|  
|m_szName|SCHEMA_NAME|  
|m_szOwner|SCHEMA_OWNER|  
|m_szCharCatalog|DEFAULT_CHARACTER_SET_CATALOG|  
|m_szCharSchema|DEFAULT_CHARACTER_SET_SCHEMA|  
|m_szCharName|DEFAULT_CHARACTER_SET_NAME|  
  
## Requirements  
 **Header:** atldbsch.h  
  
## See Also  
 [CRestrictions Class](../vs140/crestrictions-class.md)