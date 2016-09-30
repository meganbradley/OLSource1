---
title: "Compiler Error CS0425"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0425"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0425"
ms.assetid: cec0391c-a641-43bc-8557-92b23f6ca685
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0425
The constraints for type parameter 'type parameter' of method 'method' must match the constraints for type parameter 'type parameter' of interface method 'method'. Consider using an explicit interface implementation instead.  
  
 This error occurs if a virtual generic method is overridden in a derived class and the constraints on the method in the derived class do not match the constraints on the method in the base class. To avoid this error, make sure the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause is identical in both declarations, or implement the interface explicitly.  
  
## Example  
 The following example generates CS0425:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The constraints do not have to be a literal match, as long as the set of constraints has the same meaning. For example, the following is okay:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>