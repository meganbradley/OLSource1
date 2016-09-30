---
title: "CStringT::Find"
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
  - "CStringT::Find"
  - "CStringT.Find"
  - "ATL.CStringT.Find"
  - "ATL::CStringT::Find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Find method"
ms.assetid: b5746e07-e4c9-4c9f-a7da-b3a4af75f82e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::Find
Searches this string for the first match of a character or substring.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A substring to search for.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The index of the character in the string to begin the search with, or 0 to start from the beginning.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A single character to search for.  
  
## Return Value  
 The zero-based index of the first character in this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that matches the requested substring or characters; -1 if the substring or character is not found.  
  
## Remarks  
 The function is overloaded to accept both single characters (similar to the run-time function <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) and strings (similar to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#114](../vs140/codesnippet/CPP/cstringt--find_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)