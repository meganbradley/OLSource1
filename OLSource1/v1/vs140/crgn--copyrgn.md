---
title: "CRgn::CopyRgn"
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
  - "CRgn::CopyRgn"
  - "CopyRgn"
  - "CRgn.CopyRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, initialization"
  - "CopyRgn method"
ms.assetid: a44b88f6-9db2-4738-ba98-b3ac3d9b84d0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::CopyRgn
Copies the region defined by `pRgnSrc` into the `CRgn` object.  
  
## Syntax  
  
```  
  
      int CopyRgn(  
   CRgn* pRgnSrc   
);  
```  
  
#### Parameters  
 `pRgnSrc`  
 Identifies an existing region.  
  
## Return Value  
 Specifies the type of the resulting region. It can be one of the following values:  
  
-   **COMPLEXREGION** New region has overlapping borders.  
  
-   **ERROR** No new region created.  
  
-   **NULLREGION** New region is empty.  
  
-   **SIMPLEREGION** New region has no overlapping borders.  
  
## Remarks  
 The new region replaces the region formerly stored in the `CRgn` object. This function is a special case of the [CombineRgn](../vs140/crgn--combinergn.md) member function.  
  
## Example  
 See the example for [CRgn::CreateEllipticRgn](../vs140/crgn--createellipticrgn.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRgn::CombineRgn](../vs140/crgn--combinergn.md)   
 [CombineRgn](http://msdn.microsoft.com/library/windows/desktop/dd183465)