---
title: "CRgn::CreateFromData"
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
  - "CRgn::CreateFromData"
  - "CreateFromData"
  - "CRgn.CreateFromData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, initialization"
  - "CreateFromData method"
ms.assetid: bde6e1b7-c7b2-458c-9f2b-d00956dd32d1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::CreateFromData
Creates a region from the given region and transformation data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lpXForm*  
 Points to an [XFORM](../vs140/xform-structure.md) data structure that defines the transformation to be performed on the region. If this pointer is **NULL**, the identity transformation is used.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the number of bytes pointed to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to a [RGNDATA](../vs140/rgndata-structure.md) data structure that contains the region data.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 An application can retrieve data for a region by calling the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRgn::GetRegionData](../vs140/crgn--getregiondata.md)   
 [ExtCreateRegion](http://msdn.microsoft.com/library/windows/desktop/dd162706)