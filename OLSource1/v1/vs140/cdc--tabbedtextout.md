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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::TabbedTextOut
Call this member function to write a character string at the specified location, expanding tabs to the values specified in the array of tab-stop positions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the starting point of the string.  
  
 *y*  
 Specifies the logical y-coordinate of the starting point of the string.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the character string to draw. You can pass either a pointer to an array of characters or a [CString](../vs140/cstringt-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the number of characters in the string. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is –1, the length is calculated.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the number of values in the array of tab-stop positions.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Points to an array containing the tab-stop positions (in logical units). The tab stops must be sorted in increasing order; the smallest x-value should be the first item in the array.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the starting position from which tabs are expanded (in logical units).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object that contains the specified characters.  
  
## Return Value  
 The dimensions of the string (in logical units) as a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
## Remarks  
 Text is written in the currently selected font. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is 0 and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is **NULL**, tabs are expanded to eight times the average character width.  
  
 If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is 1, the tab stops are separated by the distance specified by the first value in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> array. If the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> array contains more than one value, a tab stop is set for each value in the array, up to the number specified by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter allows an application to call the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function several times for a single line. If the application calls the function more than once with the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> set to the same value each time, the function expands all tabs relative to the position specified by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 By default, the current position is not used or updated by the function. If an application needs to update the current position when it calls the function, the application can call the [SetTextAlign](../vs140/cdc--settextalign.md) member function with <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> set to **TA_UPDATECP**. When this flag is set, Windows ignores the *x* and *y* parameters on subsequent calls to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, using the current position instead.  
  
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