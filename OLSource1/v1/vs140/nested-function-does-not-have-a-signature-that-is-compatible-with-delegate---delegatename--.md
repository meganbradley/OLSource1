---
title: "Nested function does not have a signature that is compatible with delegate &#39;&lt;delegatename&gt;&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc36532"
  - "bc36532"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC36532"
ms.assetid: 493f292c-d81e-40ef-8b47-61f020571829
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nested function does not have a signature that is compatible with delegate &#39;&lt;delegatename&gt;&#39;
A lambda expression has been assigned to a delegate that has an incompatible signature. For example, in the following code, delegate <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> has two integer parameters.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The error is raised if a lambda expression with one argument is declared as type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Error ID:** BC36532  
  
### To correct this error  
  
-   Adjust either the delegate definition or the assigned lambda expression so that the signatures are compatible.  
  
## See Also  
 [Relaxed Delegate Conversion](../vs140/relaxed-delegate-conversion--visual-basic-.md)   
 [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md)