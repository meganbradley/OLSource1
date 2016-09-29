---
title: "COleServerItem::m_sizeExtent"
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
  - "COleServerItem.m_sizeExtent"
  - "COleServerItem::m_sizeExtent"
  - "m_sizeExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerItem class, data members"
  - "m_sizeExtent"
ms.assetid: f2322fd8-e0a8-4870-989f-ec0238ee9c46
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::m_sizeExtent
This member tells the server how much of the object is visible in the container document.  
  
## Syntax  
  
```  
  
CSize m_sizeExtent;  
```  
  
## Remarks  
 The default implementation of [OnSetExtent](../vs140/coleserveritem--onsetextent.md) sets this member.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::OnSetExtent](../vs140/coleserveritem--onsetextent.md)