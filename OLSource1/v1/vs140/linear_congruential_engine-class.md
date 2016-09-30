---
title: "linear_congruential_engine Class"
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
  - "std.tr1.linear_congruential_engine"
  - "random/std::tr1::linear_congruential_engine"
  - "linear_congruential_engine"
  - "std::tr1::linear_congruential_engine"
  - "tr1.linear_congruential_engine"
  - "tr1::linear_congruential_engine"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "linear_congruential_engine class"
ms.assetid: 30e00ca6-1933-4701-9561-54f3e810a5a1
caps.latest.revision: 24
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# linear_congruential_engine Class
Generates a random sequence by the linear congruential algorithm.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The unsigned integer result type. For possible types, see [\<random>](../vs140/-random-.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Multiplier**.                         **Precondition**: See Remarks section.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Increment**.                         **Precondition**: See Remarks section.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **Modulus**.                         **Precondition**: See remarks.  
  
## Members  
  
||||  
|-|-|-|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a member constant, defined as <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, used as the default parameter value for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and the single value constructor.  
  
 For more information about engine members, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> template class is the simplest generator engine, but not the fastest or highest quality. An improvement over this engine is the [substract_with_carry_engine](../vs140/subtract_with_carry_engine-class.md). Neither of these engines is as fast or with as high quality results as the [mersenne_twister_engine](../vs140/mersenne_twister_engine-class.md).  
  
 This engine produces values of a user-specified unsigned integral type using the recurrence relation ( *period*) <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is zero, the value used for this modulus operation is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. The engine's state is the last value returned, or the seed value if no call has been made to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is not zero, the values of the template arguments <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> must be less than <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 Although you can construct a generator from this engine directly, you can also use one of these predefined typedefs.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>: 1988 minimal standard engine (Lewis, Goodman, and Miller, 1969).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>: Updated minimal standard engine <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> (Park, Miller, and Stockmeyer, 1993).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For detailed information about the linear congruential engine algorithm, see the Wikipedia article                 [Linear congruential generator](http://go.microsoft.com/fwlink/?LinkId=402446).  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)