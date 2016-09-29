---
title: "CRgn::CRgn"
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
  - "CRgn.CRgn"
  - "CRgn::CRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, constructor"
  - "CRgn class, construction/destruction"
ms.assetid: 1f28a982-51b7-43db-8ec5-116c67c95ef3
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::CRgn
Constructs a `CRgn` object.  
  
## Syntax  
  
```  
  
CRgn( );  
```  
  
## Remarks  
 The `m_hObject` data member does not contain a valid Windows GDI region until the object is initialized with one or more of the other `CRgn` member functions.  
  
## Example  
 See the example for [CRgn::CreateRoundRectRgn](../vs140/crgn--createroundrectrgn.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)