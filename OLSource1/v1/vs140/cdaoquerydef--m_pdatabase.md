---
title: "CDaoQueryDef::m_pDatabase"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CDaoQueryDef::m_pDatabase"
  - "m_pDatabase"
  - "CDaoQueryDef.m_pDatabase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pDatabase"
  - "database objects [C++], querydef's pointer to"
  - "QueryDef objects, pointers to database objects"
  - "CDaoQueryDef class, pointer to database object"
ms.assetid: 8ead0481-a092-4657-8583-b7472bdd36f9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::m_pDatabase
Contains a pointer to the [CDaoDatabase](../vs140/cdaodatabase-class.md) object associated with the querydef object.  
  
## Remarks  
 Use this pointer if you need to access the database directly — for example, to obtain pointers to other querydef or recordset objects in the database's collections.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)