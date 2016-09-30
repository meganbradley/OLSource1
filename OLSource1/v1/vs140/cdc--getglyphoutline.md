---
title: "CDC::GetGlyphOutline"
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
  - "CDC.GetGlyphOutline"
  - "GetGlyphOutline"
  - "CDC::GetGlyphOutline"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetGlyphOutline method"
  - "CDC class, font functions"
ms.assetid: 3700567b-afb0-4f3c-a29c-fd7f6aff3d00
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetGlyphOutline
Retrieves the outline curve or bitmap for an outline character in the current font.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the character for which information is to be returned.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the format in which the function is to return information. It can be one of the following values, or 0:  
  
|Value|Meaning|  
|-----------|-------------|  
|**GGO_BITMAP**|Returns the glyph bitmap. When the function returns, the buffer pointed to by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> contains a 1-bit-per-pixel bitmap whose rows start on doubleword boundaries.|  
|**GGO_NATIVE**|Returns the curve data points in the rasterizer's native format, using device units. When this value is specified, any transformation specified in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is ignored.|  
  
 When the value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is 0, the function fills in a [GLYPHMETRICS](http://msdn.microsoft.com/library/windows/desktop/dd144955) structure but does not return glyph-outline data.  
  
 *lpgm*  
 Points to a **GLYPHMETRICS** structure that describes the placement of the glyph in the character cell.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the size of the buffer into which the function copies information about the outline character. If this value is 0 and the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter is either the **GGO_BITMAP** or **GGO_NATIVE** values, the function returns the required size of the buffer.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Points to a buffer into which the function copies information about the outline character. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> specifies the **GGO_NATIVE** value, the information is copied in the form of **TTPOLYGONHEADER** and **TTPOLYCURVE** structures. If this value is **NULL** and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is either the **GGO_BITMAP** or **GGO_NATIVE** value, the function returns the required size of the buffer.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Points to a [MAT2](http://msdn.microsoft.com/library/windows/desktop/dd145048) structure that contains a transformation matrix for the character. This parameter cannot be **NULL**, even when the **GGO_NATIVE** value is specified for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Return Value  
 The size, in bytes, of the buffer required for the retrieved information if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is 0 or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is **NULL**. Otherwise, it is a positive value if the function is successful, or –1 if there is an error.  
  
## Remarks  
 An application can rotate characters retrieved in bitmap format by specifying a 2-by-2 transformation matrix in the structure pointed to by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 A glyph outline is returned as a series of contours. Each contour is defined by a [TTPOLYGONHEADER](http://msdn.microsoft.com/library/windows/desktop/dd145158) structure followed by as many **TTPOLYCURVE** structures as are required to describe it. All points are returned as [POINTFX](http://msdn.microsoft.com/library/windows/desktop/dd162806) structures and represent absolute positions, not relative moves. The starting point given by the **pfxStart** member of the [TTPOLYGONHEADER](http://msdn.microsoft.com/library/windows/desktop/dd145158) structure is the point at which the outline for a contour begins. The [TTPOLYCURVE](http://msdn.microsoft.com/library/windows/desktop/dd145157) structures that follow can be either polyline records or spline records. Polyline records are a series of points; lines drawn between the points describe the outline of the character. Spline records represent the quadratic curves used by TrueType (that is, quadratic b-splines).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetOutlineTextMetrics](../vs140/cdc--getoutlinetextmetrics.md)   
 [GetGlyphOutline](http://msdn.microsoft.com/library/windows/desktop/dd144891)   
 [GLYPHMETRICS](http://msdn.microsoft.com/library/windows/desktop/dd144955)   
 [TTPOLYGONHEADER](http://msdn.microsoft.com/library/windows/desktop/dd145158)   
 [TTPOLYCURVE](http://msdn.microsoft.com/library/windows/desktop/dd145157)