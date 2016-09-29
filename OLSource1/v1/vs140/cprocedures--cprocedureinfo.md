---
title: "CProcedures, CProcedureInfo"
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
  - "CProcedures"
  - "m_szCatalog"
  - "CProcedureInfo"
  - "m_szSchema"
  - "m_szDefinition"
  - "m_szName"
  - "m_nType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DESCRIPTION class data member"
  - "m_szSchema"
  - "m_nType"
  - "m_szCatalog"
  - "CProcedureInfo parameter class"
  - "m_szName"
  - "m_szDescription"
  - "m_szDefinition"
  - "CProcedures typedef class"
ms.assetid: d0c7375e-ee0c-441d-aae6-6108150860a0
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CProcedures, CProcedureInfo
Call the typedef class **CProcedures** to implement its parameter class **CProcedureInfo**.  
  
## Remarks  
 See [Schema Rowset Classes and Typedef Classes](../vs140/schema-rowset-classes-and-typedef-classes.md) for more information on using typedef classes.  
  
 This class identifies the procedures, defined in the catalog, that are owned by a given user.  
  
 The following table lists the class data members and their corresponding OLE DB Columns. See [PROCEDURES Rowset](https://msdn.microsoft.com/en-us/library/ms724021.aspx) in the *OLE DB Programmer's Reference* for more information about the schema and columns.  
  
|Data members|OLE DB columns|  
|------------------|--------------------|  
|m_szCatalog|PROCEDURE_CATALOG|  
|m_szSchema|PROCEDURE_SCHEMA|  
|m_szName|PROCEDURE_NAME|  
|m_nType|PROCEDURE_TYPE|  
|m_szDefinition|PROCEDURE_DEFINITION|  
|m_szDescription|DESCRIPTION|  
  
## Requirements  
 **Header:** atldbsch.h  
  
## See Also  
 [CRestrictions Class](../vs140/crestrictions-class.md)