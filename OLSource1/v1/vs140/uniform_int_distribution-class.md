---
title: "uniform_int_distribution Class"
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
  - "tr1.uniform_int_distribution"
  - "random/std::tr1::uniform_int_distribution"
  - "uniform_int_distribution"
  - "tr1::uniform_int_distribution"
  - "std.tr1.uniform_int_distribution"
  - "std::tr1::uniform_int_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uniform_int_distribution class"
ms.assetid: a1867dcd-3bd9-4787-afe3-4b62692c1d04
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uniform_int_distribution Class
Generates a uniform (every value is equally probable) integer distribution within an output range that is inclusive-inclusive.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The integer result type, defaults to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes an inclusive-inclusive distribution that produces values of a user-specified integral type with a distribution so that every value is equally probable. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[uniform_int_distribution::uniform_int_distribution](#uniform_int_distribution__uniform_int_distribution)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|[uniform_int_distribution::param_type](#uniform_int_distribution__param_type)|  
  
 The property member <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns the currently stored minimum bound of the distribution, while <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns the currently stored maximum bound. For this distribution class, these minimum and maximum values are the same as those returned by the common property functions <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> described in the [\<random>](../vs140/-random-.md) topic.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 **Use CTRL-Z to bypass data entry and run using default values.Enter an integer value for the lower bound of the distribution: 0Enter an integer value for the upper bound of the distribution: 12Enter an integer value for the sample count: 200lower bound == 0upper bound == 12Distribution for 200 samples:    0 :::::::::::::::    1 :::::::::::::::::::::    2 ::::::::::::::::::    3 :::::::::::::::    4 :::::::    5 :::::::::::::::::::::    6 :::::::::::::    7 ::::::::::    8 :::::::::::::::    9 :::::::::::::   10 ::::::::::::::::::::::   11 :::::::::::::   12 :::::::::::::::::**   
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
##  \<a name="uniform_int_distribution__uniform_int_distribution">\</a>  uniform_int_distribution::uniform_int_distribution  
 Constructs the distribution.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The lower bound for random values, inclusive.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The upper bound for random values, inclusive.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The parameter structure used to construct the distribution.  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and whose stored <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object whose stored parameters are initialized from <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. You can obtain and set the current parameters of an existing distribution by calling the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> member function.  
  
##  \<a name="uniform_int_distribution__param_type">\</a>  uniform_int_distribution::param_type  
 Stores the parameters of the distribution.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [uniform_int_distribution Class](../vs140/uniform_int_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)