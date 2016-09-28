---
title: "CDC::TabbedTextOut"
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
  - "CDC::TabbedTextOut"
  - "TabbedTextOut"
  - "CDC.TabbedTextOut"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TabbedTextOut method"
  - "CDC class, text functions"
ms.assetid: 0f3bff56-f67c-4a8d-b316-f351021791e2
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::TabbedTextOut
Call this member function to write a character string at the specified location, expanding tabs to the values specified in the array of tab-stop positions.  
  
## Syntax  
  
```  
  
      virtual CSize TabbedTextOut(  
   int x,  
   int y,  
   LPCTSTR lpszString,  
   int nCount,  
   int nTabPositions,  
   LPINT lpnTabStopPositions,  
   int nTabOrigin   
);  
CSize TabbedTextOut(  
   int x,  
   int y,  
   const CString& str,  
   int nTabPositions,  
   LPINT lpnTabStopPositions,  
   int nTabOrigin   
);  
```  
  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the starting point of the string.  
  
 *y*  
 Specifies the logical y-coordinate of the starting point of the string.  
  
 `lpszString`  
 Points to the character string to draw. You can pass either a pointer to an array of characters or a [CString](../vs140/cstringt-class.md) object for this parameter.  
  
 `nCount`  
 Specifies the number of characters in the string. If `nCount` is –1, the length is calculated.  
  
 `nTabPositions`  
 Specifies the number of values in the array of tab-stop positions.  
  
 `lpnTabStopPositions`  
 Points to an array containing the tab-stop positions (in logical units). The tab stops must be sorted in increasing order; the smallest x-value should be the first item in the array.  
  
 `nTabOrigin`  
 Specifies the x-coordinate of the starting position from which tabs are expanded (in logical units).  
  
 `str`  
 A `CString` object that contains the specified characters.  
  
## Return Value  
 The dimensions of the string (in logical units) as a `CSize` object.  
  
## Remarks  
 Text is written in the currently selected font. If `nTabPositions` is 0 and `lpnTabStopPositions` is **NULL**, tabs are expanded to eight times the average character width.  
  
 If `nTabPositions` is 1, the tab stops are separated by the distance specified by the first value in the `lpnTabStopPositions` array. If the `lpnTabStopPositions` array contains more than one value, a tab stop is set for each value in the array, up to the number specified by `nTabPositions`. The `nTabOrigin` parameter allows an application to call the `TabbedTextOut` function several times for a single line. If the application calls the function more than once with the `nTabOrigin` set to the same value each time, the function expands all tabs relative to the position specified by `nTabOrigin`.  
  
 By default, the current position is not used or updated by the function. If an application needs to update the current position when it calls the function, the application can call the [SetTextAlign](../vs140/cdc--settextalign.md) member function with `nFlags` set to **TA_UPDATECP**. When this flag is set, Windows ignores the *x* and *y* parameters on subsequent calls to `TabbedTextOut`, using the current position instead.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetTabbedTextExtent](../vs140/cdc--gettabbedtextextent.md)   
 [CDC::SetTextAlign](../vs140/cdc--settextalign.md)   
 [CDC::TextOut](../vs140/cdc--textout.md)   
 [CDC::SetTextColor](../vs140/cdc--settextcolor.md)   
 [TabbedTextOut](http://msdn.microsoft.com/library/windows/desktop/dd145129)   
 [CSize Class](../vs140/csize-class.md)