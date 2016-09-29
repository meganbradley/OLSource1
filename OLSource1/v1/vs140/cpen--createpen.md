---
title: "CPen::CreatePen"
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
  - "CreatePen"
  - "CPen::CreatePen"
  - "CPen.CreatePen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreatePen method"
  - "CPen class, initialization"
ms.assetid: b3f06441-9ad7-41eb-a48f-51a361139a2e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPen::CreatePen
Creates a logical cosmetic or geometric pen with the specified style, width, and brush attributes, and attaches it to the `CPen` object.  
  
## Syntax  
  
```  
  
      BOOL CreatePen(  
   int nPenStyle,  
   int nWidth,  
   COLORREF crColor   
);  
BOOL CreatePen(  
   int nPenStyle,  
   int nWidth,  
   const LOGBRUSH* pLogBrush,  
   int nStyleCount = 0,  
   const DWORD* lpStyle = NULL   
);  
```  
  
#### Parameters  
 `nPenStyle`  
 Specifies the style for the pen. For a list of possible values, see the `nPenStyle` parameter in the [CPen](../vs140/cpen--cpen.md) constructor.  
  
 `nWidth`  
 Specifies the width of the pen.  
  
-   For the first version of `CreatePen`, if this value is 0, the width in device units is always 1 pixel, regardless of the mapping mode.  
  
-   For the second version of `CreatePen`, if `nPenStyle` is **PS_GEOMETRIC**, the width is given in logical units. If `nPenStyle` is **PS_COSMETIC**, the width must be set to 1.  
  
 `crColor`  
 Contains an RGB color for the pen.  
  
 `pLogBrush`  
 Points to a [LOGBRUSH](http://msdn.microsoft.com/library/windows/desktop/dd145035) structure. If `nPenStyle` is **PS_COSMETIC**, the **lbColor** member of the `LOGBRUSH` structure specifies the color of the pen and the `lbStyle` member of the `LOGBRUSH` structure must be set to **BS_SOLID**. If **nPenStyle** is **PS_GEOMETRIC**, all members must be used to specify the brush attributes of the pen.  
  
 `nStyleCount`  
 Specifies the length, in doubleword units, of the `lpStyle` array. This value must be zero if `nPenStyle` is not **PS_USERSTYLE**.  
  
 `lpStyle`  
 Points to an array of doubleword values. The first value specifies the length of the first dash in a user-defined style, the second value specifies the length of the first space, and so on. This pointer must be **NULL** if `nPenStyle` is not **PS_USERSTYLE**.  
  
## Return Value  
 Nonzero if successful, or zero if the method fails.  
  
## Remarks  
 The first version of `CreatePen` initializes a pen with the specified style, width, and color. The pen can be subsequently selected as the current pen for any device context.  
  
 Pens that have a width greater than 1 pixel should always have either the **PS_NULL**, **PS_SOLID**, or **PS_INSIDEFRAME** style.  
  
 If a pen has the **PS_INSIDEFRAME** style and a color that does not match a color in the logical color table, the pen is drawn with a dithered color. The **PS_SOLID** pen style cannot be used to create a pen with a dithered color. The style **PS_INSIDEFRAME** is identical to **PS_SOLID** if the pen width is less than or equal to 1.  
  
 The second version of `CreatePen` initializes a logical cosmetic or geometric pen that has the specified style, width, and brush attributes. The width of a cosmetic pen is always 1; the width of a geometric pen is always specified in world units. After an application creates a logical pen, it can select that pen into a device context by calling the [CDC::SelectObject](../vs140/cdc--selectobject.md) function. After a pen is selected into a device context, it can be used to draw lines and curves.  
  
-   If `nPenStyle` is **PS_COSMETIC** and **PS_USERSTYLE**, the entries in the `lpStyle` array specify lengths of dashes and spaces in style units. A style unit is defined by the device in which the pen is used to draw a line.  
  
-   If `nPenStyle` is **PS_GEOMETRIC** and **PS_USERSTYLE**, the entries in the `lpStyle` array specify lengths of dashes and spaces in logical units.  
  
-   If `nPenStyle` is **PS_ALTERNATE**, the style unit is ignored and every other pixel is set.  
  
 When an application no longer requires a given pen, it should call the [CGdiObject::DeleteObject](../vs140/cgdiobject--deleteobject.md) member function or destroy the `CPen` object so the resource is no longer in use. An application should not delete a pen when the pen is selected in a device context.  
  
## Example  
 [!code[NVC_MFCDocView#100](../vs140/codesnippet/CPP/cpen--createpen_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPen Class](../vs140/cpen-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPen::CreatePenIndirect](../vs140/cpen--createpenindirect.md)   
 [CPen::CPen](../vs140/cpen--cpen.md)   
 [CGdiObject::DeleteObject](../vs140/cgdiobject--deleteobject.md)   
 [LOGBRUSH](http://msdn.microsoft.com/library/windows/desktop/dd145035)