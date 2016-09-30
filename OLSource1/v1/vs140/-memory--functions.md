---
title: "&lt;memory&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 3e1898c2-44b7-4626-87ce-84962e4c6f1a
caps.latest.revision: 10
---
# &lt;memory&gt; functions
||||  
|-|-|-|  
|[addressof](#addressof)|[align](#align)|[allocate_shared](#allocate_shared)|  
|[const_pointer_cast](#const_pointer_cast)|[declare_no_pointers](#declare_no_pointers)|[declare_reachable](#declare_reachable)|  
|[default_delete](#default_delete)|[dynamic_pointer_cast](#dynamic_pointer_cast)|[get_deleter Function](#get_deleter_function)|  
|[get_pointer_safety](#get_pointer_safety)|[get_temporary_buffer](#get_temporary_buffer)|[make_shared](#make_shared)|  
|[make_unique](#make_unique)|[owner_less](#owner_less)|[return_temporary_buffer](#return_temporary_buffer)|  
|[static_pointer_cast](#static_pointer_cast)|[swap](#swap)|[undeclare_no_pointers](#undeclare_no_pointers)|  
|[undeclare_reachable](#undeclare_reachable)|[uninitialized_copy](#uninitialized_copy)|[uninitialized_copy_n](#uninitialized_copy_n)|  
|[uninitialized_fill](#uninitialized_fill)|[uninitialized_fill_n](#uninitialized_fill_n)|  
  
##  \<a name="addressof">\</a>  addressof  
 Gets the true address of an object.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The object or function for which to obtain the true address.  
  
### Return Value  
 The actual address of the object or function referenced by <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, even if an overloaded <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> exists.  
  
### Remarks  
  
##  \<a name="align">\</a>  align  
 Fits storage of the given size—aligned by the given alignment specification—into the first possible address of the given storage.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The alignment bound to attempt.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The size in bytes for the aligned storage.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The starting address of the available contiguous storage pool to use. This parameter is also an output parameter, and will contain the new starting address if the alignment is successful.  
  
 If <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is unsuccessful, this parameter is not modified.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The total space available to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to use in creating the aligned storage. This parameter is also an output parameter, and contains the adjusted space left in the storage buffer after the aligned storage and any associated overhead is subtracted.  
  
 If <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is unsuccessful, this parameter is not modified.  
  
### Return Value  
 A null pointer if the requested aligned buffer would not fit into the available space; otherwise, the new value of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
### Remarks  
 The modified <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> parameters enable you to call <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> repeatedly on the same buffer, possibly with different values for <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. The following code snippet shows one use of <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="allocate_shared">\</a>  allocate_shared  
 Creates a  <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> to objects that are allocated and constructed for a given type by using a specified allocator. Returns the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The allocator used to create objects.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The zero or more arguments that become the objects.  
  
### Remarks  
 The function creates the object <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, a pointer to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> as allocated and constructed by <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
##  \<a name="const_pointer_cast">\</a>  const_pointer_cast  
 Const cast to shared_ptr.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The type controlled by the returned shared pointer.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The type controlled by the argument shared pointer.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The argument shared pointer.  
  
### Remarks  
 The template function returns an empty shared_ptr object if <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> returns a null pointer; otherwise it returns a [shared_ptr](../vs140/shared_ptr-class.md)<CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object that owns the resource that is owned by <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>. The expression <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> must be valid.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **sp1 == 3**    
##  \<a name="declare_no_pointers">\</a>  declare_no_pointers  
 Informs a garbage collector that the characters in the memory block defined by a base address pointer and block size contains no traceable pointers.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|Address of first character that no longer contains traceable pointers.|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|Size of block that starts at <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> that contains no traceable pointers.|  
  
### Remarks  
 The function informs any <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> that the range of addresses <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> no longer contain traceable pointers. (Any pointers to allocated storage must not be dereferenced unless made <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.)  
  
##  \<a name="declare_reachable">\</a>  declare_reachable  
 Informs garbage collection that the indicated address is to allocated storage and is reachable.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 A pointer to a reachable, allocated, valid storage area.  
  
### Remarks  
 If <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is not null, the function informs any garbage collector that <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> is hereafter reachable (points to valid allocated storage).  
  
##  \<a name="default_delete">\</a>  default_delete  
 Deletes objects allocated with <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>. Suitable for use with <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Pointer to the object to delete.  
  
 Other  
 The type of elements in the array to be deleted.  
  
### Remarks  
 The template class describes a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> that deletes scalar objects allocated with <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, suitable for use with template class <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>. It also has the explicit specialization <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
##  \<a name="dynamic_pointer_cast">\</a>  dynamic_pointer_cast  
 Dynamic cast to shared_ptr.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The type controlled by the returned shared pointer.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The type controlled by the argument shared pointer.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The argument shared pointer.  
  
### Remarks  
 The template function returns an empty shared_ptr object if <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> returns a null pointer; otherwise it returns a [shared_ptr](../vs140/shared_ptr-class.md)<CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object that owns the resource that is owned by <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>. The expression <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> must be valid.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **sp1->val == 3**    
##  \<a name="get_deleter_function">\</a>  get_deleter Function  
 Get deleter from shared_ptr.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The type of the deleter.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The type controlled by the shared pointer.  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The shared pointer.  
  
### Remarks  
 The template function returns a pointer to the deleter of type <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> that belongs to the [shared_ptr](../vs140/shared_ptr-class.md) object <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> has no deleter or if its deleter is not of type <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> the function returns 0.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **get_deleter(sp0) != 0 == false**  
**get_deleter(sp1) != 0 == true**    
##  \<a name="get_pointer_safety">\</a>  get_pointer_safety  
 Returns the type of pointer safety assumed by any garbage collector.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 The function returns the type of pointer safety assumed by any automatic <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
##  \<a name="get_temporary_buffer">\</a>  get_temporary_buffer  
 Allocates temporary storage for a sequence of elements that does not exceed a specified number of elements.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 The maximum number of elements requested for which memory is to be allocated.  
  
### Return Value  
 A <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> whose first component is a pointer to the memory that was allocated, and whose second component gives the size of the buffer, indicating the largest number of elements that it could store.  
  
### Remarks  
 The function makes a request for memory and it may not succeed. If no buffer is allocated, then the function returns a pair, with the second component equal to zero and the first component equal to the null pointer.  
  
 This function should only be used for memory that is temporary.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **The number of integers in the array is: 9.**  
**The number of elements that the allocated memory**  
**could store is given by: resultPair.second = 9.**    
##  \<a name="make_shared">\</a>  make_shared  
 Creates and returns a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> that points to the allocated objects that are constructed from zero or more arguments by using the default allocator. Allocates and constructs both an object of the specified type and a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> to manage shared ownership of the object, and returns the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>|Zero or more constructor arguments. The function infers which constructor overload to invoke based on the arguments that are provided.|  
  
### Remarks  
 Use <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> as a simple and more efficient way to create an object and a <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> to manage shared access to the object at the same time. Semantically, these two statements are equivalent:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 However, the first statement makes two allocations, and if the allocation of the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> fails after the allocation of the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> object has succeeded, then the unnamed <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object is leaked. The statement that uses <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> is simpler because there's only one function call involved. It's more efficient because the library can make a single allocation for both the object and the smart pointer. This is both faster and leads to less memory fragmentation, and there is no chance of an exception on one allocation but not the other. Performance is improved by better locality for code that references the object and updates the reference counts in the smart pointer.  
  
 Consider using [make_unique](../vs140/-memory--functions.md#make_unique) if you do not need shared access to the object. Use [allocate_shared](../vs140/-memory--functions.md#allocate_shared) if you need to specify a custom allocator for the object. You can't use <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> if your object requires a custom deleter, because there is no way to pass the deleter as an argument.  
  
 The following example shows how to create shared pointers to a type by invoking specific constructor overloads.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  The example produces this output:  
  
 **Playing Ode to Joy by Beethoven, use count: 2**  
**Playing Yesterday by The Beatles, use count: 3**  
**Playing Blackbird by The Beatles, use count: 3**  
**Playing Greensleeves by Unknown, use count: 2**  
**Playing Yesterday by The Beatles, use count: 3**  
**Playing Blackbird by The Beatles, use count: 3**    
##  \<a name="make_unique">\</a>  make_unique  
 Creates and returns a [unique_ptr](../vs140/unique_ptr-class.md) to an object of the specified type, which is constructed by using the specified arguments.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The type of the object that the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> will point to.  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The types of the constructor arguments specified by <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The arguments to be passed to the constructor of the object of type <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 An array of elements of type <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 The number of elements to allocate space for in the new array.  
  
### Remarks  
 The first overload is used for single objects, the second overload is invoked for arrays, and the third overload prevents the prevents you from specifying an array size in the type argument (make_unique\<T[N]>); this construction is not supported by the current standard. When you use <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> to create a <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> to an array, you have to initialize the array elements separately. If you are considering this overload, perhaps a better choice is to use a [std::vector](../vs140/vector-class.md).  
  
 Because <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> is carefully implemented for exception safety, we recommend that you use <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> instead of directly calling <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> constructors.  
  
### Example  
  The following example shows how to use <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>. For more examples, see [How to: Create and Use unique_ptr Instances](../vs140/how-to--create-and-use-unique_ptr-instances.md).  
  
  [!code[stl_smart_pointers#214](../vs140/codesnippet/CPP/-memory--functions_1.cpp)]  
  
  When you see error C2280 in connection with a <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>, it is almost certainly because you are attempting to invoke its copy constructor, which is a deleted function.  
  
##  \<a name="owner_less">\</a>  owner_less  
 Allows ownership-based mixed comparisons of shared and weak pointers. Returns <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> if the left parameter is ordered before right parameter by the member function <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 A shared or weak pointer.  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 A shared or weak pointer.  
  
### Remarks  
 The template classes define all their member operators as returning <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
##  \<a name="return_temporary_buffer">\</a>  return_temporary_buffer  
 Deallocates the temporary memory that was allocated using the <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> template function.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 *_Pbuf*  
 A pointer to the memory to be deallocated.  
  
### Remarks  
 This function should only be used for memory that is temporary.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **The number of integers in the array is: 7.**  
**The number of elements that the allocated memory**  
 **could store is given by: resultPair.second = 7.**    
##  \<a name="static_pointer_cast">\</a>  static_pointer_cast  
 Static cast to shared_ptr.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 The type controlled by the returned shared pointer.  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 The type controlled by the argument shared pointer.  
  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 The argument shared pointer.  
  
### Remarks  
 The template function returns an empty shared_ptr object if <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> is an empty <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> object; otherwise it returns a [shared_ptr](../vs140/shared_ptr-class.md)<CodeContentPlaceHolder>144\</CodeContentPlaceHolder> object that owns the resource that is owned by <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>. The expression <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> must be valid.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **sp1->val == 3**    
##  \<a name="swap">\</a>  swap (C++ Standard Library)  
 Swap two shared_ptr or weak_ptr objects.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 The type controlled by the left shared/weak pointer.  
  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 The type controlled by the right shared/weak pointer.  
  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 The left shared/weak pointer.  
  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 The right shared/weak pointer.  
  
### Remarks  
 The template functions call <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  **\*sp1 == 5**  
**\*sp1 == 10**  
**\*sp1 == 5**  
**\*wp1 == 5**  
**\*wp1 == 10**  
**\*wp1 == 5**    
##  \<a name="undeclare_no_pointers">\</a>  undeclare_no_pointers  
 Informs a garbage collector that the characters in the memory block defined by a base address pointer and block size may now contain traceable pointers.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
 The function informs any <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> that the range of addresses <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> may now contain <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>.  
  
##  \<a name="undeclare_reachable">\</a>  undeclare_reachable  
 Informs a <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> that a specified memory location is not reachable.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>159\</CodeContentPlaceHolder>|A pointer to the memory address to be declared not reachable.|  
  
### Remarks  
 If <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>, the function informs any <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> that <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> is hereafter not <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>. It returns a <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> pointer that compares equal to <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
##  \<a name="uninitialized_copy">\</a>  uninitialized_copy  
 Copies objects from a specified source range into an uninitialized destination range.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the source range.  
  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 An input iterator addressing the last element in the source range.  
  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 A forward iterator addressing the first element in the destination range.  
  
### Return Value  
 A forward iterator addressing the first position beyond the destination range, unless the source range was empty and iterator addresses                         *_First.*  
  
### Remarks  
 This algorithm allows the decoupling of memory allocation from object construction.  
  
 The template function effectively executes:  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 unless the code throws an exception. In that case, all constructed objects are destroyed and the exception is rethrown.  
  
### Example  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
##  \<a name="uninitialized_copy_n">\</a>  uninitialized_copy_n  
 Creates a copy of a specified number of elements from an input iterator. The copies are put in a forward iterator.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 An input iterator that refers to the object to copy.  
  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 A signed or unsigned integer type specifying the number of times to copy the object.  
  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 A forward iterator that refers to where the new copies go.  
  
### Return Value  
 A forward iterator that addresses the first position beyond the destination. If the source range was empty, the iterator addresses <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>*.*  
  
### Remarks  
 The template function effectively executes the following:  
  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
  
 unless the code throws an exception. In that case, all constructed objects are destroyed and the exception is rethrown.  
  
##  \<a name="uninitialized_fill">\</a>  uninitialized_fill  
 Copies objects of a specified value into an uninitialized destination range.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 A forward iterator addressing the first element in the destination range that is to be initiated.  
  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 A forward iterator addressing the last element in the destination range that is to be initiated.  
  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 The value to be used to initialize the destination range.  
  
### Remarks  
 This algorithm allows the decoupling of memory allocation from object construction.  
  
 The template function effectively executes:  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 unless the code throws an exception. In that case, all constructed objects are destroyed and the exception is rethrown.  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  **The initialized Array contains: 25 25 25 25 25 25 25 25 25 25**     
##  \<a name="uninitialized_fill_n">\</a>  uninitialized_fill_n  
 Copies objects of a specified value into specified number of elements into an uninitialized destination range.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 A forward iterator addressing the first element in the destination range to be initiated.  
  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 The number of elements to be initialized.  
  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 The value to be used to initialize the destination range.  
  
### Remarks  
 This algorithm allows the decoupling of memory allocation from object construction.  
  
 The template function effectively executes:  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 unless the code throws an exception. In that case, all constructed objects are destroyed and the exception is rethrown.  
  
### Example  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
## See Also  
 [&lt;memory&gt;](../vs140/-memory-.md)