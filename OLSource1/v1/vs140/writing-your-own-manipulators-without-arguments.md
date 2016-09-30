---
title: "Writing Your Own Manipulators Without Arguments"
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
  - "manipulators"
ms.assetid: 2dc62d09-45b7-454d-bd9d-55f3c72c206d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Writing Your Own Manipulators Without Arguments
Writing manipulators that do not use arguments requires neither class derivation nor use of complex macros. Suppose your printer requires the pair \<ESC>[ to enter bold mode. You can insert this pair directly into the stream:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Or you can define the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> manipulator, which inserts the characters:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The globally defined <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function takes an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> reference argument and returns the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> reference. It is not a member function or a friend because it does not need access to any private class elements. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function connects to the stream because the stream's <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operator is overloaded to accept that type of function, using a declaration that looks something like this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 You can use this feature to extend other overloaded operators. In this case, it is incidental that <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> inserts characters into the stream. The function is called when it is inserted into the stream, not necessarily when the adjacent characters are printed. Thus, printing could be delayed because of the stream's buffering.  
  
## See Also  
 [Output Streams](../vs140/output-streams.md)