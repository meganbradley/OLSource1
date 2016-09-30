---
title: "CRgn::CreateEllipticRgn"
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
  - "CRgn::CreateEllipticRgn"
  - "CRgn.CreateEllipticRgn"
  - "CreateEllipticRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, initialization"
  - "CreateEllipticRgn method"
ms.assetid: e7bb105c-07f7-481e-9da4-a103e3aca881
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::CreateEllipticRgn
Creates an elliptical region.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the upper-left corner of the bounding rectangle of the ellipse.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the upper-left corner of the bounding rectangle of the ellipse.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the lower-right corner of the bounding rectangle of the ellipse.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the lower-right corner of the bounding rectangle of the ellipse.  
  
## Return Value  
 Nonzero if the operation succeeded; otherwise 0.  
  
## Remarks  
 The region is defined by the bounding rectangle specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The region is stored in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 When it has finished using a region created with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function, an application should select the region out of the device context and use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function to remove it.  
  
## Example  
 [!code[NVC_MFCDocView#145](../vs140/codesnippet/CPP/crgn--createellipticrgn_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRgn::CreateEllipticRgnIndirect](../vs140/crgn--createellipticrgnindirect.md)   
 [CreateEllipticRgn](http://msdn.microsoft.com/library/windows/desktop/dd183496)