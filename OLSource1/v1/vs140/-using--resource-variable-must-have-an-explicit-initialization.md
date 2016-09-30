---
title: "&#39;Using&#39; resource variable must have an explicit initialization"
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
  - "vbc36011"
  - "bc36011"
helpviewer_keywords: 
  - "BC36011"
ms.assetid: 5db996a6-0802-4b67-91f1-4aa9c3dd6b09
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Using&#39; resource variable must have an explicit initialization
A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement specifies at least one resource that it does not initialize with a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause.  
  
 If you have not already acquired the resource before passing control to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement must acquire the resource. To do this, it must create an object from the specified class, which requires a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clause.  
  
 **Error ID:** BC36011  
  
### To correct this error  
  
-   If you have already acquired the resource, use a reference variable or expression in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement that evaluates to the acquired resource.  
  
     <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
-   If you have not already acquired the resource, add a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement.  
  
     <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## See Also  
 [Using Statement (Visual Basic)](../vs140/using-statement--visual-basic-.md)   
 [New (Visual Basic)](../vs140/new-operator--visual-basic-.md)   
 [How to: Dispose of a System Resource](../vs140/how-to--dispose-of-a-system-resource--visual-basic-.md)