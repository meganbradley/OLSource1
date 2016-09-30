---
title: "strstreambuf::pbackfail"
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
  - "pbackfail"
  - "std.strstreambuf.pbackfail"
  - "strstreambuf::pbackfail"
  - "strstreambuf.pbackfail"
  - "std::strstreambuf::pbackfail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pbackfail method"
ms.assetid: 1dc02c72-6c2f-4e66-a48e-f4c7a3b10720
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# strstreambuf::pbackfail
A protected virtual member function that tries to put back an element into the input stream, and then makes it the current element (pointed to by the next pointer).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The character to insert into the buffer, or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Return Value  
 If the function cannot succeed, it returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Otherwise, if _*Meta* == <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, it returns some value other than <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Otherwise, it returns \_*Meta*.  
  
## Remarks  
 The protected virtual member function tries to put back an element into the input buffer, and then make it the current element (pointed to by the next pointer).  
  
 If _*Meta* == <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the element to push back is effectively the one already in the stream before the current element. Otherwise, that element is replaced by **ch** = (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>)\_*Meta*. The function can put back an element in various ways:  
  
-   If a putback position is available, and the element stored there compares equal to **ch**, it can decrement the next pointer for the input buffer.  
  
-   If a putback position is available, and if the strstreambuf mode says the controlled sequence is modifiable, the function can store **ch** into the putback position and decrement the next pointer for the input buffer.  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)