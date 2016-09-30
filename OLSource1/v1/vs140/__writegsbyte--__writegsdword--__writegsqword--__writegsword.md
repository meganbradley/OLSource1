---
title: "__writegsbyte, __writegsdword, __writegsqword, __writegsword"
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
  - "__writegsbyte"
  - "__writegsqword"
  - "__writegsdword"
  - "__writegsword"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__writegsqword intrinsic"
  - "__writegsbyte intrinsic"
  - "__writegsword intrinsic"
  - "__writegsdword intrinsic"
ms.assetid: 7746cf6d-2259-4139-9aab-c07dd75c8037
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __writegsbyte, __writegsdword, __writegsqword, __writegsword
**Microsoft Specific**  
  
 Write memory to a location specified by an offset relative to the beginning of the GS segment.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The offset from the beginning of GS to write to.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value to write.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 These intrinsics are available in kernel mode only, and these routines are only available as intrinsics.  
  
## END Microsoft Specific  
  
## See Also  
 [__readgsbyte, \__readgsdword, \__readgsqword, \__readgsword](../vs140/__readgsbyte--__readgsdword--__readgsqword--__readgsword.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)