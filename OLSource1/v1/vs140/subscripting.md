---
title: "Subscripting"
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
  - "subscript operator, overloaded"
  - "arrays [C++], subscripting"
  - "subscripting"
  - "operators [C++], overloading"
  - "operator overloading, examples"
  - "subscript operator"
ms.assetid: eb151281-6733-401d-9787-39ab6754c62c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Subscripting
The subscript operator (**[ ]**), like the function-call operator, is considered a binary operator. The subscript operator must be a nonstatic member function that takes a single argument. This argument can be of any type and designates the desired array subscript.  
  
## Example  
 The following example demonstrates how to create a vector of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that implements bounds checking:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Array bounds violation.**  
**Element: [0] = 0**  
**Element: [1] = 1**  
**Element: [2] = 2**  
**Element: [3] = 9**  
**Element: [4] = 4**  
**Element: [5] = 5**  
**Element: [6] = 6**  
**Element: [7] = 7**  
**Element: [8] = 8**  
**Element: [9] = 9**  
**Array bounds violation.**  
**Element: [10] = 10**   
## Comments  
 When <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> reaches 10 in the preceding program, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> detects that an out-of-bounds subscript is being used and issues an error message.  
  
 Note that the function <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a reference type. This causes it to be an l-value, allowing you to use subscripted expressions on either side of assignment operators.  
  
## See Also  
 [Operator Overloading](../vs140/operator-overloading.md)