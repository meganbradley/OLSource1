---
title: "&#39;Next&#39; statement names more variables than there are matching &#39;For&#39; statements"
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
  - "bc32037"
  - "vbc32037"
helpviewer_keywords: 
  - "BC32037"
ms.assetid: 7c97d835-1043-40ec-a645-63a053f5f916
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Next&#39; statement names more variables than there are matching &#39;For&#39; statements
Nested loops are terminated with a single <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement that specifies more loop variables than there are loops in the nest, as in the following example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Error ID:** BC32037  
  
### To correct this error  
  
1.  Ensure that the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement specifies all the nested loop variables in the reverse order of loop initiation.  
  
2.  Remove any extraneous variables from the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement.  
  
## See Also  
 [For...Next Statement](../vs140/for...next-statement--visual-basic-.md)