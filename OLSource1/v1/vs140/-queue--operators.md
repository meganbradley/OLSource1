---
title: "&lt;queue&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 7c435b48-175c-45b0-88eb-24561044019c
caps.latest.revision: 13
---
# &lt;queue&gt; operators
||||  
|-|-|-|  
|[operator!=](#operator_neq)|[operator&gt;](#operator_gt_)|[operator&gt;=](#operator_gt__eq)|  
|[operator&lt;](#operator_lt_)|[operator&lt;=](#operator_lt__eq)|[operator==](#operator_eq_eq)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Tests if the queue object on the left side of the operator is not equal to the queue object on the right side.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
### Return Value  
 **true** if the queues are not equal; **false** if queues are equal.  
  
### Remarks  
 The comparison between queue objects is based on a pairwise comparison of their elements. Two queues are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **The queues q1 and q2 are not equal.**  
**The queues q1 and q3 are equal.**    
##  \<a name="operator_lt_">\</a>  operator&lt;  
 Tests if the queue object on the left side of the operator is less than the queue object on the right side.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
### Return Value  
 **true** if the queue on the left side of the operator is less than and not equal to the queue on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between queue objects is based on a pairwise comparison of their elements. The less-than relationship between two queue objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The queue q1 is less than the queue q2.**  
**The queue q1 is not less than the queue q3.**    
##  \<a name="operator_lt__eq">\</a>  operator&lt;=  
 Tests if the queue object on the left side of the operator is less than or equal to the queue object on the right side.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
### Return Value  
 **true** if the queue on the left side of the operator is strictly less than the queue on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between queue objects is based on a pairwise comparison of their elements. The less than or equal to relationship between two queue objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The queue q1 is greater than the queue q2.**  
**The queue q1 is less than or equal to the queue q3.**    
##  \<a name="operator_eq_eq">\</a>  operator==  
 Tests if the queue object on the left side of the operator is equal to queue object on the right side.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
### Return Value  
 **true** if the queues are not equal; **false** if queues are equal.  
  
### Remarks  
 The comparison between queue objects is based on a pairwise comparison of their elements. Two queues are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The queues q1 and q2 are not equal.**  
**The queues q1 and q3 are equal.**    
##  \<a name="operator_gt_">\</a>  operator&gt;  
 Tests if the queue object on the left side of the operator is greater than the queue object on the right side.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
### Return Value  
 **true** if the queue on the left side of the operator is strictly less than the queue on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between queue objects is based on a pairwise comparison of their elements. The greater-than relationship between two queue objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The queue q1 is not greater than the queue q2.**  
**The queue q1 is greater than the queue q3.**    
##  \<a name="operator_gt__eq">\</a>  operator&gt;=  
 Tests if the queue object on the left side of the operator is greater than or equal to the queue object on the right side.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
### Return Value  
 **true** if the queue on the left side of the operator is strictly less than the queue on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between queue objects is based on a pairwise comparison of their elements. Two queues are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **The queue q1 is less than the queue q2.**  
**The queue q1 is greater than or equal to the queue q3.**    
## See Also  
 [&lt;queue&gt;](../vs140/-queue-.md)