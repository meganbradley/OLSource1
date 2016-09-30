---
title: "fisher_f_distribution Class"
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
  - "std.tr1.fisher_f_distribution"
  - "tr1.fisher_f_distribution"
  - "std::tr1::fisher_f_distribution"
  - "fisher_f_distribution"
  - "random/std::tr1::fisher_f_distribution"
  - "tr1::fisher_f_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fisher_f_distribution class"
ms.assetid: 9513b6ce-3309-4be1-829b-f504bca35bbf
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# fisher_f_distribution Class
Generates a Fisher F distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The floating-point result type, defaults to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes a distribution that produces values of a user-specified integral type, or type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if none is provided, distributed according to the Fisher's F-Distribution. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[fisher_f_distribution::fisher_f_distribution](#fisher_f_distribution__fisher_f_distribution)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|[fisher_f_distribution::param_type](#fisher_f_distribution__param_type)|  
  
 The property functions <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> return the values for the stored distribution parameters <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> respectively.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
 For detailed information about the F- distribution, see the Wolfram MathWorld article                 [F-Distribution](http://go.microsoft.com/fwlink/?LinkId=400899).  
  
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
  
##  \<a name="fisher_f_distribution__fisher_f_distribution">\</a>  fisher_f_distribution::fisher_f_distribution  
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
  
##  \<a name="fisher_f_distribution__param_type">\</a>  fisher_f_distribution::param_type  
 Stores the parameters of the distribution.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [extreme_value_distribution Class](../vs140/extreme_value_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)