---
title: "_close"
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
  - "_close"
apilocation: 
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_close"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_close function"
  - "close function"
  - "files [C++], closing"
ms.assetid: 4708a329-8acf-4cd9-b7b0-a952e1897247
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _close
Closes a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 File descriptor referring to the open file.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns 0 if the file was successfully closed. A return value of –1 indicates an error.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function closes the file associated with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 The file descriptor and the underlying OS file handle are closed. Thus, it is not necessary to call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the file was originally opened using the Win32 function <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and converted to a file descriptor using <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 This function validates its parameters. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a bad file descriptor, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions returns -1 and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<io.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [_open](../vs140/_open--_wopen.md).  
  
## See Also  
 [Low-Level I/O](../vs140/low-level-i-o.md)   
 [_chsize](../vs140/_chsize.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [_dup, _dup2](../vs140/_dup--_dup2.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_unlink, _wunlink](../vs140/_unlink--_wunlink.md)