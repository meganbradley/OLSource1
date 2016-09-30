---
title: "fegetenv"
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
  - "fetegenv"
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
  - "fegetenv"
  - "fenv/fegetenv"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "fetegenv function"
ms.assetid: 68962421-6978-4b27-8e4c-ad1577830cf6
caps.latest.revision: 11
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# fegetenv
Stores the current floating-point environment in the specified object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object to contain the current floating-point environment values.  
  
## Return Value  
 Returns 0 if the floating-point environment was successfully stored in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Otherwise, returns a non-zero value.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function stores the current floating-point environment in the object pointed to by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The floating point environment is the set of status flags and control modes that affect floating-point calculations. This includes the rounding direction mode and the status flags for floating-point exceptions.  If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> does not point to a valid <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object, subsequent behavior is undefined.  
  
 To use this function, you must turn off floating-point optimizations that could prevent access by using the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> directive prior to the call. For more information, see [fenv_access](../vs140/fenv_access.md).  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|\<fenv.h>|\<cfenv>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [fesetenv](../vs140/fesetenv.md)