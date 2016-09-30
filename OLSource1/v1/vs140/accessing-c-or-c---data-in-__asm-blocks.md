---
title: "Accessing C or C++ Data in __asm Blocks"
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
  - "data members [C++], in __asm blocks"
  - "data access [C++], in __asm blocks"
  - "__asm keyword [C++], data members"
  - "structure types in __asm blocks"
ms.assetid: e99f5a28-0381-4090-8ece-6af8f2436a49
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Accessing C or C++ Data in __asm Blocks
## Microsoft Specific  
 A great convenience of inline assembly is the ability to refer to C or C++ variables by name. An <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block can refer to any symbols, including variable names, that are in scope where the block appears. For instance, if the C variable <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is in scope, the instruction  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 stores the value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in EAX.  
  
 If a class, structure, or union member has a unique name, an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> block can refer to it using only the member name, without specifying the variable or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> name before the period (**.**) operator. If the member name is not unique, however, you must place a variable or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> name immediately before the period operator. For example, the structure types in the following sample share <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> as their member name:.  
  
 If you declare variables with the types  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 all references to the member <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> must use the variable name because <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is not unique. But the member <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> has a unique name, so you can refer to it using only its member name:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Note that omitting the variable name is merely a coding convenience. The same assembly instructions are generated whether or not the variable name is present.  
  
 You can access data members in C++ without regard to access restrictions. However, you cannot call member functions.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Using C or C++ in __asm Blocks](../vs140/using-c-or-c---in-__asm-blocks.md)