---
title: "COleControl::InternalGetFont"
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
  - "COleControl.InternalGetFont"
  - "COleControl::InternalGetFont"
  - "InternalGetFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InternalGetFont method"
ms.assetid: 521a644d-3ea7-4a63-bde2-2fd1cf663d27
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::InternalGetFont
Accesses the stock Font property of your control  
  
## Syntax  
  
```  
  
CFontHolder& InternalGetFont( );  
```  
  
## Return Value  
 A reference to a [CFontHolder](../vs140/cfontholder-class.md) object that contains the stock Font object.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::GetFont](../vs140/colecontrol--getfont.md)   
 [COleControl::SetFont](../vs140/colecontrol--setfont.md)