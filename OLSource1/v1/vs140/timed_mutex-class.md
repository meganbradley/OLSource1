---
title: "timed_mutex Class"
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
  - "mutex/std::timed_mutex"
dev_langs: 
  - "C++"
ms.assetid: cd198081-6f38-447a-9dba-e06dfbfafe59
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# timed_mutex Class
Represents a *timed mutex type*. Objects of this type are used to enforce mutual exclusion through time-limited blocking within a program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[timed_mutex::timed_mutex Constructor](#timed_mutex__timed_mutex_constructor)|Constructs a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object that's not locked.|  
|[timed_mutex::~timed_mutex Destructor](#timed_mutex___dtortimed_mutex_destructor)|Releases any resources that are used by the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[timed_mutex::lock Method](#timed_mutex__lock_method)|Blocks the calling thread until the thread obtains ownership of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[timed_mutex::try_lock Method](#timed_mutex__try_lock_method)|Attempts to obtain ownership of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> without blocking.|  
|[timed_mutex::try_lock_for Method](#timed_mutex__try_lock_for_method)|Attempts to obtain ownership of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for a specified time interval.|  
|[timed_mutex::try_lock_until Method](#timed_mutex__try_lock_until_method)|Attempts to obtain ownership of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> until a specified time.|  
|[timed_mutex::unlock Method](#timed_mutex__unlock_method)|Releases ownership of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
##  \<a name="timed_mutex__lock_method">\</a>  timed_mutex::lock Method  
 Blocks the calling thread until the thread obtains ownership of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the behavior is undefined.  
  
##  \<a name="timed_mutex__timed_mutex_constructor">\</a>  timed_mutex::timed_mutex Constructor  
 Constructs a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object that is not locked.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="timed_mutex___dtortimed_mutex_destructor">\</a>  timed_mutex::~timed_mutex Destructor  
 Releases any resources that are used by the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 If the object is locked when the destructor runs, the behavior is undefined.  
  
##  \<a name="timed_mutex__try_lock_method">\</a>  timed_mutex::try_lock Method  
 Attempts to obtain ownership of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> without blocking.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, the behavior is undefined.  
  
##  \<a name="timed_mutex__try_lock_for_method">\</a>  timed_mutex::try_lock_for Method  
 Attempts to obtain ownership of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> without blocking.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A [chrono::duration](../vs140/duration-class.md) object that specifies the maximum amount of time that the method attempts to obtain ownership of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, the behavior is undefined.  
  
##  \<a name="timed_mutex__try_lock_until_method">\</a>  timed_mutex::try_lock_until Method  
 Attempts to obtain ownership of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> without blocking.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A point in time that specifies the threshold after which the method no longer attempts to obtain ownership of the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, the behavior is undefined.  
  
##  \<a name="timed_mutex__unlock_method">\</a>  timed_mutex::unlock Method  
 Releases ownership of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 If the calling thread does not own the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, the behavior is undefined.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<mutex>](../vs140/-mutex-.md)