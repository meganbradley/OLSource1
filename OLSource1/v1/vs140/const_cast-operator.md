---
title: "const_cast Operator"
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
  - "const_cast"
  - "const_cast_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_cast keyword [C++]"
ms.assetid: 4d8bb203-ef33-4a10-9f9f-c64d4fbc1687
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# const_cast Operator
Removes the **const**, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and **__unaligned** attribute(s) from a class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A pointer to any object type or a pointer to a data member can be explicitly converted to a type that is identical except for the **const**, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and **__unaligned** qualifiers. For pointers and references, the result will refer to the original object. For pointers to data members, the result will refer to the same member as the original (uncast) pointer to data member. Depending on the type of the referenced object, a write operation through the resulting pointer, reference, or pointer to data member might produce undefined behavior.  
  
 You cannot use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator to directly override a constant variable's constant status.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator converts a null pointer value to the null pointer value of the destination type.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 On the line containing the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the data type of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> pointer is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operator changes the data type of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> pointer to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, allowing the member <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to be modified. The cast lasts only for the remainder of the statement in which it appears.  
  
## See Also  
 [Casting Operators](../vs140/casting-operators.md)   
 [Keywords](../vs140/keywords--c---.md)