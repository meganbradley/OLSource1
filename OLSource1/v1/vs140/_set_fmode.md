---
title: "_set_fmode"
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
  - "_set_fmode"
apilocation: 
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_set_fmode"
  - "set_fmode"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "file translation [C++], default mode"
  - "_set_fmode function"
  - "file translation [C++], setting mode"
  - "set_fmode function"
ms.assetid: f80eb9c7-733b-4652-a9bc-6b3790a35f12
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _set_fmode
Sets the default file translation mode for file I/O operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The file translation mode desired: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns zero if successful, an error code on failure. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 The function sets the [_fmode](../vs140/_fmode.md) global variable. This variable specifies the default file translation mode for the file I/O operations <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are defined in Fcntl.h. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is defined in Errno.h.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|\<stdlib.h>|\<fcntl.h>, \<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Default Mode is binary**  
**A   B   C   D   E   F   G   H   I   J   K   L**    
## See Also  
 [_fmode](../vs140/_fmode.md)   
 [_get_fmode](../vs140/_get_fmode.md)   
 [_setmode](../vs140/_setmode.md)   
 [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md)