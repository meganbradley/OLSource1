---
title: "jitintrinsic"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
f1_keywords: 
  - jitintrinsic
  - jitintrinsic_cpp
dev_langs: 
  - C++
helpviewer_keywords: 
  - __declspec keyword [C++], jitintrinsic
  - jitintrinsic __declspec modifier
ms.assetid: 23dbe416-7ef6-442b-b16d-9a81aab04fa6
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# jitintrinsic
Marks the function as significant to the 64-bit common language runtime. This is used on certain functions in Microsoft-provided libraries.  
  
## Syntax  
  
```  
__declspec(jitintrinsic)  
```  
  
## Remarks  
 `jitintrinsic` adds a MODOPT (<xref:System.Runtime.CompilerServices.IsJitIntrinsic?qualifyHint=False>) to a function signature.  
  
 Users are discouraged from using this `__declspec` modifier, as unexpected results can occur.  
  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)