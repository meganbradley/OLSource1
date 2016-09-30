---
title: "CRgn::GetRgnBox"
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
  - "CRgn::GetRgnBox"
  - "GetRgnBox"
  - "CRgn.GetRgnBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, operations"
  - "GetRgnBox method"
ms.assetid: 0add0d05-b976-4cfb-97f6-e052df658ce1
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::GetRgnBox
Retrieves the coordinates of the bounding rectangle of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to receive the coordinates of the bounding rectangle. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure has the following form:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
## Return Value  
 Specifies the region's type. It can be any of the following values:  
  
-   **COMPLEXREGION** Region has overlapping borders.  
  
-   **NULLREGION** Region is empty.  
  
-   **ERROR** <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object does not specify a valid region.  
  
-   **SIMPLEREGION** Region has no overlapping borders.  
  
## Example  
 See the example for [CRgn::CreatePolygonRgn](../vs140/crgn--createpolygonrgn.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetRgnBox](http://msdn.microsoft.com/library/windows/desktop/dd144921)