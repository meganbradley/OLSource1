---
title: "auto_ptr Class"
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
  - "std::auto_ptr"
  - "std.auto_ptr"
  - "auto_ptr"
  - "memory/std::auto_ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_ptr class"
ms.assetid: 7f9108b6-9eb3-4634-b615-cf7aa814f23b
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_ptr Class
Wraps a smart pointer around a resource that ensures the resource is destroyed automatically when control leaves a block.  
  
 The more capable             <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class supersedes             <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. For more information, see             [unique_ptr Class](../vs140/unique_ptr-class.md).  
  
 For more information about             <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and exception handling, see             [Exception Specifications](../vs140/exception-specifications--throw---c---.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> from which to get an existing resource.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The pointer specified to replace the stored pointer.  
  
## Remarks  
 The template class describes a smart pointer, called an                 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to an allocated object. The pointer must be either null or designate an object allocated by                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. The                 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> transfers ownership if its stored value is assigned to another object. (It replaces the stored value after a transfer with a null pointer.) The destructor for                 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> deletes the allocated object. The                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> ensures that an allocated object is automatically deleted when control leaves a block, even through a thrown exception. You should not construct two                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> objects that own the same object.  
  
 You can pass an                 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object by value as an argument to a function call. An                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> cannot be an element of any Standard Library container. You cannot reliably manage a sequence of                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> objects with a Standard Template Library container.  
  
## Members  
  
### Constructors  
  
|||  
|-|-|  
|[auto_ptr](#auto_ptr__auto_ptr)|The constructor for objects of type                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[element_type](#auto_ptr__element_type)|The type is a synonym for the template parameter                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[get](#auto_ptr__get)|The member function returns the stored pointer                                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.|  
|[release](#auto_ptr__release)|The member replaces the stored pointer                                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> with a null pointer and returns the previously stored pointer.|  
|[reset](#auto_ptr__reset)|The member function evaluates the expression                                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, but only if the stored pointer value                                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> changes as a result of function call. It then replaces the stored pointer with                                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#auto_ptr__operator_eq)|An assignment operator that transfers ownership from one                                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object to another.|  
|[operator*](#auto_ptr__operator_star)|The dereferencing operator for objects of type                                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.|  
|[operator->](#auto_ptr__operator-_gt_)|The operator for allowing member access.|  
|[operator auto_ptr\<Other>](#auto_ptr__operator_auto_ptr_lt_other_gt_)|Casts from one kind of                                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to another kind of                                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.|  
|[operator auto_ptr_ref\<Other>](#auto_ptr__operator_auto_ptr_ref_lt_other_gt_)|Casts from an                                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to an                                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
##  \<a name="auto_ptr__auto_ptr">\</a>  auto_ptr::auto_ptr  
 The constructor for objects of type                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The pointer to the object that                                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> encapsulates.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object to be copied by the constructor.  
  
### Remarks  
 The first constructor stores                         <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> in                         **myptr**, the stored pointer to the allocated object. The second constructor transfers ownership of the pointer stored in                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, by storing                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.                        [release](#auto_ptr__release) in                         **myptr**.  
  
 The third constructor behaves the same as the second, except that it stores                         **right**.                        <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.                        **release** in                         **myptr**, where                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is the reference stored in                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
 The template constructor behaves the same as the second constructor, provided that a pointer to                         **Other** can be implicitly converted to a pointer to                         **Type**.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **Constructing 00311AF8**  
**5**  
**7**  
**Destructing 00311AF8**    
##  \<a name="auto_ptr__element_type">\</a>  auto_ptr::element_type  
 The type is a synonym for the template parameter                 **Type**.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="auto_ptr__get">\</a>  auto_ptr::get  
 The member function returns the stored pointer                 **myptr**.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The stored pointer                         **myptr**.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **Constructing 00311AF8 Value: 5**  
**Constructing 00311B88 Value: 6**  
**Destructing 00311AF8 Value: 5**  
**pi2 == pi3**  
**Destructing 00311B88 Value: 6**    
##  \<a name="auto_ptr__operator_eq">\</a>  auto_ptr::operator=  
 An assignment operator that transfers ownership from one                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object to another.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to an object of type                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>\<                        **Type**>.  
  
### Remarks  
 The assignment evaluates the expression                         **delete myptr**, but only if the stored pointer                         **myptr** changes as a result of the assignment. It then transfers ownership of the pointer stored in _                        *Right*, by storing \_                        *Right*.                        [release](#auto_ptr__release) in                         **myptr**. The function returns                         **\*this**.  
  
### Example  
  For an example of the use of the member operator, see                                 [auto_ptr::auto_ptr](#auto_ptr__auto_ptr).  
  
##  \<a name="auto_ptr__operator_star">\</a>  auto_ptr::operator*  
 The dereferencing operator for objects of type                 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A reference to an object of type                         **Type** that the pointer owns.  
  
### Remarks  
 The indirection operator returns                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>[get](#auto_ptr__get). Hence, the stored pointer must not be null.  
  
### Example  
  For an example of how to use the member function, see                                 [auto_ptr::auto_ptr](#auto_ptr__auto_ptr).  
  
##  \<a name="auto_ptr__operator-_gt_">\</a>  auto_ptr::operator-&gt;  
 The operator for allowing member access.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A member of the object that                         **auto_ptr** owns.  
  
### Remarks  
 The selection operator returns                         [get](#auto_ptr__get)<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, so that the expression                         *ap*->                        **member** behaves the same as (                         *ap*.                        **get**( ) )->                        **member**, where                         *ap* is an object of class                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>\<                        **Type**>. Hence, the stored pointer must not be null, and                         **Type** must be a class, struct, or union type with a                         **member** member.  
  
### Example  
  For an example of how to use the member function, see                                 [auto_ptr::auto_ptr](#auto_ptr__auto_ptr).  
  
##  \<a name="auto_ptr__operator_auto_ptr_lt_other_gt_">\</a>  auto_ptr::operator auto_ptr&lt;Other&gt;  
 Casts from one kind of                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> to another kind of                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The type cast operator returns                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> \<                        **Other**>(                        **\*this**).  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="auto_ptr__operator_auto_ptr_ref_lt_other_gt_">\</a>  auto_ptr::operator auto_ptr_ref&lt;Other&gt;  
 Casts from an                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> to an                 **auto_ptr_ref**.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The type cast operator returns                         **auto_ptr_ref**\<                        **Other**>(                        **\*this**).  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **~C:  2**  
**main exiting**  
**~C:  1**    
##  \<a name="auto_ptr__release">\</a>  auto_ptr::release  
 The member replaces the stored pointer                 **myptr** with a null pointer and returns the previously stored pointer.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The previously stored pointer.  
  
### Remarks  
 The member replaces the stored pointer                         **myptr** with a null pointer and returns the previously stored pointer.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **Constructing 00311AF8 Value: 5**  
**Constructing 00311B88 Value: 6**  
**Destructing 00311AF8 Value: 5**  
**pi2 == pi3**  
**Destructing 00311B88 Value: 6**    
##  \<a name="auto_ptr__reset">\</a>  auto_ptr::reset  
 The member function evaluates the expression                 **delete**Â                 **myptr**, but only if the stored pointer value                 **myptr** changes as a result of a function call. It then replaces the stored pointer with                 **ptr**.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The pointer specified to replace the stored pointer                                 **myptr**.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **Constructing 00311AF8 Value: 5**  
**Constructing 00311B88 Value: 6**  
**Destructing 00311AF8 Value: 5**  
**pi2 == pi3**  
**Destructing 00311B88 Value: 6**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [unique_ptr](../vs140/unique_ptr-class.md)