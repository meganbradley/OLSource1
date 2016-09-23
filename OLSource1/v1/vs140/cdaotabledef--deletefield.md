---
title: "CDaoTableDef::DeleteField"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - DeleteField
  - CDaoTableDef.DeleteField
  - CDaoTableDef::DeleteField
dev_langs: 
  - C++
helpviewer_keywords: 
  - tabledefs, deleting fields
  - DeleteField method
  - CDaoTableDef class, deleting fields
ms.assetid: 306348ca-b329-4321-adba-f6f2583ec6f4
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoTableDef::DeleteField
Call this member function to remove a field and make it inaccessible.  
  
## Syntax  
  
```  
  
      void DeleteField(   
   LPCTSTR lpszName    
);  
void DeleteField(   
   int nIndex    
);  
```  
  
#### Parameters  
 `lpszName`  
 A pointer to a string expression that is the name of an existing field.  
  
 `nIndex`  
 The index of the field in the table's zero-based Fields collection, for lookup by index.  
  
## Remarks  
 You can use this member function on a new object that has not been appended to the database or when [CanUpdate](../vs140/cdaotabledef--canupdate.md) returns nonzero.  
  
 For related information, see the topic "Delete Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::CreateField](../vs140/cdaotabledef--createfield.md)   
 [CDaoTableDef::CreateIndex](../vs140/cdaotabledef--createindex.md)   
 [CDaoTableDef::DeleteIndex](../vs140/cdaotabledef--deleteindex.md)