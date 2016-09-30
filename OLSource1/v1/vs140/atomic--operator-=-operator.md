---
title: "atomic::operator+= Operator"
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
  - "atomic/std::atomic::operator+="
dev_langs: 
  - "C++"
ms.assetid: 9ec97aa2-c9d7-436b-943d-2989eb2617dd
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::operator+= Operator
Adds a specified value to the stored value. Used only by integral and pointer specializations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Value  
 An integral or pointer value.  
  
## Return Value  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object that contains the result of the addition.  
  
## Remarks  
 This operator uses the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[memory_order](../vs140/memory_order-enum.md).  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [atomic Structure](../vs140/atomic-structure.md)   
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic_fetch_add_explicit](../vs140/atomic_fetch_add_explicit-function.md)