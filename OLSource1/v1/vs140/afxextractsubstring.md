---
title: "AfxExtractSubString"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AfxExtractSubString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CString objects, formatting and message boxes"
  - "AfxExtractSubString function"
ms.assetid: eca6f230-7bb8-4cc3-80a1-265a6641a85c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxExtractSubString
This global function can be used to extract a substring from a given source string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *rString*  
 -   Reference to a [CString](../vs140/using-cstring.md) object that will receive an individual substring.  
  
 *lpszFullString*  
 -   String containing the full text of the string to extract from.  
  
 *iSubString*  
 -   Zero-based index of the substring to extract from *lpszFullString*.  
  
 *chSep*  
 -   Separator character used to delimit substrings.  
  
## Return Value  
 **TRUE** if the function successfully extracted the substring at the provided index; otherwise, **FALSE**.  
  
## Remarks  
 This function is useful for extracting multiple substrings from a source string when a known single character separates each substring. This function searches from the beginning of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter each time it is called.  
  
 This function will return FALSE if either <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is set to **NULL** or the function reaches the end of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> without finding <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>+1 occurrences of the specified separator character. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter will not be modified from its original value if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> was set to **NULL**; otherwise, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter is set to the empty string if the substring could not be extracted for the specified index.  
  
## Example  
 [!code[NVC_MFC_Utilities#48](../vs140/codesnippet/CPP/afxextractsubstring_1.cpp)]  
  
## Requirements  
 **Header**: \<afxwin.h>  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Using CString](../vs140/using-cstring.md)