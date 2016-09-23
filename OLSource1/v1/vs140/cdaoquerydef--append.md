---
title: "CDaoQueryDef::Append"
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
  - CDaoQueryDef.Append
  - CDaoQueryDef::Append
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDaoQueryDef class, appending querydefs
  - appending querydefs to QueryDefs collection
  - QueryDef objects, saving
  - QueryDefs collection
  - CDaoQueryDef class, saving querydefs
  - Append method
ms.assetid: 09837e02-bef3-4424-850d-408e7e6c16a8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoQueryDef::Append
Call this member function after you call [Create](../vs140/cdaoquerydef--create.md) to create a new querydef object.  
  
## Syntax  
  
```  
  
virtual void Append( );  
  
```  
  
## Remarks  
 **Append** saves the querydef in the database by appending the object to the database's QueryDefs collection. You can use the querydef as a temporary object without appending it, but if you want it to persist, you must call **Append**.  
  
 If you attempt to append a temporary querydef object, MFC throws an exception of type [CDaoException](../vs140/cdaoexception-class.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)