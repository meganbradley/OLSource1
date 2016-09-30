---
title: "kill_dependency Function"
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
  - "atomic/std::kill_dependency"
dev_langs: 
  - "C++"
ms.assetid: 37f64495-e1db-4864-bcc3-175d59335c00
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# kill_dependency Function
Removes a dependency.  
  
## Syntax  
  
```  
template<class Ty>  
Ty kill_dependency(  
   TyArg  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Arg`  
 A value of type `Ty`.  
  
## Return Value  
 The return value is `Arg`. The evaluation of `Arg` does not carry a dependency to the function call. By breaking a possible dependency chain, the function might permit the compiler to generate more efficient code.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)