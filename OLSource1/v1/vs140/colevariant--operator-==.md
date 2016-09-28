---
title: "COleVariant::operator =="
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
  - "COleVariant::operator=="
  - "COleVariant.operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleVariant class, operators"
  - "operator ==, variant"
  - "operator==, variant"
  - "== operator"
ms.assetid: 7e2c50fe-af33-4886-8c91-751e90e71c0f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleVariant::operator ==
This operator compares two variant values and returns nonzero if they are equal; otherwise 0.  
  
## Syntax  
  
```  
  
      BOOL operator ==(  
   const VARIANT& varSrc   
) const;  
BOOL operator ==(  
   LPCVARIANT pSrc   
) const;  
```  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleVariant Class](../vs140/colevariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleVariant::operator =](../vs140/colevariant--operator-=.md)