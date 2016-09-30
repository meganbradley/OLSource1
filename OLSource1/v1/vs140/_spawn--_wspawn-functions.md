---
title: "_spawn, _wspawn Functions"
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
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_spawn"
  - "_tspawnlp"
  - "_tspawnlpe"
  - "_tspawnve"
  - "_tspawnvp"
  - "_tspawnvpe"
  - "_tspawnl"
  - "spawn"
  - "_tspawnv"
  - "_tspawnle"
  - "wspawn"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tspawnve function"
  - "_spawn functions"
  - "_tspawnlpe function"
  - "tspawnvpe function"
  - "processes, creating"
  - "tspawnve function"
  - "_tspawnvp function"
  - "spawn functions"
  - "tspawnl function"
  - "tspawnlp function"
  - "_tspawnvpe function"
  - "_tspawnl function"
  - "tspawnvp function"
  - "tspawnv function"
  - "processes, executing new"
  - "_tspawnv function"
  - "tspawnle function"
  - "process creation"
  - "_tspawnlp function"
  - "tspawnlpe function"
  - "_tspawnle function"
ms.assetid: bb47c703-5216-4e09-8023-8cf25bbf2cf9
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _spawn, _wspawn Functions
Each of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> functions creates and executes a new process:  
  
|||  
|-|-|  
|[_spawnl, _wspawnl](../vs140/_spawnl--_wspawnl.md)|[_spawnv, _wspawnv](../vs140/_spawnv--_wspawnv.md)|  
|[_spawnle, _wspawnle](../vs140/_spawnle--_wspawnle.md)|[_spawnve, _wspawnve](../vs140/_spawnve--_wspawnve.md)|  
|[_spawnlp, _wspawnlp](../vs140/_spawnlp--_wspawnlp.md)|[_spawnvp, _wspawnvp](../vs140/_spawnvp--_wspawnvp.md)|  
|[_spawnlpe, _wspawnlpe](../vs140/_spawnlpe--_wspawnlpe.md)|[_spawnvpe, _wspawnvpe](../vs140/_spawnvpe--_wspawnvpe.md)|  
  
 The letters at the end of the function name determine the variation.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, array of pointers to environment settings, is passed to new process.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Command-line arguments are passed individually to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function. This suffix is typically used when a number of parameters to a new process is known in advance.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> environment variable is used to find the file to execute.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, array of pointers to command-line arguments, is passed to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function. This suffix is typically used when a number of parameters to a new process is variable.  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> functions each create and execute a new process. They automatically handle multibyte-character string arguments as appropriate, recognizing multibyte-character sequences according to the multibyte code page currently in use. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> functions are wide-character versions of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> functions; they do not handle multibyte-character strings. Otherwise, the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> functions behave identically to their <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> counterparts.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
  
 Enough memory must be available for loading and executing the new process. The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> argument determines the action taken by the calling process before and during <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. The following values for <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> are defined in Process.h:  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Overlays a calling process with a new process, destroying the calling process (same effect as <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> calls).  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Suspends a calling thread until execution of the new process is complete (synchronous <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Continues to execute a calling process concurrently with the new process (asynchronous <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Continues to execute the calling process; the new process is run in the background with no access to the console or keyboard. Calls to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> against the new process fail (asynchronous <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>).  
  
 The <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> argument specifies the file that is executed as the new process and can specify a full path (from the root), a partial path (from the current working directory), or just a file name. If <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> does not have a file name extension or does not end with a period (.), the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> function first tries the .com file name extension and then the .exe file name extension, the .bat file name extension, and finally the .cmd file name extension.  
  
 If <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> has a file name extension, only that extension is used. If <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> ends with a period, the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> call searches for <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> with no file name extension. The <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> functions search for <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> (using the same procedures) in the directories specified by the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> environment variable.  
  
 If <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> contains a drive specifier or any slashes (that is, if it is a relative path), the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> call searches only for the specified file; no path searching is done.  
  
 In the past, some of these functions set <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> to zero on success; the current behavior is to leave <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> untouched on success, as specified by the C standard. If you need to emulate the old behavior, set <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> to zero just before calling these functions.  
  
> [!NOTE]
>  To ensure proper overlay initialization and termination, do not use the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> function to enter or leave an overlay routine.  
  
## Arguments for the Spawned Process  
 To pass arguments to the new process, give one or more pointers to character strings as arguments in the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> call. These character strings form the argument list for the spawned process. The combined length of the strings forming the argument list for the new process must not exceed 1024 bytes. The terminating null character ('\0') for each string is not included in the count, but space characters (automatically inserted to separate arguments) are included.  
  
> [!NOTE]
>  Spaces embedded in strings may cause unexpected behavior; for example, passing <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> the string <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> will result in the new process getting two arguments, <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>. If the intent was to have the new process open a file named "hi there", the process would fail. You can avoid this by quoting the string: <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
> [!IMPORTANT]
>  Do not pass user input to <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> without explicitly checking its content. <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> will result in a call to [CreateProcess](http://msdn.microsoft.com/library/windows/desktop/ms682425) so keep in mind that unqualified path names could lead to potential security vulnerabilities.  
  
 You can pass argument pointers as separate arguments (in <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>) or as an array of pointers (in <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>). You must pass at least one argument, <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>[0], to the spawned process. By convention, this argument is the name of the program as you would type it on the command line. A different value does not produce an error.  
  
 The <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> calls are typically used in cases where the number of arguments is known in advance. The <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> argument is usually a pointer to <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>. The arguments <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> are pointers to the character strings forming the new argument list. Following <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, there must be a <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> pointer to mark the end of the argument list.  
  
 The <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> calls are useful when there is a variable number of arguments to the new process. Pointers to the arguments are passed as an array, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>*.* The argument <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>[0] is usually a pointer to a path in real mode or to the program name in protected mode, and <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>[1] through <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>] are pointers to the character strings forming the new argument list. The argument <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>119\</CodeContentPlaceHolder> +1] must be a <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> pointer to mark the end of the argument list.  
  
## Environment of the Spawned Process  
 Files that are open when a <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> call is made remain open in the new process. In the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> calls, the new process inherits the environment of the calling process. You can use the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> calls to alter the environment for the new process by passing a list of environment settings through the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> argument. The argument <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> is an array of character pointers, each element (except the final element) of which points to a null-terminated string defining an environment variable. Such a string usually has the form <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>=<CodeContentPlaceHolder>133\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> is the name of an environment variable and <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> is the string value to which that variable is set. (Note that <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> is not enclosed in double quotation marks.) The final element of the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> array should be <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> itself is <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, the spawned process inherits the environment settings of the parent process.  
  
 The <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> functions can pass all information about open files, including the translation mode, to the new process. This information is passed in real mode through the <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> entry in the environment. The startup code normally processes this entry and then deletes it from the environment. However, if a <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> function spawns a non-C process, this entry remains in the environment. Printing the environment shows graphics characters in the definition string for this entry because the environment information is passed in binary form in real mode. It should not have any other effect on normal operations. In protected mode, the environment information is passed in text form and therefore contains no graphics characters.  
  
 You must explicitly flush (using <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>) or close any stream before calling a <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> function.  
  
 New processes created by calls to <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> routines do not preserve signal settings. Instead, the spawned process resets signal settings to the default.  
  
## Redirecting Output  
 If you are calling <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> from a DLL or a GUI application and want to redirect the output to a pipe, you have two options:  
  
-   Use the Win32 API to create a pipe, then call [AllocConsole](http://msdn.microsoft.com/library/windows/desktop/ms681944), set the handle values in the startup structure, and call [CreateProcess](http://msdn.microsoft.com/library/windows/desktop/ms682425).  
  
-   Call [_popen, _wpopen](../vs140/_popen--_wpopen.md) which will create a pipe and invoke the app using **cmd.exe /c** (or **command.exe /c**).  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **child process output**  
**from SPAWN!**   
## See Also  
 [Process and Environment Control Routines](../vs140/process-and-environment-control.md)   
 [abort](../vs140/abort.md)   
 [atexit](../vs140/atexit.md)   
 [_exec Functions](../vs140/_exec--_wexec-functions.md)   
 [exit, _exit](../vs140/exit--_exit--_exit.md)   
 [_flushall](../vs140/_flushall.md)   
 [_getmbcp](../vs140/_getmbcp.md)   
 [_onexit, _onexit_m](../vs140/_onexit--_onexit_m.md)   
 [_setmbcp](../vs140/_setmbcp.md)   
 [system, _wsystem](../vs140/system--_wsystem.md)