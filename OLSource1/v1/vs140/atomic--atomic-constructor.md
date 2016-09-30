---
title: "atomic::atomic Constructor"
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
  - "atomic/std::atomic::atomic"
dev_langs: 
  - "C++"
ms.assetid: a538c43f-4d48-4308-ae1b-bab1839bccb8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::atomic Constructor
Constructs an atomic object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Initialization value.  
  
## Remarks  
 Atomic objects cannot be copied or moved.  
  
 Objects that are instantiations of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> can be initialized only by the constructor that takes an argument of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and not by using aggregate initialization. However, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects can be initialized only by using aggregate initialization.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)