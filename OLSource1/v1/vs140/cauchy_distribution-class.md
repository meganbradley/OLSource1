---
title: "cauchy_distribution Class"
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
  - "cauchy_distribution"
  - "random/std::tr1::cauchy_distribution"
  - "std::tr1::cauchy_distribution"
  - "std.tr1.cauchy_distribution"
  - "tr1::cauchy_distribution"
  - "tr1.cauchy_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cauchy_distribution class"
ms.assetid: 21522351-f2f1-46d9-97f0-d358c932356c
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cauchy_distribution Class
Generates a Cauchy distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The floating-point result type, defaults to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes a distribution that produces values of a user-specified integral type, or type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if none is provided, distributed according to the Cauchy Distribution. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[cauchy_distribution::cauchy_distribution](#cauchy_distribution__cauchy_distribution)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|[cauchy_distribution::param_type](#cauchy_distribution__param_type)|  
  
 The property functions <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> return their respective values for stored distribution parameters <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
 For detailed information about the cauchy distribution, see the Wolfram MathWorld article                 [Cauchy Distribution](http://go.microsoft.com/fwlink/?LinkId=400523).  
  
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
  
##  \<a name="cauchy_distribution__cauchy_distribution">\</a>  cauchy_distribution::cauchy_distribution  
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
 **Precondition:** <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and whose stored <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object whose stored parameters are initialized from <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. You can obtain and set the current parameters of an existing distribution by calling the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> member function.  
  
##  \<a name="cauchy_distribution__param_type">\</a>  cauchy_distribution::param_type  
 Stores all the parameters of the distribution.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [cauchy_distribution Class](../vs140/cauchy_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)