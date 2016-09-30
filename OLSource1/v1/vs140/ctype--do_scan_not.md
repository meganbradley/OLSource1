---
title: "ctype::do_scan_not"
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
  - "std::ctype::do_scan_not"
  - "ctype::do_scan_not"
  - "std.ctype.do_scan_not"
  - "ctype.do_scan_not"
  - "do_scan_not"
  - "xlocale/std::ctype::do_scan_not"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_scan_not method"
ms.assetid: db59ab21-b17a-45cc-8f0f-1782d19fbbc7
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::do_scan_not
A virtual function called to locate the first character in a range that does not match a specified mask.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The mask value not to be matched by a character.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the first character in the range to be scanned.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range to be scanned.  
  
## Return Value  
 A pointer to the first character in a range that doesn't match a specified mask. If no such value exists, the function returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The protected member function returns the smallest pointer <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in the range [<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) for which [do_is](../vs140/ctype--do_is.md)(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, *<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) is false.  
  
## Example  
 See the example for [scan_not](../vs140/ctype--scan_not.md), which calls <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)