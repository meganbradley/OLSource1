---
title: "CDC::GetOutputTextExtent"
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
  - "CDC::GetOutputTextExtent"
  - "GetOutputTextExtent"
  - "CDC.GetOutputTextExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetOutputTextExtent method"
  - "CDC class, text functions"
ms.assetid: bb6e0ea6-df8f-4e73-bfeb-4178c9a6be4b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetOutputTextExtent
Call this member function to use the output device context, [m_hDC](../vs140/cdc--m_hdc.md), and compute the width and height of a line of text, using the current font.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a string of characters. You can also pass a [CString](../vs140/cstringt-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the number of characters in the string. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is –1, the length is calculated.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that contains the specified characters to be measured.  
  
## Return Value  
 The dimensions of the string (in logical units) returned in a [CSize](../vs140/csize-class.md) object.  
  
## Remarks  
 The current clipping region does not affect the width and height returned by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 Since some devices do not place characters in regular cell arrays (that is, they carry out kerning), the sum of the extents of the characters in a string may not be equal to the extent of the string.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetTabbedTextExtent](../vs140/cdc--gettabbedtextextent.md)   
 [CDC::GetOutputTabbedTextExtent](../vs140/cdc--getoutputtabbedtextextent.md)   
 [CDC::m_hAttribDC](../vs140/cdc--m_hattribdc.md)   
 [CDC::m_hDC](../vs140/cdc--m_hdc.md)   
 [CDC::GetTextExtent](../vs140/cdc--gettextextent.md)   
 [CDC::SetTextJustification](../vs140/cdc--settextjustification.md)   
 [CSize Class](../vs140/csize-class.md)