---
title: "CStringT::Trim"
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
  - "ATL::CStringT::Trim"
  - "CStringT.Trim"
  - "CStringT::Trim"
  - "Trim"
  - "ATL.CStringT.Trim"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Trim method"
ms.assetid: e7260dc3-5a75-41a4-9c6c-c16681601c62
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::Trim
Trims leading and trailing characters from the string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The target character to be trimmed.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a string containing the target characters to be trimmed. All leading and trailing occurrences of characters in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> will be trimmed from the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Return Value  
 Returns the trimmed string.  
  
## Remarks  
 Removes all leading and trailing occurrences of one of the following:  
  
-   The character specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
-   All characters found in the string specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
-   Whitespace.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#136](../vs140/codesnippet/CPP/cstringt--trim_1.cpp)]  
  
## Remarks  
 The output from this example is as follows:  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)   
 [CStringT::TrimLeft](../vs140/cstringt--trimleft.md)   
 [CStringT::TrimRight](../vs140/cstringt--trimright.md)