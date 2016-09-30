---
title: "atomic_thread_fence Function"
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
  - "atomic/std::atomic_thread_fence"
dev_langs: 
  - "C++"
ms.assetid: 14d2d5fc-e490-4160-9b1e-4711d78b0577
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_thread_fence Function
Acts as a *fence*—which is a memory synchronization primitive that enforces ordering between load/store operations—without an associated atomic operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A memory ordering constraint that determines fence type.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> argument determines fence type.  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The fence has no effect.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The fence is an acquire fence.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The fence is an acquire fence.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The fence is a release fence.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The fence is both an acquire fence and a release fence.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The fence is both an acquire fence and a release fence, and is sequentially consistent.|  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_signal_fence](../vs140/atomic_signal_fence-function.md)