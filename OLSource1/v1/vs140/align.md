---
title: "align"
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
ms.assetid: 302b5954-9ed5-4b7a-888a-eb04f69414ba
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# align
Fits storage of the given size—aligned by the given alignment specification—into the first possible address of the given storage.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The alignment bound to attempt.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size in bytes for the aligned storage.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The starting address of the available contiguous storage pool to use. This parameter is also an output parameter, and will contain the new starting address if the alignment is successful.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is unsuccessful, this parameter is not modified.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The total space available to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to use in creating the aligned storage. This parameter is also an output parameter, and contains the adjusted space left in the storage buffer after the aligned storage and any associated overhead is subtracted.  
  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is unsuccessful, this parameter is not modified.  
  
## Return Value  
 A null pointer if the requested aligned buffer would not fit into the available space; otherwise, the new value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 The modified <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameters enable you to call <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> repeatedly on the same buffer, possibly with different values for <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The following code snippet shows one use of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [\<memory>](../vs140/-memory-.md)