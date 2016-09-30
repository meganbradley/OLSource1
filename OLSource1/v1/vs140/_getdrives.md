---
title: "_getdrives"
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
  - "_getdrives"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "getdrives"
  - "_getdrives"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_getdrives function"
  - "getdrives function"
  - "disk drives"
ms.assetid: 869bb51f-4209-4328-846e-3aadebaceb9c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _getdrives
Returns a bitmask that represents the currently available disk drives.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If the function succeeds, the return value is a bitmask that represents the currently available disk drives. Bit position 0 (the least-significant bit) is drive A, bit position 1 is drive B, bit position 2 is drive C, and so on. If the function fails, the return value is zero. To get extended error information, call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|\<direct.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The following logical drives are being used:**  
**A:**  
**C:**  
**D:**  
**E:**   
## NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Directory Control](../vs140/directory-control.md)