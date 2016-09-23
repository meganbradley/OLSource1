---
title: "CDC::GetTextExtent"
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
  - CDC::GetTextExtent
  - GetTextExtent
  - CDC.GetTextExtent
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTextExtent method
  - CDC class, text functions
ms.assetid: 80905cf9-876a-4e51-b1bf-9c7e837cd978
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::GetTextExtent
Call this member function to compute the width and height of a line of text using the current font to determine the dimensions.  
  
## Syntax  
  
```  
  
      CSize GetTextExtent(  
   LPCTSTR lpszString,  
   int nCount   
) const;  
CSize GetTextExtent(  
   const CString& str   
) const;  
```  
  
#### Parameters  
 `lpszString`  
 Points to a string of characters. You can also pass a [CString](../vs140/cstringt-class.md) object for this parameter.  
  
 `nCount`  
 Specifies the number of characters in the string.  
  
 `str`  
 A `CString` object that contains the specified characters.  
  
## Return Value  
 The dimensions of the string (in logical units) in a [CSize](../vs140/csize-class.md) object.  
  
## Remarks  
 The information is retrieved from [m_hAttribDC](../vs140/cdc--m_hattribdc.md), the attribute device context.  
  
 By default, `GetTextExtent` assumes the text for which it retrieves the dimension is set along a horizontal line (that is, the escapement is 0). If you create a font specifying a non-zero escapement, you must convert the angle of the text explicitly to get the dimensions of the string.  
  
 The current clipping region does not affect the width and height returned by `GetTextExtent`.  
  
 Since some devices do not place characters in regular cell arrays (that is, they carry out kerning), the sum of the extents of the characters in a string may not be equal to the extent of the string.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetTabbedTextExtent](../vs140/cdc--gettabbedtextextent.md)   
 [CDC::m_hAttribDC](../vs140/cdc--m_hattribdc.md)   
 [CDC::m_hDC](../vs140/cdc--m_hdc.md)   
 [CDC::GetOutputTextExtent](../vs140/cdc--getoutputtextextent.md)   
 [CDC::SetTextJustification](../vs140/cdc--settextjustification.md)   
 [CSize Class](../vs140/csize-class.md)