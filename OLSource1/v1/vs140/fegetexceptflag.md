---
title: "fegetexceptflag"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "fegetexceptflag"
apilocation: 
  - "api-ms-win-crt-runtime-l1-1-0.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fegetexceptflag"
  - "fenv/fegetexceptflag"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "fegetexceptflag function"
ms.assetid: 2d28f0ca-70c9-4cff-be8b-3d876eacde71
caps.latest.revision: 11
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# fegetexceptflag
Stores the current state of the specified floating-point exception flags.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object to contain the current values of the  exception flags specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The floating-point exception flags to store in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 On success, returns 0. Otherwise, returns a non-zero value.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function stores the current state of the floating-point exception status flags specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object pointed to by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> must point to a valid <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object, or subsequent behavior is undefined. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function supports these exception macros, defined in \<fenv.h>:  
  
|Exception Macro|Description|  
|---------------------|-----------------|  
|FE_DIVBYZERO|A singularity or pole error occurred in an earlier floating-point operation; an infinity value was created.|  
|FE_INEXACT|The function was forced to round the stored result of an earlier floating-point operation.|  
|FE_INVALID|A domain error occurred in an earlier floating-point operation.|  
|FE_OVERFLOW|A range error occurred; an earlier floating-point operation result was too large to be represented.|  
|FE_UNDERFLOW|An earlier floating-point operation result was too small to be represented at full precision; a denormal value was created.|  
|FE_ALLEXCEPT|The bitwise OR of all supported floating-point exceptions.|  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> argument may be zero, one of the supported floating-point exception macros, or the bitwise OR of two or more of the macros. The effect of any other argument value is undefined.  
  
 To use this function, you must turn off floating-point optimizations that could prevent access by using the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> directive prior to the call. For more information, see [fenv_access](../vs140/fenv_access.md).  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<fenv.h>|\<cfenv>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [fesetexceptflag](../vs140/fesetexceptflag.md)