---
title: "__debugbreak"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - __debugbreak_cpp
  - __debugbreak
dev_langs: 
  - C++
helpviewer_keywords: 
  - breakpoints, __debugbreak intrinsic
  - __debugbreak intrinsic
ms.assetid: 1d1e1c0c-891a-4613-ae4b-d790094ba830
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# __debugbreak
**Microsoft Specific**  
  
 Causes a breakpoint in your code, where the user will be prompted to run the debugger.  
  
## Syntax  
  
```  
void __debugbreak();  
```  
  
## Requirements  
  
|Intrinsic|Architecture|Header|  
|---------------|------------------|------------|  
|`__debugbreak`|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|<intrin.h>|  
  
## Remarks  
 The `__debugbreak` compiler intrinsic, similar to [DebugBreak](http://msdn.microsoft.com/library/windows/desktop/ms679297.aspx), is a portable Win32 way to cause a breakpoint.  
  
> [!NOTE]
>  When compiling with **/clr**, a function containing `__debugbreak` will be compiled to MSIL. `asm int 3` causes a function to be compiled to native. For more information, see [__asm](../vs140/__asm.md).  
  
 For example:  
  
```  
main() {  
   __debugbreak();  
}  
```  
  
 is similar to:  
  
```  
main() {  
   __asm {  
      int 3  
   }  
}  
```  
  
 on an x86 computer.  
  
 This routine is only available as an intrinsic.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [Keywords](../vs140/keywords--c---.md)