---
title: "_exec, _wexec Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_texecve"
  - "texecl"
  - "_texeclpe"
  - "texecve"
  - "texecv"
  - "texeclp"
  - "texecle"
  - "exec"
  - "texeclpe"
  - "_texecvp"
  - "_texecl"
  - "_texecle"
  - "wexec"
  - "_exec"
  - "_texeclp"
  - "_texecvpe"
  - "texecvpe"
  - "_texecv"
  - "_wexec"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_texecle function"
  - "_texecv function"
  - "texeclpe function"
  - "texecle function"
  - "_texecl function"
  - "texecv function"
  - "_texeclp function"
  - "_texecve function"
  - "texecl function"
  - "texecve function"
  - "exec function"
  - "texeclp function"
  - "texecvp function"
  - "texecvpe function"
  - "processes, executing new"
  - "_texecvp function"
  - "_texeclpe function"
  - "_wexec functions"
  - "wexec functions"
  - "_exec function"
  - "_texecvpe function"
ms.assetid: a261df93-206a-4fdc-b8ac-66aa7db83bc6
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _exec, _wexec Functions
Each function in this family loads and executes a new process:  
  
|||  
|-|-|  
|[_execl, _wexecl](../vs140/_execl--_wexecl.md)|[_execv, _wexecv](../vs140/_execv--_wexecv.md)|  
|[_execle, _wexecle](../vs140/_execle--_wexecle.md)|[_execve, _wexecve](../vs140/_execve--_wexecve.md)|  
|[_execlp, _wexeclp](../vs140/_execlp--_wexeclp.md)|[_execvp, _wexecvp](../vs140/_execvp--_wexecvp.md)|  
|[_execlpe, _wexeclpe](../vs140/_execlpe--_wexeclpe.md)|[_execvpe, _wexecvpe](../vs140/_execvpe--_wexecvpe.md)|  
  
 The letter at the end of the function name determines the variation.  
  
|_exec function suffix|Description|  
|----------------------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, array of pointers to environment settings, is passed to the new process.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Command-line arguments are passed individually to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function. Typically used when the number of parameters to the new process is known in advance.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> environment variable is used to find the file to execute.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, array of pointers to command-line arguments, is passed to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Typically used when the number of parameters to the new process is variable.|  
  
## Remarks  
 Each <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function loads and executes a new process. All <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> functions use the same operating-system function ([CreateProcess](http://msdn.microsoft.com/library/windows/desktop/ms682425.aspx)). The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> functions automatically handle multibyte-character string arguments as appropriate, recognizing multibyte-character sequences according to the multibyte code page currently in use. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> functions are wide-character versions of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> functions. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> functions behave identically to their <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> family counterparts except that they do not handle multibyte-character strings.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> parameter specifies the file to be executed as the new process. It can specify a full path (from the root), a partial path (from the current working directory), or a file name. If <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> does not have a file name extension or does not end with a period (.), the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> function searches for the named file. If the search is unsuccessful, it tries the same base name with the .com file name extension and then with the .exe, .bat, and .cmd file name extensions. If <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> has a file name extension, only that extension is used in the search. If <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> ends with a period, the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> function searches for <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> with no file name extension. <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> search for <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> (using the same procedures) in the directories specified by the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> environment variable. If <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> contains a drive specifier or any slashes (that is, if it is a relative path), the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> call searches only for the specified file; the path is not searched.  
  
 Parameters are passed to the new process by giving one or more pointers to character strings as parameters in the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> call. These character strings form the parameter list for the new process. The combined length of the inherited environment settings and the strings forming the parameter list for the new process must not exceed 32 kilobytes. The terminating null character ('\0') for each string is not included in the count, but space characters (inserted automatically to separate the parameters) are counted.  
  
> [!NOTE]
>  Spaces embedded in strings may cause unexpected behavior; for example, passing <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> the string <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> will result in the new process getting two arguments, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>. If the intent was to have the new process open a file named "hi there", the process would fail. You can avoid this by quoting the string: <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
> [!IMPORTANT]
>  Do not pass user input to <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> without explicitly checking its content. <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> will result in a call to [CreateProcess](http://msdn.microsoft.com/library/windows/desktop/ms682425.aspx) so keep in mind that unqualified path names could lead to potential security vulnerabilities.  
  
 The <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> functions validate their parameters. If expected parameters are null pointers, empty strings, or omitted, the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> functions invoke the invalid parameter handler as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> and return -1. No new process is executed.  
  
 The argument pointers can be passed as separate parameters (in <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>) or as an array of pointers (in <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>). At least one parameter, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, must be passed to the new process; this parameter is <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>[0] of the new process. Usually, this parameter is a copy of <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>. (A different value does not produce an error.)  
  
 The <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> calls are typically used when the number of parameters is known in advance. The parameter <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is usually a pointer to <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>. The parameters <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> point to the character strings forming the new parameter list. A null pointer must follow <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> to mark the end of the parameter list.  
  
 The <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> calls are useful when the number of parameters to the new process is variable. Pointers to the parameters are passed as an array, <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>. The parameter <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>[0] is usually a pointer to <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>. The parameters <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>[1] through <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>] point to the character strings forming the new parameter list. The parameter <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>+1] must be a <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> pointer to mark the end of the parameter list.  
  
 Files that are open when an <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> call is made remain open in the new process. In <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> calls, the new process inherits the environment of the calling process. <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> calls alter the environment for the new process by passing a list of environment settings through the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> parameter. <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> is an array of character pointers, each element of which (except for the final element) points to a null-terminated string defining an environment variable. Such a string usually has the form <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>=<CodeContentPlaceHolder>122\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> is the name of an environment variable and <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> is the string value to which that variable is set. (Note that <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> is not enclosed in double quotation marks.) The final element of the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> array should be <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> itself is <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>, the new process inherits the environment settings of the calling process.  
  
 A program executed with one of the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> functions is always loaded into memory as if the maximum allocation field in the program's .exe file header were set to the default value of 0xFFFFH.  
  
 The <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> calls do not preserve the translation modes of open files. If the new process must use files inherited from the calling process, use the [_setmode](../vs140/_setmode.md) routine to set the translation mode of these files to the desired mode. You must explicitly flush (using <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>) or close any stream before the <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> function call. Signal settings are not preserved in new processes that are created by calls to <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> routines. The signal settings are reset to the default in the new process.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Run the following program to execute Crt_args.exe:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
  
-   [System::Diagnostics::Process Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.process.aspx)  
  
-   [System::Diagnostics::ProcessStartInfo Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.processstartinfo.aspx)  
  
 **Header:** process.h  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [abort](../vs140/abort.md)   
 [atexit](../vs140/atexit.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [_onexit, _onexit_m](../vs140/_onexit--_onexit_m.md)   
 [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md)   
 [system, _wsystem](../vs140/system--_wsystem.md)