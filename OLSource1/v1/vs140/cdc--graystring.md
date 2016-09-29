---
title: "CDC::GrayString"
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
  - "CDC::GrayString"
  - "CDC.GrayString"
  - "GrayString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GrayString method"
  - "CDC class, text functions"
ms.assetid: c15e6ae3-a172-4505-b9e8-fe400c6d1a3a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GrayString
Draws dimmed (gray) text at the given location by writing the text in a memory bitmap, dimming the bitmap, and then copying the bitmap to the display.  
  
## Syntax  
  
```  
  
      virtual BOOL GrayString(  
   CBrush* pBrush,  
   BOOL ( CALLBACK* lpfnOutput )( HDC, LPARAM, int ),  
   LPARAM lpData,  
   int nCount,  
   int x,  
   int y,  
   int nWidth,  
   int nHeight  
);  
```  
  
#### Parameters  
 `pBrush`  
 Identifies the brush to be used for dimming (graying).  
  
 `lpfnOutput`  
 Specifies the procedure-instance address of the application-supplied callback function that will draw the string. For more information, see the description of the Windows **OutputFunc** [callback function](../vs140/callback-function-for-cdc--graystring.md). If this parameter is **NULL**, the system uses the Windows `TextOut` function to draw the string, and `lpData` is assumed to be a long pointer to the character string to be output.  
  
 `lpData`  
 Specifies a far pointer to data to be passed to the output function. If `lpfnOutput` is **NULL**, `lpData` must be a long pointer to the string to be output.  
  
 `nCount`  
 Specifies the number of characters to be output. If this parameter is 0, `GrayString` calculates the length of the string (assuming that `lpData` is a pointer to the string). If `nCount` is –1 and the function pointed to by `lpfnOutput` returns 0, the image is shown but not dimmed.  
  
 *x*  
 Specifies the logical x-coordinate of the starting position of the rectangle that encloses the string.  
  
 *y*  
 Specifies the logical y-coordinate of the starting position of the rectangle that encloses the string.  
  
 `nWidth`  
 Specifies the width (in logical units) of the rectangle that encloses the string. If `nWidth` is 0, `GrayString` calculates the width of the area, assuming `lpData` is a pointer to the string.  
  
 `nHeight`  
 Specifies the height (in logical units) of the rectangle that encloses the string. If `nHeight` is 0, `GrayString` calculates the height of the area, assuming `lpData` is a pointer to the string.  
  
## Return Value  
 Nonzero if the string is drawn, or 0 if either the `TextOut` function or the application-supplied output function returned 0, or if there was insufficient memory to create a memory bitmap for dimming.  
  
## Remarks  
 The function dims the text regardless of the selected brush and background. The `GrayString` member function uses the currently selected font. The `MM_TEXT` mapping mode must be selected before using this function.  
  
 An application can draw dimmed (grayed) strings on devices that support a solid gray color without calling the `GrayString` member function. The system color **COLOR_GRAYTEXT** is the solid-gray system color used to draw disabled text. The application can call the **GetSysColor** Windows function to retrieve the color value of **COLOR_GRAYTEXT**. If the color is other than 0 (black), the application can call the `SetTextColor` member function to set the text color to the color value and then draw the string directly. If the retrieved color is black, the application must call `GrayString` to dim (gray) the text.  
  
 If `lpfnOutput` is **NULL**, GDI uses the Windows [TextOut](http://msdn.microsoft.com/library/windows/desktop/dd145133) function, and `lpData` is assumed to be a far pointer to the character to be output. If the characters to be output cannot be handled by the `TextOut` member function (for example, the string is stored as a bitmap), the application must supply its own output function.  
  
 Also note that all callback functions must trap Microsoft Foundation exceptions before returning to Windows, since exceptions cannot be thrown across callback boundaries. For more information about exceptions, see the article [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
 The callback function passed to `GrayString` must use the `__stdcall` calling convention and must be exported with `__declspec`.  
  
 When the framework is in preview mode, a call to the `GrayString` member function is translated to a `TextOut` call, and the callback function is not called.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetSysColor](http://msdn.microsoft.com/library/windows/desktop/ms724371)   
 [CDC::SetTextColor](../vs140/cdc--settextcolor.md)   
 [CDC::TextOut](../vs140/cdc--textout.md)   
 [GrayString](http://msdn.microsoft.com/library/windows/desktop/dd144963)