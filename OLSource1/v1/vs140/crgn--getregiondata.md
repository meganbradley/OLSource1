---
title: "CRgn::GetRegionData"
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
  - "CRgn.GetRegionData"
  - "GetRegionData"
  - "CRgn::GetRegionData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, operations"
  - "GetRegionData method"
ms.assetid: f2249159-8c24-48aa-bc3a-1603f5a70c4b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::GetRegionData
Fills the specified buffer with data describing the region.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a [RGNDATA](../vs140/rgndata-structure.md) data structure that receives the information. If this parameter is **NULL**, the return value contains the number of bytes needed for the region data.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the size, in bytes, of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> buffer.  
  
## Return Value  
 If the function succeeds and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> specifies an adequate number of bytes, the return value is always <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If the function fails, or if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> specifies less than adequate number of bytes, the return value is 0 (error).  
  
## Remarks  
 This data includes the dimensions of the rectangles that make up the region. This function is used in conjunction with the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRgn::CreateFromData](../vs140/crgn--createfromdata.md)