---
title: "CDaoTableDef::CDaoTableDef"
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
  - "CDaoTableDef.CDaoTableDef"
  - "CDaoTableDef::CDaoTableDef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoTableDef class, constructor"
  - "tabledefs, construction"
ms.assetid: f90a5918-0bd5-4ea6-83de-cc0f0055fd59
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::CDaoTableDef
Constructs a **CDaoTableDef** object.  
  
## Syntax  
  
```  
  
      CDaoTableDef(  
   CDaoDatabase* pDatabase   
);  
```  
  
#### Parameters  
 `pDatabase`  
 A pointer to a [CDaoDatabase](../vs140/cdaodatabase-class.md) object.  
  
## Remarks  
 After constructing the object, you must call the [Create](../vs140/cdaotabledef--create.md) or [Open](../vs140/cdaotabledef--open.md) member function. When you finish with the object, you must call its [Close](../vs140/cdaotabledef--close.md) member function and destroy the `CDaoTableDef` object.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::Open](../vs140/cdaotabledef--open.md)   
 [CDaoTableDef::Close](../vs140/cdaotabledef--close.md)   
 [CDaoTableDef::Create](../vs140/cdaotabledef--create.md)   
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)