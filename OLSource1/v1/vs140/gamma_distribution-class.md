---
title: "gamma_distribution Class"
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
  - "random/std::tr1::gamma_distribution"
  - "std::tr1::gamma_distribution"
  - "std.tr1.gamma_distribution"
  - "tr1.gamma_distribution"
  - "tr1::gamma_distribution"
  - "gamma_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "gamma_distribution class [TR1]"
  - "gamma_distribution class"
ms.assetid: 2a6798ac-6152-41d7-8ef6-d684d92f1572
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# gamma_distribution Class
Generates a gamma distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The floating-point result type, defaults to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes a distribution that produces values of a user-specified integral type, or type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if none is provided, distributed according to the Gamma Distribution. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[gamma_distribution::gamma_distribution](#gamma_distribution__gamma_distribution)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|[gamma_distribution::param_type](#gamma_distribution__param_type)|  
  
 The property functions <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> return their respective values for stored distribution parameters <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
 For detailed information about the gamma distribution, see the Wolfram MathWorld article                 [Gamma Distribution](http://go.microsoft.com/fwlink/?LinkId=401111).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
##  \<a name="gamma_distribution__gamma_distribution">\</a>  gamma_distribution::gamma_distribution  
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
 **Precondition:** <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and whose stored <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object whose stored parameters are initialized from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. You can obtain and set the current parameters of an existing distribution by calling the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> member function.  
  
##  \<a name="gamma_distribution__param_type">\</a>  gamma_distribution::param_type  
 Stores the parameters of the distribution.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [gamma_distribution Class](../vs140/gamma_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)