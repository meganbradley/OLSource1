---
title: "&lt;atomic&gt; enums"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: cd3a81c5-a19e-448f-952a-c34c717f21a9
caps.latest.revision: 13
---
# &lt;atomic&gt; enums
||  
|-|  
|[memory_order Enum](#memory_order_enum)|  
  
##  \<a name="memory_order_enum">\</a>  memory_order Enum  
 Supplies symbolic names for synchronization operations on memory locations. These operations affect how assignments in one thread become visible in another.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|No ordering required.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A load operation acts as a consume operation on the memory location.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|A load operation acts as an acquire operation on the memory location.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|A store operation acts as a release operation on the memory location.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Combines <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Combines <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Memory accesses that are marked as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> must be sequentially consistent.|  
  
## See Also  
 [&lt;atomic&gt;](../vs140/-atomic-.md)