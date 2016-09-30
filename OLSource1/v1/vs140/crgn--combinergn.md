---
title: "CRgn::CombineRgn"
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
  - "CRgn.CombineRgn"
  - "CombineRgn"
  - "CRgn::CombineRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, initialization"
  - "CombineRgn method"
ms.assetid: c20ff366-845d-465c-9fff-69205aceec51
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::CombineRgn
Creates a new GDI region by combining two existing regions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifies an existing region.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Identifies an existing region.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the operation to be performed when combining the two source regions. It can be any one of the following values:  
  
-   **RGN_AND** Uses overlapping areas of both regions (intersection).  
  
-   **RGN_COPY** Creates a copy of region 1 (identified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
-   **RGN_DIFF** Creates a region consisting of the areas of region 1 (identified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) that are not part of region 2 (identified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
-   **RGN_OR** Combines both regions in their entirety (union).  
  
-   **RGN_XOR** Combines both regions but removes overlapping areas.  
  
## Return Value  
 Specifies the type of the resulting region. It can be one of the following values:  
  
-   **COMPLEXREGION** New region has overlapping borders.  
  
-   **ERROR** No new region created.  
  
-   **NULLREGION** New region is empty.  
  
-   **SIMPLEREGION** New region has no overlapping borders.  
  
## Remarks  
 The regions are combined as specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 The two specified regions are combined, and the resulting region handle is stored in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object. Thus, whatever region is stored in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object is replaced by the combined region.  
  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 Use [CopyRgn](../vs140/crgn--copyrgn.md) to simply copy one region into another region.  
  
## Example  
 [!code[NVC_MFCDocView#144](../vs140/codesnippet/CPP/crgn--combinergn_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRgn::CopyRgn](../vs140/crgn--copyrgn.md)   
 [CombineRgn](http://msdn.microsoft.com/library/windows/desktop/dd183465)