---
title: "tmpfile_s"
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
  - "tmpfile_s"
apilocation: 
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "tmpfile_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "temporary files"
  - "tmpfile_s function"
  - "temporary files, creating"
ms.assetid: 50879c69-215e-425a-a2a3-8b5467121eae
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tmpfile_s
Creates a temporary file. It is a version of [tmpfile](../vs140/tmpfile.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The address of a pointer to store the address of the generated pointer to a stream.  
  
## Return Value  
 Returns 0 if successful, an error code on failure.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|**Return Value**|**Contents of**  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|----------------|----------------------|---------------------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|not changed|  
  
 If the above parameter validation error occurs, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and the return value is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function creates a temporary file and puts a pointer to that stream in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> argument. The temporary file is created in the root directory. To create a temporary file in a directory other than the root, use [tmpnam_s](../vs140/tmpnam_s--_wtmpnam_s.md) or [tempnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md) in conjunction with [fopen](../vs140/fopen--_wfopen.md).  
  
 If the file cannot be opened, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> writes <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter. This temporary file is automatically deleted when the file is closed, when the program terminates normally, or when <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is called, assuming that the current working directory does not change. The temporary file is opened in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> (binary read/write) mode.  
  
 Failure can occur if you attempt more than <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (see STDIO.H) calls with <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
> [!NOTE]
>  This example requires administrative privileges to run on Windows Vista.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Temporary file 1 was created**  
**Temporary file 2 was created**  
**Temporary file 3 was created**  
**3 temporary files deleted**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_rmtmp](../vs140/_rmtmp.md)   
 [_tempnam, _wtempnam, tmpnam, _wtmpnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md)