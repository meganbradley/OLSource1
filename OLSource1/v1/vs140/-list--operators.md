---
title: "&lt;list&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 8103d8f2-c30f-49ad-ac50-b3ba6a907ebe
caps.latest.revision: 9
---
# &lt;list&gt; operators
||||  
|-|-|-|  
|[operator!=](#operator_neq)|[operator&gt;](#operator_gt_)|[operator&gt;=](#operator_gt__eq)|  
|[operator&lt;](#operator_lt_)|[operator&lt;=](#operator_lt__eq)|[operator==](#operator_eq_eq)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Tests if the list object on the left side of the operator is not equal to the list object on the right side.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 An object of type **list**.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 An object of type **list**.  
  
### Return Value  
 **true** if the lists are not equal; **false** if the lists are equal.  
  
### Remarks  
 The comparison between list objects is based on a pairwise comparison of their elements. Two lists are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="operator_lt_">\</a>  operator&lt;  
 Tests if the list object on the left side of the operator is less than the list object on the right side.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 An object of type **list**.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 An object of type **list**.  
  
### Return Value  
 **true** if the list on the left side of the operator is less than but not equal to the list on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between list objects is based on a pairwise comparison of their elements. The less-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="operator_lt__eq">\</a>  operator&lt;=  
 Tests if the list object on the left side of the operator is less than or equal to the list object on the right side.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 An object of type **list**.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 An object of type **list**.  
  
### Return Value  
 **true** if the list on the left side of the operator is less than or equal to the list on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between list objects is based on a pairwise comparison of their elements. The less than or equal to relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="operator_eq_eq">\</a>  operator==  
 Tests if the list object on the left side of the operator is equal to the list object on the right side.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 An object of type **list**.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 An object of type **list**.  
  
### Return Value  
 **true** if the list on the left side of the operator is equal to the list on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between list objects is based on a pairwise comparison of their elements. Two lists are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="operator_gt_">\</a>  operator&gt;  
 Tests if the list object on the left side of the operator is greater than the list object on the right side.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 An object of type **list**.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 An object of type **list**.  
  
### Return Value  
 **true** if the list on the left side of the operator is greater than the list on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between list objects is based on a pairwise comparison of their elements. The greater-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="operator_gt__eq">\</a>  operator&gt;=  
 Tests if the list object on the left side of the operator is greater than or equal to the list object on the right side.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 An object of type **list**.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 An object of type **list**.  
  
### Return Value  
 **true** if the list on the left side of the operator is greater than or equal to the list on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between list objects is based on a pairwise comparison of their elements. The greater than or equal to relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## See Also  
 [&lt;list&gt;](../vs140/-list-.md)