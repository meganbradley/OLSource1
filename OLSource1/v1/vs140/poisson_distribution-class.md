---
title: "poisson_distribution Class"
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
  - "poisson_distribution"
  - "std.tr1.poisson_distribution"
  - "random/std::tr1::poisson_distribution"
  - "std::tr1::poisson_distribution"
  - "tr1.poisson_distribution"
  - "tr1::poisson_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "poisson_distribution class [TR1]"
  - "poisson_distribution class"
ms.assetid: 09614281-349a-45f7-8e95-c0196be0a937
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# poisson_distribution Class
Generates a Poisson distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The integer result type, defaults to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes a distribution that produces values of a user-specified integral type with a Poisson distribution. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[poisson_distribution::poisson_distribution](#poisson_distribution__poisson_distribution)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>||[poisson_distribution::param_type](#poisson_distribution__param_type)|  
  
 The property function <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns the value for stored distribution parameter <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
 For detailed information about the Poisson distribution, see the Wolfram MathWorld article                 [Poisson Distribution](http://go.microsoft.com/fwlink/?LinkId=401112).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 First test:  
  
 **Use CTRL-Z to bypass data entry and run using default values.Enter a floating point value for the 'mean' distribution parameter (must be greater than zero): 1Enter an integer value for the sample count: 100min() == 0max() == 2147483647p() == 1.0000000000Distribution for 100 samples:    0 ::::::::::::::::::::::::::::::    1 ::::::::::::::::::::::::::::::::::::::    2 :::::::::::::::::::::::    3 ::::::::    5 :** Second test:  
  
 **Use CTRL-Z to bypass data entry and run using default values.Enter a floating point value for the 'mean' distribution parameter (must be greater than zero): 10Enter an integer value for the sample count: 100min() == 0max() == 2147483647p() == 10.0000000000Distribution for 100 samples:    3 :    4 ::    5 ::    6 ::::::::    7 ::::    8 ::::::::    9 ::::::::::::::   10 ::::::::::::   11 ::::::::::::::::   12 :::::::::::::::   13 ::::::::   14 ::::::   15 :   16 ::   17 :**   
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
##  \<a name="poisson_distribution__poisson_distribution">\</a>  poisson_distribution::poisson_distribution  
 Constructs the distribution.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> distribution parameter.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The parameter structure used to construct the distribution.  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object whose stored parameters are initialized from <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. You can obtain and set the current parameters of an existing distribution by calling the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> member function.  
  
##  \<a name="poisson_distribution__param_type">\</a>  poisson_distribution::param_type  
 Stores the parameters of the distribution.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [poisson_distribution Class](../vs140/poisson_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)