---
title: "va_arg, va_copy, va_end, va_start"
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
  - "va_arg"
  - "va_end"
  - "va_copy"
  - "va_start"
apilocation: 
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "va_arg"
  - "va_start"
  - "va_list"
  - "va_alist"
  - "va_dcl"
  - "va_copy"
  - "va_end"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "variable argument lists, accessing"
  - "va_start macro"
  - "va_arg macro"
  - "va_end macro"
  - "arguments [C++], argument lists"
  - "va_list macro"
  - "va_dcl macro"
  - "va_alist macro"
  - "va_copy macro"
ms.assetid: a700dbbd-bfe5-4077-87b6-3a07af74a907
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# va_arg, va_copy, va_end, va_start
Accesses variable-argument lists.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type of argument to be retrieved.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the list of arguments.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the list of arguments to be initialized from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Pointer to the initialized list of arguments to copy to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Parameter that precedes the first optional argument.  
  
## Return Value  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns the current argument. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> do not return values.  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> macros provide a portable way to access the arguments to a function when the function takes a variable number of arguments. There are two versions of the macros: The macros defined in STDARG.H conform to the ISO C99 standard; the macros defined in VARARGS.H are deprecated but are retained for backward compatibility with code that was written before the ANSI C89 standard.  
  
 These macros assume that the function takes a fixed number of required arguments, followed by a variable number of optional arguments. The required arguments are declared as ordinary parameters to the function and can be accessed through the parameter names. The optional arguments are accessed through the macros in STDARG.H (or VARARGS.H for code that was written before the ANSI C89 standard), which sets a pointer to the first optional argument in the argument list, retrieves arguments from the list, and resets the pointer when argument processing is completed.  
  
 The C standard macros, defined in STDARG.H, are used as follows:  
  
-   <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to the first optional argument in the list of arguments that's passed to the function. The argument <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> must have the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> type. The argument <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is the name of the required parameter that immediately precedes the first optional argument in the argument list. If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is declared with the register storage class, the macro's behavior is undefined. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> must be used before <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is used for the first time.  
  
-   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> retrieves a value of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> from the location that's given by <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, and increments <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to point to the next argument in the list by using the size of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to determine where the next argument starts. <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> can be used any number of times in the function to retrieve arguments from the list.  
  
-   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> makes a copy of a list of arguments in its current state. The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> parameter must already be initialized with <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>; it may have been updated with <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> calls, but must not have been reset with <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. The next argument that's retrieved by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is the same as the next argument that's retrieved from <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
-   After all arguments have been retrieved, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> resets the pointer to **NULL**. <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> must be called on each argument list that's initialized with <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> before the function returns.  
  
> [!NOTE]
>  The macros in VARARGS.H are deprecated and are retained only for backwards compatibility with code that was written before the ANSI C89 standard. In all other cases, use the macros in STDARGS.H.  
  
 When they are compiled by using [/clr:pure](../vs140/-clr--common-language-runtime-compilation-.md), programs that use these macros may generate unexpected results because of differences between native and common language runtime (CLR) type systems. Consider this program:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Notice that <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> expects its second parameter to be either an <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. The arguments being passed are 0xffffffff (an <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, not an <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>) and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> (actually an <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, not a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>). When the program is compiled for native code, it produces this output:  
  
 **-1**  
**(null)** However, when the program is compiled by using **/clr:pure**, the type mismatches cause it to generate an exception. The solution is to use explicit casts:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<stdio.h> and \<stdarg.h>  
  
 **Deprecated Header:** \<varargs.h>  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Output  
 **Deviation is: 0.816497**  
**Deviation is: 2.236068**  
**Deviation is: 0.000000**   
## .NET Framework Equivalent  
 [System::ParamArrayAttribute Class](https://msdn.microsoft.com/en-us/library/system.paramarrayattribute.aspx)  
  
## See Also  
 [Argument Access](../vs140/argument-access.md)   
 [vfprintf, _vfprintf_l, vfwprintf, _vfwprintf_l](../vs140/vfprintf--_vfprintf_l--vfwprintf--_vfwprintf_l.md)