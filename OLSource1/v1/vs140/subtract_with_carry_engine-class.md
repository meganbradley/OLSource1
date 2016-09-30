---
title: "subtract_with_carry_engine Class"
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
  - "tr1.subtract_with_carry_engine"
  - "std::tr1::subtract_with_carry_engine"
  - "random/std::tr1::subtract_with_carry_engine"
  - "subtract_with_carry_engine"
  - "tr1::subtract_with_carry_engine"
  - "std.tr1.subtract_with_carry_engine"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "subtract_with_carry_engine class"
ms.assetid: 94a055f2-a620-4a22-ac34-c156924bab31
caps.latest.revision: 23
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# subtract_with_carry_engine Class
Generates a random sequence by the subtract-with-carry (lagged Fibonacci) algorithm.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The unsigned integer result type. For possible types, see [\<random>](../vs140/-random-.md).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Word size**. Size of each word, in bits, of the state sequence.                         **Precondition**: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Short lag**. Number of integer values.                         **Precondition**: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **Long lag**. Determines recurrence in the series generated.  
  
## Members  
  
||||  
|-|-|-|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a member constant, defined as <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, used as the default parameter value for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and the single value constructor.|||  
  
 For more information about engine members, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> template class is an improvement over the [linear_congruential_engine](../vs140/linear_congruential_engine-class.md). Neither for these engines is as fast or with as high quality results as the [mersenne_twister_engine](../vs140/mersenne_twister_engine-class.md).  
  
 This engine produces values of a user-specified unsigned integral type using the recurrence relation ( *period*) <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> has the value <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, otherwise <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> has the value <CodeContentPlaceHolder>23\</CodeContentPlaceHolder><sup>W\</sup>. The engine's state is a carry indicator plus <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> values. These values consist of the last <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> values returned if <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> has been called at least <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> times, otherwise the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> values that have been returned and the last <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> values of the seed.  
  
 The template argument <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> must be large enough to hold values up to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 Although you can construct a generator from this engine directly, you can also use one of these predefined typedefs:  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>: Used as a base for <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.                   
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>: Used as a base for <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.                   
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
 For detailed information about the subract with carry engine algorithm, see the Wikipedia article                 [Lagged Fibonacci generator](http://go.microsoft.com/fwlink/?LinkId=402445).  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)