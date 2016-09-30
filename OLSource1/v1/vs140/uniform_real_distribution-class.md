---
title: "uniform_real_distribution Class"
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
  - "tr1::uniform_real_distribution"
  - "std::tr1::uniform_real_distribution"
  - "random/std::tr1::uniform_real_distribution"
  - "uniform_real_distribution"
  - "std.tr1.uniform_real_distribution"
  - "tr1.uniform_real_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uniform_real_distribution class"
ms.assetid: 5cf906fd-0319-4984-b21b-98425cd7532d
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uniform_real_distribution Class
Generates a uniform (every value is equally probable) floating-point distribution  within an output range that is inclusive-exclusive.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The floating-point result type, defaults to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes an inclusive-exclusive distribution that produces values of a user-specified integral floating point type with a distribution so that every value is equally probable. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[uniform_real_distribution::uniform_real_distribution](#uniform_real_distribution__uniform_real_distribution)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|[uniform_real_distribution::param_type](#uniform_real_distribution__param_type)|  
  
 The property member <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns the currently stored minimum bound of the distribution, while <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns the currently stored maximum bound. For this distribution class, these minimum and maximum values are the same as those returned by the common property functions <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> described in the [\<random>](../vs140/-random-.md) topic.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 **Use CTRL-Z to bypass data entry and run using default values.Enter a floating point value for the lower bound of the distribution: .5Enter a floating point value for the upper bound of the distribution: 1Enter an integer value for the sample count: 20lower bound == 0.5upper bound == 1Distribution for 20 samples:          1: 0.5144304741          2: 0.6003997192          3: 0.6060792968          4: 0.6270416650          5: 0.6295091197          6: 0.6437749373          7: 0.6513740058          8: 0.7062379346          9: 0.7117609406         10: 0.7206888566         11: 0.7423223702         12: 0.7826033033         13: 0.8112872958         14: 0.8440467608         15: 0.8461254641         16: 0.8598305065         17: 0.8640874069         18: 0.8770968361         19: 0.9397858282         20: 0.9804645012**   
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
##  \<a name="uniform_real_distribution__uniform_real_distribution">\</a>  uniform_real_distribution::uniform_real_distribution  
 Constructs the distribution.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The lower bound for random values, inclusive.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The upper bound for random values, exclusive.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The parameter structure used to construct the distribution.  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and whose stored <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object whose stored parameters are initialized from <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. You can obtain and set the current parameters of an existing distribution by calling the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> member function.  
  
##  \<a name="uniform_real_distribution__param_type">\</a>  uniform_real_distribution::param_type  
 Stores all the parameters of the distribution.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [uniform_real_distribution Class](../vs140/uniform_real_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)