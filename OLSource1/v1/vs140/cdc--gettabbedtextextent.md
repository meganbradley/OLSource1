---
title: "CDC::GetTabbedTextExtent"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDC::GetTabbedTextExtent
  - GetTabbedTextExtent
  - CDC.GetTabbedTextExtent
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTabbedTextExtent method
  - CDC class, text functions
ms.assetid: a94c04e6-339a-4b2f-9e0b-3a527e830c52
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::GetTabbedTextExtent
Call this member function to compute the width and height of a character string using [m_hAttribDC](../vs140/cdc--m_hattribdc.md), the attribute device context.  
  
## Syntax  
  
```  
  
      CSize GetTabbedTextExtent(  
   LPCTSTR lpszString,  
   int nCount,  
   int nTabPositions,  
   LPINT lpnTabStopPositions   
) const;  
CSize GetTabbedTextExtent(  
   const CString& str,  
   int nTabPositions,  
   LPINT lpnTabStopPositions   
) const;  
```  
  
#### Parameters  
 `lpszString`  
 Points to a character string. You can also pass a [CString](../vs140/cstringt-class.md) object for this parameter.  
  
 `nCount`  
 Specifies the number of characters in the string. If `nCount` is –1, the length is calculated.  
  
 `nTabPositions`  
 Specifies the number of tab-stop positions in the array pointed to by `lpnTabStopPositions`.  
  
 `lpnTabStopPositions`  
 Points to an array of integers containing the tab-stop positions in logical units. The tab stops must be sorted in increasing order; the smallest x-value should be the first item in the array. Back tabs are not allowed.  
  
 `str`  
 A `CString` object that contains the specified characters to be drawn.  
  
## Return Value  
 The dimensions of the string (in logical units) in a [CSize](../vs140/csize-class.md) object.  
  
## Remarks  
 If the string contains one or more tab characters, the width of the string is based upon the tab stops specified by `lpnTabStopPositions`. The function uses the currently selected font to compute the dimensions of the string.  
  
 The current clipping region does not offset the width and height returned by the `GetTabbedTextExtent` function.  
  
 Since some devices do not place characters in regular cell arrays (that is, they kern the characters), the sum of the extents of the characters in a string may not be equal to the extent of the string.  
  
 If `nTabPositions` is 0 and `lpnTabStopPositions` is **NULL**, tabs are expanded to eight times the average character width. If `nTabPositions` is 1, the tab stops will be separated by the distance specified by the first value in the array to which `lpnTabStopPositions` points. If `lpnTabStopPositions` points to more than a single value, a tab stop is set for each value in the array, up to the number specified by `nTabPositions`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetTextExtent](../vs140/cdc--gettextextent.md)   
 [CDC::GetOutputTabbedTextExtent](../vs140/cdc--getoutputtabbedtextextent.md)   
 [CDC::GetOutputTextExtent](../vs140/cdc--getoutputtextextent.md)   
 [CDC::TabbedTextOut](../vs140/cdc--tabbedtextout.md)   
 [GetTabbedTextExtent](http://msdn.microsoft.com/library/windows/desktop/dd144930)   
 [CSize Class](../vs140/csize-class.md)