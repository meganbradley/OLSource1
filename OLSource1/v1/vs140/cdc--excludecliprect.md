---
title: "CDC::ExcludeClipRect"
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
  - "ExcludeClipRect"
  - "CDC.ExcludeClipRect"
  - "CDC::ExcludeClipRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ExcludeClipRect method"
  - "CDC class, clipping functions"
ms.assetid: 7a5f5014-0dd4-46e4-9f63-d5283a79d7bc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ExcludeClipRect
Creates a new clipping region that consists of the existing clipping region minus the specified rectangle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the upper-left corner of the rectangle.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the upper-left corner of the rectangle.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the lower-right corner of the rectangle.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the lower-right corner of the rectangle.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the rectangle. Can also be a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
## Return Value  
 Specifies the new clipping region's type. It can be any of the following values:  
  
-   **COMPLEXREGION** The region has overlapping borders.  
  
-   **ERROR** No region was created.  
  
-   **NULLREGION** The region is empty.  
  
-   **SIMPLEREGION** The region has no overlapping borders.  
  
## Remarks  
 The width of the rectangle, specified by the absolute value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, must not exceed 32,767 units. This limit applies to the height of the rectangle as well.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::ExcludeUpdateRgn](../vs140/cdc--excludeupdatergn.md)   
 [ExcludeClipRect](http://msdn.microsoft.com/library/windows/desktop/dd162702)