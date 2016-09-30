---
title: "CStringT::Insert"
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
  - "ATL.CStringT.Insert"
  - "CStringT::Insert"
  - "ATL::CStringT::Insert"
  - "CStringT.Insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Insert method"
ms.assetid: a3a32b1a-f223-4467-8886-42fa815898fc
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::Insert
Inserts a single character or a substring at the given index within the string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index of the character before which the insertion will take place.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the substring to be inserted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The character to be inserted.  
  
## Return Value  
 The length of the changed string.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter identifies the first character that will be moved to make room for the character or substring. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is zero, the insertion will occur before the entire string. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is higher than the length of the string, the function will concatenate the present string and the new material provided by either <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#122](../vs140/codesnippet/CPP/cstringt--insert_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)