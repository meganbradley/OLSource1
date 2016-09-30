---
title: "msad4 Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: faa3bc53-08ef-4e32-a358-61bf2b1c6210
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# msad4 Function
Compares a 4-byte reference value and an 8-byte source value and accumulates a vector of 4 sums. Each sum corresponds to the masked sum of absolute differences of different byte alignments between the reference value and the source value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The reference array of 4 bytes in one uint value  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The source array of 8 bytes in a vector of two uint values.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A vector of 4 values to be added to the masked sum of absolute differences of the different byte alignments between the reference value and the source value.  
  
## Return Value  
 Returns a vector of 4 sums. Each sum corresponds to the masked sum of absolute differences of different byte alignments between the reference value and the source value.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics::direct3d  
  
## See Also  
 [concurrency::graphics::direct3d Namespace](../vs140/concurrency--graphics--direct3d-namespace.md)