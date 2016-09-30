---
title: "vector&lt;bool&gt;::operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 97738633-690d-4069-b2d9-8c54104fbfdd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector&lt;bool&gt;::operator
Returns a simulated reference to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The position of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element.|  
  
## Return Value  
 A [vector\<bool>::reference](../vs140/vector-bool---reference-class.md) or [vector\<bool>::const_reference](../vs140/vector-bool---const_reference.md) object that contains the value of the indexed element.  
  
 If the position specified is greater than or equal to the size of the container, the result is undefined.  
  
## Remarks  
 If you compile with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> set, a run-time error occurs if you attempt to access an element outside the bounds of the vector.  For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
 This code example shows the correct use of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and two common coding mistakes, which are commented out. These mistakes cause errors because the address of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object that <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns cannot be taken.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector\<bool> Class](../vs140/vector-bool--class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)