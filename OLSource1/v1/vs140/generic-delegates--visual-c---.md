---
title: "Generic Delegates (Visual C++)"
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
  - "generic delegates"
  - "delegates, generic [C++]"
ms.assetid: 09d430b2-1aef-4fbc-87f9-9d7b8185d798
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generic Delegates (Visual C++)
You can use generic type parameters with delegates. For more information on delegates, see [delegate](../vs140/delegate---c---component-extensions-.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (Optional)  
 Additional declarative information. For more information on attributes and attribute classes, see Attributes.  
  
 *type-parameter-identifier(s)*  
 Comma-separated list of identifiers for the type parameters.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Takes the form specified in [Constraints](../vs140/constraints-on-generic-type-parameters--c---cli-.md)  
  
 *accessibility-modifiers* (Optional)  
 Accessibility modifiers (e.g. **public**, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
 *result-type*  
 The return type of the delegate.  
  
 *identifier*  
 The name of the delegate.  
  
 *formal-parameters* (Optional)  
 The parameter list of the delegate.  
  
## Example  
 The delegate type parameters are specified at the point where a delegate object is created. Both the delegate and method associated with it must have the same signature. The following is an example of a generic delegate declaration.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following sample shows that  
  
-   You cannot use the same delegate object with different constructed types. Create different delegate objects for different types.  
  
-   A generic delegate can be associated with a generic method.  
  
-   When a generic method is called without specifying type arguments, the compiler tries to infer the type arguments for the call.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following example declares a generic delegate <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and then instantiates it by associating it to the method <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that uses the type parameter <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Two instances of the delegate (an integer and a double) are created and invoked.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Invoking the integer delegate: i = 123, j = 123**  
**Invoking the double delegate: m = 0.123, n = 0.123**   
## See Also  
 [Generics (C++)](../vs140/generics---c---component-extensions-.md)