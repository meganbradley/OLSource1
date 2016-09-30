---
title: "_cscanf, _cscanf_l, _cwscanf, _cwscanf_l"
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
  - "_cscanf_l"
  - "_cscanf"
  - "_cwscanf"
  - "_cwscanf_l"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_cwscanf"
  - "cwscanf_l"
  - "tcscanf_l"
  - "_tcscanf_l"
  - "_cscanf"
  - "_cscanf_l"
  - "tcscanf"
  - "cwscanf"
  - "_cwscanf_l"
  - "cscanf_l"
  - "_tcscanf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_cwscanf function"
  - "data [C++], reading from the console"
  - "cscanf_l function"
  - "tcscanf function"
  - "_cscanf_l function"
  - "cwscanf function"
  - "_tcscanf_l function"
  - "_cscanf function"
  - "_tcscanf function"
  - "cwscanf_l function"
  - "tcscanf_l function"
  - "reading data [C++], from the console"
  - "_cwscanf_l function"
ms.assetid: dbfe7547-b577-4567-a1cb-893fa640e669
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _cscanf, _cscanf_l, _cwscanf, _cwscanf_l
Reads formatted data from the console. More secure versions of these functions are available; see [_cscanf_s, _cscanf_s_l, _cwscanf_s, _cwscanf_s_l](../vs140/_cscanf_s--_cscanf_s_l--_cwscanf_s--_cwscanf_s_l.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Format-control string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional parameters.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 The number of fields that were successfully converted and assigned. The return value does not include fields that were read but not assigned. The return value is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for an attempt to read at end of file. This can occur when keyboard input is redirected at the operating-system command-line level. A return value of 0 means that no fields were assigned.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function reads data directly from the console into the locations given by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The [_getche](../vs140/_getch--_getwch.md) function is used to read characters. Each optional parameter must be a pointer to a variable with a type that corresponds to a type specifier in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The format controls the interpretation of the input fields and has the same form and function as the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter for the [scanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md) function. While <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> normally echoes the input character, it does not do so if the last call was to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 This function validates its parameters. If format is NULL, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 The versions of these functions with the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<conio.h>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<conio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_cprintf, _cwprintf](../vs140/_cprintf--_cprintf_l--_cwprintf--_cwprintf_l.md)   
 [fscanf, fwscanf](../vs140/fscanf--_fscanf_l--fwscanf--_fwscanf_l.md)   
 [scanf_s, wscanf_s](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md)   
 [sscanf, swscanf](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md)