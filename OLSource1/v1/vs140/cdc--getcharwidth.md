---
title: "CDC::GetCharWidth"
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
  - "CDC::GetCharWidth"
  - "GetCharWidth"
  - "CDC.GetCharWidth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCharWidth method"
  - "CDC class, font functions"
ms.assetid: da149f64-6077-4d2e-bcfd-e36cff1a3664
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetCharWidth
Retrieves the widths of individual characters in a consecutive group of characters from the current font, using `m_hAttribDC`, the input device context.  
  
## Syntax  
  
```  
  
      BOOL GetCharWidth(  
   UINT nFirstChar,  
   UINT nLastChar,  
   LPINT lpBuffer   
) const;  
BOOL GetCharWidth(  
   UINT nFirstChar,  
   UINT nLastChar,  
   float* lpFloatBuffer   
) const;  
```  
  
#### Parameters  
 `nFirstChar`  
 Specifies the first character in a consecutive group of characters in the current font.  
  
 `nLastChar`  
 Specifies the last character in a consecutive group of characters in the current font.  
  
 `lpBuffer`  
 Points to a buffer that will receive the width values for a consecutive group of characters in the current font.  
  
 *lpFloatBuffer*  
 Points to a buffer to receive the character widths. The returned widths are in the 32-bit IEEE floating-point format. (The widths are measured along the base line of the characters.)  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 For example, if `nFirstChar` identifies the letter 'a' and `nLastChar` identifies the letter 'z', the function retrieves the widths of all lowercase characters.  
  
 The function stores the values in the buffer pointed to by `lpBuffer`. This buffer must be large enough to hold all of the widths. That is, there must be at least 26 entries in the example given.  
  
 If a character in the consecutive group of characters does not exist in a particular font, it will be assigned the width value of the default character.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetOutputCharWidth](../vs140/cdc--getoutputcharwidth.md)   
 [CDC::m_hAttribDC](../vs140/cdc--m_hattribdc.md)   
 [CDC::m_hDC](../vs140/cdc--m_hdc.md)   
 [CDC::GetCharABCWidths](../vs140/cdc--getcharabcwidths.md)   
 [GetCharWidth](http://msdn.microsoft.com/library/windows/desktop/dd144861)   
 [GetCharABCWidths](http://msdn.microsoft.com/library/windows/desktop/dd144857)   
 [GetCharABCWidthsFloat](http://msdn.microsoft.com/library/windows/desktop/dd144858)   
 [GetCharWidthFloat](http://msdn.microsoft.com/library/windows/desktop/dd144863)