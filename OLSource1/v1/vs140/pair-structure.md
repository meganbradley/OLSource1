---
title: "pair Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "utility/std::pair"
  - "pair"
  - "std::pair"
  - "std.pair"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pair class"
ms.assetid: 539d3d67-80a2-4170-b347-783495d42109
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pair Structure
A struct that provides for the ability to treat two objects as a single object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Value initializing the first element of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Value initializing the second element of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pair whose values are to be used to initialize the elements of another pair.  
  
## Return Value  
 The first (default) constructor initializes first element of the pair to the default of type **T1** and second element to default of type **T2**.  
  
 The second constructor initializes first element of the pair to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and second to                 *Val2.*  
  
 The third (template) constructor initializes first element of the pair to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. **first** and second to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. **second**.  
  
 The fourth constructor initializes first element of the pair to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and second to                 *Val2* using [rvalue references](../vs140/rvalue-reference-declarator----.md).  
  
## Remarks  
 The template struct stores a pair of objects of type **T1** and **T2**, respectively. The type **first_type** is the same as the template parameter **T1** and the type **second_type** is the same as the template parameter **T2**. **T1** and **T2** each need supply only a default constructor, a single-argument constructor, and a destructor. All members of the type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> are public, because the type is declared as a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> rather than as a **class**. The two most common uses for a pair are as return types for functions that return two values and as elements for the associative container classes [map Class](../vs140/map-class.md) and [multimap Class](../vs140/multimap-class.md) that have both a key and a value type associated with each element. The latter satisfies the requirements for a pair associative container and has a value type of the form <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>< **const**<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<utility>  
  
 **Namespace:** std  
  
## See Also  
 [Pair Logical Operator Sample](../vs140/pair-logical-operator.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)