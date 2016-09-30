---
title: "__cpuid, __cpuidex"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "__cpuid_cpp"
  - "__cpuid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__cpuid intrinsic"
  - "cpuid instruction"
  - "cpuid intrinsic"
ms.assetid: f8c344d3-91bf-405f-8622-cb0e337a6bdc
caps.latest.revision: 40
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __cpuid, __cpuidex
**Microsoft Specific**  
  
 Generates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instruction that is available on x86 and [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]. This instruction queries the processor for information about supported features and the CPU type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An array of four integers that contains the information returned in EAX, EBX, ECX, and EDX about supported features of the CPU.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A code that specifies the information to retrieve, passed in EAX.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An additional code that specifies information to retrieve, passed in ECX.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This intrinsic stores the supported features and CPU information returned by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> instruction in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, an array of four 32-bit integers that is filled with the values of the EAX, EBX, ECX, and EDX registers (in that order). The information returned has a different meaning depending on the value passed as the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter. The information returned with various values of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is processor-dependent.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> intrinsic clears the ECX register before calling the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> instruction. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> intrinsic sets the value of the ECX register to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> before it generates the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> instruction. This enables you to gather additional information about the processor.  
  
 For more information about the specific parameters to use and the values returned by these intrinsics on Intel processors, see the documentation for the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> instruction in [Intel 64 and IA-32 Architectures Software Developers Manual Volume 2: Instruction Set Reference](http://go.microsoft.com/fwlink/p/?LinkID=510021) and [Intel Architecture Instruction Set Extensions Programming Reference](http://go.microsoft.com/fwlink/p/?LinkID=506627). Intel documentation uses the terms "leaf" and "subleaf" for the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameters passed in EAX and ECX.  
  
 For more information about the specific parameters to use and the values returned by these intrinsics on AMD processors, see the documentation for the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> instruction in [AMD64 Architecture Programmer's Manual Volume 3: General-Purpose and System Instructions](http://go.microsoft.com/fwlink/p/?LinkId=510023) and in the [Revision Guides](http://go.microsoft.com/fwlink/p/?LinkId=510023) for specific processor families. AMD documentation uses the terms "function number" and "subfunction number" for the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameters passed in EAX and ECX.  
  
 When the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> argument is 0, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> returns the highest available non-extended <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> supported by the processor. The processor manufacturer is encoded in <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and cpuInfo[3].  
  
 Support for specific instruction set extensions and CPU features is encoded in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> results returned for higher function_id values. For more information, see the manuals linked above, and the following example code.  
  
 Some processors support Extended Function CPUID information. If this is supported, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> values from 0x80000000 might be used to return information. To determine the maximum meaningful value allowed, set <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to 0x80000000. The maximum value of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> supported for extended functions will be written to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
## Example  
 This example shows some of the information available through the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> intrinsics. The app lists the instruction set extensions supported by the current processor. The output shows a possible result for a particular processor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **GenuineIntel**  
 **Intel(R) Core(TM) i5-2500 CPU @ 3.30GHz**  
**3DNOW not supported**  
**3DNOWEXT not supported**  
**ABM not supported**  
**ADX not supported**  
**AES supported**  
**AVX supported**  
**AVX2 not supported**  
**AVX512CD not supported**  
**AVX512ER not supported**  
**AVX512F not supported**  
**AVX512PF not supported**  
**BMI1 not supported**  
**BMI2 not supported**  
**CLFSH supported**  
**CMPXCHG16B supported**  
**CX8 supported**  
**ERMS not supported**  
**F16C not supported**  
**FMA not supported**  
**FSGSBASE not supported**  
**FXSR supported**  
**HLE not supported**  
**INVPCID not supported**  
**LAHF supported**  
**LZCNT not supported**  
**MMX supported**  
**MMXEXT not supported**  
**MONITOR not supported**  
**MOVBE not supported**  
**MSR supported**  
**OSXSAVE supported**  
**PCLMULQDQ supported**  
**POPCNT supported**  
**PREFETCHWT1 not supported**  
**RDRAND not supported**  
**RDSEED not supported**  
**RDTSCP supported**  
**RTM not supported**  
**SEP supported**  
**SHA not supported**  
**SSE supported**  
**SSE2 supported**  
**SSE3 supported**  
**SSE4.1 supported**  
**SSE4.2 supported**  
**SSE4a not supported**  
**SSSE3 supported**  
**SYSCALL supported**  
**TBM not supported**  
**XOP not supported**  
**XSAVE supported**   
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)