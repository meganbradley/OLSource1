---
title: "__vmx_on"
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
  - "__vmx_on"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VMXON instruction"
  - "__vmx_on intrinsic"
ms.assetid: 16804991-6a75-4adf-8ec2-bc95acfa4801
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __vmx_on
**Microsoft Specific**  
  
 Activates virtual machine extensions (VMX) operation in the processor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a 64-bit physical address that points to a virtual-machine control structure (VMCS).  
  
## Return Value  
  
|Value|Meaning|  
|-----------|-------------|  
|0|The operation succeeded.|  
|1|The operation failed with extended status available in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> of the current VMCS.|  
|2|The operation failed without status available.|  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function corresponds to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> machine instruction. This function supports the interaction of a host's virtual machine monitor with a guest operating system and its applications. For more information, search for the document, "Intel Virtualization Technical Specification for the IA-32 Intel Architecture," document number C97063-002, at the [Intel Corporation](http://go.microsoft.com/fwlink/?LinkId=127) site.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)