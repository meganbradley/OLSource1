---
title: "discard_block_engine Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "tr1.discard_block_engine"
  - "std.tr1.discard_block_engine"
  - "std::tr1::discard_block_engine"
  - "random/std::tr1::discard_block_engine"
  - "discard_block_engine"
  - "tr1::discard_block_engine"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "discard_block_engine class"
ms.assetid: aa84808e-38fe-4fa0-9f73-d5b9a653345b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# discard_block_engine Class
Generates a random sequence by discarding values returned by its base engine.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The base engine type.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Block size**. The number of values in each block.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Used block**. The number of values in each block that are used. The rest are discarded ( <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> - <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).                         **Precondition**: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Members  
  
||||  
|-|-|-|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
  
 For more information about engine members, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 This template class describes an engine adaptor that produces values by discarding some of the values returned by its base engine.  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)