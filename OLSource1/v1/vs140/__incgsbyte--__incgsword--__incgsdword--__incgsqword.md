---
title: "__incgsbyte, __incgsword, __incgsdword, __incgsqword"
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
  - "__incgsdword"
  - "__incgsqword_cpp"
  - "__incgsword_cpp"
  - "__incgsword"
  - "__incgsbyte"
  - "__incgsbyte_cpp"
  - "__incgsqword"
  - "__incgsdword_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__incgsbyte intrinsic"
  - "__incgsword intrinsic"
  - "__incgsqword intrinsic"
  - "__incgsdword intrinsic"
ms.assetid: 06bfdf4f-7643-4fe0-8455-60ce3068073e
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __incgsbyte, __incgsword, __incgsdword, __incgsqword
**Microsoft Specific**  
  
 Add one to the value at a memory location specified by an offset relative to the beginning of the `GS` segment.  
  
## Syntax  
  
```  
void __incgsbyte(   
   unsigned long Offset   
);  
void __incgsword(   
   unsigned long Offset   
);  
void __incgsdword(   
   unsigned long Offset  
);  
void __incgsqword(   
   unsigned long Offset   
);  
```  
  
#### Parameters  
 [in] `Offset`  
 The offset from the beginning of `GS`.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|`__incgsbyte`|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|`__incgsword`|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|`__incgsdword`|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|`__incgsqword`|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
## Remarks  
 These intrinsics are only available in kernel mode, and the routines are only available as intrinsics.  
  
## END Microsoft Specific  
  
## See Also  
 [__addgsbyte, \__addgsword, \__addgsdword, \__addgsqword](../vs140/__addgsbyte--__addgsword--__addgsdword--__addgsqword.md)   
 [__readgsbyte, \__readgsdword, \__readgsqword, \__readgsword](../vs140/__readgsbyte--__readgsdword--__readgsqword--__readgsword.md)   
 [__writegsbyte, \__writegsdword, \__writegsqword, \__writegsword](../vs140/__writegsbyte--__writegsdword--__writegsqword--__writegsword.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)