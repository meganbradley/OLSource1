---
title: "CDaoTableDef::DeleteIndex"
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
  - "DeleteIndex"
  - "CDaoTableDef.DeleteIndex"
  - "CDaoTableDef::DeleteIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteIndex method"
  - "tabledefs, deleting indexes"
  - "CDaoTableDef class, deleting indexes"
ms.assetid: a3c5693d-0dbf-46ed-8422-927c6946cfeb
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::DeleteIndex
Call this member function to delete an index in an underlying table.  
  
## Syntax  
  
```  
  
      void DeleteIndex(   
   LPCTSTR lpszName    
);  
void DeleteIndex(   
   int nIndex    
);  
```  
  
#### Parameters  
 `lpszName`  
 A pointer to a string expression that is the name of an existing index.  
  
 `nIndex`  
 The array index of the index object in the database's zero-based TableDefs collection, for lookup by index.  
  
## Remarks  
 You can use this member function on a new object that hasn't been appended to the database or when [CanUpdate](../vs140/cdaotabledef--canupdate.md) returns nonzero.  
  
 For related information, see the topic "Delete Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::CreateIndex](../vs140/cdaotabledef--createindex.md)   
 [CDaoTableDef::CreateField](../vs140/cdaotabledef--createfield.md)   
 [CDaoTableDef::DeleteField](../vs140/cdaotabledef--deletefield.md)