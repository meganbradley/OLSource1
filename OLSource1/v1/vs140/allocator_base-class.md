---
title: "allocator_base Class"
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
  - "allocators.allocator_base"
  - "stdext.allocators.allocator_base"
  - "allocator_base"
  - "allocators/stdext::allocator_base"
  - "stdext::allocator_base"
  - "stdext::allocators::allocator_base"
  - "allocators/stdext::allocators::allocator_base"
  - "allocators::allocator_base"
  - "stdext.allocator_base"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocator_base class"
ms.assetid: f920b45f-2a88-4bb0-8ead-b6126b426ed4
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_base Class
Defines the base class and common functions needed to create a user-defined allocator from a synchronization filter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|The type of elements allocated by the allocator.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|The synchronization policy for the allocator, which is [sync_none](../vs140/sync_none-class.md), [sync_per_container](../vs140/sync_per_container-class.md), [sync_per_thread](../vs140/sync_per_thread-class.md), or [sync_shared](../vs140/sync_shared-class.md).|  
  
### Constructors  
  
|||  
|-|-|  
|[allocator_base](#allocator_base__allocator_base)|Constructs an object of type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
  
### TypeDefs  
  
|||  
|-|-|  
|[const_pointer](#allocator_base__const_pointer)|A type that provides a constant pointer to the type of object managed by the allocator.|  
|[const_reference](#allocator_base__const_reference)|A type that provides a constant reference to type of object managed by the allocator.|  
|[difference_type](#allocator_base__difference_type)|A signed integral type that can represent the difference between values of pointers to the type of object managed by the allocator.|  
|[pointer](#allocator_base__pointer)|A type that provides a pointer to the type of object managed by the allocator.|  
|[reference](#allocator_base__reference)|A type that provides a reference to the type of object managed by the allocator.|  
|[size_type](#allocator_base__size_type)|An unsigned integral type that can represent the length of any sequence that an object of template class <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> can allocate.|  
|[value_type](#allocator_base__value_type)|A type that is managed by the allocator.|  
  
### Member Functions  
  
|||  
|-|-|  
|[_Charalloc](#allocator_base___charalloc)|Allocates storage for an array of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
|[_Chardealloc](#allocator_base___chardealloc)|Frees storage for the array containing elements of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.|  
|[address](#allocator_base__address)|Finds the address of an object whose value is specified.|  
|[allocate](#allocator_base__allocate)|Allocates a block of memory large enough to store at least some specified number of elements.|  
|[construct](#allocator_base__construct)|Constructs a specific type of object at a specified address that is initialized with a specified value.|  
|[deallocate](#allocator_base__deallocate)|Frees a specified number of objects from storage beginning at a specified position.|  
|[destroy](#allocator_base__destroy)|Calls an objects destructor without deallocating the memory where the object was stored.|  
|[max_size](#allocator_base__max_size)|Returns the number of elements of type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> that could be allocated by an object of class allocator before the free memory is used up.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
##  \<a name="allocator_base___charalloc">\</a>  allocator_base::_Charalloc  
 Allocates storage for an array of type <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
  
### Return Value  
 A pointer to the allocated object.  
  
### Remarks  
 This member function is used by containers when compiled with a compiler that cannot compile rebind. It implements <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> for the user-defined allocator by returning the result of a call to the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> function of the synchronization filter.  
  
##  \<a name="allocator_base___chardealloc">\</a>  allocator_base::_Chardealloc  
 Frees storage for the array containing elements of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|A pointer to the first object to be deallocated from storage.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|The number of objects to be deallocated from storage.|  
  
### Remarks  
 This member function is used by containers when compiled with a compiler that cannot compile rebind. It implements <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> for the user-defined allocator by calling the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> function of the synchronization filter. The pointer _Ptr must have been earlier returned by a call to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> for an allocator object that compares equal to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, allocating an array object of the same size and type. <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> never throws an exception.  
  
##  \<a name="allocator_base__address">\</a>  allocator_base::address  
 Finds the address of an object whose value is specified.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The const or nonconst value of the object whose address is being searched for.  
  
### Return Value  
 A const or nonconst pointer to the object found of, respectively, const or nonconst value.  
  
### Remarks  
 This member function is implemented for the user-defined allocator by returning <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
##  \<a name="allocator_base__allocate">\</a>  allocator_base::allocate  
 Allocates a block of memory large enough to store at least some specified number of elements.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|This parameter is ignored.|  
  
### Return Value  
 A pointer to the allocated object.  
  
### Remarks  
 The member function implements memory allocation for the user-defined allocator by returning the result of a call to the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> function of the synchronization filter of type Type <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, otherwise by returning the result of a call to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> cast to type Type <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
##  \<a name="allocator_base__allocator_base">\</a>  allocator_base::allocator_base  
 Constructs an object of type <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|The allocator object to be copied.|  
  
### Remarks  
 The first constructor constructs an [allocator_base](../vs140/allocator_base-class.md) instance. The second constructor constructs an <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> instance such that for any <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> instance <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
##  \<a name="allocator_base__const_pointer">\</a>  allocator_base::const_pointer  
 A type that provides a constant pointer to the type of object managed by the allocator.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="allocator_base__const_reference">\</a>  allocator_base::const_reference  
 A type that provides a constant reference to type of object managed by the allocator.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="allocator_base__construct">\</a>  allocator_base::construct  
 Constructs a specific type of object at a specified address that is initialized with a specified value.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|A pointer to the location where the object is to be constructed.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|The value with which the object being constructed is to be initialized.|  
  
### Remarks  
 This member function is implemented for the user-defined allocator by calling <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
##  \<a name="allocator_base__deallocate">\</a>  allocator_base::deallocate  
 Frees a specified number of objects from storage beginning at a specified position.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|A pointer to the first object to be deallocated from storage.|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|The number of objects to be deallocated from storage.|  
  
### Remarks  
 This member function is implemented for the user-defined allocator by calling <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> on the synchronization filter <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, otherwise by calling <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
##  \<a name="allocator_base__destroy">\</a>  allocator_base::destroy  
 Calls an objects destructor without deallocating the memory where the object was stored.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|A pointer designating the address of the object to be destroyed.|  
  
### Remarks  
 This member function is implemented for the user-defined allocator by calling <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
##  \<a name="allocator_base__difference_type">\</a>  allocator_base::difference_type  
 A signed integral type that can represent the difference between values of pointers to the type of object managed by the allocator.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="allocator_base__max_size">\</a>  allocator_base::max_size  
 Returns the number of elements of type <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> that could be allocated by an object of class allocator before the free memory is used up.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements that could be allocated.  
  
### Remarks  
 This member function is implemented for the user-defined allocator by returning <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, otherwise <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
##  \<a name="allocator_base__pointer">\</a>  allocator_base::pointer  
 A type that provides a pointer to the type of object managed by the allocator.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="allocator_base__reference">\</a>  allocator_base::reference  
 A type that provides a reference to the type of object managed by the allocator.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
##  \<a name="allocator_base__size_type">\</a>  allocator_base::size_type  
 An unsigned integral type that can represent the length of any sequence that an object of template class <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> can allocate.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="allocator_base__value_type">\</a>  allocator_base::value_type  
 A type that is managed by the allocator.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)