---
title: "Compiler Error CS0313"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0313"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0313"
ms.assetid: a0b0f2fb-e742-4df8-98bd-3bc068f0c71c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0313
The type 'type1' cannot be used as type parameter 'parameter name' in the generic type or method 'type2'. The nullable type 'type1' does not satisfy the constraint of 'type2'. Nullable types cannot satisfy any interface constraints.  
  
 A nullable type is not equivalent to its non-nullable counterpart. In the example that follows, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> satisfies the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> constraint but <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> does not because <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> does not implement <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
### To correct this error  
  
1.  Using the code that follows as an example, one solution is to specify an ordinary <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> as the first type argument in the call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Then modify <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to create a nullable version of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in its return statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following code generates CS0313:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Nullable Types (C# Programming Guide)](../vs140/nullable-types--csharp-programming-guide-.md)