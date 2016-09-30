---
title: "&lt;tuple&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: f25752dc-d3e2-4e12-b5ac-9a8682ca60ed
caps.latest.revision: 13
---
# &lt;tuple&gt; operators
||||  
|-|-|-|  
|[operator!=](#operator_neq)|[operator&gt;](#operator_gt_)|[operator&gt;=](#operator_gt__eq)|  
|[operator&lt;](#operator_lt_)|[operator&lt;=](#operator_lt__eq)|[operator==](#operator_eq_eq)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Compare <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> objects for inequality.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The type of the Nth tuple element.  
  
### Remarks  
 The function returns false when <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is 0, otherwise <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0 1 2 3**  
 **false**  
 **true**    
##  \<a name="operator_lt_">\</a>  operator&lt;  
 Compare <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> objects for less.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The type of the Nth tuple element.  
  
### Remarks  
 The function returns true when <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is greater than 0 and the first differing value in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> compares less than the corresponding value in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, otherwise it returns false.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0 1 2 3**  
 **false**  
 **true**    
##  \<a name="operator_lt__eq">\</a>  operator&lt;=  
 Compare <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> objects for less or equal.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The type of the Nth tuple element.  
  
### Remarks  
 The function returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0 1 2 3**  
 **true**  
 **false**    
##  \<a name="operator_eq_eq">\</a>  operator==  
 Compare <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> objects for equality.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The type of the Nth tuple element.  
  
### Remarks  
 The function returns true when <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is 0, otherwise <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0 1 2 3**  
 **true**  
 **false**    
##  \<a name="operator_gt_">\</a>  operator&gt;  
 Compare <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> objects for greater.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The type of the Nth tuple element.  
  
### Remarks  
 The function returns <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0 1 2 3**  
 **false**  
 **true**    
##  \<a name="operator_gt__eq">\</a>  operator&gt;=  
 Compare <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> objects for greater or equal.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The type of the Nth tuple element.  
  
### Remarks  
 The function returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0 1 2 3**  
 **true**  
 **false**    
## See Also  
 [&lt;tuple&gt;](../vs140/-tuple-.md)