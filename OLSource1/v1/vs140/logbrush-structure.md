---
title: "LOGBRUSH Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "LOGBRUSH"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LOGBRUSH structure"
ms.assetid: 1bf96768-52c5-4444-9bb8-d41ba2e27e68
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LOGBRUSH Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure defines the style, color, and pattern of a physical brush. It is used by the Windows [CreateBrushIndirect](http://msdn.microsoft.com/library/windows/desktop/dd183487) and [ExtCreatePen](http://msdn.microsoft.com/library/windows/desktop/dd162705) functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the brush style. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member must be one of the following styles:  
  
-   **BS_DIBPATTERN** A pattern brush defined by a device-independent bitmap (DIB) specification. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is **BS_DIBPATTERN**, the **lbHatch** member contains a handle to a packed DIB.  
  
-   **BS_DIBPATTERNPT** A pattern brush defined by a device-independent bitmap (DIB) specification. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is **BS_DIBPATTERNPT**, the **lbHatch** member contains a pointer to a packed DIB.  
  
-   **BS_HATCHED** Hatched brush.  
  
-   **BS_HOLLOW** Hollow brush.  
  
-   **BS_NULL** Same as **BS_HOLLOW**.  
  
-   **BS_PATTERN** Pattern brush defined by a memory bitmap.  
  
-   **BS_SOLID** Solid brush.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the color in which the brush is to be drawn. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is the **BS_HOLLOW** or **BS_PATTERN** style, **lbColor** is ignored. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is **BS_DIBPATTERN** or **BS_DIBPATTERNBT**, the low-order word of **lbColor** specifies whether the **bmiColors** members of the [BITMAPINFO](../vs140/bitmapinfo-structure.md) structure contain explicit red, green, blue (RGB) values or indices into the currently realized logical palette. The **lbColor** member must be one of the following values:  
  
-   **DIB_PAL_COLORS** The color table consists of an array of 16-bit indices into the currently realized logical palette.  
  
-   **DIB_RGB_COLORS** The color table contains literal RGB values.  
  
 *lbHatch*  
 Specifies a hatch style. The meaning depends on the brush style defined by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is **BS_DIBPATTERN**, the **lbHatch** member contains a handle to a packed DIB. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is **BS_DIBPATTERNPT**, the **lbHatch** member contains a pointer to a packed DIB. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is **BS_HATCHED**, the **lbHatch** member specifies the orientation of the lines used to create the hatch. It can be one of the following values:  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> A 45-degree upward, left-to-right hatch  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> Horizontal and vertical crosshatch  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> 45-degree crosshatch  
  
-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> A 45-degree downward, left-to-right hatch  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> Horizontal hatch  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> Vertical hatch  
  
 If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is **BS_PATTERN**, **lbHatch** is a handle to the bitmap that defines the pattern. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is **BS_SOLID** or **BS_HOLLOW**, **lbHatch** is ignored.  
  
## Remarks  
 Although **lbColor** controls the foreground color of a hatch brush, the [CDC::SetBkMode](../vs140/cdc--setbkmode.md) and [CDC::SetBkColor](../vs140/cdc--setbkcolor.md) functions control the background color.  
  
## Requirements  
 **Header:** wingdi.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CDC::GetCharABCWidths](../vs140/cdc--getcharabcwidths.md)