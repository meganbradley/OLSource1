---
title: "basic_string::rbegin"
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
  - "std.basic_string.rbegin"
  - "rbegin"
  - "basic_string.rbegin"
  - "std::basic_string::rbegin"
  - "xstring/std::basic_string::rbegin"
  - "basic_string::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
ms.assetid: 76896399-50ec-41e9-a2c0-3f1aff3b2a4f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::rbegin
Returns an iterator to the first element in a reversed string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns a random-access iterator to the first element in a reversed string, addressing what would be the last element in the corresponding unreversed string.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed string just as [begin](../vs140/basic_string--begin.md) is used with a string.  
  
 If the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the string object cannot be modified. If the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the string object can be modified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used to initialize an iteration through a string backwards.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first character-letter of the reversed string str1 is: a**  
**The full reversed string str1 is:**  
 **ablE was I ere I saw elbA**  
**The first character-letter of the modified str1 is now: A**  
**The full modified reversed string str1 is now:**  
 **AblE was I ere I saw elbA**  
**The string str2 is empty.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)