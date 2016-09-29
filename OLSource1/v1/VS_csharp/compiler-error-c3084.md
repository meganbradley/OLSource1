---
title: "Compiler Error C3084"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3084"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3084"
ms.assetid: 0362cb70-e24e-476f-a24d-8f5bb97c3afd
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3084
'function': a finalizer/destructor cannot be 'keyword'  
  
 A finalizer or destructor was declared incorrectly.  
  
 For example, a destructor should not be marked as sealed.  The destructor will be inaccessible to derived types.  For more information, see [Explicit Overrides](../VS_csharp/explicit-overrides---c---component-extensions-.md) and [Destructors and Finalizers](../Topic/Destructors%20and%20Finalizers%20in%20Visual%20C++.md).  
  
## Example  
 The following sample generates C3084.  
  
```  
// C3084.cpp  
// compile with: /clr /c  
ref struct R {  
protected:  
   !R() sealed;   // C3084  
   !R() abstract;   // C3084  
   !R();  
};  
```