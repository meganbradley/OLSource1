---
title: "&lt;functional&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: d4b3c760-f3e2-4b65-bdaa-d42e8dd6f5e1
caps.latest.revision: 13
---
# &lt;functional&gt; operators
|||  
|-|-|  
|[operator!=](#operator_neq)|[operator==](#operator_eq_eq)|  
  
##  \<a name="operator_eq_eq">\</a>  operator==  
 Tests if callable object is empty.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The function type to wrap.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The function object  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A null pointer.  
  
### Remarks  
 The operators both take an argument that is a reference to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object and an argument that is a null pointer constant. Both return true only if the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is empty.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **empty == true**  
**empty == false**    
##  \<a name="operator_neq">\</a>  operator!=  
 Tests if callable object is not empty.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The function type to wrap.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The function object  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A null pointer.  
  
### Remarks  
 The operators both take an argument that is a reference to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object and an argument that is a null pointer constant. Both return true only if the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object is not empty.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **not empty == false**  
**not empty == true**    
## See Also  
 [&lt;functional&gt;](../vs140/-functional-.md)