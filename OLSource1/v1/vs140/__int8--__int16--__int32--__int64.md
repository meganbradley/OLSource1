---
title: "__int8, __int16, __int32, __int64"
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
  - "__int8_cpp"
  - "__int64"
  - "__int8"
  - "__int16"
  - "__int16_cpp"
  - "__int64_cpp"
  - "__int32_cpp"
  - "__int32"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__int16 keyword [C++]"
  - "integer data type, integer types in C++"
  - "__int32 keyword [C++]"
  - "integer types [C++]"
  - "__int8 keyword [C++]"
  - "__int64 keyword [C++]"
ms.assetid: 8e384602-2578-4980-8cc8-da63842356b2
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __int8, __int16, __int32, __int64
## Microsoft Specific  
 Microsoft C/C++ features support for sized integer types. You can declare 8-, 16-, 32-, or 64-bit integer variables by using the **__int***n* type specifier, where *n* is 8, 16, 32, or 64.  
  
 The following example declares one variable for each of these types of sized integers:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The types <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are synonyms for the ANSI types that have the same size, and are useful for writing portable code that behaves identically across multiple platforms. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> data type is synonymous with type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is synonymous with type **short**, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is synonymous with type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> type has no ANSI equivalent.  
  
## Example  
 The following sample shows that an __int*xx* parameter will be promoted to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **func**   
## END Microsoft Specific  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [Fundamental Types](../vs140/fundamental-types---c---.md)   
 [Data Type Ranges](../vs140/data-type-ranges.md)