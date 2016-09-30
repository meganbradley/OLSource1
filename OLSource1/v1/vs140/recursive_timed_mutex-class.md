---
title: "recursive_timed_mutex Class"
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
  - "mutex/std::recursive_timed_mutex"
dev_langs: 
  - "C++"
ms.assetid: 59cc2d5c-ed80-45f3-a0a8-05652a8ead7e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# recursive_timed_mutex Class
Represents a *timed mutex type*. Objects of this type are used to enforce mutual exclusion by using time-limited blocking within a program. Unlike objects of type [timed_mutex](../vs140/timed_mutex-class.md), the effect of calling locking methods for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects is well-defined.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[recursive_timed_mutex::recursive_timed_mutex Constructor](#recursive_timed_mutex__recursive_timed_mutex_constructor)|Constructs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object that's not locked.|  
|[recursive_timed_mutex::~recursive_timed_mutex Destructor](#recursive_timed_mutex___dtorrecursive_timed_mutex_destructor)|Releases any resources that are used by the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[recursive_timed_mutex::lock Method](#recursive_timed_mutex__lock_method)|Blocks the calling thread until the thread obtains ownership of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|[recursive_timed_mutex::try_lock Method](#recursive_timed_mutex__try_lock_method)|Attempts to obtain ownership of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> without blocking.|  
|[recursive_timed_mutex::try_lock_for Method](#recursive_timed_mutex__try_lock_for_method)|Attempts to obtain ownership of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for a specified time interval.|  
|[recursive_timed_mutex::try_lock_until Method](#recursive_timed_mutex__try_lock_until_method)|Attempts to obtain ownership of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> until a specified time.|  
|[recursive_timed_mutex::unlock Method](#recursive_timed_mutex__unlock_method)|Releases ownership of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
##  \<a name="recursive_timed_mutex__lock_method">\</a>  recursive_timed_mutex::lock Method  
 Blocks the calling thread until the thread obtains ownership of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the method returns immediately, and the previous lock remains in effect.  
  
##  \<a name="recursive_timed_mutex__recursive_timed_mutex_constructor">\</a>  recursive_timed_mutex::recursive_timed_mutex Constructor  
 Constructs a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object that is not locked.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="recursive_timed_mutex___dtorrecursive_timed_mutex_destructor">\</a>  recursive_timed_mutex::~recursive_timed_mutex Destructor  
 Releases any resources that are used by the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 If the object is locked when the destructor runs, the behavior is undefined.  
  
##  \<a name="recursive_timed_mutex__try_lock_method">\</a>  recursive_timed_mutex::try_lock Method  
 Attempts to obtain ownership of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> without blocking.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> if the method successfully obtained ownership of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or if the calling thread already owns the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, the function immediately returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and the previous lock remains in effect.  
  
##  \<a name="recursive_timed_mutex__try_lock_for_method">\</a>  recursive_timed_mutex::try_lock_for Method  
 Attempts to obtain ownership of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> without blocking.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A [chrono::duration](../vs140/duration-class.md) object that specifies the maximum amount of time that the method attempts to obtain ownership of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or if the calling thread already owns the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, the method immediately returns <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, and the previous lock remains in effect.  
  
##  \<a name="recursive_timed_mutex__try_lock_until_method">\</a>  recursive_timed_mutex::try_lock_until Method  
 Attempts to obtain ownership of the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> without blocking.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A point in time that specifies the threshold after which the method no longer attempts to obtain ownership of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> or if the calling thread already owns the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, the method immediately returns <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, and the previous lock remains in effect.  
  
##  \<a name="recursive_timed_mutex__unlock_method">\</a>  recursive_timed_mutex::unlock Method  
 Releases ownership of the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 This method releases ownership of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> only after it is called as many times as [lock](#recursive_timed_mutex__lock_method), [try_lock](#recursive_timed_mutex__try_lock_method), [try_lock_for](#recursive_timed_mutex__try_lock_for_method), and [try_lock_until](#recursive_timed_mutex__try_lock_until_method) have been called successfully on the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.  
  
 If the calling thread does not own the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, the behavior is undefined.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<mutex>](../vs140/-mutex-.md)