---
title: "Reference-Type Function Arguments"
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
  - "arguments [C++], function"
  - "functions [C++], paramters"
  - "function parameters, reference-type"
  - "function arguments, reference-type"
  - "passing parameters, reference-type arguments"
ms.assetid: 0a70e831-9e76-46c0-821d-aeba13d73cc0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reference-Type Function Arguments
It is often more efficient to pass references, rather than large objects, to functions. This allows the compiler to pass the address of the object while maintaining the syntax that would have been used to access the object. Consider the following example that uses the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The preceding code shows that members of a structure passed by reference are accessed using the member-selection operator (**.**) instead of the pointer member-selection operator (**–>**).  
  
 Although arguments passed as reference types observe the syntax of non-pointer types, they retain one important characteristic of pointer types: they are modifiable unless declared as **const**. Because the intent of the preceding code is not to modify the object <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, a more appropriate function prototype is:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This prototype guarantees that the function <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will not change its argument.  
  
 Any function prototyped as taking a reference type can accept an object of the same type in its place because there is a standard conversion from *typename* to *typename***&**.  
  
## See Also  
 [References](../vs140/references--c---.md)