---
title: "__fastfail"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 9cd32639-e395-4c75-9f3a-ac3ba7f49921
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __fastfail
**Microsoft Specific**  
  
 Immediately terminates the calling process with minimum overhead.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> symbolic constant from winnt.h or wdm.h that indicates the reason for process termination.  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> intrinsic does not return.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> intrinsic provides a mechanism for a *fast fail* request—a way for a potentially corrupted process to request immediate process termination. Critical failures that may have corrupted program state and stack beyond recovery cannot be handled by the regular exception handling facility. Use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to terminate the process using minimal overhead.  
  
 Internally, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is implemented by using several architecture-specific mechanisms:  
  
|Architecture|Instruction|Location of code argument|  
|------------------|-----------------|-------------------------------|  
|x86|int 0x29|ecx|  
|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|int 0x29|rcx|  
|ARM|Opcode 0xDEFB|r0|  
  
 A fast fail request is self-contained and typically requires just two instructions to execute. Once a fast fail request has been executed the kernel then takes the appropriate action. In user-mode code, there are no memory dependencies beyond the instruction pointer itself when a fast fail event is raised. This maximizes its reliability even if there is severe memory corruption.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> argument—one of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> symbolic constants from winnt.h or wdm.h—describes the type of failure condition and is incorporated into failure reports in an environment-specific manner.  
  
 User-mode fast fail requests appear as a second chance non-continuable exception with exception code 0xC0000409 and with at least one exception parameter. The first exception parameter is the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> value. This exception code indicates to the Windows Error Reporting (WER) and debugging infrastructure that the process is corrupted and that minimal in-process actions should be taken in response to the failure. Kernel-mode fast fail requests are implemented by using a dedicated bugcheck code, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (0x139). In both cases, no exception handlers are invoked because the program is expected to be in a corrupted state. If a debugger is present, it is given an opportunity to examine the state of the program before termination.  
  
 Support for the native fast fail mechanism began in Windows 8. Windows operating systems that do not support the fast fail instruction natively will typically treat a fast fail request as an access violation, or as an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> bugcheck. In these cases, the program is still terminated, but not necessarily as quickly.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is only available as an intrinsic.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)], ARM|  
  
 **Header file** \<intrin.h>  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)