---
title: "fesetexceptflag"
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
  - "fesetexceptflag"
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
  - "fesetexceptflag"
  - "fenv/fesetexceptflag"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "fesetexceptflag function"
ms.assetid: 2f7dad77-9e54-4097-a3e3-35176ace4de5
caps.latest.revision: 11
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# fesetexceptflag
Sets the specified floating-point status flags in the current floating-point environment.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to an  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object containing the values to set the exception status flags to. The object may be set by a previous call to [fegetexceptflag](assetId:///5031bc1a-9834-4573-9113-160a55eb9654).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The floating-point exception status flags to set.  
  
## Return Value  
 If all the specified exception status flags are set successfully, returns 0. Otherwise, returns     a nonzero value.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function sets the state of the floating-point exception status flags specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to the corresponding values set in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object pointed to by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  It does not raise the exceptions. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> pointer must point to a valid <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object, or subsequent behavior is undefined. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function supports these exception macro values in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, defined in \<fenv.h>:  
  
|Exception Macro|Description|  
|---------------------|-----------------|  
|FE_DIVBYZERO|A singularity or pole error occurred in an earlier floating-point operation; an infinity value was created.|  
|FE_INEXACT|The function was forced to round the stored result of an earlier floating-point operation.|  
|FE_INVALID|A domain error occurred in an earlier floating-point operation.|  
|FE_OVERFLOW|A range error occurred; an earlier floating-point operation result was too large to be represented.|  
|FE_UNDERFLOW|An earlier floating-point operation result was too small to be represented at full precision; a denormal value was created.|  
|FE_ALLEXCEPT|The bitwise OR of all supported floating-point exceptions.|  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> argument may be zero, one of the supported floating-point exception macros, or the bitwise OR of two or more of the macros. The effect of any other argument value is undefined.  
  
 To use this function, you must turn off floating-point optimizations that could prevent access by using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> directive prior to the call. For more information, see [fenv_access](../vs140/fenv_access.md).  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|\<fenv.h>|\<cfenv>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [fegetexceptflag](../vs140/fegetexceptflag.md)