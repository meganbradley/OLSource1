---
title: "rand"
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
  - "rand"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "rand"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "generating pseudorandom numbers"
  - "random numbers, generating"
  - "numbers, pseudorandom"
  - "rand function"
  - "pseudorandom numbers"
  - "numbers, generating pseudorandom"
ms.assetid: 75d9df25-7aaf-4a88-b940-2775559634e8
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rand
Generates a pseudorandom number. A more secure version of this function is available, see [rand_s](../vs140/rand_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns a pseudorandom number, as described above. There is no error return.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function returns a pseudorandom integer in the range 0 to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (32767). Use the [srand](../vs140/srand.md) function to seed the pseudorandom-number generator before calling <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **22036**  
 **18330**  
 **11651**  
 **27464**  
 **18093**  
 **3284**  
 **11785**  
 **14686**  
 **11447**  
 **11285**  
 **74**  
 **48**  
 **27**  
 **65**  
 **96**  
 **64**  
 **-5**  
 **-42**  
 **-55**  
 **66**   
## .NET Framework Equivalent  
 [System::Random Class](https://msdn.microsoft.com/en-us/library/system.random.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [srand](../vs140/srand.md)   
 [rand_s](../vs140/rand_s.md)