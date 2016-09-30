---
title: "__vmx_vmread"
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
  - "__vmx_vmread"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VMREAD instruction"
  - "__vmx_vmread intrinsic"
ms.assetid: 08bdd7a0-6435-4ea6-b9a0-f592d870e5aa
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __vmx_vmread
**Microsoft Specific**  
  
 Reads a specified field from the current virtual machine control structure (VMCS) and places it in the specified location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The VMCS field to read.|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A pointer to the location to store the value read from the VMCS field specified by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.|  
  
## Return Value  
  
|Value|Meaning|  
|-----------|-------------|  
|0|The operation succeeded.|  
|1|The operation failed with extended status available in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> of the current VMCS.|  
|2|The operation failed without status available.|  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function is equivalent to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> machine instruction. The value of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter is an encoded field index that is described in Intel documentation. For more information, search for the document, "Intel Virtualization Technical Specification for the IA-32 Intel Architecture," document number C97063-002, at the [Intel Corporation](http://go.microsoft.com/fwlink/?LinkId=127) site, then consult Appendix C of that document.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [__vmx_vmwrite](../vs140/__vmx_vmwrite.md)