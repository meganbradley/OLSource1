---
title: "recursive_timed_mutex::try_lock_until Method"
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
  - "mutex/std::recursive_timed_mutex::try_lock_until"
dev_langs: 
  - "C++"
ms.assetid: 4a90d00a-a412-4533-998e-cc8fab5e68fe
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# recursive_timed_mutex::try_lock_until Method
Attempts to obtain ownership of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> without blocking.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A point in time that specifies the threshold after which the method no longer attempts to obtain ownership of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or if the calling thread already owns the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the method immediately returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and the previous lock remains in effect.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<mutex>](../vs140/-mutex-.md)   
 [recursive_timed_mutex Class](../vs140/recursive_timed_mutex-class.md)   
 [time_point Class](../vs140/time_point-class.md)