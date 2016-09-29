---
title: "CDaoTableDef::Append"
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
  - "CDaoTableDef::Append"
  - "CDaoTableDef.Append"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoTableDef class, appending"
  - "tabledefs, appending to collection"
  - "Append method"
ms.assetid: b5e705c1-bb06-48a5-93e4-72a536bb17c6
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::Append
Call this member function after you call [Create](../vs140/cdaotabledef--create.md) to create a new tabledef object to save the tabledef in the database.  
  
## Syntax  
  
```  
  
virtual void Append( );  
  
```  
  
## Remarks  
 The function appends the object to the database's TableDefs collection. You can use the tabledef as a temporary object while defining it by not appending it, but if you want to save and use it, you must call **Append**.  
  
> [!NOTE]
>  If you attempt to append an unnamed tabledef (containing a null or empty string), MFC throws an exception.  
  
 For related information, see the topic "Append Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::Create](../vs140/cdaotabledef--create.md)