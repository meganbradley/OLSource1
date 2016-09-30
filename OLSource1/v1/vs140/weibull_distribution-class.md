---
title: "weibull_distribution Class"
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
  - "std.tr1.weibull_distribution"
  - "weibull_distribution"
  - "tr1::weibull_distribution"
  - "std::tr1::weibull_distribution"
  - "tr1.weibull_distribution"
  - "random/std::tr1::weibull_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "weibull_distribution class"
ms.assetid: f20b49d3-1b9a-41af-8db4-baf800eaa02b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# weibull_distribution Class
Generates a Weibull distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The floating-point result type, defaults to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes a distribution that produces values of a user-specified integral type, or type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if none is provided, distributed according to the Weibull Distribution. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[weibull_distribution::weibull_distribution](#weibull_distribution__weibull_distribution)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|[weibull_distribution::param_type](#weibull_distribution__param_type)|  
  
 The property functions <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> return their respective values for stored distribution parameters <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
 For detailed information about the Weibull distribution, see the Wolfram MathWorld article                 [Weibull Distribution](http://go.microsoft.com/fwlink/?LinkId=401115).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 First run:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Second run:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
##  \<a name="weibull_distribution__weibull_distribution">\</a>  weibull_distribution::weibull_distribution  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> distribution parameter.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> distribution parameter.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The parameter structure used to construct the distribution.  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>value holds the value <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and whose stored <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object whose stored parameters are initialized from <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. You can obtain and set the current parameters of an existing distribution by calling the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> member function.  
  
##  \<a name="weibull_distribution__param_type">\</a>  weibull_distribution::param_type  
 Stores the parameters of the distribution.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [weibull_distribution Class](../vs140/weibull_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)