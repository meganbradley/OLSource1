---
title: "COleVariant::operator LPVARIANT"
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
  - "COleVariant::operatorLPVARIANT"
  - "COleVariant.operatorLPVARIANT"
  - "operatorLPVARIANT"
  - "LPVARIANT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator LPVARIANT"
  - "LPVARIANT operator"
  - "COleVariant class, operators"
ms.assetid: 78690bd0-0f1d-49c1-a6b0-88515ed2ffac
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleVariant::operator LPVARIANT
Call this casting operator to access the underlying `VARIANT` structure for this `COleVariant` object.  
  
## Syntax  
  
```  
  
operator LPVARIANT( );  
  
```  
  
## Remarks  
  
> [!CAUTION]
>  Changing the value in the **VARIANT** structure accessed by the pointer returned by this function will change the value of this `COleVariant` object.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleVariant Class](../vs140/colevariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleVariant::operator LPCVARIANT](../vs140/colevariant--operator-lpcvariant.md)