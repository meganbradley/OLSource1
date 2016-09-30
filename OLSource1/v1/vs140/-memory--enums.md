---
title: "&lt;memory&gt; enums"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: b9be0a7b-0beb-40b2-8183-911de371c6b9
caps.latest.revision: 13
---
# &lt;memory&gt; enums
||  
|-|  
|[pointer_safety Enumeration](#pointer_safety_enumeration)|  
  
##  \<a name="pointer_safety_enumeration">\</a>  pointer_safety Enumeration  
 The enumeration of possible values returned by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
 The scoped <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> defines the values that can be returned by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> -- pointers not safely derived (obviously pointers to declared or allocated objects) are treated the same as those safely derived.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> -- as before, but pointers not safely derived should not be dereferenced.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> -- pointers not safely derived might be treated differently than those safely derived.  
  
## See Also  
 [&lt;memory&gt;](../vs140/-memory-.md)