---
title: "&#39;Using&#39; resource variable type can not be array type"
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
  - "vbc36012"
  - "bc36012"
helpviewer_keywords: 
  - "BC36012"
ms.assetid: f98c54b0-6ede-48b6-aa31-438664c219f3
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Using&#39; resource variable type can not be array type
A `Using` statement specifies an array variable for a resource.  
  
 The \<xref:System.Array*> class does not implement the \<xref:System.IDisposable*> interface, so the `Using` block cannot call the \<xref:System.IDisposable.Dispose*> method on an array resource.  
  
 **Error ID:** BC36012  
  
### To correct this error  
  
-   Use a different type of system resource in the `Using` block.  
  
## See Also  
 [Using Statement (Visual Basic)](../vs140/using-statement--visual-basic-.md)   
 [How to: Dispose of a System Resource](../vs140/how-to--dispose-of-a-system-resource--visual-basic-.md)   
 [NOTINBUILD Overview of Arrays in Visual Basic](assetId:///ca50e2f2-b4d2-4c57-9169-9abbcc3392d8)