---
title: "&lt;stack&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 9c1fc282-2f61-4727-9e80-84ea5d4934a2
caps.latest.revision: 13
---
# &lt;stack&gt; operators
||||  
|-|-|-|  
|[operator!=](#operator_neq)|[operator&gt;](#operator_gt_)|[operator&gt;=](#operator_gt__eq)|  
|[operator&lt;](#operator_lt_)|[operator&lt;=](#operator_lt__eq)|[operator==](#operator_eq_eq)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Tests if the stack object on the left side of the operator is not equal to stack object on the right side.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
### Return Value  
 **true** if the stacks or stacks are not equal; **false** if stacks or stacks are equal.  
  
### Remarks  
 The comparison between stacks objects is based on a pairwise comparison of their elements. Two stacks are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **The stacks s1 and s2 are not equal.**  
**The stacks s1 and s3 are equal.**    
##  \<a name="operator_lt_">\</a>  operator&lt;  
 Tests if the stack object on the left side of the operator is less than the stack object on the right side.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
### Return Value  
 **true** if the stack on the left side of the operator is less than and not equal to the stack on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between stack objects is based on a pairwise comparison of their elements. The less-than relationship between two stack objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The stack s1 is less than the stack s2.**  
**The stack s1 is greater than or equal to the stack s3.**  
**The stack s1 from the top down is: ( 8 6 4 2 ).**    
##  \<a name="operator_lt__eq">\</a>  operator&lt;=  
 Tests if the stack object on the left side of the operator is less than or equal to the stack object on the right side.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
### Return Value  
 **true** if the stack on the left side of the operator is less than or equal to the stack on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between stack objects is based on a pairwise comparison of their elements. The less than or equal to relationship between two stack objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The stack s1 is greater than the stack s2.**  
**The stack s1 is less than or equal to the stack s3.**    
##  \<a name="operator_eq_eq">\</a>  operator==  
 Tests if the stack object on the left side of the operator is equal to stack object on the right side.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
### Return Value  
 **true** if the stacks or stacks are equal; **false** if stacks or stacks are not equal.  
  
### Remarks  
 The comparison between stack objects is based on a pairwise comparison of their elements. Two stacks are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The stacks s1 and s2 are not equal.**  
**The stacks s1 and s3 are equal.**    
##  \<a name="operator_gt_">\</a>  operator&gt;  
 Tests if the stack object on the left side of the operator is greater than the stack object on the right side.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
### Return Value  
 **true** if the stack on the left side of the operator is greater than and not equal to the stack on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between stack objects is based on a pairwise comparison of their elements. The greater-than relationship between two stack objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The stack s1 is not greater than the stack s2.**  
**The stack s1 is greater than the stack s3.**    
##  \<a name="operator_gt__eq">\</a>  operator&gt;=  
 Tests if the stack object on the left side of the operator is greater than or equal to the stack object on the right side.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
### Return Value  
 **true** if the stack on the left side of the operator is strictly less than the stack on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between stack objects is based on a pairwise comparison of their elements. The greater than or equal to relationship between two stack objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **The stack s1 is less than the stack s2.**  
**The stack s1 is greater than or equal to the stack s3.**    
## See Also  
 [&lt;stack&gt;](../vs140/-stack-.md)