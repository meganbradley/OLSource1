---
title: "function Class"
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
  - "functional/std::tr1::function"
  - "std.tr1.function"
  - "std::tr1::function"
  - "function"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "function class [TR1]"
ms.assetid: 7b5ca76b-9ca3-4d89-8fcf-cad70a4aeae6
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# function Class
Wrapper for a callable object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The function type to wrap.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The allocator function.  
  
## Remarks  
 The template class is a call wrapper whose call signature is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. You use it to enclose a variety of callable objects in a uniform wrapper.  
  
 Some member functions take an operand that names the desired target object. You can specify such an operand in several ways:  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> -- the callable object <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>; after the call the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object holds a copy of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> -- the callable object named by <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>; after the call the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object holds a reference to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> -- the callable object, if any, held by the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> -- a null pointer; after the call the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object is empty  
  
 In all cases, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is the callable object and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> are lvalues of types <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> respectively, must be well-formed and, if <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is not void, convertible to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 An empty <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object does not hold a callable object or a reference to a callable object.  
  
### Constructors  
  
|||  
|-|-|  
|[function::function](#function__function)|Constructs a wrapper that either is empty or stores a callable object of arbitrary type with a fixed signature.|  
  
### Typedefs  
  
|||  
|-|-|  
|[function::result_type](#function__result_type)|The return type of the stored callable object.|  
  
### Member Functions  
  
|||  
|-|-|  
|[function::assign](#function__assign)|Assigns a callable object to this function object.|  
|[function::swap](#function__swap)|Swap two callable objects.|  
|[function::target](#function__target)|Tests if stored callable object is callable as specified.|  
|[function::target_type](#function__target_type)|Gets type information on the callable object.|  
  
### Operators  
  
|||  
|-|-|  
|[function::operator unspecified](#function__operator_unspecified)|Tests if stored callable object exists.|  
|[function::operator()](#function__operator__)|Calls a callable object.|  
|[function::operator=](#function__operator_eq)|Replaces the stored callable object.|  
  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
##  \<a name="function__assign">\</a>  function::assign  
 Assigns a callable object to this function object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A callable object.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A reference wrapper that contains a callable object.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 An allocator object.  
  
### Remarks  
 The member functions each replace the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> held by <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> with the callable object passed as the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. Both allocate storage with the allocator object <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
##  \<a name="function__function">\</a>  function::function  
 Constructs a wrapper that either is empty or stores a callable object of arbitrary type with a fixed signature.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The function object to copy.  
  
 Fx  
 The type of the callable object.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The callable object to wrap.  
  
 Alloc  
 The allocator type.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The allocator.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The callable object reference to wrap.  
  
### Remarks  
 The first two constructors construct an empty <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object. The next three constructors construct a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object that holds the callable object passed as the operand. The last two constructors allocate storage with the allocator object _Ax.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **100**  
**-10**  
**30**  
**f is non-empty (correct).**  
**g is empty (correct).**    
##  \<a name="function__operator_unspecified">\</a>  function::operator unspecified  
 Tests if stored callable object exists.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 The operator returns a value that is convertible to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> with a true value only if the object is not empty. You use it to test whether the object is empty.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **not empty == false**  
**not empty == true**    
##  \<a name="function__operator__">\</a>  function::operator()  
 Calls a callable object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The type of the Nth call argument.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The Nth call argument.  
  
### Remarks  
 The member function returns <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is the target object stored in <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. You use it to call the wrapped callable object.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **empty == false**  
**val == -3**    
##  \<a name="function__operator_eq">\</a>  function::operator=  
 Replaces the stored callable object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A null pointer constant.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The function object to copy.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The callable object to wrap.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The callable object reference to wrap.  
  
### Remarks  
 The operators each replace the callable object held by <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> with the callable object passed as the operand.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **empty == false**  
**val == -3**  
**empty == true**  
**empty == false**  
**val == -3**  
**empty == false**  
**val == -3**  
**empty == false**  
**val == -3**    
##  \<a name="function__result_type">\</a>  function::result_type  
 The return type of the stored callable object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 The typedef is a synonym for the type <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> in the template's call signature. You use it to determine the return type of the wrapped callable object.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **empty == false**  
**val == -3**    
##  \<a name="function__swap">\</a>  function::swap  
 Swap two callable objects.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The function object to swap with.  
  
### Remarks  
 The member function swaps the target objects between <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>. It does so in constant time and throws no exceptions.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **empty == false**  
**val == -3**  
**empty == true**  
**empty == true**  
**empty == false**  
**val == -3**    
##  \<a name="function__target">\</a>  function::target  
 Tests if stored callable object is callable as specified.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The target callable object type to test.  
  
### Remarks  
 The type <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> must be callable for the argument types <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> and the return type <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, the member template function returns the address of the target object; otherwise, it returns 0.  
  
 A type <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> is callable for the argument types <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> and the return type <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> if, for lvalues <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> of types <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, respectively, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> is well-formed and, if <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, convertible to <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  **empty == false**  
**no target == false**  
**val == -3**  
**empty == true**  
**no target == true**    
##  \<a name="function__target_type">\</a>  function::target_type  
 Gets type information on the callable object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> is empty, otherwise it returns <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> is the type of the target object.  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  **empty == false**  
**type == int (__cdecl\*)(int)**  
**empty == true**  
**type == void**    
## See Also  
 [mem_fn](../vs140/-functional--functions.md#mem_fn_function)   
 [reference_wrapper](../vs140/reference_wrapper-class.md)