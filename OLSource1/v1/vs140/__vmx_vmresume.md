---
title: "__vmx_vmresume"
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
  - "__vmx_vmresume"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__vmx_vmresume intrinsic"
  - "VMRESUME instruction"
ms.assetid: 233fe1b6-c727-493a-a484-1b2363732281
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __vmx_vmresume
**Microsoft Specific**  
  
 Resumes VMX non-root operation by using the current virtual machine control structure (VMCS).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
  
|Value|Meaning|  
|-----------|-------------|  
|0|The operation succeeded.|  
|1|The operation failed with extended status available in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> of the current VMCS.|  
|2|The operation failed without status available.|  
  
## Remarks  
 An application can perform a VM-enter operation by using either the [__vmx_vmlaunch](../vs140/__vmx_vmlaunch.md) or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function can be used only with a VMCS whose launch state is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function can be used only with a VMCS whose launch state is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Consequently, use the [__vmx_vmclear](../vs140/__vmx_vmclear.md) function to set the launch state of a VMCS to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and then use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function for your first VM-enter operation and the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function for subsequent VM-enter operations.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function is equivalent to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> machine instruction. This function supports the interaction of a host's virtual machine monitor with a guest operating system and its applications. For more information, search for the PDF document, "Intel Virtualization Technical Specification for the IA-32 Intel Architecture," document number C97063-002, at the [Intel Corporation](http://go.microsoft.com/fwlink/?LinkId=127) site.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [__vmx_vmlaunch](../vs140/__vmx_vmlaunch.md)   
 [__vmx_vmclear](../vs140/__vmx_vmclear.md)