---
title: "__vmx_vmclear"
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
  - "__vmx_vmclear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VMCLEAR instruction"
  - "__vmx_vmclear intrinsic"
ms.assetid: e3eb98e4-50fc-4c93-9bac-340fd1f0a466
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __vmx_vmclear
**Microsoft Specific**  
  
 Initializes the specified virtual machine control structure (VMCS) and sets its launch state to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A pointer to a 64-bit memory location that contains the physical address of the VMCS to clear.|  
  
## Return Value  
  
|Value|Meaning|  
|-----------|-------------|  
|0|The operation succeeded.|  
|1|The operation failed with extended status available in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the current VMCS.|  
|2|The operation failed without status available.|  
  
## Remarks  
 An application can perform a VM-enter operation by using either the [__vmx_vmlaunch](../vs140/__vmx_vmlaunch.md) or [__vmx_vmresume](../vs140/__vmx_vmresume.md) function. The [__vmx_vmlaunch](../vs140/__vmx_vmlaunch.md) function can be used only with a VMCS whose launch state is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and the [__vmx_vmresume](../vs140/__vmx_vmresume.md) function can be used only with a VMCS whose launch state is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Consequently, use the [__vmx_vmclear](../vs140/__vmx_vmclear.md) function to set the launch state of a VMCS to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Use the [__vmx_vmlaunch](../vs140/__vmx_vmlaunch.md) function for your first VM-enter operation and the [__vmx_vmresume](../vs140/__vmx_vmresume.md) function for subsequent VM-enter operations.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function is equivalent to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> machine instruction. This function supports the interaction of a host's virtual machine monitor with a guest operating system and its applications. For more information, search for the document, "Intel Virtualization Technical Specification for the IA-32 Intel Architecture," document number C97063-002, at the [Intel Corporation](http://go.microsoft.com/fwlink/?LinkId=127) site.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [__vmx_vmlaunch](../vs140/__vmx_vmlaunch.md)   
 [__vmx_vmresume](../vs140/__vmx_vmresume.md)