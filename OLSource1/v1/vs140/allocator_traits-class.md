---
title: "allocator_traits Class"
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
  - "memory/std::allocator_traits"
  - "memory/std::allocator_traits::propagate_on_container_move_assignment"
  - "memory/std::allocator_traits::const_pointer"
  - "memory/std::allocator_traits::propagate_on_container_swap"
  - "memory/std::allocator_traits::propagate_on_container_copy_assignment"
  - "memory/std::allocator_traits::difference_type"
  - "memory/std::allocator_traits::allocator_type"
  - "memory/std::allocator_traits::value_type"
  - "memory/std::allocator_traits::pointer"
  - "memory/std::allocator_traits::size_type"
  - "memory/std::allocator_traits::const_void_pointer"
  - "memory/std::allocator_traits::void_pointer"
dev_langs: 
  - "C++"
ms.assetid: 612974b8-b5d4-4668-82fb-824bff6821d6
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_traits Class
The template class describes an object that supplements an *allocator type*. An allocator type is any type that describes an allocator object that is used for managing allocated storage. Specifically, for any allocator type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, you can use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to determine all the information that is needed by an allocator-enabled container. For more information, see the default [allocator Class](../vs140/allocator-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|This type is a synonym for the template parameter <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|This type is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, if that type is well-formed; otherwise, this type is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|This type is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, if that type is well-formed; otherwise, this type is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|This type is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, if that type is well-formed; otherwise, this type is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|This type is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, if that type is well-formed; otherwise, this type is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|This type is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, if that type is well-formed; otherwise, this type is <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|This type is <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, if that type is well-formed; otherwise, this type is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. If the type holds true, an allocator-enabled container copies its stored allocator on a move assignment.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|This type is <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, if that type is well-formed; otherwise, this type is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. If the type holds true, an allocator-enabled container swaps its stored allocator on a swap.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|This type is <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, if that type is well-formed; otherwise, this type is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|This type is a synonym for <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|This type is <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, if that type is well-formed; otherwise, this type is <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.|  
  
### Static Methods  
 The following static methods call the corresponding method on a given allocator parameter.  
  
|Name|Description|  
|----------|-----------------|  
|[allocator_traits::allocate](#allocator_traits__allocate_method)|Static method that allocates memory by using the given allocator parameter.|  
|[allocator_traits::construct](#allocator_traits__construct_method)|Static method that uses a specified allocator to construct an object.|  
|[allocator_traits::deallocate](#allocator_traits__deallocate_method)|Static method that uses a specified allocator to deallocate a specified number of objects.|  
|[allocator_traits::destroy](#allocator_traits__destroy_method)|Static method that uses a specified allocator to call the destructor on an object without deallocating its memory.|  
|[allocator_traits::max_size](#allocator_traits__max_size_method)|Static method that uses a specified allocator to determine the maximum number of objects that can be allocated.|  
|[allocator_traits::select_on_container_copy_construction](#allocator_traits__select_on_container_copy_construction_method)|Static method that calls <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> on the specified allocator.|  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
##  \<a name="allocator_traits__allocate_method">\</a>  allocator_traits::allocate Method  
 Static method that allocates memory by using the given allocator parameter.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 An allocator object.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The number of elements to allocate.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> that might assist the allocator object in satisfying the request for storage by locating the address of an allocated object prior to the request. A null pointer is treated as no hint.  
  
### Return Value  
 Each method returns a pointer to the allocated object.  
  
 The first static method returns <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 The second method returns <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, if that expression is well formed; otherwise it returns <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
##  \<a name="allocator_traits__construct_method">\</a>  allocator_traits::construct Method  
 Static method that uses a specified allocator to construct an object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 An allocator object.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 A pointer to the location where the object is to be constructed.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A list of arguments that is passed to the object constructor.  
  
### Remarks  
 The static member function calls <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, if that expression is well formed; otherwise it evaluates <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
##  \<a name="allocator_traits__deallocate_method">\</a>  allocator_traits::deallocate Method  
 Static method that uses a specified allocator to deallocate a specified number of objects.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 An allocator object.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A pointer to the starting location of the objects to be deallocated.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The number of objects to deallocate.  
  
### Remarks  
 This method calls <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
 This method throws nothing.  
  
##  \<a name="allocator_traits__destroy_method">\</a>  allocator_traits::destroy Method  
 Static method that uses a specified allocator to call the destructor on an object without deallocating its memory.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 An allocator object.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A pointer to the location of the object.  
  
### Remarks  
 This method calls <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, if that expression is well formed; otherwise it evaluates <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
##  \<a name="allocator_traits__max_size_method">\</a>  allocator_traits::max_size Method  
 Static method that uses a specified allocator to determine the maximum number of objects that can be allocated.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 An allocator object.  
  
### Remarks  
 This method returns <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, if that expression is well formed; otherwise it returns <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
##  \<a name="allocator_traits__select_on_container_copy_construction_method">\</a>  allocator_traits::select_on_container_copy_construction Method  
 Static method that calls <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> on the specified allocator.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 An allocator object.  
  
### Return Value  
 This method returns <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, if that type is well formed; otherwise it returns <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method is used to specify an allocator when the associated container is copy-constructed.  
  
## See Also  
 [\<memory>](../vs140/-memory-.md)   
 [pointer_traits Struct](../vs140/pointer_traits-struct.md)   
 [scoped_allocator_adaptor Class](../vs140/scoped_allocator_adaptor-class.md)