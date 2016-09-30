---
title: "reinterpret_cast Operator"
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
  - "reinterpret_cast"
  - "reinterpret_cast_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reinterpret_cast keyword [C++]"
ms.assetid: eb3283c7-7f88-467e-affd-407d37b46d6c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reinterpret_cast Operator
Allows any pointer to be converted into any other pointer type. Also allows any integral type to be converted into any pointer type and vice versa.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Misuse of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator can easily be unsafe. Unless the desired conversion is inherently low-level, you should use one of the other cast operators.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator can be used for conversions such as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which are inherently unsafe.  
  
 The result of a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> cannot safely be used for anything other than being cast back to its original type. Other uses are, at best, nonportable.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operator cannot cast away the **const**, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, or **__unaligned** attributes. See [const_cast Operator](../vs140/const_cast-operator.md) for information on removing these attributes.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> operator converts a null pointer value to the null pointer value of the destination type.  
  
 One practical use of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is in a hash function, which maps a value to an index in such a way that two distinct values rarely end up with the same index.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> allows the pointer to be treated as an integral type. The result is then bit-shifted and XORed with itself to produce a unique index (unique to a high degree of probability). The index is then truncated by a standard C-style cast to the return type of the function.  
  
## See Also  
 [Casting Operators](../vs140/casting-operators.md)   
 [Keywords](../vs140/keywords--c---.md)