---
title: "CCriticalSection Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CCriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "synchronization objects, critical section"
  - "CCriticalSection class"
  - "critical sections"
  - "synchronization classes, CCriticalSection class"
ms.assetid: f776f74b-5b0b-4f32-9c13-2b8e4a0d7b2b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCriticalSection Class
Represents a "critical section" — a synchronization object that allows one thread at a time to access a resource or section of code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CCriticalSection::CCriticalSection](#ccriticalsection__ccriticalsection)|Constructs a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CCriticalSection::Lock](#ccriticalsection__lock)|Use to gain access to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
|[CCriticalSection::Unlock](#ccriticalsection__unlock)|Releases the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CCriticalSection::operator CRITICAL_SECTION*](#ccriticalsection__operator_critical_section_star)|Retrieves a pointer to the internal **CRITICAL_SECTION** object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CCriticalSection::m_sect](#ccriticalsection__m_sect)|A **CRITICAL_SECTION** object.|  
  
## Remarks  
 Critical sections are useful when only one thread at a time can be allowed to modify data or some other controlled resource. For example, adding nodes to a linked list is a process that should only be allowed by one thread at a time. By using a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object to control the linked list, only one thread at a time can gain access to the list.  
  
> [!NOTE]
>  The functionality of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class is provided by an actual Win32 **CRITICAL_SECTION** object.  
  
 Critical sections are used instead of mutexes (see [CMutex](../vs140/cmutex-class.md)) when speed is critical and the resource will not be used across process boundaries.  
  
 There are two methods for using a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object: stand-alone and embedded in a class.  
  
-   Stand-alone method   To use a stand-alone <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object, construct the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object when it is needed. After a successful return from the constructor, explicitly lock the object with a call to [Lock](#ccriticalsection__lock). Call [Unlock](#ccriticalsection__unlock) when you are done accessing the critical section. This method, while clearer to someone reading your source code, is more prone to error as you must remember to lock and unlock the critical section before and after access.  
  
     A more preferable method is to use the [CSingleLock](../vs140/csinglelock-class.md) class. It also has a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method, but you don't have to worry about unlocking the resource if an exception occurs.  
  
-   Embedded method   You can also share a class with multiple threads by adding a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>-type data member to the class and locking the data member when needed.  
  
 For more information on using <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> objects, see the article [Multithreading: How to Use the Synchronization Classes](../vs140/multithreading--how-to-use-the-synchronization-classes.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CSyncObject](../vs140/csyncobject-class.md)  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxmt.h  
  
##  \<a name="ccriticalsection__ccriticalsection">\</a>  CCriticalSection::CCriticalSection  
 Constructs a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 To access or release a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object, create a [CSingleLock](../vs140/csinglelock-class.md) object and call its [Lock](../vs140/csinglelock-class.md#csinglelock__lock) and [Unlock](../vs140/csinglelock-class.md#csinglelock__unlock) member functions. If the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object is being used stand-alone, call its [Unlock](#ccriticalsection__unlock) member function to release it.  
  
 If the constructor fails to allocate the required system memory, a memory exception (of type [CMemoryException](../vs140/cmemoryexception-class.md)) is automatically thrown.  
  
### Example  
  See the example for [CCriticalSection::Lock](#ccriticalsection__lock).  
  
##  \<a name="ccriticalsection__lock">\</a>  CCriticalSection::Lock  
 Call this member function to gain access to the critical section object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> ignores this parameter value.  
  
### Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
### Remarks  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a blocking call that will not return until the critical section object is signaled (becomes available).  
  
 If timed waits are necessary, you can use a [CMutex](../vs140/cmutex-class.md) object instead of a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
 If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> fails to allocate the necessary system memory, a memory exception (of type [CMemoryException](../vs140/cmemoryexception-class.md)) is automatically thrown.  
  
### Example  
 This example demonstrates the nested critical section approach by controlling access to a shared resource (the static <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object) using a shared <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> function demonstrates updating a shared resource in a safe manner.  
  
 [!code[NVC_MFC_Utilities#11](../vs140/codesnippet/CPP/ccriticalsection-class_1.h)]  
  
##  \<a name="ccriticalsection__m_sect">\</a>  CCriticalSection::m_sect  
 Contains a critical section object that is used by all <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> methods.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="ccriticalsection__operator_critical_section_star">\</a>  CCriticalSection::operator CRITICAL_SECTION*  
 Retrieves a **CRITICAL_SECTION** object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Call this function to retrieve a pointer to the internal **CRITICAL_SECTION** object.  
  
##  \<a name="ccriticalsection__unlock">\</a>  CCriticalSection::Unlock  
 Releases the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object for use by another thread.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object was owned by the thread and the release was successful; otherwise 0.  
  
### Remarks  
 If the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is being used stand-alone, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> must be called immediately after completing use of the resource controlled by the critical section. If a [CSingleLock](../vs140/csinglelock-class.md) object is being used, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> will be called by the lock object's <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> member function.  
  
### Example  
  See the example for [CCriticalSection::Lock](#ccriticalsection__lock).  
  
## See Also  
 [Base Class](../vs140/csyncobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMutex](../vs140/cmutex-class.md)