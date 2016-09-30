---
title: "Math Error Constants"
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
  - "_PLOSS"
  - "_UNDERFLOW"
  - "_TLOSS"
  - "_SING"
  - "_DOMAIN"
  - "_OVERFLOW"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_TLOSS constant"
  - "_SING constant"
  - "PLOSS constant"
  - "UNDERFLOW constant"
  - "_UNDERFLOW constant"
  - "_OVERFLOW constant"
  - "DOMAIN constant"
  - "OVERFLOW constant"
  - "TLOSS constant"
  - "SING constant"
  - "_DOMAIN constant"
  - "_PLOSS constant"
  - "math error constants"
ms.assetid: 4be933a6-674e-45a5-8ac9-090023542f5b
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Math Error Constants
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The math routines of the run-time library can generate math error constants.  
  
 These errors, described as follows, correspond to the exception types defined in MATH.H and are returned by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function when a math error occurs.  
  
|Constant|Meaning|  
|--------------|-------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Argument to function is outside domain of function.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Result is too large to be represented in function's return type.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Partial loss of significance occurred.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Argument singularity: argument to function has illegal value. (For example, value 0 is passed to function that requires nonzero value.)|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Total loss of significance occurred.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Result is too small to be represented.|  
  
## See Also  
 [_matherr](../vs140/_matherr.md)   
 [Global Constants](../vs140/global-constants.md)