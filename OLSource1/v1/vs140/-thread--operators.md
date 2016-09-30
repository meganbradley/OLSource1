---
title: "&lt;thread&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: e6bb6c0f-64f9-4cb2-9ff2-05b88a6ba7ac
caps.latest.revision: 13
---
# &lt;thread&gt; operators
||||  
|-|-|-|  
|[operator!=](#operator_neq)|[operator&gt;](#operator_gt_)|[operator&gt;=](#operator_gt__eq)|  
|[operator&lt;](#operator_lt_)|[operator&lt;&lt;](#operator_lt__lt_)|[operator&lt;=](#operator_lt__eq)|  
|[operator==](#operator_eq_eq)|  
  
##  \<a name="operator_gt__eq">\</a>  operator&gt;=  
 Determines whether one <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is greater than or equal to another.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
### Remarks  
 This function does not throw any exceptions.  
  
##  \<a name="operator_gt_">\</a>  operator&gt;  
 Determines whether one <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object is greater than another.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
### Remarks  
 This function does not throw any exceptions.  
  
##  \<a name="operator_lt__eq">\</a>  operator&lt;=  
 Determines whether one <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object is less than or equal to another.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
### Remarks  
 This function does not throw any exceptions.  
  
##  \<a name="operator_lt_">\</a>  operator&lt;  
 Determines whether one <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object is less than another.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> precedes <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> in the total ordering; otherwise, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Remarks  
 The operator defines a total ordering on all <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> objects. These objects can be used as keys in associative containers.  
  
 This function does not throw any exceptions.  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Compares two <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> objects for inequality.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
### Remarks  
 This function does not throw any exceptions.  
  
##  \<a name="operator_eq_eq">\</a>  operator==  
 Compares two <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> objects for equality.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> if the two objects represent the same thread of execution or if neither object represents a thread of execution; otherwise, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
### Remarks  
 This function does not throw any exceptions.  
  
##  \<a name="operator_lt__lt_">\</a>  operator&lt;&lt;  
 Inserts a text representation of a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object into a stream.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 A [basic_ostream](../vs140/basic_ostream-class.md) object.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
### Remarks  
 This function inserts <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
 If two <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> objects compare equal, the inserted text representations of those objects are the same.  
  
## See Also  
 [&lt;thread&gt;](../vs140/-thread-.md)