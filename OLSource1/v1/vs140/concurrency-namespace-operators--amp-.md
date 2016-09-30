---
title: "Concurrency namespace operators (AMP)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 77f1ae17-1eb2-480d-8fe5-66d4c24bb91e
caps.latest.revision: 10
---
# Concurrency namespace operators (AMP)
||||  
|-|-|-|  
|[operator!= Operator (C++ AMP)](#operator_neq_operator__c_add_add_amp_)|[operator% Operator (C++ AMP)](#operator_mod_operator__c_add_add_amp_)|[operator* Operator (C++ AMP)](#operator_star_operator__c_add_add_amp_)|  
|[operator+ Operator (C++ AMP)](#operator_add_operator__c_add_add_amp_)|[operator- Operator (C++ AMP)](#operator-_operator__c_add_add_amp_)|[operator/ Operator (C++ AMP)](#operator__operator__c_add_add_amp_)|  
|[operator== Operator (C++ AMP)](#operator_eq_eq_operator__c_add_add_amp_)|  
  
##  \<a name="operator_eq_eq_operator__c_add_add_amp_">\</a>  operator== Operator (C++ AMP)  
 Determines whether the specified arguments are equal.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The rank of the tuple arguments.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 One of the tuples to compare.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 One of the tuples to compare.  
  
### Return Value  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the tuples are equal; otherwise,                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_neq_operator__c_add_add_amp_">\</a>  operator!= Operator (C++ AMP)  
 Determines whether the specified arguments are not equal.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The rank of the tuple arguments.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 One of the tuples to compare.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 One of the tuples to compare.  
  
### Return Value  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if the tuples are not equal; otherwise,                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_add_operator__c_add_add_amp_">\</a>  operator+ Operator (C++ AMP)  
 Computes the component-wise sum of the specified arguments.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The rank of the tuple arguments.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 One of the arguments to add.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 One of the arguments to add.  
  
### Return Value  
 The component-wise sum of the specified arguments.  
  
##  \<a name="operator-_operator__c_add_add_amp_">\</a>  operator- Operator (C++ AMP)  
 Computes the component-wise difference between the specified arguments.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The rank of the tuple arguments.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The argument to be subtracted from.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The argument to subtract.  
  
### Return Value  
 The component-wise difference between the specified arguments.  
  
##  \<a name="operator_star_operator__c_add_add_amp_">\</a>  operator* Operator (C++ AMP)  
 Computes the component-wise product of the specified arguments.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The rank of the tuple arguments.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 One of the tuples to multiply.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 One of the tuples to multiply.  
  
### Return Value  
 The component-wise product of the specified arguments.  
  
##  \<a name="operator__operator__c_add_add_amp_">\</a>  operator/ Operator (C++ AMP)  
 Computes the component-wise quotient of the specified arguments.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The rank of the tuple arguments.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The tuple to be divided.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The tuple to divide by.  
  
### Return Value  
 The component-wise quotient of the specified arguments.  
  
##  \<a name="operator_mod_operator__c_add_add_amp_">\</a>  operator% Operator (C++ AMP)  
 Computes the modulus of the first specified argument by the second specified argument.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The rank of the tuple arguments.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The tuple from which the modulo is calculated.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The tuple to modulo by.  
  
### Return Value  
 The result of the first specified argument modulus the second specified argument.  
  
## See Also  
 [Concurrency Namespace (C++ AMP)](../vs140/concurrency-namespace--c---amp-.md)