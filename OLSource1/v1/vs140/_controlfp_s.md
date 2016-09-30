---
title: "_controlfp_s"
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
  - "_controlfp_s"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "controlfp_s"
  - "_controlfp_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "floating-point numbers, control word"
  - "controlfp_s function"
  - "floating-point functions, setting control word"
  - "EM_AMBIGUOUS"
  - "_controlfp_s function"
ms.assetid: a51fc3f6-ab13-41f0-b227-6bf02d98e987
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _controlfp_s
Gets and sets the floating-point control word. This version of [_controlfp](../vs140/_control87--_controlfp--__control87_2.md) has security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The current control-word bit value.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 New control-word bit values.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Mask for new control-word bits to set.  
  
## Return Value  
 Zero if successful, or an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value error code.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function is a platform-independent and more secure version of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which gets the floating-point control word into the address that's stored in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and sets it by using <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The bits in the values indicate the floating-point control state. The floating-point control state enables the program to change the precision, rounding, and infinity modes in the floating-point math package, depending on the platform. You can also use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to mask or unmask floating-point exceptions.  
  
 If the value for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is equal to 0, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> gets the floating-point control word and stores the retrieved value in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is nonzero, a new value for the control word is set: For any bit that is set (that is, equal to 1) in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the corresponding bit in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is used to update the control word. In other words, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> ((<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>) &#124; (<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>)) where <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is the floating-point control word. In this scenario, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is set to the value after the change completes; it is not the old control-word bit value.  
  
> [!NOTE]
>  By default, the run-time libraries mask all floating-point exceptions.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is nearly identical to the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> function on Intel (x86), [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)], and ARM platforms. If you are targeting x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)], or ARM platforms, you can use <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 The difference between <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is in how they treat <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> values. For Intel (x86), [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)], and ARM platforms, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> can set and clear the DENORMAL OPERAND exception mask. <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> does not modify the DENORMAL OPERAND exception mask. This example demonstrates the difference:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The possible values for the mask constant (<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>) and new control values (<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>) are shown in the following Hexadecimal Values table. Use the portable constants listed below (<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, and so on) as arguments to these functions, rather than supplying the hexadecimal values explicitly.  
  
 Intel (x86)-derived platforms support the DENORMAL input and output values in hardware. The x86 behavior is to preserve DENORMAL values. The ARM platform and the [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] platforms that have SSE2 support enable DENORMAL operands and results to be flushed, or forced to zero. The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> functions provide a mask to change this behavior. The following example demonstrates the use of this mask:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 On ARM platforms, the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> function applies to the FPSCR register. On [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] architectures, only the SSE2 control word that's stored in the MXCSR register is affected. On Intel (x86) platforms, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> affects the control words for both the x87 and the SSE2, if present. It is possible for the two control words to be inconsistent with each other (because of a previous call to [__control87_2](../vs140/_control87--_controlfp--__control87_2.md), for example); if there is an inconsistency between the two control words, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> sets the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> flag in <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. This is a warning that the returned control word might not represent the state of both floating-point control words accurately.  
  
 On the ARM and [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] architectures, changing the infinity mode or the floating-point precision is not supported. If the precision control mask is used on the [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] platform, the function raises an assertion and the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
 If the mask is not set correctly, this function generates an invalid parameter exception, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
 This function is ignored when you use [/clr](../vs140/-clr--common-language-runtime-compilation-.md) or **/clr:pure** to compile because the common language runtime (CLR) only supports the default floating-point precision.  
  
 **Hexadecimal Values**  
  
 For the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> mask, clearing it sets the exception, which allows the hardware exception; setting it hides the exception. If a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> occurs, no hardware exception is thrown until the next floating-point instruction is executed. To generate a hardware exception immediately after <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, call the FWAIT MASM instruction.  
  
|Mask|Hex value|Constant|Hex value|  
|----------|---------------|--------------|---------------|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder> (Denormal control)|0x03000000|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|0x00000000\<br />\<br /> 0x01000000|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder> (Interrupt exception mask)|0x0008001F|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|0x00000010\<br />\<br /> 0x00080000\<br />\<br /> 0x00000008\<br />\<br /> 0x00000004\<br />\<br /> 0x00000002\<br />\<br /> 0x00000001|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder> (Infinity control)\<br />\<br /> (Not supported on ARM or [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] platforms.)|0x00040000|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|0x00040000\<br />\<br /> 0x00000000|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder> (Rounding control)|0x00000300|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|0x00000300\<br />\<br /> 0x00000200\<br />\<br /> 0x00000100\<br />\<br /> 0x00000000|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder> (Precision control)\<br />\<br /> (Not supported on ARM or [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] platforms.)|0x00030000|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder> (24 bits)\<br />\<br /> <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> (53 bits)\<br />\<br /> <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> (64 bits)|0x00020000\<br />\<br /> 0x00010000\<br />\<br /> 0x00000000|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|\<float.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [_clear87, _clearfp](../vs140/_clear87--_clearfp.md)   
 [_status87, _statusfp, _statusfp2](../vs140/_status87--_statusfp--_statusfp2.md)   
 [_control87](../vs140/_control87--_controlfp--__control87_2.md)