---
title: "CDC::GetOutputCharWidth"
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
  - "CDC.GetOutputCharWidth"
  - "GetOutputCharWidth"
  - "CDC::GetOutputCharWidth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetOutputCharWidth method"
  - "CDC class, font functions"
ms.assetid: 2b5c67de-6e96-4658-91aa-15defd8737b2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetOutputCharWidth
Uses the output device context, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and retrieves the widths of individual characters in a consecutive group of characters from the current font.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the first character in a consecutive group of characters in the current font.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the last character in a consecutive group of characters in the current font.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to a buffer that will receive the width values for a consecutive group of characters in the current font.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 For example, if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> identifies the letter 'a' and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> identifies the letter 'z', the function retrieves the widths of all lowercase characters.  
  
 The function stores the values in the buffer pointed to by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. This buffer must be large enough to hold all of the widths; that is, there must be at least 26 entries in the example given.  
  
 If a character in the consecutive group of characters does not exist in a particular font, it will be assigned the width value of the default character.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetCharWidth](../vs140/cdc--getcharwidth.md)   
 [CDC::m_hAttribDC](../vs140/cdc--m_hattribdc.md)   
 [CDC::m_hDC](../vs140/cdc--m_hdc.md)   
 [GetCharWidth](http://msdn.microsoft.com/library/windows/desktop/dd144861)