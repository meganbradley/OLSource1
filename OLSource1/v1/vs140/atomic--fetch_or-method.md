---
title: "atomic::fetch_or Method"
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
  - "atomic/std::atomic::fetch_or"
dev_langs: 
  - "C++"
ms.assetid: 4c532f7f-80c5-432a-b34b-48feacab8dca
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# atomic::fetch_or Method
Performs a bitwise <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> on a value and an existing value that is stored in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/memory_order-enum.md).  
  
## Return Value  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that contains the result of the bitwise <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method performs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operation to replace the stored value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> with a bitwise <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and the current value that is stored in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, within the memory constraints that are specified by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_or_explicit](../vs140/atomic_fetch_or_explicit-function.md)