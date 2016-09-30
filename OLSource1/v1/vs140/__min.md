---
title: "__min"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "__min"
apilocation: 
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "__min"
  - "min"
  - "_min"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "__min macro"
  - "min macro"
  - "minimum macro"
  - "_min macro"
ms.assetid: 2037f26c-b48a-4a69-8870-22519f052a3c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __min
Returns the smaller of two values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Any numeric data type.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Values of any numeric type to be compared.  
  
## Return Value  
 The smaller of the two arguments.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro compares two values and returns the value of the smaller one. The arguments can be of any numeric data type, signed or unsigned. Both arguments and the return value must be of the same data type.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The larger of 10 and 21 is 21**  
**The smaller of 10 and 21 is 10**   
## .NET Framework Equivalent  
 [System::Math::Min](https://msdn.microsoft.com/en-us/library/system.math.min.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [__max](../vs140/__max.md)