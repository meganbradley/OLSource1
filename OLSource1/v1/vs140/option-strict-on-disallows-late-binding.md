---
title: "Option Strict On disallows late binding"
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
  - "bc30574"
  - "vbc30574"
helpviewer_keywords: 
  - "BC30574"
ms.assetid: 9da4b826-2e12-4a5d-9e17-762b0b68fc9b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option Strict On disallows late binding
[!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] allows implicit conversions of any data type to any other data type. However, data loss can occur if the value of one data type is converted to a data type with less precision or a smaller capacity. <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> ensures compile-time notification of these types of conversions so they may be avoided. You cannot use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> with late binding.  
  
 The following code example uses late binding and causes this error when <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [!CODE [VbVbalrOptionStrictError#1](VbVbalrOptionStrictError#1)]  
  
 **Error ID:** BC30574  
  
### To correct this error  
  
-   Modify the object declaration to use an explicit type, as shown in the following example:  
  
     [!CODE [VbVbalrOptionStrictError#2](VbVbalrOptionStrictError#2)]  
  
 \- or -  
  
-   Modify the late-bound expression to specify an explicit type, as shown in the following example:  
  
     [!CODE [VbVbalrOptionStrictError#3](VbVbalrOptionStrictError#3)]  
  
 \- or -  
  
-   Let the compiler infer a specific type, as shown in the following example:  
  
     [!CODE [VbVbalrOptionStrictError#4](VbVbalrOptionStrictError#4)]  
  
 \- or -  
  
-   Turn <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> off by removing the word <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> after it or by explicitly specifying <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## See Also  
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)