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
  
```  
void __writegsbyte(   
   unsigned long Offset,   
   unsigned char Data   
);  
void __writegsword(   
   unsigned long Offset,   
   unsigned short Data   
);  
void __writegsdword(   
   unsigned long Offset,   
   unsigned long Data   
);  
void __writegsqword(   
   unsigned long Offset,   
   unsigned __int64 Data   
);  
```  
  
#### Parameters  
 [in] `Offset`  
 The offset from the beginning of GS to write to.  
  
 [in] `Data`  
 The value to write.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|`__writegsbyte`|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|`__writegsdword`|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|`__writegsqword`|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|`__writegsword`|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 These intrinsics are available in kernel mode only, and these routines are only available as intrinsics.  
  
## END Microsoft Specific  
  
## See Also  
 [__readgsbyte, \__readgsdword, \__readgsqword, \__readgsword](../vs140/__readgsbyte--__readgsdword--__readgsqword--__readgsword.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)