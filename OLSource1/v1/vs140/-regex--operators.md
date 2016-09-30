---
title: "&lt;regex&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: ec623e65-c186-491f-aa18-6b12b47e1127
caps.latest.revision: 13
---
# &lt;regex&gt; operators
||||  
|-|-|-|  
|[operator!=](#operator_neq)|[operator&gt;](#operator_gt_)|[operator&gt;=](#operator_gt__eq)|  
|[operator&lt;](#operator_lt_)|[operator&lt;&lt;](#operator_lt__lt_)|[operator&lt;=](#operator_lt__eq)|  
|[operator==](#operator_eq_eq)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Not equal comparison for various objects.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The iterator type.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The string traits class.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The allocator class.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The left object to compare.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The right object to compare.  
  
### Remarks  
 Each template operator returns <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **match == caaa**  
**sub == aaa**  
**match != match == false**  
**sub != sub == false**  
**string("aab") != sub == true**  
**sub != string("aab") == true**  
**"aab" != sub == true**  
**sub != "aab" == true**  
**'a' != sub == true**  
**sub != 'a' == true**    
##  \<a name="operator_lt_">\</a>  operator&lt;  
 Less than comparison for various objects.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The iterator type.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The string traits class.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The allocator class.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The left object to compare.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The right object to compare.  
  
### Remarks  
 Each template operator converts its arguments to a string type and returns true only if the converted value of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> compares less than the converted value of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **sub == aaa**  
**sub < sub == false**  
**string("aab") < sub == false**  
**sub < string("aab") == true**  
**"aab" < sub == false**  
**sub < "aab" == true**  
**'a' < sub == true**  
**sub < 'a' == false**    
##  \<a name="operator_lt__lt_">\</a>  operator&lt;&lt;  
 Inserts a sub_match in a stream.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The element type.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The string traits class.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The allocator class.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The iterator type.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The output stream.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The object to insert.  
  
### Remarks  
 The template operator returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **whole match: caaa**    
##  \<a name="operator_lt__eq">\</a>  operator&lt;=  
 Less than or equal comparison for various objects.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The iterator type.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The string traits class.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The allocator class.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The left object to compare.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The right object to compare.  
  
### Remarks  
 Each template operator returns <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **sub == aaa**  
**sub <= sub == true**  
**string("aab") <= sub == false**  
**sub <= string("aab") == true**  
**"aab" <= sub == false**  
**sub <= "aab" == true**  
**'a' <= sub == true**  
**sub <= 'a' == false**    
##  \<a name="operator_eq_eq">\</a>  operator==  
 Equal comparison for various objects.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The iterator type.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The string traits class.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The allocator class.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The left object to compare.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The right object to compare.  
  
### Remarks  
 Each template operator converts each of its arguments to a string type and returns the result of comparing the converted objects for equality.  
  
 When a template operator converts its arguments to a string type it uses the first of the following transformations that applies:  
  
 arguments whose types are a specialization of template class <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> are converted by calling the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> member function;  
  
 arguments whose types are a specialization of the template class <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> are unchanged;  
  
 all other argument types are converted by passing the argument value to the constructor for an appropriate specialization of the template class <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **match == caaa**  
**sub == aaa**  
**match == match == true**  
**sub == sub == true**  
**string("aab") == sub == false**  
**sub == string("aab") == false**  
**"aab" == sub == false**  
**sub == "aab" == false**  
**'a' == sub == false**  
**sub == 'a' == false**    
##  \<a name="operator_gt_">\</a>  operator&gt;  
 Greater than comparison for various objects.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The iterator type.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The string traits class.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The allocator class.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The left object to compare.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The right object to compare.  
  
### Remarks  
 Each template operator returns <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **sub == aaa**  
**sub > sub == false**  
**string("aab") > sub == true**  
**sub > string("aab") == false**  
**"aab" > sub == true**  
**sub > "aab" == false**  
**'a' > sub == false**  
**sub > 'a' == true**    
##  \<a name="operator_gt__eq">\</a>  operator&gt;=  
 Greater than or equal comparison for various objects.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The iterator type.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The string traits class.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The allocator class.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The left object to compare.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The right object to compare.  
  
### Remarks  
 Each template operator returns <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **sub == aaa**  
**sub >= sub == true**  
**string("aab") >= sub == true**  
**sub >= string("aab") == false**  
**"aab" >= sub == true**  
**sub >= "aab" == false**  
**'a' >= sub == false**  
**sub >= 'a' == true**    
## See Also  
 [&lt;regex&gt;](../vs140/-regex-.md)