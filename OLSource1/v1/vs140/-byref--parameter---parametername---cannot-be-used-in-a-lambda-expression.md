---
title: "&#39;ByRef&#39; parameter &#39;&lt;parametername&gt;&#39; cannot be used in a lambda expression"
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
  - "bc36639"
  - "vbc36639"
helpviewer_keywords: 
  - "BC36639"
ms.assetid: 5913f9b6-2929-4c05-8dd1-00b10fcd5a83
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;ByRef&#39; parameter &#39;&lt;parametername&gt;&#39; cannot be used in a lambda expression
A lambda expression declared within a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or function cannot use any <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameters of that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or function. For example, the following code will cause this error because the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is used in the lambda expression.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Error ID:** BC36639  
  
### To correct this error  
  
-   Assign the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter to a local variable, and use the local variable in the lambda expression, as shown in the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md)