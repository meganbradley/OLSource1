---
title: "&lt;memory&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 257e3ba9-c4c2-4ae8-9b11-b156ba9c28de
caps.latest.revision: 13
---
# &lt;memory&gt; operators
||||  
|-|-|-|  
|[operator!=](#operator_neq)|[operator&gt;](#operator_gt_)|[operator&gt;=](#operator_gt__eq)|  
|[operator&lt;](#operator_lt_)|[operator&lt;&lt;](#operator_lt__lt_)|[operator&lt;=](#operator_lt__eq)|  
|[operator==](#operator_eq_eq)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Tests for inequality between objects.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 One of the objects to be tested for inequality.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 One of the objects to be tested for inequality.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The type controlled by the left shared pointer.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The type controlled by the right shared pointer.  
  
### Return Value  
 **true** if the objects are not equal; **false** if objects are equal.  
  
### Remarks  
 The first template operator returns false. (All default allocators are equal.)  
  
 The second and third template operators return <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **The allocator objects Alloc & v1Alloc are equal.**    
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **sp0 != sp0 == false**  
**sp0 != sp1 == true**    
##  \<a name="operator_eq_eq">\</a>  operator==  
 Tests for equality between objects.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 One of the objects to be tested for equality.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 One of the objects to be tested for equality.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The type controlled by the left shared pointer.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The type controlled by the right shared pointer.  
  
### Return Value  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> if the objects are equal, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if objects are not equal.  
  
### Remarks  
 The first template operator returns true. (All default allocators are equal.)  
  
 The second and third template operators return <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **The allocator objects cv1Alloc & v1Alloc are equal.**  
**The allocator objects cAlloc & Alloc are equal.**    
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **sp0 == sp0 == true**  
**sp0 == sp1 == false**    
##  \<a name="operator_gt__eq">\</a>  operator&gt;=  
 Tests for one object being greater than or equal to a second object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 One of the objects to be compared.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 One of the objects to be compared.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The type controlled by the left shared pointer.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The type controlled by the right shared pointer.  
  
### Remarks  
 The template operators return <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_lt_">\</a>  operator&lt;  
 Tests for one object being less than a second object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 One of the objects to be compared.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 One of the objects to be compared.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The type controlled by the left pointer.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The type controlled by the right pointer.  
  
##  \<a name="operator_lt__eq">\</a>  operator&lt;=  
 Tests for one object being less than or equal to a second object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 One of the objects to be compared.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 One of the objects to be compared.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The type controlled by the left shared pointer.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The type controlled by the right shared pointer.  
  
### Remarks  
 The template operators return <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
##  \<a name="operator_gt_">\</a>  operator&gt;  
 Tests for one object being greater than a second object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 One of the objects to be compared.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 One of the objects to be compared.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The type controlled by the left shared pointer.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The type controlled by the right shared pointer.  
  
##  \<a name="operator_lt__lt_">\</a>  operator&lt;&lt;  
 shared_ptr inserter.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The type of the stream element.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The type the stream element traits.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The type controlled by the shared pointer.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The output stream.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The shared pointer.  
  
### Remarks  
 The template function returns <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **sp0 == 3f3040 (varies)**    
## See Also  
 [&lt;memory&gt;](../vs140/-memory-.md)