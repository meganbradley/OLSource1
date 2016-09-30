---
title: "timed_mutex::try_lock Method"
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
  - "mutex/std::timed_mutex::try_lock"
dev_langs: 
  - "C++"
ms.assetid: 4ef05eb4-ba7a-4716-b21c-894f8fbdcb55
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# timed_mutex::try_lock Method
Attempts to obtain ownership of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> without blocking.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the behavior is undefined.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<mutex>](../vs140/-mutex-.md)   
 [timed_mutex Class](../vs140/timed_mutex-class.md)