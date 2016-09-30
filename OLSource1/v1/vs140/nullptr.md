---
title: "nullptr"
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
  - "nullptr_cpp"
  - "nullptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nullptr keyword [C++]"
ms.assetid: e9d80ea6-2506-4eb5-b47b-2349df085832
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nullptr
Designates a null pointer constant of type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, which is convertible to any raw pointer type.  Although you can use the keyword <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> without including any headers, if your code uses the type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, then you must define it by including the header <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword is also defined in C++/CLI for managed code applications and is not interchangeable with the ISO Standard C++ keyword. If your code might be compiled by using the [/clr](../vs140/-clr--common-language-runtime-compilation-.md) compiler option, which targets managed code, then use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in any line of code where you must guarantee that the compiler uses the native C++ interpretation. For more information, see [nullptr (C++/CLI)](../vs140/nullptr---c---component-extensions-.md).  
  
## Remarks  
 Avoid using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or zero (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) as a null pointer constant; <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is less vulnerable to misuse and works better in most situations.  For example, given <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, then calling <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> causes a compiler error.  The macro NULL expands to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, so that the call <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, which is not convertible to func()'s <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter type.  Calling <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> successfully compiles because <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, which is convertible to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [nullptr (C++/CLI)](../vs140/nullptr---c---component-extensions-.md)