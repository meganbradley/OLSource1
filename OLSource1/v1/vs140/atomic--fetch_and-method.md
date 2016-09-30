---
title: "atomic::fetch_and Method"
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
  - "atomic/std::atomic::fetch_and"
dev_langs: 
  - "C++"
ms.assetid: a9c83001-b72c-4085-9640-f63f866714b9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::fetch_and Method
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
 [atomic_fetch_and_explicit](../vs140/atomic_fetch_and_explicit-function.md)