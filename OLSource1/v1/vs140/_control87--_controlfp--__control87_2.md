---
title: "_control87, _controlfp, __control87_2"
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
  - "_control87"
  - "_controlfp"
  - "__control87_2"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_control87"
  - "__control87_2"
  - "control87"
  - "_controlfp"
  - "controlfp"
  - "control87_2"
  - "_control87_2"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "floating-point numbers, control word"
  - "_control87 function"
  - "control87 function"
  - "controlfp function"
  - "_controlfp function"
  - "__control87_2 function"
  - "floating-point functions, setting control word"
  - "floating-point functions"
  - "EM_AMBIGUOUS"
  - "control87_2 function"
ms.assetid: 0d09729d-d9a0-43d6-864c-43ff25e7e0c5
caps.latest.revision: 38
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _control87, _controlfp, __control87_2
Gets and sets the floating-point control word. A more secure version of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is available; see [_controlfp_s](../vs140/_controlfp_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 New control-word bit values.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Mask for new control-word bits to set.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Filled in with the control word for the x87 floating-point unit. Pass in 0 (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) to set only the SSE2 control word.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Control word for the SSE floating-point unit. Pass in 0 (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) to set only the x87 control word.  
  
## Return Value  
 For <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the bits in the value returned indicate the floating-point control state. For a complete definition of the bits that are returned by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, see FLOAT.H.  
  
 For <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the return value is 1, which indicates success.  
  
## Remarks  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function gets and sets the floating-point control word. The floating-point control word enables the program to change the precision, rounding, and infinity modes in the floating-point math package, depending on the platform. You can also use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to mask or unmask floating-point exceptions. If the value for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is equal to 0, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> gets the floating-point control word. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is nonzero, a new value for the control word is set: For any bit that is on (that is, equal to 1) in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the corresponding bit in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is used to update the control word. In other words, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> ((<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>) &#124; (<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>)) where <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is the floating-point control word.  
  
> [!NOTE]
>  By default, the run-time libraries mask all floating-point exceptions.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is a platform-independent, portable version of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. It is nearly identical to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> function on Intel (x86), [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)], and ARM platforms. If you are targeting x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)], or ARM platforms, use <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 The difference between <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is in how they treat DENORMAL values. For Intel (x86), [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)], and ARM platforms, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> can set and clear the DENORMAL OPERAND exception mask. <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> does not modify the DENORMAL OPERAND exception mask. This example demonstrates the difference:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The possible values for the mask constant (<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>) and new control values (<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>) are shown in the following Hexadecimal Values table. Use the portable constants listed below (<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, and so forth) as arguments to these functions, rather than supplying the hexadecimal values explicitly.  
  
 Intel (x86)-derived platforms support the DENORMAL input and output values in hardware. The x86 behavior is to preserve DENORMAL values. The ARM platform and the [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] platforms that have SSE2 support enable DENORMAL operands and results to be flushed, or forced to zero. The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> functions provide a mask to change this behavior. The following example demonstrates the use of this mask.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 On ARM platforms, the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> functions apply to the FPSCR register. On [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] architectures, only the SSE2 control word that's stored in the MXCSR register is affected. On Intel (x86) platforms, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> affect the control words for both the x87 and the SSE2, if present. The function <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> enables both the x87 and SSE2 floating-point units to be controlled together or separately. If you want to affect both units, pass in the addresses of two integers to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. If you only want to affect one unit, pass in an address for that parameter but pass in 0 (NULL) for the other. If 0 is passed for one of these parameters, the function has no effect on that floating-point unit. This functionality could be useful in situations where part of the code uses the x87 floating-point unit and another part of the code uses the SSE2 floating-point unit. If you use <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> in one part of a program and set different values for the floating-point control words, and then use <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> to further manipulate the control word, then <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> might be unable to return a single control word to represent the state of both floating-point units. In such a case, these functions set the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> flag in the returned integer value to indicate that there is an inconsistency between the two control words. This is a warning that the returned control word might not represent the state of both floating-point control words accurately.  
  
 On the ARM and [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] architectures, changing the infinity mode or the floating-point precision is not supported. If the precision control mask is used on the [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] platform, the function raises an assertion and the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
> [!NOTE]
>  <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is not supported on the ARM or [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] architectures. If you use <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> and compile your program for the ARM or [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] architectures, the compiler generates an error.  
  
 These functions are ignored when you use [/clr](../vs140/-clr--common-language-runtime-compilation-.md) or <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> to compile because the common language runtime (CLR) only supports the default floating-point precision.  
  
 **Hexadecimal Values**  
  
 For the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> mask, clearing the mask sets the exception, which allows the hardware exception; setting the mask hides the exception. If a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> occurs, no hardware exception is thrown until the next floating-point instruction is executed. To generate a hardware exception immediately after <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, call the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> MASM instruction.  
  
|Mask|Hex value|Constant|Hex value|  
|----------|---------------|--------------|---------------|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder> (Denormal control)|0x03000000|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|0x00000000\<br />\<br /> 0x01000000|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder> (Interrupt exception mask)|0x0008001F|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|0x00000010\<br />\<br /> 0x00080000\<br />\<br /> 0x00000008\<br />\<br /> 0x00000004\<br />\<br /> 0x00000002\<br />\<br /> 0x00000001|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder> (Infinity control)\<br />\<br /> (Not supported on ARM or [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] platforms.)|0x00040000|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|0x00040000\<br />\<br /> 0x00000000|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder> (Rounding control)|0x00000300|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|0x00000300\<br />\<br /> 0x00000200\<br />\<br /> 0x00000100\<br />\<br /> 0x00000000|  
|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder> (Precision control)\<br />\<br /> (Not supported on ARM or [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] platforms.)|0x00030000|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder> (24 bits)\<br />\<br /> <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> (53 bits)\<br />\<br /> <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> (64 bits)|0x00020000\<br />\<br /> 0x00010000\<br />\<br /> 0x00000000|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|\<float.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [_clear87, _clearfp](../vs140/_clear87--_clearfp.md)   
 [_status87, _statusfp, _statusfp2](../vs140/_status87--_statusfp--_statusfp2.md)   
 [_controlfp_s](../vs140/_controlfp_s.md)