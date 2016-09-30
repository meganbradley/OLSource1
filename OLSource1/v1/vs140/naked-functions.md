---
title: "Naked Functions"
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
  - "naked functions"
  - "functions [C++], naked"
  - "prolog code"
  - "epilog code"
ms.assetid: 2543c8af-00d4-4a2a-8a87-e746da1f9929
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Naked Functions
**Microsoft Specific**  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> storage-class attribute is a Microsoft-specific extension to the C language. For functions declared with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> storage-class attribute, the compiler generates code without prolog and epilog code. You can use this feature to write your own prolog/epilog code sequences using inline assembler code. Naked functions are particularly useful in writing virtual device drivers.  
  
 Because the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute is only relevant to the definition of a function and is not a type modifier, naked functions use the extended attribute syntax, described in [Extended Storage-Class Attributes](../vs140/c-extended-storage-class-attributes.md).  
  
 The following example defines a function with the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> attribute:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Or, alternatively:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute affects only the nature of the compiler's code generation for the function's prolog and epilog sequences. It does not affect the code that is generated for calling such functions. Thus, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute is not considered part of the function's type, and function pointers cannot have the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute. Furthermore, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute cannot be applied to a data definition. For example, the following code generates errors:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> attribute is relevant only to the definition of the function and cannot be specified in the function's prototype. The following declaration generates a compiler error:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [C Function Definitions](../vs140/c-function-definitions.md)