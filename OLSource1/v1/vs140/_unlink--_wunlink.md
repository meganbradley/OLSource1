---
title: "_unlink, _wunlink"
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
  - "_unlink"
  - "_wunlink"
apilocation: 
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tunlink"
  - "_unlink"
  - "wunlink"
  - "_wunlink"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "files [C++], deleting"
  - "_wunlink function"
  - "wunlink function"
  - "unlink function"
  - "_unlink function"
  - "tunlink function"
  - "files [C++], removing"
  - "_tunlink function"
ms.assetid: 5e4f5f1b-1e99-4391-9b18-9ac63c32fae8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _unlink, _wunlink
Delete a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Name of file to remove.  
  
## Return Value  
 Each of these functions returns 0 if successful. Otherwise, the function returns –1 and sets <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, which means the path specifies a read-only file, or to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which means the file or path is not found or the path specified a directory.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, return codes.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function deletes the file specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a wide-character string. These functions behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<io.h> and \<stdio.h>|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<io.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Code Example  
 This program uses _unlink to delete CRT_UNLINK.TXT.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Input: crt_unlink.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Sample Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::IO::File::Delete](https://msdn.microsoft.com/en-us/library/system.io.file.delete.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_close](../vs140/_close.md)   
 [remove, _wremove](../vs140/remove--_wremove.md)