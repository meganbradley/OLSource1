---
title: "mutex Class (STL)"
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
  - "mutex/std::mutex"
dev_langs: 
  - "C++"
ms.assetid: 7999d055-f74f-4303-810f-8d3c9cde2f69
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mutex Class (STL)
Represents a *mutex type*. Objects of this type can be used to enforce mutual exclusion within a program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[mutex::mutex Constructor (STL)](#mutex__mutex_constructor)|Constructs a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
|[mutex::~mutex Destructor (STL)](#mutex___dtormutex_destructor)|Releases any resources that were used by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[mutex::lock Method (STL)](#mutex__lock_method)|Blocks the calling thread until the thread obtains ownership of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|[mutex::native_handle Method](#mutex__native_handle_method)|Returns the implementation-specific type that represents the mutex handle.|  
|[mutex::try_lock method (STL)](#mutex__try_lock_method)|Attempts to obtain ownership of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> without blocking.|  
|[mutex::unlock Method (STL)](#mutex__unlock_method)|Releases ownership of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
##  \<a name="mutex__lock_method">\</a>  mutex::lock Method  
 Blocks the calling thread until the thread obtains ownership of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the behavior is undefined.  
  
##  \<a name="mutex__mutex_constructor">\</a>  mutex::mutex Constructor  
 Constructs a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object that is not locked.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="mutex___dtormutex_destructor">\</a>  mutex::~mutex Destructor  
 Releases any resources that are used by the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 If the object is locked when the destructor runs, the behavior is undefined.  
  
##  \<a name="mutex__native_handle_method">\</a>  mutex::native_handle Method  
 Returns the implementation-specific type that represents the mutex handle. The mutex handle can be used in implementation-specific ways.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is defined as a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> that's cast as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
##  \<a name="mutex__try_lock_method">\</a>  mutex::try_lock Method  
 Attempts to obtain ownership of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> without blocking.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, the behavior is undefined.  
  
##  \<a name="mutex__unlock_method">\</a>  mutex::unlock Method  
 Releases ownership of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 If the calling thread does not own the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, the behavior is undefined.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<mutex>](../vs140/-mutex-.md)