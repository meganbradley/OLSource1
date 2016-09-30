---
title: "allocator Class"
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
  - "std::allocator"
  - "allocator"
  - "memory/std::allocator"
  - "std.allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocator class"
ms.assetid: 3fd58076-56cc-43bb-ad58-b4b7c9c6b410
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# allocator Class
The template class describes an object that manages storage allocation and freeing for arrays of objects of type **Type**. An object of class **allocator** is the default allocator object specified in the constructors for several container template classes in the Standard C++ Library.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *Type*  
 The type of object for which storage is being allocated or deallocated.  
  
## Remarks  
 All the Standard Template Library containers have a template parameter that defaults to **allocator**. Constructing a container with a custom allocator provide control over allocation and freeing of that container's elements.  
  
 For example, an allocator object might allocate storage on a private heap or in shared memory, or it might optimize for small or large object sizes. It might also specify, through the type definitions it supplies, that elements be accessed through special accessor objects that manage shared memory, or perform automatic garbage collection. Hence, a class that allocates storage using an allocator object should use these types for declaring pointer and reference objects, as the containers in the Standard C++ Library do.  
  
 **(C_++98/03 only)**When you derive from allocator class, you have to provide a [rebind](#allocator__rebind) struct, whose <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> typedef references your newly-derived class.  
  
 Thus, an allocator defines the following types:  
  
-   [pointer](#allocator__pointer) behaves like a pointer to **Type**.  
  
-   [const_pointer](#allocator__const_pointer) behaves like a const pointer to **Type**.  
  
-   [reference](#allocator__reference) behaves like a reference to **Type**.  
  
-   [const_reference](#allocator__const_reference) behaves like a const reference to **Type**.  
  
 These **Type**s specify the form that pointers and references must take for allocated elements. ( [allocator::pointer](#allocator__pointer) is not necessarily the same as **Type**\* for all allocator objects, even though it has this obvious definition for class **allocator**.)  
  
 **C++11 and later:**  To enable move operations in your allocator, use the minimal allocator interface and implement copy constructor, == and != operators, allocate and deallocate. For more information and an example, see [Allocators](../vs140/allocators.md)  
  
## Members  
  
### Constructors  
  
|||  
|-|-|  
|[allocator](#allocator__allocator)|Constructors used to create <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> objects.|  
  
### Typedefs  
  
|||  
|-|-|  
|[const_pointer](#allocator__const_pointer)|A type that provides a constant pointer to the type of object managed by the allocator.|  
|[const_reference](#allocator__const_reference)|A type that provides a constant reference to type of object managed by the allocator.|  
|[difference_type](#allocator__difference_type)|A signed integral type that can represent the difference between values of pointers to the type of object managed by the allocator.|  
|[pointer](#allocator__pointer)|A type that provides a pointer to the type of object managed by the allocator.|  
|[reference](#allocator__reference)|A type that provides a reference to the type of object managed by the allocator.|  
|[size_type](#allocator__size_type)|An unsigned integral type that can represent the length of any sequence that an object of template class <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> can allocate.|  
|[value_type](#allocator__value_type)|A type that is managed by the allocator.|  
  
### Member Functions  
  
|||  
|-|-|  
|[address](#allocator__address)|Finds the address of an object whose value is specified.|  
|[allocate](#allocator__allocate)|Allocates a block of memory large enough to store at least some specified number of elements.|  
|[construct](#allocator__construct)|Constructs a specific type of object at a specified address that is initialized with a specified value.|  
|[deallocate](#allocator__deallocate)|Frees a specified number of objects from storage beginning at a specified position.|  
|[destroy](#allocator__destroy)|Calls an objects destructor without deallocating the memory where the object was stored.|  
|[max_size](#allocator__max_size)|Returns the number of elements of type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> that could be allocated by an object of class <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> before the free memory is used up.|  
|[rebind](#allocator__rebind)|A structure that enables an allocator for objects of one type to allocate storage for objects of another type.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#allocator__operator_eq)|Assigns one <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object to another <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.|  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
##  \<a name="allocator__address">\</a>  allocator::address  
 Finds the address of an object whose value is specified.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The const or nonconst value of the object whose address is being searched for.  
  
### Return Value  
 A const or nonconst pointer to the object found of, respectively, const or nonconst value.  
  
### Remarks  
 The member functions return the address of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, in the form that pointers must take for allocated elements.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **The original vector v1 is:**  
 **( 2 4 6 8 10 12 14 ).**  
**The integer addressed by v1Ptr has a value of: \*v1Ptr = 8.**    
##  \<a name="allocator__allocate">\</a>  allocator::allocate  
 Allocates a block of memory large enough to store at least some specified number of elements.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The number of elements for which sufficient storage is to be allocated.  
  
 *_Hint*  
 A const pointer that may assist the allocator object satisfy the request for storage by locating the address of an object allocated prior to the request.  
  
### Return Value  
 A pointer to the allocated object or null if memory was not allocated.  
  
### Remarks  
 The member function allocates storage for an array of count elements of type **Type**, by calling operator new( <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>). It returns a pointer to the allocated object. The hint argument helps some allocators in improving locality of reference; a valid choice is the address of an object earlier allocated by the same allocator object and not yet deallocated. To supply no hint, use a null pointer argument instead.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **0 1 2 3 4 5 6 7 8 9**     
##  \<a name="allocator__allocator">\</a>  allocator::allocator  
 Constructors used to create allocator objects.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The allocator object to be copied.  
  
### Remarks  
 The constructor does nothing. In general, however, an allocator object constructed from another allocator object should compare equal to it and permit intermixing of object allocation and freeing between the two allocator objects.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **The allocator objects cv1Alloc & v1Alloc are equal.**  
**The allocator objects cAlloc & Alloc are equal.**    
##  \<a name="allocator__const_pointer">\</a>  allocator::const_pointer  
 A type that provides a constant pointer to the type of object managed by the allocator.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The pointer type describes an object **ptr** that can designate, through the expression **\*ptr**, any const object that an object of template class allocator can allocate.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **The original vector v1 is:**  
 **( 2 4 6 8 10 12 14 ).**  
**The integer's address found has a value of: 10.**    
##  \<a name="allocator__const_reference">\</a>  allocator::const_reference  
 A type that provides a constant reference to type of object managed by the allocator.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The reference type describes an object that can designate any const object that an object of template class allocator can allocate.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **The original vector v is:**  
 **( 100 200 300 400 500 600 700 ).**  
**The value of the element referred to by vref is: 100,**  
 **the first element in the vector.**  
**The value of the element referred to by vcref,**  
 **after nofication through its nonconst iterator, is: 175.**    
##  \<a name="allocator__construct">\</a>  allocator::construct  
 Constructs a specific type of object at a specified address that is initialized with a specified value.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A pointer to the location where the object is to be constructed.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The value with which the object being constructed is to be initialized.  
  
### Remarks  
 The first member function is equivalent to **new** ( ( <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> \*) <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> ) **Type** ( <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> ).  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **The original vector v1 is:**  
 **( 3 6 9 12 15 18 21 ).**  
**The modified vector v1 is:**  
 **( 3 7 9 12 15 18 21 ).**    
##  \<a name="allocator__deallocate">\</a>  allocator::deallocate  
 Frees a specified number of objects from storage beginning at a specified position.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A pointer to the first object to be deallocated from storage.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The number of objects to be deallocated from storage.  
  
### Remarks  
 The member function frees storage for the array of count objects of type **Type** beginning at <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, by calling <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>). The pointer <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> must have been returned earlier by a call to [allocate](#allocator__allocate) for an allocator object that compares equal to **\*this**, allocating an array object of the same size and type. <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> never throws an exception.  
  
### Example  
  For an example using the member function, see [allocator::allocate](#allocator__allocate).  
  
##  \<a name="allocator__destroy">\</a>  allocator::destroy  
 Calls an objects destructor without deallocating the memory where the object was stored.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A pointer designating the address of the object to be destroyed.  
  
### Remarks  
 The member function destroys the object designated by <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, by calling the destructor <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> -> **Type**:: **~Type**.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **The original vector v1 is:**  
 **( 2 4 6 8 10 12 14 ).**  
**The modified vector v1 is:**  
 **( 2 4 6 8 10 -99 14 ).**    
##  \<a name="allocator__difference_type">\</a>  allocator::difference_type  
 A signed integral type that can represent the difference between values of pointers to the type of object managed by the allocator.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 The signed integer type describes an object that can represent the difference between the addresses of any two elements in a sequence that an object of template class allocator can allocate.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  **The original vector v1 is:**  
 **( 0 2 4 6 8 10 12 14 ).**  
**Pointer v1PtrA addresses 4.**  
**Pointer v1PtrB addresses 12.**  
**The difference between the integer's addresses is: 8.**    
##  \<a name="allocator__max_size">\</a>  allocator::max_size  
 Returns the number of elements of type **Type** that could be allocated by an object of class allocator before the free memory is used up.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements that could be allocated.  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="allocator__operator_eq">\</a>  allocator::operator=  
 Assigns one allocator object to another allocator object.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 An allocator object to be assigned to another such object.  
  
### Return Value  
 A reference to the allocator object  
  
### Remarks  
 The template assignment operator does nothing. In general, however, an allocator object assigned to another allocator object should compare equal to it and permit intermixing of object allocation and freeing between the two allocator objects.  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="allocator__pointer">\</a>  allocator::pointer  
 A type that provides a pointer to the type of object managed by the allocator.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Remarks  
 The pointer type describes an object **ptr** that can designate, through the expression **\*ptr**, any object that an object of template class allocator can allocate.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  **The original vector v1 is:**  
 **( 3 6 9 12 15 18 21 ).**  
**The integer addressed by v1Ptr has a value of: \*v1Ptr = 12.**    
##  \<a name="allocator__rebind">\</a>  allocator::rebind  
 A structure that enables an allocator for objects of one type to allocate storage for objects of another type.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 *other*  
 The type of element for which memory is being allocated.  
  
### Remarks  
 This structure is useful for allocating memory for type that differs from the element type of the container being implemented.  
  
 The member template class defines the type other. Its sole purpose is to provide the type name **allocator**\<_ **Other**>, given the type name **allocator**\< **Type**>.  
  
 For example, given an allocator object **al** of type **A**, you can allocate an object of type **_Other** with the expression:  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Or, you can name its pointer type by writing the type:  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
##  \<a name="allocator__reference">\</a>  allocator::reference  
 A type that provides a reference to the type of object managed by the allocator.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Remarks  
 The reference type describes an object that can designate any object that an object of template class allocator can allocate.  
  
### Example  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  **The original vector v is:**  
 **( 100 200 300 400 500 600 700 ).**  
**The value of the element referred to by vref is: 100,**  
 **the first element in the vector.**  
**The element referred to by vref after being modified is: 150.**    
##  \<a name="allocator__size_type">\</a>  allocator::size_type  
 An unsigned integral type that can represent the length of any sequence that an object of template class allocator can allocate.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
##  \<a name="allocator__value_type">\</a>  allocator::value_type  
 A type that is managed by the allocator.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **Type**.  
  
### Example  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  **The original vector v is:**  
 **( 100 200 300 400 500 600 700 ).**  
**The value of the element addressed by vfIter is: 150,**  
 **the first element in the vector.**  
**The modified vector v is:**  
 **( 150 200 300 400 500 600 700 ).**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)