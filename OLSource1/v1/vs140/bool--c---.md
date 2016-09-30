---
title: "bool (C++)"
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
  - "bool_cpp"
  - "bool"
  - "__BOOL_DEFINED"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bool keyword [C++]"
  - "__BOOL_DEFINED macro"
ms.assetid: 9abed3f2-d21c-4eb4-97c5-716342e613d8
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bool (C++)
This keyword is a built-in type. A variable of this type can have values [true](../vs140/true--c---.md) and [false](../vs140/false--c---.md). Conditional expressions have the type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and so have values of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. For example, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> now has **true** or **false** depending on the value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The values **true** and **false** have the following relationship:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the following statement:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is **true**, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is always executed; if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is **false**, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is never executed.  
  
 When a postfix or prefix <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> operator is applied to a variable of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the variable is set to **true**. The postfix or prefix <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> operator cannot be applied to a variable of this type.  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> type participates in integral promotions. An r-value of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> can be converted to an r-value of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, with **false** becoming zero and **true** becoming one. As a distinct type, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> participates in overload resolution.  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [Fundamental Types](../vs140/fundamental-types---c---.md)