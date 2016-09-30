---
title: "negative_binomial_distribution Class"
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
  - "tr1::negative_binomial_distribution"
  - "tr1.negative_binomial_distribution"
  - "std.tr1.negative_binomial_distribution"
  - "random/std::tr1::negative_binomial_distribution"
  - "std::tr1::negative_binomial_distribution"
  - "negative_binomial_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "negative_binomial_distribution class"
ms.assetid: 7f5f0967-7fdd-4578-99d4-88f292b4fe9c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# negative_binomial_distribution Class
Generates a negative binomial distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The integer result type, defaults to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes a distribution that produces values of a user-specified integral type, or type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if none is provided, distributed according to the Negative Binomial Distribution discrete probability function. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[negative_binomial_distribution::negative_binomial_distribution](#negative_binomial_distribution__negative_binomial_distribution)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|[negative_binomial_distribution::param_type](#negative_binomial_distribution__param_type)|  
  
 The property members <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> return the currently stored distribution parameter values <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> respectively.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
 For detailed information about the negative binomial distribution discrete probability function, see the Wolfram MathWorld article                 [Negative Binomial Distribution](http://go.microsoft.com/fwlink/?LinkId=400516).  
  
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
  
##  \<a name="negative_binomial_distribution__negative_binomial_distribution">\</a>  negative_binomial_distribution::negative_binomial_distribution  
 Constructs the distribution.  
  
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
  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and whose stored <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object whose stored parameters are initialized from <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. You can obtain and set the current parameters of an existing distribution by calling the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> member function.  
  
##  \<a name="negative_binomial_distribution__param_type">\</a>  negative_binomial_distribution::param_type  
 Stores the parameters of the distribution.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [negative_binomial_distribution Class](../vs140/negative_binomial_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)