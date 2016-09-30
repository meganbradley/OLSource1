---
title: "__max"
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
  - "__max"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "max"
  - "__max"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "max macro"
  - "maximum macro"
  - "__max macro"
ms.assetid: 05c936f6-0e22-45d6-a58d-4bc102e9dae2
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __max
Returns the larger of two values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Any numeric data type.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Values of any numeric type to be compared.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns the larger of its arguments.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro compares two values and returns the value of the larger one. The arguments can be of any numeric data type, signed or unsigned. Both arguments and the return value must be of the same data type.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
## Example  
 For more information, see the example for [__min](../vs140/__min.md).  
  
## .NET Framework Equivalent  
 [System::Math::Max](https://msdn.microsoft.com/en-us/library/system.math.max.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [__min](../vs140/__min.md)