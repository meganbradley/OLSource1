---
title: "Compiler Error C3535"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C3535"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3535"
ms.assetid: 24449c98-f681-484d-a00b-32533dca3a88
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3535
cannot deduce type for 'type1' from 'type2'  
  
 The type of the variable declared by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword cannot be deduced from the type of the initialization expression. For example, this error occurs if the initialization expression evaluates to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which is not a type.  
  
### To correct this error  
  
1.  Ensure that the type of the initialization expression is not <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
2.  Ensure that the declaration is not a pointer to a fundamental type. For more information, see [Fundamental Types](../vs140/fundamental-types---c---.md).  
  
3.  Ensure that if the declaration is a pointer to a type, the initialization expression is a pointer type.  
  
## Example  
 The following example yields C3535 because the initialization expression evaluates to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example yields C3535 because the statement declares variable <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> as a pointer to a deduced type, but the type of the initializer expression is double. Consequently, the compiler cannot deduce the type of the variable.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example yields C3535 because variable <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> declares a pointer to a deduced type, but the initialization expression is not a pointer type.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [auto Keyword](../vs140/auto-keyword.md)   
 [Fundamental Types](../vs140/fundamental-types---c---.md)