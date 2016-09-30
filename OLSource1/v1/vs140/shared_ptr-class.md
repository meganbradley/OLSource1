---
title: "shared_ptr Class"
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
  - "shared_ptr"
  - "tr1::shared_ptr"
  - "memory/std::tr1::shared_ptr"
  - "std::tr1::shared_ptr"
  - "std.tr1.shared_ptr"
  - "tr1.shared_ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "shared_ptr class [TR1]"
  - "shared_ptr class"
ms.assetid: 1469fc51-c658-43f1-886c-f4530dd84860
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr Class
Wraps a reference-counted smart pointer around a dynamically allocated object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The type controlled by the shared pointer.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The type controlled by the argument pointer.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The pointer to copy.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The type of the deleter.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The type of the allocator.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The deleter.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The allocator.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The smart pointer to copy or move.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The weak pointer to copy or move.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The auto pointer to copy or move.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The unique pointer to move.  
  
## Remarks  
 The template class describes an object that uses reference counting to manage resources. A <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object effectively holds a pointer to the resource that it owns or holds a null pointer. A resource can be owned by more than one <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object; when the last <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object that owns a particular resource is destroyed, the resource is freed.  
  
 A <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> stops owning a resource when it is reassigned or reset.  
  
 The template argument <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> might be an incomplete type except as noted for certain member functions.  
  
 When a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object is constructed from a resource pointer of type <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> or from a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, the pointer type <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> must be convertible to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. If it is not, the code will not compile. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object owns a resource:  
  
-   if it was constructed with a pointer to that resource,  
  
-   if it was constructed from a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object that owns that resource,  
  
-   if it was constructed from a [weak_ptr](../vs140/weak_ptr-class.md) object that points to that resource, or  
  
-   if ownership of that resource was assigned to it, either with [operator=](#shared_ptr__operator_eq) or by calling the member function [reset](#shared_ptr__reset).  
  
 The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> objects that own a resource share a control block. The control block holds:  
  
-   the number of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> objects that own the resource,  
  
-   the number of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> objects that point to the resource,  
  
-   the deleter for that resource if it has one,  
  
-   the custom allocator for the control block if it has one.  
  
 A <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object that is initialized by using a null pointer has a control block and is not empty. After a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object releases a resource, it no longer owns that resource. After a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object releases a resource, it no longer points to that resource.  
  
 When the number of <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> objects that own a resource becomes zero, the resource is freed, either by deleting it or by passing its address to a deleter, depending on how ownership of the resource was originally created. When the number of <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> objects that own a resource is zero, and the number of <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> objects that point to that resource is zero, the control block is freed, using the custom allocator for the control block if it has one.  
  
 An empty <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object does not own any resources and has no control block.  
  
 A deleter is a function object that has a member function <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. Its type must be copy constructible, and its copy constructor and destructor must not throw exceptions. It accepts one parameter, the object to be deleted.  
  
 Some functions take an argument list that defines properties of the resulting <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object. You can specify such an argument list in several ways:  
  
 no arguments -- the resulting object is an empty <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object or an empty <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> -- a pointer of type <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> to the resource to be managed. <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> must be a complete type. If the function fails (because the control block cannot be allocated) it evaluates the expression <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> -- a pointer of type <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> to the resource to be managed and a deleter for that resource. If the function fails (because the control block cannot be allocated), it calls <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, which must be well defined.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> -- a pointer of type <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> to the resource to be managed, a deleter for that resource, and an allocator to manage any storage that must be allocated and freed. If the function fails (because the control block can't be allocated) it calls <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, which must be well defined.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> -- a <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object that owns the resource to be managed.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> -- a <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object that points to the resource to be managed.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> -- an <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object that holds a pointer to the resource to be managed. If the function succeeds it calls <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>; otherwise it leaves <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> unchanged.  
  
 In all cases, the pointer type <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> must be convertible to <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
## Thread Safety  
 Multiple threads can read and write different <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> objects at the same time, even when the objects are copies that share ownership.  
  
## Members  
  
### Constructors  
  
|||  
|-|-|  
|[shared_ptr::shared_ptr](#shared_ptr__shared_ptr)|Constructs a <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>.|  
|[shared_ptr::~shared_ptr](#shared_ptr___dtorshared_ptr)|Destroys a <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.|  
  
### Methods  
  
|||  
|-|-|  
|[shared_ptr::element_type](#shared_ptr__element_type)|The type of an element.|  
|[shared_ptr::get](#shared_ptr__get)|Gets address of owned resource.|  
|[shared_ptr::owner_before](#shared_ptr__owner_before)|Returns true if this <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> is ordered before (or less than) the provided pointer.|  
|[shared_ptr::reset](#shared_ptr__reset)|Replace owned resource.|  
|[shared_ptr::swap](#shared_ptr__swap)|Swaps two <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> objects.|  
|[shared_ptr::unique](#shared_ptr__unique)|Tests if owned resource is unique.|  
|[shared_ptr::use_count](#shared_ptr__use_count)|Counts numbers of resource owners.|  
  
### Operators  
  
|||  
|-|-|  
|[shared_ptr::operator boolean-type](#shared_ptr__operator_boolean-type)|Tests if an owned resource exists.|  
|[shared_ptr::operator*](#shared_ptr__operator_star)|Gets the designated value.|  
|[shared_ptr::operator=](#shared_ptr__operator_eq)|Replaces the owned resource.|  
|[shared_ptr::operator-&gt;](#shared_ptr__operator-_gt_)|Gets a pointer to the designated value.|  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
##  \<a name="shared_ptr__element_type">\</a>  shared_ptr::element_type  
 The type of an element.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **\*sp0 == 5**    
##  \<a name="shared_ptr__get">\</a>  shared_ptr::get  
 Gets address of owned resource.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the address of the owned resource. If the object does not own a resource it returns 0.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **sp0.get() == 0 == true**  
**\*sp1.get() == 5**    
##  \<a name="shared_ptr__operator_boolean-type">\</a>  shared_ptr::operator boolean-type  
 Tests if an owned resource exists.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The operator returns a value of a type that is convertible to <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>. The result of the conversion to <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, otherwise <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **(bool)sp0 == false**  
**(bool)sp1 == true**    
##  \<a name="shared_ptr__operator_star">\</a>  shared_ptr::operator*  
 Gets the designated value.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The indirection operator returns <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>. Hence, the stored pointer must not be null.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **\*sp0 == 5**    
##  \<a name="shared_ptr__operator_eq">\</a>  shared_ptr::operator=  
 Replaces the owned resource.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The shared pointer to copy.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 The auto pointer to copy.  
  
### Remarks  
 The operators all decrement the reference count for the resource currently owned by <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> and assign ownership of the resource named by the operand sequence to <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>. If the reference count falls to zero, the resource is released. If an operator fails it leaves <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> unchanged.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **\*sp0 == 5**  
**\*sp0 == 10**    
##  \<a name="shared_ptr__operator-_gt_">\</a>  shared_ptr::operator-&gt;  
 Gets a pointer to the designated value.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 The selection operator returns <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>, so that the expression <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> behaves the same as <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> is an object of class <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>. Hence, the stored pointer must not be null, and <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> must be a class, structure, or union type with a member <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **sp0->first == 1**  
**sp0->second == 2**    
##  \<a name="shared_ptr__owner_before">\</a>  shared_ptr::owner_before  
 Returns true if this <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> is ordered before (or less than) the provided pointer.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> reference to either a <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template member function returns true if <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.  
  
##  \<a name="shared_ptr__reset">\</a>  shared_ptr::reset  
 Replace owned resource.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The type controlled by the argument pointer.  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 The type of the deleter.  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The pointer to copy.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The deleter to copy.  
  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The type of the allocator.  
  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 The allocator to copy.  
  
### Remarks  
 The operators all decrement the reference count for the resource currently owned by <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> and assign ownership of the resource named by the operand sequence to <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>. If the reference count falls to zero, the resource is released. If an operator fails it leaves <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> unchanged.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  **\*sp == 5**  
**(bool)sp == false**  
**\*sp == 10**  
**\*sp == 15**    
##  \<a name="shared_ptr__shared_ptr">\</a>  shared_ptr::shared_ptr  
 Constructs a <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 The type controlled by the argument pointer.  
  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 The pointer to copy.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 The type of the deleter.  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 The type of the allocator.  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 The deleter.  
  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 The allocator.  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The smart pointer to copy.  
  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 The weak pointer.  
  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 The auto pointer to copy.  
  
### Remarks  
 The constructors each construct an object that owns the resource named by the operand sequence. The constructor <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> throws an exception object of type [bad_weak_ptr](../vs140/bad_weak_ptr-class.md) if <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  **(bool)sp0 == false**  
**\*sp1 == 5**  
**\*sp2 == 10**  
**\*sp3 == 10**  
**\*sp4 == 10**  
**\*sp5 == 15**    
##  \<a name="shared_ptr___dtorshared_ptr">\</a>  shared_ptr::~shared_ptr  
 Destroys a <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Remarks  
 The destructor decrements the reference count for the resource currently owned by <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>. If the reference count falls to zero, the resource is released.  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  **\*sp1 == 5**  
**use count == 1**  
**\*sp2 == 5**  
**use count == 2**  
**use count == 1**    
##  \<a name="shared_ptr__swap">\</a>  shared_ptr::swap  
 Swaps two <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 The shared pointer to swap with.  
  
### Remarks  
 The member function leaves the resource originally owned by <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> subsequently owned by <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>, and the resource originally owned by <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> subsequently owned by <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>. The function does not change the reference counts for the two resources and it does not throw any exceptions.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  **\*sp1 == 5**  
**\*sp1 == 10**  
**\*sp1 == 5**  
**\*wp1 == 5**  
**\*wp1 == 10**  
**\*wp1 == 5**    
##  \<a name="shared_ptr__unique">\</a>  shared_ptr::unique  
 Tests if owned resource is unique.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> if no other <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> object owns the resource that is owned by <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>, otherwise <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  **sp1.unique() == true**  
**sp1.unique() == false**    
##  \<a name="shared_ptr__use_count">\</a>  shared_ptr::use_count  
 Counts numbers of resource owners.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the number of <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> objects that own the resource that is owned by <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  **sp1.use_count() == 1**  
**sp1.use_count() == 2**    
## See Also  
 [weak_ptr](../vs140/weak_ptr-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)