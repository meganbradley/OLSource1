---
title: "&lt;random&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 2ac9ec59-619b-4b85-a425-f729277c1bc8
caps.latest.revision: 13
---
# &lt;random&gt; functions
||  
|-|  
|[generate_canonical](#generate_canonical)|  
  
##  \<a name="generate_canonical">\</a>  generate_canonical  
 Returns a floating-point value from a random sequence.  
  
> [!NOTE]
>  The ISO C++ Standard states that this function should return values in the range [ <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>). Visual Studio is not yet compliant with this constraint. As a workaround to generate values in this range, use [uniform_real_distribution](../vs140/uniform_real_distribution-class.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The floating point integral type. For possible types, see [\<random>](../vs140/-random-.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The random number generator.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The random number generator.  
  
### Remarks  
 The template function calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> repeatedly and packs the returned values into a floating-point value <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> until it has gathered the specified number of mantissa bits in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The specified number is the smaller of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (which must be nonzero) and the full number of mantissa bits in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The first call supplies the lowest-order bits. The function returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## See Also  
 [&lt;random&gt;](../vs140/-random-.md)