---
title: "_get_fmode"
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
  - "_get_fmode"
apilocation: 
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "get_fmode"
  - "_get_fmode"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_get_fmode function"
  - "file translation [C++], default mode"
  - "get_fmode function"
ms.assetid: 22ea70e2-b9b5-422d-b514-64f4beaea45c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _get_fmode
Gets the default file translation mode for file I/O operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an integer to be filled with the current default mode: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns zero if successful; an error code on failure. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the invalid parameter handler is invoked as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 The function gets the value of the [_fmode](../vs140/_fmode.md) global variable. This variable specifies the default file translation mode for both low-level and stream file I/O operations, such as <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|\<stdlib.h>|\<fcntl.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example in [_set_fmode](../vs140/_set_fmode.md).  
  
## NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [_fmode](../vs140/_fmode.md)   
 [_set_fmode](../vs140/_set_fmode.md)   
 [_setmode](../vs140/_setmode.md)   
 [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md)