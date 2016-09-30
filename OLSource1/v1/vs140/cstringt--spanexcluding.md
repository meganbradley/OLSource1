---
title: "CStringT::SpanExcluding"
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
  - "ATL.CStringT.SpanExcluding"
  - "SpanExcluding"
  - "CStringT.SpanExcluding"
  - "ATL::CStringT::SpanExcluding"
  - "CStringT::SpanExcluding"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SpanExcluding method"
ms.assetid: 616ec369-da29-4d0f-9f38-a523418ac2fa
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::SpanExcluding
Extracts characters from the string, starting with the first character, that are not in the set of characters identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A string interpreted as a set of characters.  
  
## Return Value  
 A substring that contains characters in the string that are not in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, beginning with the first character in the string and ending with the first character found in the string that is also in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (that is, starting with the first character in the string and up to but excluding the first character in the string that is found <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>). It returns the entire string if no character in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is found in the string.  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> extracts and returns all characters preceding the first occurrence of a character from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (in other words, the character from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and all characters following it in the string, are not returned). If no character from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is found in the string, then <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns the entire string.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#133](../vs140/codesnippet/CPP/cstringt--spanexcluding_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)