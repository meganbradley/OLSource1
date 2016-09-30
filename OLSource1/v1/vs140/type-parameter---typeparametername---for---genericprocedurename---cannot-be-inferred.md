---
title: "Type parameter &#39;&lt;typeparametername&gt;&#39; for &#39;&lt;genericprocedurename&gt;&#39; cannot be inferred"
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
  - "vbc32050"
  - "bc32050"
helpviewer_keywords: 
  - "BC32050"
ms.assetid: e4a69ffb-0764-4e5a-8de1-40f881a3f4fb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type parameter &#39;&lt;typeparametername&gt;&#39; for &#39;&lt;genericprocedurename&gt;&#39; cannot be inferred
A generic procedure is called without supplying a type argument list, and type inference fails for one of the type arguments.  
  
 When you call a generic procedure, you normally supply a type argument for each type parameter defined by the procedure. However, you have the alternative of omitting the type argument list entirely. When you do this, the compiler attempts to infer the type of each type argument from the context of your call. For more information, see "Type Inference" in [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md).  
  
 One possible cause of type inference failure is a mismatch of rank between a type parameter and the calling type. The following code illustrates this.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the preceding code, the two calls to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> both produce this error, because the type parameter <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> calls for a one-dimensional array, whereas the type arguments the compiler infers from the calls are a scalar (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) and a two-dimensional array (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
 **Error ID:** BC32050  
  
### To correct this error  
  
-   Make sure the types of the normal arguments are such that type inference is consistent with the type parameters declared for the generic procedure.  
  
     -or-  
  
-   Call the generic procedure with a complete type argument list, so that type inference is not necessary.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)   
 [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md)