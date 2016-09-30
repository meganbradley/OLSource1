---
title: "How to: Define and consume enums in C++-CLI"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Define and consume enums in C++/CLI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "enum class, specifying underlying types"
ms.assetid: df8f2b91-b9d2-4fab-9be4-b1d58b8bc570
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Define and consume enums in C++-CLI
This topic discusses enums in C++/CLI.  
  
## Specifying the underlying type of an enum  
 By default, the underlying type of an enumeration is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  However, you can specify the type to be signed or unsigned forms of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  You can also use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Output**  
  
 **sun**  
**0**  
**1**  
**2**   
## How to convert between managed and standard enumerations  
 There is no standard conversion between an enum and an integral type; a cast is required.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **a and day2 are the same**   
## Operators and enums  
 The following operators are valid on enums in C++/CLI:  
  
|Operator|  
|--------------|  
|== != \< > \<= >=|  
|+ -|  
|&#124; ^ & ~|  
|++ --|  
|sizeof|  
  
 Operators &#124; ^ & ~ ++ -- are defined only for enumerations with integral underlying types, not including bool.  Both operands must be of the enumeration type.  
  
 The compiler does no static or dynamic checking of the result of an enum operation; an operation may result in a value not in the range of the enum's valid enumerators.  
  
> [!NOTE]
>  C++11 introduces enum class types in unmanaged code which are significantly different than managed enum classes in C++/CLI. In particular, the C++11 enum class type does not support the same operators as the managed enum class type in C++/CLI, and C++/CLI source code must provide an accessibility specifier in managed enum class declarations in order to distinguish them from unmanaged (C++11) enum class declarations. For more information about enum classes in C++/CLI, C++/CX, and C++11, see [enum class](../vs140/enum-class---c---component-extensions-.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Output**  
  
 **4**  
**1**  
**True**   
## See Also  
 [enum class](../vs140/enum-class---c---component-extensions-.md)