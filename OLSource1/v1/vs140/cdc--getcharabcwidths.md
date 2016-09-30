---
title: "CDC::GetCharABCWidths"
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
  - "CDC::GetCharABCWidths"
  - "CDC.GetCharABCWidths"
  - "GetCharABCWidths"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCharABCWidths method"
  - "CDC class, font functions"
ms.assetid: ca59c5d5-e2fb-44fa-b061-911bd2407212
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetCharABCWidths
Retrieves the widths of consecutive characters in a specified range from the current TrueType font.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the first character in the range of characters from the current font for which character widths are returned.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the last character in the range of characters from the current font for which character widths are returned.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to an array of [ABC](../vs140/abc-structure.md) structures that receive the character widths when the function returns. This array must contain at least as many **ABC** structures as there are characters in the range specified by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameters.  
  
 *lpABCF*  
 Points to an application-supplied buffer with an array of [ABCFLOAT](../vs140/abcfloat-structure.md) structures to receive the character widths when the function returns. The widths returned by this function are in the IEEE floating-point format.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The widths are returned in logical units. This function succeeds only with TrueType fonts.  
  
 The TrueType rasterizer provides "ABC" character spacing after a specific point size has been selected. "A" spacing is the distance that is added to the current position before placing the glyph. "B" spacing is the width of the black part of the glyph. "C" spacing is added to the current position to account for the white space to the right of the glyph. The total advanced width is given by A + B + C.  
  
 When the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member function retrieves negative "A" or "C" widths for a character, that character includes underhangs or overhangs.  
  
 To convert the ABC widths to font design units, an application should create a font whose height (as specified in the **lfHeight** member of the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure) is equal to the value stored in the **ntmSizeEM** member of the [NEWTEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd162741) structure. (The value of the **ntmSizeEM** member can be retrieved by calling the [EnumFontFamilies](http://msdn.microsoft.com/library/windows/desktop/dd162619) Windows function.)  
  
 The ABC widths of the default character are used for characters that are outside the range of the currently selected font.  
  
 To retrieve the widths of characters in non-TrueType fonts, applications should use the [GetCharWidth](http://msdn.microsoft.com/library/windows/desktop/dd144861) Windows function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetCharWidth](../vs140/cdc--getcharwidth.md)   
 [GetCharABCWidths](http://msdn.microsoft.com/library/windows/desktop/dd144857)   
 [GetCharABCWidthsFloat](http://msdn.microsoft.com/library/windows/desktop/dd144858)   
 [GetCharWidthFloat](http://msdn.microsoft.com/library/windows/desktop/dd144863)