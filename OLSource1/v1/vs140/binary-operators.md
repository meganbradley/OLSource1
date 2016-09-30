---
title: "Binary Operators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "member-selection operators"
  - "operators [C++], binary"
  - "binary operators"
ms.assetid: c0e7fbff-bc87-4708-8333-504ac09ee83e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Binary Operators
The following table shows a list of operators that can be overloaded.  
  
### Redefinable Binary Operators  
  
|Operator|Name|  
|--------------|----------|  
|**,**|Comma|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|Inequality|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Modulus|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Modulus/assignment|  
|**&**|Bitwise AND|  
|**&&**|Logical AND|  
|**&=**|Bitwise AND/assignment|  
|**\***|Multiplication|  
|**\*=**|Multiplication/assignment|  
|**+**|Addition|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Addition/assignment|  
|**–**|Subtraction|  
|**–=**|Subtraction/assignment|  
|**–>**|Member selection|  
|**–>\***|Pointer-to-member selection|  
|**/**|Division|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Division/assignment|  
|**<**|Less than|  
|**<<**|Left shift|  
|**<<=**|Left shift/assignment|  
|**<=**|Less than or equal to|  
|**=**|Assignment|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Equality|  
|**>**|Greater than|  
|**>=**|Greater than or equal to|  
|**>>**|Right shift|  
|**>>=**|Right shift/assignment|  
|**^**|Exclusive OR|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Exclusive OR/assignment|  
|**&#124;**|Bitwise inclusive OR|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Bitwise inclusive OR/assignment|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Logical OR|  
  
 To declare a binary operator function as a nonstatic member, you must declare it in the form:  
  
 *ret-type* **operator**<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>**(** <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> **)**  
  
 where *ret-type* is the return type, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is one of the operators listed in the preceding table, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is an argument of any type.  
  
 To declare a binary operator function as a global function, you must declare it in the form:  
  
 *ret-type* **operator**<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>**(** <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> **)**  
  
 where *ret-type* and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are as described for member operator functions and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are arguments. At least one of the arguments must be of class type.  
  
> [!NOTE]
>  There is no restriction on the return types of the binary operators; however, most user-defined binary operators return either a class type or a reference to a class type.  
  
## See Also  
 [Operator Overloading](../vs140/operator-overloading.md)