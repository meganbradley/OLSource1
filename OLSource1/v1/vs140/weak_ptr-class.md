---
title: "weak_ptr Class"
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
  - "std.tr1.weak_ptr"
  - "tr1.weak_ptr"
  - "weak_ptr"
  - "tr1::weak_ptr"
  - "std::tr1::weak_ptr"
  - "memory/std::tr1::weak_ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "weak_ptr class [TR1]"
  - "weak_ptr class"
ms.assetid: 2db4afb2-c7be-46fc-9c20-34ec2f8cc7c2
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# weak_ptr Class
Wraps a weakly linked pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The type controlled by the weak pointer.  
  
## Remarks  
 The template class describes an object that points to a resource that is managed by one or more [shared_ptr](../vs140/shared_ptr-class.md) objects. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> objects that point to a resource do not affect the resource's reference count. Thus, when the last <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object that manages that resource is destroyed the resource will be freed, even if there are <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> objects pointing to that resource. This is essential for avoiding cycles in data structures.  
  
 A <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object points to a resource if it was constructed from a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object that owns that resource, if it was constructed from a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object that points to that resource, or if that resource was assigned to it with [operator=](#weak_ptr__operator_eq). A <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object does not provide direct access to the resource that it points to. Code that needs to use the resource does so through a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object that owns that resource, created by calling the member function [lock](#weak_ptr__lock). A <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object has expired when the resource that it points to has been freed because all of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> objects that own the resource have been destroyed. Calling <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> on a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object that has expired creates an empty shared_ptr object.  
  
 An empty weak_ptr object does not point to any resources and has no control block. Its member function <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> returns an empty shared_ptr object.  
  
 A cycle occurs when two or more resources controlled by <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> objects hold mutually referencing <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> objects. For example, a circular linked list with three elements has a head node <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>; that node holds a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object that owns the next node, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>; that node holds a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object that owns the next node, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>; that node, in turn, holds a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object that owns the head node, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, closing the cycle. In this situation, none of the reference counts will ever become zero, and the nodes in the cycle will not be freed. To eliminate the cycle, the last node <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> should hold a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object pointing to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> instead of a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object. Since the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object does not own <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> it doesn't affect <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>'s reference count, and when the program's last reference to the head node is destroyed the nodes in the list will also be destroyed.  
  
## Members  
  
### Constructors  
  
|||  
|-|-|  
|[weak_ptr::weak_ptr](#weak_ptr__weak_ptr)|Constructs a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.|  
  
### Methods  
  
|||  
|-|-|  
|[weak_ptr::element_type](#weak_ptr__element_type)|The type of the element.|  
|[weak_ptr::expired](#weak_ptr__expired)|Tests if ownership has expired.|  
|[weak_ptr::lock](#weak_ptr__lock)|Obtains exclusive ownership of a resource.|  
|[weak_ptr::owner_before](#weak_ptr__owner_before)|Returns <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> if this <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is ordered before (or less than) the provided pointer.|  
|[weak_ptr::reset](#weak_ptr__reset)|Releases owned resource.|  
|[weak_ptr::swap](#weak_ptr__swap)|Swaps two <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> objects.|  
|[weak_ptr::use_count](#weak_ptr__use_count)|Counts number of designated <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> objects.|  
  
### Operators  
  
|||  
|-|-|  
|[weak_ptr::operator=](#weak_ptr__operator_eq)|Replaces owned resource.|  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
##  \<a name="weak_ptr__element_type">\</a>  weak_ptr::element_type  
 The type of the element.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **\*wp0.lock() == 5**    
##  \<a name="weak_ptr__expired">\</a>  weak_ptr::expired  
 Tests if ownership has expired.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> has expired, otherwise <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **wp.expired() == false**  
**\*wp.lock() == 10**  
**wp.expired() == true**  
**(bool)wp.lock() == false**    
##  \<a name="weak_ptr__lock">\</a>  weak_ptr::lock  
 Obtains exclusive ownership of a resource.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns an empty shared_ptr object if <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> has expired; otherwise it returns a [shared_ptr](../vs140/shared_ptr-class.md)<CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object that owns the resource that <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> points to.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **wp.expired() == false**  
**\*wp.lock() == 10**  
**wp.expired() == true**  
**(bool)wp.lock() == false**    
##  \<a name="weak_ptr__operator_eq">\</a>  weak_ptr::operator=  
 Replaces owned resource.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The type controlled by the argument shared/weak pointer.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The weak pointer to copy.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The shared pointer to copy.  
  
### Remarks  
 The operators all release the resource currently pointed to by <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> and assign ownership of the resource named by the operand sequence to <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>. If an operator fails it leaves <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> unchanged.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **\*wp0.lock() == 5**  
**\*wp0.lock() == 10**  
**\*wp1.lock() == 10**    
##  \<a name="weak_ptr__owner_before">\</a>  weak_ptr::owner_before  
 Returns <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> if this <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is ordered before (or less than) the provided pointer.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> reference to either a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template member function returns <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
##  \<a name="weak_ptr__reset">\</a>  weak_ptr::reset  
 Releases owned resource.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 The member function releases the resource pointed to by <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> and converts <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> to an empty weak_ptr object.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **\*wp.lock() == 5**  
**wp.expired() == false**  
**wp.expired() == true**    
##  \<a name="weak_ptr__swap">\</a>  weak_ptr::swap  
 Swaps two <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The weak pointer to swap with.  
  
### Remarks  
 The member function leaves the resource originally pointed to by <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> subsequently pointed to by <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, and the resource originally pointed to by <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> subsequently pointed to by <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>. The function does not change the reference counts for the two resources and it does not throw any exceptions.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **\*sp1 == 5**  
**\*sp1 == 10**  
**\*sp1 == 5**  
**\*wp1 == 5**  
**\*wp1 == 10**  
**\*wp1 == 5**    
##  \<a name="weak_ptr__use_count">\</a>  weak_ptr::use_count  
 Counts number of designated <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the number of <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> objects that own the resource pointed to by <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **wp.use_count() == 1**  
**wp.use_count() == 2**    
##  \<a name="weak_ptr__weak_ptr">\</a>  weak_ptr::weak_ptr  
 Constructs a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The type controlled by the argument shared/weak pointer.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The weak pointer to copy.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The shared pointer to copy.  
  
### Remarks  
 The constructors each construct an object that points to the resource named by the operand sequence.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  **wp0.expired() == true**  
**\*wp1.lock() == 5**  
**\*wp2.lock() == 5**    
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)