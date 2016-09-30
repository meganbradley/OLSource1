---
title: "Cannot infer a common type for the first and second operands of the binary &#39;If&#39; operator"
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
  - "vbc33110"
  - "bc33110"
helpviewer_keywords: 
  - "BC33110"
ms.assetid: f46873aa-f6cd-4cc9-9e8e-e668bddf0980
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Cannot infer a common type for the first and second operands of the binary &#39;If&#39; operator
Cannot infer a common type for the first and second operands of the binary 'If' operator. One must have a widening conversion to the other.  
  
 The binary <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator requires that there be a widening conversion between one of the arguments and the other argument. For example, because there is not a widening conversion in either direction between <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the following code causes this error.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Error ID:** BC33110  
  
### To correct this error  
  
-   Provide an explicit conversion for one of the operands, if that is possible in your code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   Rewrite the code by using a different conditional construction.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [If Operator](../vs140/if-operator--visual-basic-.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [If...Then...Else Statement (Visual Basic)](../vs140/if...then...else-statement--visual-basic-.md)