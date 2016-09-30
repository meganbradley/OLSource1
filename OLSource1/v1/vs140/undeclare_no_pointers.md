---
title: "undeclare_no_pointers"
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
  - "undeclare_no_pointers"
  - "std::undeclare_no_pointers"
  - "std.undeclare_no_pointers"
  - "memory/std::undeclare_no_pointers"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "undeclare_no_pointers function"
  - "undeclare_no_pointers"
ms.assetid: b3bb5cf9-52ed-4ad8-8008-f314d064a656
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# undeclare_no_pointers
Informs a garbage collector that the characters in the memory block defined by a base address pointer and block size may now contain traceable pointers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The function informs any <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that the range of addresses <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> may now contain <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [\<memory>](../vs140/-memory-.md)