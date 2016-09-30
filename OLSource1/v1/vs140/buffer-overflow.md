---
title: "Buffer Overflow"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "buffers [C++], character sizes"
  - "buffer overflows [C++]"
  - "MBCS [C++], buffer overflow"
ms.assetid: f2b7e40a-f02b-46d8-a449-51d26fc0c663
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Buffer Overflow
Varying character sizes can cause problems when you put characters into a buffer. Consider the following code, which copies characters from a string, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, into a buffer, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The question is: Was the last byte copied a lead byte? The following does not solve the problem because it can potentially overflow the buffer:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> call attempts to do the correct thing — copy the full character, whether it is 1 or 2 bytes. But it does not take into account that the last character copied might not fit the buffer if the character is 2 bytes wide. The correct solution is:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code tests for possible buffer overflow in the loop test, using <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to test the size of the current character pointed to by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. By making a call to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function, you can replace the code in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> loop with a single line of code. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [MBCS Programming Tips](../vs140/mbcs-programming-tips.md)