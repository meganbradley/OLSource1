---
title: "CDaoTableDef::SetName"
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
  - "SetName"
  - "CDaoTableDef.SetName"
  - "CDaoTableDef::SetName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tabledefs, setting table names"
  - "SetName method"
  - "CDaoTableDef class, setting table names"
ms.assetid: 261a27c9-a27a-4415-ae6e-61ce479cc5cb
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::SetName
Call this member function to set a user-defined name for a table.  
  
## Syntax  
  
```  
  
      void SetName(   
   LPCTSTR lpszName    
);  
```  
  
#### Parameters  
 `lpszName`  
 A pointer to a string expression that specifies a name for a table.  
  
## Remarks  
 The name must start with a letter and can contain a maximum of 64 characters. It can include numbers and underscore characters but cannot include punctuation or spaces.  
  
 For related information, see the topic "Name Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::RefreshLink](../vs140/cdaotabledef--refreshlink.md)   
 [CDaoTableDef::SetConnect](../vs140/cdaotabledef--setconnect.md)