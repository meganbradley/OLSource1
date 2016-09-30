---
title: "recursive_timed_mutex::try_lock_for Method"
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
  - "mutex/std::recursive_timed_mutex::try_lock_for"
dev_langs: 
  - "C++"
ms.assetid: 4e46684d-7c55-4146-b1d5-ffef7c6af911
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# recursive_timed_mutex::try_lock_for Method
Attempts to obtain ownership of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> without blocking.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A [chrono::duration](../vs140/duration-class.md) object that specifies the maximum amount of time that the method attempts to obtain ownership of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
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