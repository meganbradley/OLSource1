---
title: "basic_string::rend"
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
  - "rend"
  - "basic_string.rend"
  - "xstring/std::basic_string::rend"
  - "std::basic_string::rend"
  - "basic_string::rend"
  - "std.basic_string.rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: e4bd8ef0-f755-4616-ab46-3c963cef9f65
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::rend
Returns an iterator that addresses the location succeeding the last element in a reversed string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reverse random-access iterator that addresses the location succeeding the last element in a reversed string.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed string just as [end](../vs140/basic_string--end.md) is used with a string.  
  
 If the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the string object cannot be modified. If the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the string object can be modified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used to test whether a reverse iterator has reached the end of its string.  
  
 The value returned by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> should not be dereferenced.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The last character-letter of the reversed string str1 is: A**  
**The full reversed string str1 is:**  
 **ablE was I ere I saw elbA**  
**The last character-letter of the modified str1 is now: o**  
**The full modified reversed string str1 is now:**  
 **ablE was I ere I saw elbo**  
**The string str2 is empty.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)