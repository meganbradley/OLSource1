---
title: "geometric_distribution Class"
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
  - "std.tr1.geometric_distribution"
  - "random/std::tr1::geometric_distribution"
  - "tr1::geometric_distribution"
  - "tr1.geometric_distribution"
  - "geometric_distribution"
  - "std::tr1::geometric_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "geometric_distribution class"
  - "geometric_distribution class [TR1]"
ms.assetid: 38f933af-3b49-492e-9d26-b6b272a60013
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# geometric_distribution Class
Generates a geometric distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The integer result type, defaults to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes a distribution that produces values of a user-specified integral type with a geometric distribution. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[geometric_distribution::geometric_distribution](#geometric_distribution__geometric_distribution)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>||[geometric_distribution::param_type](#geometric_distribution__param_type)|  
  
 The property function <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns the value for stored distribution parameter <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
 For detailed information about the chi-squared distribution, see the Wolfram MathWorld article                 [Geometric Distribution](http://go.microsoft.com/fwlink/?LinkId=400529).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 First test:  
  
 **Use CTRL-Z to bypass data entry and run using default values.Enter a floating point value for the 'p' distribution parameter: .5Enter an integer value for the sample count: 100min() == 0max() == 2147483647p() == 0.5000000000Distribution for 100 samples:    0 ::::::::::::::::::::::::::::::::::::::::::::::::::::    1 ::::::::::::::::::::::::    2 ::::::::::::::    3 :::::    4 ::    5 ::    6 :** Second test:  
  
 **Use CTRL-Z to bypass data entry and run using default values.Enter a floating point value for the 'p' distribution parameter: .1Enter an integer value for the sample count: 100min() == 0max() == 2147483647p() == 0.1000000000Distribution for 100 samples:    0 :::::::::    1 :::::::::::    2 :::::::    3 ::::::::    4 ::::::::    5 ::::::    6 :::::    7 ::::::    8 :::::    9 ::::   10 ::::   11 ::   12 :   13 :   14 :::   15 ::::   16 :::   17 :   18 :   19 :   20 ::   21 :   22 :   23 :   28 ::   33 :   35 :   40 :**   
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
##  \<a name="geometric_distribution__geometric_distribution">\</a>  geometric_distribution::geometric_distribution  
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
  
##  \<a name="geometric_distribution__param_type">\</a>  geometric_distribution::param_type  
 Stores the parameters of the distribution.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [geometric_distribution Class](../vs140/geometric_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)