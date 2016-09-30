---
title: "_finite, _finitef"
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
  - "_finite"
  - "_finitef"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "finite"
  - "_finite"
  - "_finitef"
  - "math/_finite"
  - "math/_finitef"
  - "float/_finite"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "finite function"
  - "_finite function"
  - "_finitef function"
ms.assetid: 5a7d7ca7-befb-4e1f-831d-28713c6eb805
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _finite, _finitef
Determines whether a floating-point value is finite.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The floating-point value to test.  
  
## Return Value  
 Both <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> return a nonzero value if the argument *x* is finite; that is, if –INF < <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> < +INF. It returns 0 if the argument is infinite or a NAN.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> functions are Microsoft specific. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function is only available when compiled for x86, ARM, or ARM64 platforms.  
  
## Requirements  
  
|Function|Required header (C)|Required header (C++)|  
|--------------|---------------------------|-------------------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|\<float.h> or \<math.h>|\<float.h>, \<math.h>, \<cfloat>, or \<cmath>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|\<math.h>|\<math.h> or \<cmath>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 [System::Double::IsInfinity](https://msdn.microsoft.com/en-us/library/system.double.isinfinity.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [isnan, _isnan, _isnanf](../vs140/isnan--_isnan--_isnanf.md)   
 [_fpclass, _fpclassf](../vs140/_fpclass--_fpclassf.md)