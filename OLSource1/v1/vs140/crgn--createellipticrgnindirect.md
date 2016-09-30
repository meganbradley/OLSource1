---
title: "CRgn::CreateEllipticRgnIndirect"
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
  - "CRgn.CreateEllipticRgnIndirect"
  - "CreateEllipticRgnIndirect"
  - "CRgn::CreateEllipticRgnIndirect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, initialization"
  - "CreateEllipticRgnIndirect method"
ms.assetid: 2f44d9d2-6acc-44ce-b236-b60f540b8e28
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::CreateEllipticRgnIndirect
Creates an elliptical region.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that contains the logical coordinates of the upper-left and lower-right corners of the bounding rectangle of the ellipse.  
  
## Return Value  
 Nonzero if the operation succeeded; otherwise 0.  
  
## Remarks  
 The region is defined by the structure or object pointed to by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and is stored in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 When it has finished using a region created with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function, an application should select the region out of the device context and use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function to remove it.  
  
## Example  
 See the example for [CRgn::CreateRectRgnIndirect](../vs140/crgn--createrectrgnindirect.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRgn::CreateEllipticRgn](../vs140/crgn--createellipticrgn.md)   
 [CreateEllipticRgnIndirect](http://msdn.microsoft.com/library/windows/desktop/dd183497)