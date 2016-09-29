---
title: "CDC::ExtTextOut"
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
  - "ExtTextOut"
  - "CDC::ExtTextOut"
  - "CDC.ExtTextOut"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ExtTextOut method"
  - "CDC class, text functions"
ms.assetid: 8f1fbcbc-3195-4955-8cc4-bbc60d4226be
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ExtTextOut
Call this member function to write a character string within a rectangular region using the currently selected font.  
  
## Syntax  
  
```  
  
      virtual BOOL ExtTextOut(  
   int x,  
   int y,  
   UINT nOptions,  
   LPCRECT lpRect,  
   LPCTSTR lpszString,  
   UINT nCount,  
   LPINT lpDxWidths   
);  
BOOL ExtTextOut(  
   int x,  
   int y,  
   UINT nOptions,  
   LPCRECT lpRect,  
   const CString& str,  
   LPINT lpDxWidths   
);  
```  
  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the character cell for the first character in the specified string.  
  
 *y*  
 Specifies the logical y-coordinate of the top of the character cell for the first character in the specified string.  
  
 `nOptions`  
 Specifies the rectangle type. This parameter can be one, both, or neither of the following values:  
  
-   **ETO_CLIPPED** Specifies that text is clipped to the rectangle.  
  
-   **ETO_OPAQUE** Specifies that the current background color fills the rectangle. (You can set and query the current background color with the [SetBkColor](../vs140/cdc--setbkcolor.md) and [GetBkColor](../vs140/cdc--getbkcolor.md) member functions.)  
  
 `lpRect`  
 Points to a [RECT](../vs140/rect-structure.md) structure that determines the dimensions of the rectangle. This parameter can be **NULL**. You can also pass a [CRect](../vs140/crect-class.md) object for this parameter.  
  
 `lpszString`  
 Points to the specified character string to be drawn. You can also pass a [CString](../vs140/cstringt-class.md) object for this parameter.  
  
 `nCount`  
 Specifies the number of characters in the string.  
  
 `lpDxWidths`  
 Points to an array of values that indicate the distance between origins of adjacent character cells. For instance, `lpDxWidths`[*i*] logical units will separate the origins of character cell *i* and character cell *i* + 1. If `lpDxWidths` is **NULL**, `ExtTextOut` uses the default spacing between characters.  
  
 `str`  
 A `CString` object that contains the specified characters to be drawn.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The rectangular region can be opaque (filled with the current background color), and it can be a clipping region.  
  
 If `nOptions` is 0 and `lpRect` is **NULL**, the function writes text to the device context without using a rectangular region. By default, the current position is not used or updated by the function. If an application needs to update the current position when it calls `ExtTextOut`, the application can call the `CDC` member function [SetTextAlign](../vs140/cdc--settextalign.md) with `nFlags` set to **TA_UPDATECP**. When this flag is set, Windows ignores *x* and *y* on subsequent calls to `ExtTextOut` and uses the current position instead. When an application uses **TA_UPDATECP** to update the current position, `ExtTextOut` sets the current position either to the end of the previous line of text or to the position specified by the last element of the array pointed to by `lpDxWidths`, whichever is greater.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetTextAlign](../vs140/cdc--settextalign.md)   
 [CDC::TabbedTextOut](../vs140/cdc--tabbedtextout.md)   
 [CDC::TextOut](../vs140/cdc--textout.md)   
 [CDC::GetBkColor](../vs140/cdc--getbkcolor.md)   
 [CDC::SetBkColor](../vs140/cdc--setbkcolor.md)   
 [CDC::SetTextColor](../vs140/cdc--settextcolor.md)   
 [ExtTextOut](http://msdn.microsoft.com/library/windows/desktop/dd162713)   
 [RECT Structure](../vs140/rect-structure.md)