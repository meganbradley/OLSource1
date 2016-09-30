---
title: "chi_squared_distribution Class"
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
  - "std::tr1::chi_squared_distribution"
  - "chi_squared_distribution"
  - "random/std::tr1::chi_squared_distribution"
  - "std.tr1.chi_squared_distribution"
  - "tr1.chi_squared_distribution"
  - "tr1::chi_squared_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "chi_squared_distribution class"
ms.assetid: 9b603fbe-cafd-4a92-b8c5-a434d60b8122
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# chi_squared_distribution Class
Generates a chi-squared distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The floating-point result type, defaults to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes a distribution that produces values of a user-specified integral type, or type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if none is provided, distributed according to the Chi-Squared Distribution. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[chi_squared_distribution::chi_squared_distribution](../vs140/chi_squared_distribution-class.md)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>||[chi_squared_distribution::param_type](#chi_squared_distribution__param_type)|  
  
 The property function <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> returns the value for the stored distribution parameter <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
 For detailed information about the chi-squared distribution, see the Wolfram MathWorld article                 [Chi-Squared Distribution](http://go.microsoft.com/fwlink/?LinkId=400528).  
  
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
  
##  \<a name="chi_squared_distribution__chi_squared_distribution">\</a>  chi_squared_distribution::chi_squared_distribution  
 Constructs the distribution.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> distribution parameter.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The parameter structure used to construct the distribution.  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object whose stored parameters are initialized from <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. You can obtain and set the current parameters of an existing distribution by calling the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> member function.  
  
##  \<a name="chi_squared_distribution__param_type">\</a>  chi_squared_distribution::param_type  
 Stores the parameters of the distribution.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [chi_squared_distribution Class](../vs140/chi_squared_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)