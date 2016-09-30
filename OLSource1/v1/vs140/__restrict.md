---
title: "__restrict"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "__restrict"
  - "__restrict_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__restrict keyword [C++]"
ms.assetid: 2d151b4d-f930-49df-bd16-d8757ec7fa83
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __restrict
Like the **__declspec ( [restrict](../vs140/restrict.md) )** modifier, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword indicates that a symbol is not aliased in the current scope. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword differs from the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> modifier in the following ways:  
  
-   The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword is valid only on variables, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is only valid on function declarations and definitions.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is similar to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> from the C99 spec, but <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be used in C++ or C programs.  
  
-   When <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is used, the compiler will not propagate the no-alias property of a variable. That is, if you assign a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> variable to a non-<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> variable, the compiler will still allow the non-__restrict variable to be aliased. This is different from the behavior of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keyword from the C99 specification.  
  
 Generally, if you affect the behavior of an entire function, it is better to use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> than the keyword.  
  
 In Visual Studio 2015 and later, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> can be used on C++ references.  
  
> [!NOTE]
>  When used on a variable that also has the [volatile](../vs140/volatile--c---.md) keyword, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> will take precedence.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Keywords](../vs140/keywords--c---.md)