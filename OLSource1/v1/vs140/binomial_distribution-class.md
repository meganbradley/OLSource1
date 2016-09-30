---
title: "binomial_distribution Class"
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
  - "std::tr1::binomial_distribution"
  - "std.tr1.binomial_distribution"
  - "tr1::binomial_distribution"
  - "random/std::tr1::binomial_distribution"
  - "tr1.binomial_distribution"
  - "binomial_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "binomial_distribution class [TR1]"
  - "binomial_distribution class"
ms.assetid: b7c8a26a-da8c-45a5-a3a8-208f7a3609ce
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# binomial_distribution Class
Generates a binomial distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The integer result type, defaults to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes a distribution that produces values of a user-specified integral type, or type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if none is provided, distributed according to the Binomial Distribution discrete probability function. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[binomial_distribution::binomial_distribution](#binomial_distribution__binomial_distribution)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|[binomial_distribution::param_type](#binomial_distribution__param_type)|  
  
 The property members <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> return the currently stored distribution parameter values <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> respectively.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
 For detailed information about the binomial distribution discrete probability function, see the Wolfram MathWorld article                 [Binomial Distribution](http://go.microsoft.com/fwlink/?LinkId=398469).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 First run:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Second run:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Third run:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
##  \<a name="binomial_distribution__binomial_distribution">\</a>  binomial_distribution::binomial_distribution  
 Constructs the distribution.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> distribution parameter.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> distribution parameter.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The parameter structure used to construct the distribution.  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and whose stored <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object whose stored parameters are initialized from <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. You can obtain and set the current parameters of an existing distribution by calling the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> member function.  
  
 For more information and a code example, see [binomial_distribution Class](../vs140/binomial_distribution-class.md).  
  
##  \<a name="binomial_distribution__param_type">\</a>  binomial_distribution::param_type  
 Stores all the parameters of the distribution.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [binomial_distribution Class](../vs140/binomial_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)