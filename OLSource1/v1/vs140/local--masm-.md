---
title: "LOCAL (MASM)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "Local"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LOCAL directive"
ms.assetid: 76147e2d-23ca-4f1e-8817-81428becd113
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LOCAL (MASM)
In the first directive, within a macro, **LOCAL** defines labels that are unique to each instance of the macro.  
  
## Syntax  
  
```  
  
      LOCAL localname [[, localname]]...  
LOCAL label [[ [count ] ]] [[:type]] [[, label [[ [count] ]] [[type]]]]...  
```  
  
## Remarks  
 In the second directive, within a procedure definition (**PROC**), **LOCAL** creates stack-based variables that exist for the duration of the procedure. The *label* may be a simple variable or an array containing *count* elements.  
  
## See Also  
 [Directives Reference](../vs140/directives-reference.md)