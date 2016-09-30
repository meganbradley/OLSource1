---
title: "undeclare_reachable"
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
  - "std.undeclare_reachable"
  - "undeclare_reachable"
  - "memory/std::undeclare_reachable"
  - "std::undeclare_reachable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "undeclare_reachable"
  - "undeclare_reachable function"
ms.assetid: 67f7845e-48a8-4531-a049-b6a4957bcaec
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# undeclare_reachable
Informs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that a specified memory location is not reachable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A pointer to the memory address to be declared not reachable.|  
  
## Property Value/Return Value  
 Returns a pointer to the specified memory location.  
  
## Remarks  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the function informs any <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is hereafter not <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. It returns a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> pointer that compares equal to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [\<memory>](../vs140/-memory-.md)