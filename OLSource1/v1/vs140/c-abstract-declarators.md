---
title: "C Abstract Declarators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "declarators, abstract"
  - "abstract declarations"
ms.assetid: 6a556ad7-0555-421a-aa02-294d77cda8b5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C Abstract Declarators
An abstract declarator is a declarator without an identifier, consisting of one or more pointer, array, or function modifiers. The pointer modifier (**\***) always precedes the identifier in a declarator; array (**[ ]**) and function ( **( )** ) modifiers follow the identifier. Knowing this, you can determine where the identifier would appear in an abstract declarator and interpret the declarator accordingly. See [Interpreting More Complex Declarators](../vs140/interpreting-more-complex-declarators.md) for additional information and examples of complex declarators. Generally <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> can be used to simplify declarators. See [Typedef Declarations](../vs140/typedef-declarations.md).  
  
 Abstract declarators can be complex. Parentheses in a complex abstract declarator specify a particular interpretation, just as they do for the complex declarators in declarations.  
  
 These examples illustrate abstract declarators:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
> [!NOTE]
>  The abstract declarator consisting of a set of empty parentheses, **( )**, is not allowed because it is ambiguous. It is impossible to determine whether the implied identifier belongs inside the parentheses (in which case it is an unmodified type) or before the parentheses (in which case it is a function type).  
  
## See Also  
 [Declarators and Variable Declarations](../vs140/declarators-and-variable-declarations.md)