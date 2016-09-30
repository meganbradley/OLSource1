---
title: "&lt;future&gt;"
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
  - "<future>"
dev_langs: 
  - "C++"
ms.assetid: 2f5830fc-455d-44f9-9e3d-94ea051596a2
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;future&gt;
Include the standard header \<future> to define template classes and supporting templates that simplify running a function—possibly in a separate thread—and retrieving its result. The result is either the value that is returned by the function or an exception that is emitted by the function but is not caught in the function.  
  
 This header uses Concurrency Runtime (ConcRT) so that you can use it together with other ConcRT mechanisms. For more information about ConcRT, see [Concurrency Runtime](../vs140/concurrency-runtime.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
> [!NOTE]
>  In code that is compiled by using **/clr** or **/clr:pure**, this header is blocked.  
  
 An *asynchronous provider* stores the result of a function call. An *asynchronous return object* is used to retrieve the result of a function call. An *associated asynchronous state* provides communication between an asynchronous provider and one or more asynchronous return objects.  
  
 A program does not directly create any associated asynchronous state objects. The program creates an asynchronous provider whenever it needs one and from that it creates an asynchronous return object that shares its associated asynchronous state with the provider. Asynchronous providers and asynchronous return objects manage the objects that hold their shared associated asynchronous state. When the last object that references the associated asynchronous state releases it, the object that holds the associated asynchronous state is destroyed.  
  
 An asynchronous provider or an asynchronous return object that has no associated asynchronous state is *empty*.  
  
 An associated asynchronous state is *ready* only if its asynchronous provider has stored a return value or stored an exception.  
  
 The template function <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and the template classes <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are asynchronous providers. The template classes <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> describe asynchronous return objects.  
  
 Each of the template classes <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> has a specialization for the type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and a partial specialization for storing and retrieving a value by reference. These specializations differ from the primary template only in the signatures and semantics of the functions that store and retrieve the returned value.  
  
 The template classes <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> never block in their destructors, except in one case that's preserved for backward compatibility: Unlike all other futures, for a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>—or the last <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>—that's attached to a task started with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the destructor blocks if the task has not completed; that is, it blocks if this thread did not yet call <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and the task is still running. The following usability note has been added to the description of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> in the draft standard: "[Note: If a future obtained from std::async is moved outside the local scope, other code that uses the future must be aware that the future’s destructor may block for the shared state to become ready.—end note]" In all other cases, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> destructors are required and are guaranteed to never block.  
  
## Members  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[future Class](../vs140/future-class.md)|Describes an asynchronous return object.|  
|[future_error Class](../vs140/future_error-class.md)|Describes an exception object that can be thrown by methods of types that manage <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> objects.|  
|[packaged_task Class](../vs140/packaged_task-class.md)|Describes an asynchronous provider that is a call wrapper and whose call signature is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. Its associated asynchronous state holds a copy of its callable object in addition to the potential result.|  
|[promise Class](../vs140/promise-class.md)|Describes an asynchronous provider.|  
|[shared_future Class](../vs140/shared_future-class.md)|Describes an asynchronous return object. In contrast with a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object, an asynchronous provider can be associated with any number of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> objects.|  
  
### Structures  
  
|Name|Description|  
|----------|-----------------|  
|[is_error_code_enum Structure](../vs140/is_error_code_enum-structure.md)|Specialization that indicates that <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is suitable for storing an <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|[uses_allocator Structure](../vs140/uses_allocator-structure.md)|Specialization that always holds true.|  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[async Function](../vs140/-future--functions.md#async_function)|Represents an asynchronous provider.|  
|[future_category Function](../vs140/-future--functions.md#future_category_function)|Returns a reference to the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object that characterizes errors that are associated with <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> objects.|  
|[make_error_code Function](../vs140/-future--functions.md#make_error_code_function)|Creates an <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> that has the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object that characterizes <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> errors.|  
|[make_error_condition Function](../vs140/-future--functions.md#make_error_condition_function)|Creates an <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> that has the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object that characterizes <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> errors.|  
|[swap Function](../vs140/-future--functions.md#swap_function)|Exchanges the associated asynchronous state of one <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object with that of another.|  
  
### Enumerations  
  
|Name|Description|  
|----------|-----------------|  
|[future_errc Enumeration](../vs140/-future--enums.md#future_errc_enumeration)|Supplies symbolic names for the errors that are reported by the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> class.|  
|[future_status Enumeration](../vs140/-future--enums.md#future_status_enumeration)|Supplies symbolic names for the reasons that a timed wait function can return.|  
|[launch Enumeration](../vs140/-future--enums.md#launch_enumeration)|Represents a bitmask type that describes the possible modes for the template function <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.|  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)