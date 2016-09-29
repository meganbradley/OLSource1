---
title: "COleClientItem::GetDrawAspect"
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
  - "COleClientItem.GetDrawAspect"
  - "COleClientItem::GetDrawAspect"
  - "GetDrawAspect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, status"
  - "GetDrawAspect method"
ms.assetid: ccc3261e-fd26-43d0-a42f-7996a011cb4b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::GetDrawAspect
Call the `GetDrawAspect` member function to determine the current "aspect," or view, of the item.  
  
## Syntax  
  
```  
  
DVASPECT GetDrawAspect( ) const;  
```  
  
## Return Value  
 A value from the `DVASPECT` enumeration, whose values are listed in the reference for [SetDrawAspect](../vs140/coleclientitem--setdrawaspect.md).  
  
## Remarks  
 The aspect specifies how the item is to be rendered.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::SetDrawAspect](../vs140/coleclientitem--setdrawaspect.md)   
 [COleClientItem::Draw](../vs140/coleclientitem--draw.md)