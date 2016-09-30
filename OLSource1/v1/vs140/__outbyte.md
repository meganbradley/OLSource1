---
title: "__outbyte"
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
  - "__outbyte"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "out instruction"
  - "__outbyte intrinsic"
ms.assetid: c4cd1a34-8a02-4e37-993d-3201bc17901a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __outbyte
**Microsoft Specific**  
  
 Generates the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> instruction, which sends 1 byte specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> out the I/O port specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The port to send the data to.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The byte to be sent out the specified port.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This routine is only available as an intrinsic.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)