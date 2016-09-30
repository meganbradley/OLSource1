---
title: "&lt;new&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: d1af4b56-9a95-4c65-ab01-bf43e982c7bd
caps.latest.revision: 10
---
# &lt;new&gt; operators
||||  
|-|-|-|  
|[operator delete](#operator_delete)|[operator delete&#91;&#93;](#operator_delete_arr)|[operator new](#operator_new)|  
|[operator new&#91;&#93;](#operator_new_arr)|  
  
##  \<a name="operator_delete">\</a>  operator delete  
 The function called by a delete expression to deallocate storage for individual of objects.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The pointer whose value is to be rendered invalid by the deletion.  
  
### Remarks  
 The first function is called by a delete expression to render the value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> invalid. The program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The required behavior is to accept a value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that is null or that was returned by an earlier call to [operator new](../vs140/-new--operators.md#operator_new)( **size_t**).  
  
 The default behavior for a null value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is to do nothing. Any other value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> must be a value returned earlier by a call as previously described. The default behavior for such a nonnull value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is to reclaim storage allocated by the earlier call. It is unspecified under what conditions part or all of such reclaimed storage is allocated by a subsequent call to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>( **size_t**), or to any of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>( **size_t**), <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>( **size_t**), or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>( **void\***, **size_t**).  
  
 The second function is called by a placement delete expression corresponding to a new expression of the form **new**( **std::size_t**). It does nothing.  
  
 The third function is called by a placement delete expression corresponding to a new expression of the form **new**( **std::size_t**, **conststd::nothrow_t&**). The program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The required behavior is to accept a value of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> that is null or that was returned by an earlier call to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>( **size_t**). The default behavior is to evaluate **delete**( <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>).  
  
### Example  
  See [operator new](../vs140/-new--operators.md#operator_new) for an example that use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_delete_arr">\</a>  operator delete[]  
 The function called by a delete expression to deallocate storage for an array of objects.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The pointer whose value is to be rendered invalid by the deletion.  
  
### Remarks  
 The first function is called by an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> expression to render the value of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> invalid. The function is replaceable because the program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The required behavior is to accept a value of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> that is null or that was returned by an earlier call to [operator new&#91;&#93;](../vs140/-new--operators.md#operator_new_arr)( **size_t**). The default behavior for a null value of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is to do nothing. Any other value of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> must be a value returned earlier by a call as previously described. The default behavior for such a nonnull value of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is to reclaim storage allocated by the earlier call. It is unspecified under what conditions part or all of such reclaimed storage is allocated by a subsequent call to [operator new](../vs140/-new--operators.md#operator_new)( **size_t**), or to any of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>( **size_t**), <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>( **size_t**), or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>( **void\***, **size_t**).  
  
 The second function is called by a placement <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> expression corresponding to a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> expression of the form <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>( **std::size_t**). It does nothing.  
  
 The third function is called by a placement delete expression corresponding to a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> expression of the form <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>( **std::size_t**, **const std::nothrow_t&**). The program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The required behavior is to accept a value of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> that is null or that was returned by an earlier call to operator <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>( **size_t**). The default behavior is to evaluate <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>).  
  
### Example  
  See [operator new&#91;&#93;](../vs140/-new--operators.md#operator_new_arr) for examples of the use of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_new">\</a>  operator new  
 The function called by a new-expression to allocate storage for individual objects.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The number of bytes of storage to be allocated.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The pointer to be returned.  
  
### Return Value  
 A pointer to the lowest byte address of the newly-allocated storage. Or <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
### Remarks  
 The first function is called by a new expression to allocate <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> bytes of storage suitably aligned to represent any object of that size. The program can define an alternate function with this function signature that replaces the default version defined by the Standard C++ Library and so is replaceable.  
  
 The required behavior is to return a nonnull pointer only if storage can be allocated as requested. Each such allocation yields a pointer to storage disjoint from any other allocated storage. The order and contiguity of storage allocated by successive calls is unspecified. The initial stored value is unspecified. The returned pointer points to the start (lowest byte address) of the allocated storage. If count is zero, the value returned does not compare equal to any other value returned by the function.  
  
 The default behavior is to execute a loop. Within the loop, the function first attempts to allocate the requested storage. Whether the attempt involves a call to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>( **size_t**) is unspecified. If the attempt is successful, the function returns a pointer to the allocated storage. Otherwise, the function calls the designated [new handler](../vs140/-new--typedefs.md#new_handler). If the called function returns, the loop repeats. The loop terminates when an attempt to allocate the requested storage is successful or when a called function does not return.  
  
 The required behavior of a new handler is to perform one of the following operations:  
  
-   Make more storage available for allocation and then return.  
  
-   Call either **abort** or **exit**( <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>).  
  
-   Throw an object of type **bad_alloc.**  
  
 The default behavior of a [new handler](../vs140/-new--typedefs.md#new_handler) is to throw an object of type <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. A null pointer designates the default new handler.  
  
 The order and contiguity of storage allocated by successive calls to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>( **size_t**) is unspecified, as are the initial values stored there.  
  
 The second function is called by a placement new expression to allocate <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> bytes of storage suitably aligned to represent any object of that size. The program can define an alternate function with this function signature that replaces the default version defined by the Standard C++ Library and so is replaceable.  
  
 The default behavior is to return <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>) if that function succeeds. Otherwise, it returns a null pointer.  
  
 The third function is called by a placement **new** expression, of the form **new** (                        *args*) T. Here,                         *args* consists of a single object pointer. This can be useful for constructing an object at a known address. The function returns  *_Ptr*.  
  
 To free storage allocated by <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, call [operator delete](../vs140/-new--operators.md#operator_delete).  
  
 For information on throwing or nonthrowing behavior of new, see [The new and delete Operators](../vs140/new-and-delete-operators.md).  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="operator_new_arr">\</a>  operator new[]  
 The allocation function called by a new expression to allocate storage for an array of objects.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The number of bytes of storage to be allocated for the array object.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The pointer to be returned.  
  
### Return Value  
 A pointer to the lowest byte address of the newly-allocated storage. Or <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  
### Remarks  
 The first function is called by a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> expression to allocate <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> bytes of storage suitably aligned to represent any array object of that size or smaller. The program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The required behavior is the same as for [operator new](../vs140/-new--operators.md#operator_new)( **size_t**). The default behavior is to return <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>).  
  
 The second function is called by a placement <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> expression to allocate <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> bytes of storage suitably aligned to represent any array object of that size. The program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The default behavior is to return **operatornew**( <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>) if that function succeeds. Otherwise, it returns a null pointer.  
  
 The third function is called by a placement <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> expression, of the form **new** (                        *args*) **T**[ **N**]. Here,                         *args* consists of a single object pointer. The function returns <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
 To free storage allocated by <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, call [operator delete&#91;&#93;](../vs140/-new--operators.md#operator_delete_at).  
  
 For information on throwing or nonthrowing behavior of new, see [The new and delete Operators](../vs140/new-and-delete-operators.md).  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [&lt;new&gt;](../vs140/-new-.md)