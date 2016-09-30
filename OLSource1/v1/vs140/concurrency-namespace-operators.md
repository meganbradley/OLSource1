---
title: "concurrency namespace Operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 8e373f23-fc8e-49f7-82e6-ba0c57b822f8
caps.latest.revision: 7
---
# concurrency namespace Operators
||||  
|-|-|-|  
|[operator!= Operator](#operator_neq_operator)|[operator&amp;&amp; Operator](#operator_amp__amp__operator)|[operator&gt; Operator](#operator_gt__operator)|  
|[operator&gt;= Operator](#operator_gt__eq_operator)|[operator&lt; Operator](#operator_lt__operator)|[operator&lt;= Operator](#operator_lt__eq_operator)|  
|[operator== Operator](#operator_eq_eq_operator)|[operator&#124;&#124; Operator](#operator_lor_operator)|  
  
##  \<a name="operator_lor_operator">\</a>  operator&#124;&#124; Operator  
 Creates a task that will complete successfully when either of the tasks supplied as arguments completes successfully.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The type of the returned task.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The first task to combine into the resulting task.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The second task to combine into the resulting task.  
  
### Return Value  
 A task that completes sucessfully when either of the input tasks has completed successfully. If the input tasks are of type                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the output of this function will be a                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If the input tasks are of type                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> the output task will also be a                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
### Remarks  
 If both of the tasks are canceled or throw exceptions, the returned task will complete in the canceled state, and one of the exceptions, if any are encountered, will be thrown when you call                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> on that task.  
  
##  \<a name="operator_amp__amp__operator">\</a>  operator&amp;&amp; Operator  
 Creates a task that will complete succesfully when both of the tasks supplied as arguments complete successfully.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The type of the returned task.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The first task to combine into the resulting task.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The second task to combine into the resulting task.  
  
### Return Value  
 A task that completes successfully when both of the input tasks have completed successfully. If the input tasks are of type                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the output of this function will be a                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. If the input tasks are of type                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> the output task will also be a                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
### Remarks  
 If one of the tasks is canceled or throws an exception, the returned task will complete early, in the canceled state, and the exception, if one is encoutered, will be thrown if you call                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> on that task.  
  
##  \<a name="operator_eq_eq_operator">\</a>  operator== Operator  
 Tests if the                 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object on the left side of the operator is equal to the                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object on the right side.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The data type of the elements stored in the concurrent vectors.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The allocator type of the first                                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The allocator type of the second                                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> if the concurrent vector on the left side of the operator is equal to the concurrent vector on the right side of the operator; otherwise                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Remarks  
 Two concurrent vectors are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
 This method is not concurrency-safe with respect to other methods that could modify either of the concurrent vectors                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_neq_operator">\</a>  operator!= Operator  
 Tests if the                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object on the left side of the operator is not equal to the                 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object on the right side.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The data type of the elements stored in the concurrent vectors.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The allocator type of the first                                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The allocator type of the second                                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> if the concurrent vectors are not equal;                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> if the concurrent vectors are equal.  
  
### Remarks  
 Two concurrent vectors are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
 This method is not concurrency-safe with respect to other methods that could modify either of the concurrent vectors                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_lt__operator">\</a>  operator&lt; Operator  
 Tests if the                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object on the left side of the operator is less than the                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object on the right side.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The data type of the elements stored in the concurrent vectors.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The allocator type of the first                                 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The allocator type of the second                                 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> if the concurrent vector on the left side of the operator is less than the concurrent vector on the right side of the operator; otherwise                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
### Remarks  
 The behavior of this operator is identical to the equivalent operator for the                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> class in the                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> namespace.  
  
 This method is not concurrency-safe with respect to other methods that could modify either of the concurrent vectors                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_lt__eq_operator">\</a>  operator&lt;= Operator  
 Tests if the                 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object on the left side of the operator is less than or equal to the                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object on the right side.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The data type of the elements stored in the concurrent vectors.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The allocator type of the first                                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The allocator type of the second                                 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> if the concurrent vector on the left side of the operator is less than or equal to the concurrent vector on the right side of the operator; otherwise                         <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
### Remarks  
 The behavior of this operator is identical to the equivalent operator for the                         <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> class in the                         <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> namespace.  
  
 This method is not concurrency-safe with respect to other methods that could modify either of the concurrent vectors                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_gt__operator">\</a>  operator&gt; Operator  
 Tests if the                 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object on the left side of the operator is greater than the                 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object on the right side.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The data type of the elements stored in the concurrent vectors.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The allocator type of the first                                 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The allocator type of the second                                 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> if the concurrent vector on the left side of the operator is greater than the concurrent vector on the right side of the operator; otherwise                         <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
### Remarks  
 The behavior of this operator is identical to the equivalent operator for the                         <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> class in the                         <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> namespace.  
  
 This method is not concurrency-safe with respect to other methods that could modify either of the concurrent vectors                         <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_gt__eq_operator">\</a>  operator&gt;= Operator  
 Tests if the                 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object on the left side of the operator is greater than or equal to the                 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> object on the right side.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 The data type of the elements stored in the concurrent vectors.  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The allocator type of the first                                 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The allocator type of the second                                 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 An object of type                                 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> if the concurrent vector on the left side of the operator is greater than or equal to the concurrent vector on the right side of the operator; otherwise                         <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
### Remarks  
 The behavior of this operator is identical to the equivalent operator for the                         <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> class in the                         <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> namespace.  
  
 This method is not concurrency-safe with respect to other methods that could modify either of the concurrent vectors                         <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)