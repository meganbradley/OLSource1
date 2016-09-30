---
title: "independent_bits_engine Class"
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
  - "std.tr1.independent_bits_engine"
  - "std::tr1::independent_bits_engine"
  - "tr1::independent_bits_engine"
  - "tr1.independent_bits_engine"
  - "independent_bits_engine"
  - "random/std::tr1::independent_bits_engine"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "independent_bits_engine class"
ms.assetid: 889e9a82-f457-49a7-9d2e-26e0fc3cd907
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# independent_bits_engine Class
Generates a random sequence of numbers with a specified number of bits by repacking bits from the values returned by its base engine.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The base engine type.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Word size**. Size, in bits, of each number generated.                         **Precondition**: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The unsigned integer result type. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Members  
  
||||  
|-|-|-|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
  
 For more information about engine members, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 This template class describes an *engine adaptor* that produces values by repacking bits from the values returned by its base engine, resulting in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>-bit values.  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)