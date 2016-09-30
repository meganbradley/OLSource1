---
title: "Extension method &#39;&lt;methodname&gt;&#39; has type constraints that can never be satisfied"
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
  - "bc36561"
  - "vbc36561"
helpviewer_keywords: 
  - "BC36561"
ms.assetid: ff42d6e9-611b-407d-a269-f268b36ed277
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Extension method &#39;&lt;methodname&gt;&#39; has type constraints that can never be satisfied
The type parameters of this method interact in a way that prevents them from ever being satisfied. The following extension method is an example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Because the method is an extension method, the compiler must be able to determine the data type or types that the method extends based only on the first parameter in the method declaration, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and the argument sent in for that parameter. When the first parameter refers to generic type parameters, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the constraints on the generic parameters restrict the set of types to which the method applies.  
  
 Applicability of an extension method is determined from the argument provided for the first parameter, which is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the following code.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 It must be possible to verify the constraints on all generic type parameters referred to by the first parameter, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, by looking at only the first argument, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. In <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the set of types that is being extended cannot be determined from the first parameter alone. Type parameter <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is constrained by type parameter <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which is not referenced by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and cannot be inferred from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. Therefore, the applicability of the method to any possible type cannot be verified, and the method can never be called.  
  
 **Error ID:** BC36561  
  
### To correct this error  
  
-   Change the type declaration to remove the interdependence between the types.  
  
## See Also  
 [Extension Methods (Visual Basic)](../vs140/extension-methods--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)