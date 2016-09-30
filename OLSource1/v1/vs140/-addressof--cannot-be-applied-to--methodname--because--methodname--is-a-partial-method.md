---
title: "&#39;AddressOf&#39; cannot be applied to &#39;methodname&#39; because &#39;methodname&#39; is a partial method"
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
  - "vbc31440"
  - "bc31440"
helpviewer_keywords: 
  - "BC31440"
ms.assetid: 924dbada-3e0a-4004-a3ae-a209b7c3d1fa
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;AddressOf&#39; cannot be applied to &#39;methodname&#39; because &#39;methodname&#39; is a partial method
A partial method has been passed to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator. Partial methods are invalid values for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator.  
  
 **Error ID:** BC31440  
  
### To correct this error  
  
1.  Add an implementation method for the partial method. The implementation method is a valid value for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator. The following example shows a partial method signature and its implementation.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md)   
 [Partial Methods](../vs140/partial-methods--visual-basic-.md)