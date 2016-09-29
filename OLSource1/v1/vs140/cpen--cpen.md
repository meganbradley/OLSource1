---
title: "CPen::CPen"
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
  - "CPen::CPen"
  - "CPen.CPen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPen class, constructor"
  - "CPen class, construction/destruction"
ms.assetid: 8323e37a-a887-43e6-b4fe-0b1d3e8e64cd
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPen::CPen
Constructs a `CPen` object.  
  
## Syntax  
  
```  
  
      CPen( );  
CPen(  
   int nPenStyle,  
   int nWidth,  
   COLORREF crColor   
);  
CPen(  
   int nPenStyle,  
   int nWidth,  
   const LOGBRUSH* pLogBrush,  
   int nStyleCount = 0,  
   const DWORD* lpStyle = NULL   
);  
```  
  
#### Parameters  
 `nPenStyle`  
 Specifies the pen style. This parameter in the first version of the constructor can be one of the following values:  
  
-   **PS_SOLID** Creates a solid pen.  
  
-   **PS_DASH** Creates a dashed pen. Valid only when the pen width is 1 or less, in device units.  
  
-   **PS_DOT** Creates a dotted pen. Valid only when the pen width is 1 or less, in device units.  
  
-   **PS_DASHDOT** Creates a pen with alternating dashes and dots. Valid only when the pen width is 1 or less, in device units.  
  
-   **PS_DASHDOTDOT** Creates a pen with alternating dashes and double dots. Valid only when the pen width is 1 or less, in device units.  
  
-   **PS_NULL** Creates a null pen.  
  
-   **PS_INSIDEFRAME** Creates a pen that draws a line inside the frame of closed shapes produced by the Windows GDI output functions that specify a bounding rectangle (for example, the **Ellipse**, **Rectangle**, `RoundRect`, `Pie`, and `Chord` member functions). When this style is used with Windows GDI output functions that do not specify a bounding rectangle (for example, the `LineTo` member function), the drawing area of the pen is not limited by a frame.  
  
 The second version of the `CPen` constructor specifies a combination of type, style, end cap, and join attributes. The values from each category should be combined by using the bitwise OR operator (&#124;). The pen type can be one of the following values:  
  
-   **PS_GEOMETRIC** Creates a geometric pen.  
  
-   **PS_COSMETIC** Creates a cosmetic pen.  
  
     The second version of the `CPen` constructor adds the following pen styles for `nPenStyle`:  
  
-   **PS_ALTERNATE** Creates a pen that sets every other pixel. (This style is applicable only for cosmetic pens.)  
  
-   **PS_USERSTYLE** Creates a pen that uses a styling array supplied by the user.  
  
     The end cap can be one of the following values:  
  
-   **PS_ENDCAP_ROUND** End caps are round.  
  
-   **PS_ENDCAP_SQUARE** End caps are square.  
  
-   **PS_ENDCAP_FLAT** End caps are flat.  
  
     The join can be one of the following values:  
  
-   **PS_JOIN_BEVEL** Joins are beveled.  
  
-   **PS_JOIN_MITER** Joins are mitered when they are within the current limit set by the [SetMiterLimit](http://msdn.microsoft.com/library/windows/desktop/dd145076) function. If the join exceeds this limit, it is beveled.  
  
-   **PS_JOIN_ROUND** Joins are round.  
  
 `nWidth`  
 Specifies the width of the pen.  
  
-   For the first version of the constructor, if this value is 0, the width in device units is always 1 pixel, regardless of the mapping mode.  
  
-   For the second version of the constructor, if `nPenStyle` is **PS_GEOMETRIC**, the width is given in logical units. If `nPenStyle` is **PS_COSMETIC**, the width must be set to 1.  
  
 `crColor`  
 Contains an RGB color for the pen.  
  
 `pLogBrush`  
 Points to a `LOGBRUSH` structure. If `nPenStyle` is **PS_COSMETIC**, the `lbColor` member of the `LOGBRUSH` structure specifies the color of the pen and the `lbStyle` member of the `LOGBRUSH` structure must be set to **BS_SOLID**. If `nPenStyle` is **PS_GEOMETRIC**, all members must be used to specify the brush attributes of the pen.  
  
 `nStyleCount`  
 Specifies the length, in doubleword units, of the `lpStyle` array. This value must be zero if `nPenStyle` is not **PS_USERSTYLE**.  
  
 `lpStyle`  
 Points to an array of doubleword values. The first value specifies the length of the first dash in a user-defined style, the second value specifies the length of the first space, and so on. This pointer must be **NULL** if `nPenStyle` is not **PS_USERSTYLE**.  
  
## Remarks  
 If you use the constructor with no arguments, you must initialize the resulting `CPen` object with the `CreatePen`, `CreatePenIndirect`, or `CreateStockObject` member functions.  
  
 If you use the constructor that takes arguments, then no further initialization is necessary. The constructor with arguments can throw an exception if errors are encountered, while the constructor with no arguments will always succeed.  
  
## Example  
 [!code[NVC_MFCDocView#99](../vs140/codesnippet/CPP/cpen--cpen_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPen Class](../vs140/cpen-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPen::CreatePen](../vs140/cpen--createpen.md)   
 [CPen::CreatePenIndirect](../vs140/cpen--createpenindirect.md)   
 [CGdiObject::CreateStockObject](../vs140/cgdiobject--createstockobject.md)