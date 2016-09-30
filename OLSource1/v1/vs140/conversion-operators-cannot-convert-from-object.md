---
title: "Conversion operators cannot convert from Object"
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
  - "bc33032"
  - "vbc33032"
helpviewer_keywords: 
  - "BC33032"
ms.assetid: 877f626f-7aa1-41d8-b7ca-eb4337d012d1
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conversion operators cannot convert from Object
A conversion operator is declared with a parameter of the [Object Data Type](../vs140/object-data-type.md).  
  
 At compile time, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] considers a predefined conversion to exist from any reference type to any type in its inheritance hierarchy, that is, any type from which it derives or which derives from it. <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is the universal data type in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], so every type derives from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 Because the compiler considers this conversion to be already defined, it does not allow you to redefine it.  
  
 **Error ID:** BC33032  
  
### To correct this error  
  
-   Remove this operator definition entirely. It is already predefined.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)   
 [Object as the Universal Data Type (Visual Basic)](assetId:///5315bf21-2b22-45ab-98cd-5631dffbcb2f)