---
title: "recursive_mutex Class"
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
  - "mutex/std::recursive_mutex"
dev_langs: 
  - "C++"
ms.assetid: eb5ffd1b-7e78-4559-8391-bb220ead42fc
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# recursive_mutex Class
Represents a *mutex type*. In contrast to [mutex](../vs140/mutex-class--stl-.md), the behavior of calls to locking methods for objects that are already locked is well-defined.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[recursive_mutex::recursive_mutex Constructor](#recursive_mutex__recursive_mutex_constructor)|Constructs a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
|[recursive_mutex::~recursive_mutex Destructor](#recursive_mutex___dtorrecursive_mutex_destructor)|Releases any resources that are used by the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[recursive_mutex::lock Method](#recursive_mutex__lock_method)|Blocks the calling thread until the thread obtains ownership of the mutex.|  
|[recursive_mutex::try_lock Method](#recursive_mutex__try_lock_method)|Attempts to obtain ownership of the mutex without blocking.|  
|[recursive_mutex::unlock Method](#recursive_mutex__unlock_method)|Releases ownership of the mutex.|  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
##  \<a name="recursive_mutex__lock_method">\</a>  recursive_mutex::lock Method  
 Blocks the calling thread until the thread obtains ownership of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the method returns immediately, and the previous lock remains in effect.  
  
##  \<a name="recursive_mutex__recursive_mutex_constructor">\</a>  recursive_mutex::recursive_mutex Constructor  
 Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object that is not locked.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="recursive_mutex___dtorrecursive_mutex_destructor">\</a>  recursive_mutex::~recursive_mutex Destructor  
 Releases any resources that are used by the object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 If the object is locked when the destructor runs, the behavior is undefined.  
  
##  \<a name="recursive_mutex__try_lock_method">\</a>  recursive_mutex::try_lock Method  
 Attempts to obtain ownership of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> without blocking.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or if the calling thread already owns the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the function immediately returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and the previous lock remains in effect.  
  
##  \<a name="recursive_mutex__unlock_method">\</a>  recursive_mutex::unlock Method  
 Releases ownership of the mutex.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 This method releases ownership of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> only after it is called as many times as [lock](#recursive_mutex__lock_method) and [try_lock](#recursive_mutex__try_lock_method) have been called successfully on the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
 If the calling thread does not own the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the behavior is undefined.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<mutex>](../vs140/-mutex-.md)