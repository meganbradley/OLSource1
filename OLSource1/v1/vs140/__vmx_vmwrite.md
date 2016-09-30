---
title: "__vmx_vmwrite"
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
  - "__vmx_vmwrite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__vmx_vmwrite intrinsic"
  - "VMWRITE instruction"
ms.assetid: 88139792-fd3f-4210-97ca-9d84f43a0252
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __vmx_vmwrite
**Microsoft Specific**  
  
 Writes the specified value to the specified field in the current virtual machine control structure (VMCS).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The VMCS field to write.|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The value to write to the VMCS field.|  
  
## Return Value  
 0  
 The operation succeeded.  
  
 1  
 The operation failed with extended status available in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the current VMCS.  
  
 2  
 The operation failed without status available.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function is equivalent to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> machine instruction. The value of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is an encoded field index that is described in Intel documentation. For more information, search for the document, "Intel Virtualization Technical Specification for the IA-32 Intel Architecture," document number C97063-002, at the [Intel Corporation](http://go.microsoft.com/fwlink/?LinkId=127) site, and then consult Appendix C of that document.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [__vmx_vmread](../vs140/__vmx_vmread.md)