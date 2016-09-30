---
title: "&lt;allocators&gt;"
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
  - "stdext::<allocators>"
  - "allocators/stdext::allocators"
  - "<allocators>"
  - "stdext.<allocators>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocators header"
ms.assetid: 4393a607-4df8-4278-bbb2-c8ec52e60b83
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;allocators&gt;
Defines several templates that help allocate and free memory blocks for node-based containers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The \<allocators> header provides six allocator templates that can be used to select memory-management strategies for node-based containers. For use with these templates, it also provides several different synchronization filters to tailor the memory-management strategy to a variety of different multithreading schemes (including none). Matching a memory management strategy to the known memory usage patterns, and synchronization requirements, of a particular application can often increase the speed or reduce the overall memory requirements of an application.  
  
 The allocator templates are implemented with reusable components that can be customized or replaced to provide additional memory-management strategies.  
  
 The node-based containers in the Standard C++ library (std::list, std::set, std::multiset, std::map and std::multimap) store their elements in individual nodes. All the nodes for a particular container type are the same size, so the flexibility of a general-purpose memory manager is not needed. Because the size of each memory block is known at compile time, the memory manager can be much simpler and faster.  
  
 When used with containers that are not node-based (such as the Standard C++ library containers std::vector std::deque, and std::basic_string), the alllocator templates will work correctly, but are not likely to provide any performance improvement over the default allocator.  
  
 An allocator is a template class that describes an object that manages storage allocation and freeing for objects and arrays of objects of a designated type. Allocator objects are used by several container template classes in the Standard C++ library.  
  
 The allocators are all templates of this type:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 where the template argument <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the type managed by the allocator instance. The Standard C++ library provides a default allocator, template class [allocator](../vs140/allocator-class.md), which is defined in [\<memory>](../vs140/-memory-.md). The \<allocators> header provides the following allocators:  
  
-   [allocator_newdel](../vs140/allocator_newdel-class.md)  
  
-   [allocator_unbounded](../vs140/allocator_unbounded-class.md)  
  
-   [allocator_fixed_size](../vs140/allocator_fixed_size-class.md)  
  
-   [allocator_variable_size](../vs140/allocator_variable_size-class.md)  
  
-   [allocator_suballoc](../vs140/allocator_suballoc-class.md)  
  
-   [allocator_chunklist](../vs140/allocator_chunklist-class.md)  
  
 Use an appropriate instantiation of an allocator as the second type argument when creating a container, such as the following code example.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 _List0 allocates nodes with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and the default synchronization filter.  
  
 Use the macro [ALLOCATOR_DECL](../vs140/-allocators--functions.md#allocator_decl) to create allocator templates with synchronization filters other than the default:  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 _Lst1 allocates nodes with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and the [sync_per_thread](../vs140/sync_per_thread-class.md) synchronization filter.  
  
 A block allocator is a cache or a filter. A cache is a template class that takes one argument of type std::size_t. It defines a block allocator that allocates and deallocates memory blocks of a single size. It must obtain memory using operator <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, but it need not make a separate call to operator <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> for each block. It may, for example, suballocate from a larger block or cache deallocated blocks for subsequent reallocation.  
  
 With a compiler that cannot compile rebind the value of the std::size_t argument used when the template was instantiated is not necessarily the value of the argument _Sz passed to a cache's member functions allocate and deallocate.  
  
 \<allocators> provides the following cache templates:  
  
-   [cache_freelist](../vs140/cache_freelist-class.md)  
  
-   [cache_suballoc](../vs140/cache_suballoc-class.md)  
  
-   [cache_chunklist](../vs140/cache_chunklist-class.md)  
  
 A filter is a block allocator that implements its member functions using another block allocator which is passed to it as a template argument. The most common form of filter is a synchronization filter, which applies a synchronization policy to control access to the member functions of an instance of another block allocator. \<allocators> provides the following synchronization filters:  
  
-   [sync_none](../vs140/sync_none-class.md)  
  
-   [sync_per_container](../vs140/sync_per_container-class.md)  
  
-   [sync_per_thread](../vs140/sync_per_thread-class.md)  
  
-   [sync_shared](../vs140/sync_shared-class.md)  
  
 \<allocators> also provides the filter [rts_alloc](../vs140/rts_alloc-class.md), which holds multiple block allocator instances and determines which instance to use for allocation or deallocation at runtime instead of at compile time. It is used with compilers that cannot compile rebind.  
  
 A synchronization policy determines how an allocator instance handles simultaneous allocation and deallocation requests from multiple threads. The simplest policy is to pass all requests directly through to the underlying cache object, leaving synchronization management to the user. A more complex policy could be to use a mutex to serialize access to the underlying cache object.  
  
 If a compiler supports compiling both single-threaded and multi-threaded applications, the default synchronization filter for single-threaded applications is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>; for all other cases it is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 The cache template <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> takes a max class argument which determines the maximum number of elements to be stored in the free list.  
  
 \<allocators> provides the following max classes:  
  
-   [max_none](../vs140/max_none-class.md)  
  
-   [max_unbounded](../vs140/max_unbounded-class.md)  
  
-   [max_fixed_size](../vs140/max_fixed_size-class.md)  
  
-   [max_variable_size](../vs140/max_variable_size-class.md)  
  
### Macros  
  
|||  
|-|-|  
|[ALLOCATOR_DECL](../vs140/-allocators--functions.md#allocator_decl)|Yields an allocator template class.|  
|[CACHE_CHUNKLIST](../vs140/-allocators--functions.md#cache_chunklist)|Yields <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
|[CACHE_FREELIST](../vs140/-allocators--functions.md#cache_freelist)|Yields <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
|[CACHE_SUBALLOC](../vs140/-allocators--functions.md#cache_suballoc)|Yields <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.|  
|[SYNC_DEFAULT](../vs140/-allocators--functions.md#sync_default)|Yields a synchronization filter.|  
  
### Operators  
  
|||  
|-|-|  
|[operator!= (\<allocators>)](../vs140/-allocators--operators.md#operator_neq)|Tests for inequality between allocator objects of a specified class.|  
|[operator== (\<allocators>)](../vs140/-allocators--operators.md#operator_eq_eq)|Tests for equality between allocator objects of a specified class.|  
  
### Classes  
  
|||  
|-|-|  
|[allocator_base](../vs140/allocator_base-class.md)|Defines the base class and common functions needed to create a user-defined allocator from a synchronization filter.|  
|[allocator_chunklist](../vs140/allocator_chunklist-class.md)|Describes an object that manages storage allocation and freeing for objects using a cache of type [cache_chunklist](../vs140/cache_chunklist-class.md).|  
|[allocator_fixed_size](../vs140/allocator_fixed_size-class.md)|Describes an object that manages storage allocation and freeing for objects of type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> using a cache of type [cache_freelist](../vs140/cache_freelist-class.md) with a length managed by [max_fixed_size](../vs140/max_fixed_size-class.md).|  
|[allocator_newdel](../vs140/allocator_newdel-class.md)|Implements an allocator that uses <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to deallocate a memory block and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to allocate a memory block.|  
|[allocator_suballoc](../vs140/allocator_suballoc-class.md)|Describes an object that manages storage allocation and freeing for objects of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> using a cache of type [cache_suballoc](../vs140/cache_suballoc-class.md).|  
|[allocator_unbounded](../vs140/allocator_unbounded-class.md)|Describes an object that manages storage allocation and freeing for objects of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> using a cache of type [cache_freelist](../vs140/cache_freelist-class.md) with a length managed by [max_unbounded](../vs140/max_unbounded-class.md).|  
|[allocator_variable_size](../vs140/allocator_variable_size-class.md)|Describes an object that manages storage allocation and freeing for objects of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> using a cache of type [cache_freelist](../vs140/cache_freelist-class.md) with a length managed by [max_variable_size](../vs140/max_variable_size-class.md).|  
|[cache_chunklist](../vs140/cache_chunklist-class.md)|Defines a block allocator that allocates and deallocates memory blocks of a single size.|  
|[cache_freelist](../vs140/cache_freelist-class.md)|Defines a block allocator that allocates and deallocates memory blocks of a single size.|  
|[cache_suballoc](../vs140/cache_suballoc-class.md)|Defines a block allocator that allocates and deallocates memory blocks of a single size.|  
|[freelist](../vs140/freelist-class.md)|Manages a list of memory blocks.|  
|[max_fixed_size](../vs140/max_fixed_size-class.md)|Describes a max class object that limits a [freelist](../vs140/freelist-class.md) object to a fixed maximum length.|  
|[max_none](../vs140/max_none-class.md)|Describes a max class object that limits a [freelist](../vs140/freelist-class.md) object to a maximum length of zero.|  
|[max_unbounded](../vs140/max_unbounded-class.md)|Describes a max class object that does not limit the maximum length of a [freelist](../vs140/freelist-class.md) object.|  
|[max_variable_size](../vs140/max_variable_size-class.md)|Describes a max class object that limits a [freelist](../vs140/freelist-class.md) object to a maximum length that is roughly proportional to the number of allocated memory blocks.|  
|[rts_alloc](../vs140/rts_alloc-class.md)|The rts_alloc template class describes a [filter](../vs140/-allocators-.md) that holds an array of cache instances and determines which instance to use for allocation and deallocation at runtime instead of at compile time.|  
|[sync_none](../vs140/sync_none-class.md)|Describes a synchronization filter that provides no synchronization.|  
|[sync_per_container](../vs140/sync_per_container-class.md)|Describes a synchronization filter that provides a separate cache object for each allocator object.|  
|[sync_per_thread](../vs140/sync_per_thread-class.md)|Describes a synchronization filter that provides a separate cache object for each thread.|  
|[sync_shared](../vs140/sync_shared-class.md)|Describes a synchronization filter that uses a mutex to control access to a cache object that is shared by all allocators.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)