---
title: "Unit Type (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "unit type [F#]"
ms.assetid: d9c887e3-231b-448f-8f18-2cb60e89d10a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unit Type (F#)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> type is a type that indicates the absence of a specific value; the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> type has only a single value, which acts as a placeholder when no other value exists or is needed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Every F# expression must evaluate to a value. For expressions that do not generate a value that is of interest, the value of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> type resembles the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> type in languages such as C# and C++.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> type has a single value, and that value is indicated by the token <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 The value of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> type is often used in F# programming to hold the place where a value is required by the language syntax, but when no value is needed or desired. An example might be the return value of a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function. Because the important actions of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> operation occur in the function, the function does not have to return an actual value. Therefore, the return value is of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 Some constructs expect a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> value. For example, a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> binding or any code at the top level of a module is expected to evaluate to a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> value. The compiler reports a warning when a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> binding or code at the top level of a module produces a result other than the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value that is not used, as shown in the following example.  
  
 [!code[FsLangRef1#901](../vs140/codesnippet/FSharp/unit-type--fsharp-_1.fs)]  
  
 This warning is a characteristic of functional programming; it does not appear in other .NET programming languages. In a purely functional program, in which functions do not have any side effects, the final return value is the only result of a function call. Therefore, when the result is ignored, it is a possible programming error. Although F# is not a purely functional programming language, it is a good practice to follow functional programming style whenever possible.  
  
## See Also  
 [Primitive Types](../vs140/primitive-types--fsharp-.md)   
 [F# Language Reference](../vs140/fsharp-language-reference.md)