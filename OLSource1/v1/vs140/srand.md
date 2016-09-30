---
title: "srand"
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
  - "srand"
apilocation: 
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "srand"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "random starting point"
  - "random starting point, setting"
  - "random numbers, generating"
  - "srand function"
  - "numbers, pseudorandom"
  - "numbers, random"
  - "pseudorandom numbers"
  - "starting points, setting random"
  - "starting points"
ms.assetid: 7bf56dc5-5692-4182-a3c1-18af98d2dd1a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# srand
Sets the starting seed value for the pseudorandom number generator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Seed for pseudorandom number generation  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function sets the starting point for generating a series of pseudorandom integers in the current thread. To reinitialize the generator to create the same sequence of results, call the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function and use the same <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument again. Any other value for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> sets the generator to a different starting point in the pseudorandom sequence. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> retrieves the pseudorandom numbers that are generated. Calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> before any call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> generates the same sequence as calling <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> passed as 1.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [rand](../vs140/rand.md).  
  
## .NET Framework Equivalent  
 [System::Random Class](https://msdn.microsoft.com/en-us/library/system.random.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [rand](../vs140/rand.md)