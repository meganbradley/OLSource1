---
title: "CDocItem::IsBlank"
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
  - CDocItem::IsBlank
  - IsBlank
  - CDocItem.IsBlank
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsBlank method
  - CDocItem class, overridables
ms.assetid: 20eb5128-01f7-4d9a-8fc4-80fc6456f25d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDocItem::IsBlank
Called by the framework when default serialization occurs.  
  
## Syntax  
  
```  
  
virtual BOOL IsBlank( ) const;  
```  
  
## Return Value  
 Nonzero if the item contains no information; otherwise 0.  
  
## Remarks  
 By default, `CDocItem` objects are not blank. [COleClientItem](../vs140/coleclientitem-class.md) objects are sometimes blank because they derive directly from `CDocItem`. However, [COleServerItem](../vs140/coleserveritem-class.md) objects are always blank. By default, OLE applications containing `COleClientItem` objects that have no x or y extent are serialized. This is done by returning **TRUE** from an override of `IsBlank` when the item has no x or y extent.  
  
 Override this function if you want to implement other actions during serialization.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [CDocItem Class](../vs140/cdocitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)