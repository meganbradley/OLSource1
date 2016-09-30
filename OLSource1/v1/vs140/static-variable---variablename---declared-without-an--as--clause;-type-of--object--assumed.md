---
title: "Static variable &#39;&lt;variablename&gt;&#39; declared without an &#39;As&#39; clause; type of &#39;Object&#39; assumed"
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
  - "vbc42111"
  - "bc42111"
helpviewer_keywords: 
  - "BC42111"
ms.assetid: ca6b625c-21a5-45f7-ac67-282f6993a724
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Static variable &#39;&lt;variablename&gt;&#39; declared without an &#39;As&#39; clause; type of &#39;Object&#39; assumed
The compiler does not infer the data type of static local variables. In the following example, with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the type of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, regardless of whether <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Local type inference does not apply.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 By default, this message is a warning. For information about how to hide warnings or how to treat warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42111  
  
### To address this warning  
  
-   Specify the data type for static local variables.  
  
     For example, if you want <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in the previous example to be of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, specify the type in the declaration.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md)   
 [NOTINBUILD How to: Lengthen a Variable's Lifetime](assetId:///04e7c56c-1db0-4fe5-a678-859a39ec654b)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Option Infer Statement](../vs140/option-infer-statement.md)   
 [Static (Visual Basic)](../vs140/static--visual-basic-.md)