---
title: "fpclassify"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "fpclassify"
apitype: "HeaderDef"
f1_keywords: 
  - "fpclassify"
  - "math/fpclassify"
helpviewer_keywords: 
  - "fpclassify macro"
  - "fpclassify function"
ms.assetid: bf549499-7ff9-4a58-8692-f2d1cb6bab81
caps.latest.revision: 7
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# fpclassify
Returns the floating-point classification of the argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The floating-point value to test.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns an integer value that indicates the floating-point class of the argument <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This table shows the possible values returned by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, defined in \<math.h>.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|A quiet, signaling, or indeterminate NaN|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|A positive or negative infinity|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|A positive or negative normalized non-zero value|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|A positive or negative denormalized value|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|A positive or negative zero value|  
  
## Remarks  
 In C, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a macro; in C++, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a function overloaded using argument types of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. In either case, the value returned depends on the effective type of the argument expression, and not on any intermediate representation. For example, a normal <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value can become an infinity, denormal, or zero value when converted to a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function/Macro|Required header (C)|Required header (C++)|  
|---------------------|---------------------------|-------------------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<math.h>|\<math.h> or \<cmath>|  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> macro and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> functions conform to the C99 and C++11 specifications. For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [isnan, _isnan, _isnanf](../vs140/isnan--_isnan--_isnanf.md)