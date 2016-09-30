---
title: "negate Struct"
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
  - "negate"
  - "std.negate"
  - "std::negate"
  - "xfunctional/std::negate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "negate struct"
  - "negate class"
ms.assetid: 8a372686-786e-4262-b37c-ca13dc11e62f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# negate Struct
A predefined function object that performs the arithmetic negation operation (unary <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) on its argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Any type that supports an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that takes an operand of the specified or inferred type.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The operand to be negated. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 The result of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> The specialized template does perfect forwarding of the result, which has the type that's returned by unary <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)