---
title: "__ptr32, __ptr64"
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
  - "__ptr32_cpp"
  - "__ptr64_cpp"
  - "__ptr32"
  - "__ptr64"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__ptr64 keyword [C++]"
  - "_ptr32 keyword [C++]"
  - "ptr32 keyword [C++]"
  - "ptr64 keyword [C++]"
  - "_ptr64 keyword [C++]"
  - "__ptr32 keyword [C++]"
ms.assetid: afb563d8-7458-4fe7-9c30-bd4b5385a59f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __ptr32, __ptr64
## Microsoft Specific  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> represents a native pointer on a 32-bit system, while <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> represents a native pointer on a 64-bit system.  
  
 The following example shows how to declare each of these pointer types:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 On a 32-bit system, a pointer declared with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is truncated to a 32-bit pointer. On a 64-bit system, a pointer declared with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is coerced to a 64-bit pointer.  
  
> [!NOTE]
>  You cannot use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> when compiling with **/clr:pure**. Otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> will be generated.  
  
## Example  
 The following example shows how to declare and allocate pointers with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keywords.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **32**  
**64**   
## END Microsoft Specific  
  
## See Also  
 [Fundamental Types](../vs140/fundamental-types---c---.md)