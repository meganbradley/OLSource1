---
title: "CRgn::EqualRgn"
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
  - "EqualRgn"
  - "CRgn.EqualRgn"
  - "CRgn::EqualRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EqualRgn method"
  - "CRgn class, operations"
ms.assetid: 9685ae11-ba8d-4d32-abf8-ee6cfed5c215
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::EqualRgn
Determines whether the given region is equivalent to the region stored in the `CRgn` object.  
  
## Syntax  
  
```  
  
      BOOL EqualRgn(  
   CRgn* pRgn   
) const;  
```  
  
#### Parameters  
 `pRgn`  
 Identifies a region.  
  
## Return Value  
 Nonzero if the two regions are equivalent; otherwise 0.  
  
## Example  
 [!code[NVC_MFCDocView#150](../vs140/codesnippet/CPP/crgn--equalrgn_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [EqualRgn](http://msdn.microsoft.com/library/windows/desktop/dd162700)