---
title: "atan2 (&lt;valarray&gt;)"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::atan2"
  - "std.atan2"
  - "atan2"
  - "valarray/std::atan2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "atan2 function"
ms.assetid: fdf80ad4-958a-4485-b003-2b6fb344cbde
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# atan2 (&lt;valarray&gt;)
Returns a valarray whose elements are equal to the arctangent of the Cartesian components specified by a combination of constants and elements of valarrays.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The constant numerical data type or input valarray whose elements provide the values for the y-coordinate of the arctangent argument.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The constant numerical data type or input valarray whose elements provide the values for the x-coordinate of the arctangent argument.  
  
## Return Value  
 A valarray whose elements <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are equal to the arctangent of:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> [ *I* ] / *_Righ*t [ *I* ] for the first template function.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> [ *I* ] / <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for the second template function.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> [ *I* ] for the third template function.  
  
## Remarks  
 The units of the returned elements are in radians.  
  
 This function preserves information about the signs of the components in the argument that is lost by the standard tangent function, and this knowledge of the quadrant enables the return value to be assigned a unique angle between +pi and –pi.  
  
 If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> have a different number of elements, the result is undefined.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial valarray for the x coordinate is: ( 1 -1 -1 1 ).**  
**The initial valarray for the y coordinate is: ( 1 1 -1 -1 ).**  
**The atan2 ( y / x ) of the initial valarrays is:**  
 **0.785398  radians, which is           45degrees**  
 **2.35619  radians, which is          135degrees**  
 **-2.35619  radians, which is         -135degrees**  
 **-0.785398  radians, which is          -45degrees**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std