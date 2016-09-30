---
title: "lognormal_distribution Class"
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
  - "std.tr1.lognormal_distribution"
  - "tr1.lognormal_distribution"
  - "tr1::lognormal_distribution"
  - "std::tr1::lognormal_distribution"
  - "lognormal_distribution"
  - "random/std::tr1::lognormal_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lognormal_distribution class"
ms.assetid: f2d6a431-6c3a-4370-b12e-4adb4ddf6cc4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lognormal_distribution Class
Generates a log normal distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The floating-point result type, defaults to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes a distribution that produces values of a user-specified integral type, or type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if none is provided, distributed according to the Log Normal Distribution. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[lognormal_distribution::lognormal_distribution](#lognormal_distribution__lognormal_distribution)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|[lognormal_distribution::param_type](#lognormal_distribution__param_type)|  
  
 The property functions <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> return the values for the stored distribution parameters <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> respectively.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
 For detailed information about the LogNormal distribution, see the Wolfram MathWorld article                 [LogNormal Distribution](http://go.microsoft.com/fwlink/?LinkId=400917).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
##  \<a name="lognormal_distribution__lognormal_distribution">\</a>  lognormal_distribution::lognormal_distribution  
 Constructs the distribution.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> distribution parameter.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> distribution parameter.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The parameter structure used to construct the distribution.  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and whose stored <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object whose stored parameters are initialized from <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. You can obtain and set the current parameters of an existing distribution by calling the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> member function.  
  
##  \<a name="lognormal_distribution__param_type">\</a>  lognormal_distribution::param_type  
 Stores the parameters of the distribution.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [lognormal_distribution Class](../vs140/lognormal_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)