---
title: "intrinsic"
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
  - "intrinsic_CPP"
  - "vc-pragma.intrinsic"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "intrinsic pragma"
  - "pragmas, intrinsic"
ms.assetid: 25c86ac7-ef40-47b7-a2c0-fada9c5dc3c5
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# intrinsic
Specifies that calls to functions specified in the pragma's argument list are intrinsic.  
  
## Syntax  
  
```  
  
#pragma intrinsic( function1 [, function2, ...] )  
```  
  
## Remarks  
 The **intrinsic** pragma tells the compiler that a function has known behavior.  The compiler may call the function and not replace the function call with inline instructions, if it will result in better performance.  
  
 The library functions with intrinsic forms are listed below. Once an **intrinsic** pragma is seen, it takes effect at the first function definition containing a specified intrinsic function. The effect continues to the end of the source file or to the appearance of a **function** pragma specifying the same intrinsic function. The **intrinsic** pragma can be used only outside of a function definition — at the global level.  
  
 The following functions have intrinsic forms and the intrinsic forms are used when you specify [/Oi](../vs140/-oi--generate-intrinsic-functions-.md):  
  
|||||  
|-|-|-|-|  
|[_disable](../vs140/_disable.md)|[_outp](../vs140/_outp--_outpw--_outpd.md)|[fabs](../vs140/fabs--fabsf--fabsl.md)|[strcmp](../vs140/strcmp--wcscmp--_mbscmp.md)|  
|[_enable](../vs140/_enable.md)|[_outpw](../vs140/_outp--_outpw--_outpd.md)|[labs](../vs140/labs--llabs.md)|[strcpy](../vs140/strcpy--wcscpy--_mbscpy.md)|  
|[_inp](../vs140/_inp--_inpw--_inpd.md)|[_rotl](../vs140/_rotl--_rotl64--_rotr--_rotr64.md)|[memcmp](../vs140/memcmp--wmemcmp.md)|[strlen](../vs140/strlen--wcslen--_mbslen--_mbslen_l--_mbstrlen--_mbstrlen_l.md)|  
|[_inpw](../vs140/_inp--_inpw--_inpd.md)|[_rotr](../vs140/_rotl--_rotl64--_rotr--_rotr64.md)|[memcpy](../vs140/memcpy--wmemcpy.md)||  
|[_lrotl](../vs140/_lrotl--_lrotr.md)|[_strset](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)|[memset](../vs140/memset--wmemset.md)||  
|[_lrotr](../vs140/_lrotl--_lrotr.md)|[abs](../vs140/abs--labs--llabs--_abs64.md)|[strcat](../vs140/strcat--wcscat--_mbscat.md)||  
  
 Programs that use intrinsic functions are faster because they do not have the overhead of function calls but may be larger due to the additional code generated.  
  
 **x86 Specific**  
  
 The _disable and _enable intrinsics generate kernel-mode instructions to disable/enable interrupts and could be useful in kernel-mode drivers.  
  
## Example  
 Compile the following code from the command line with "cl -c -FAs sample.c" and look at sample.asm to see that they turn into x86 instructions CLI and STI:  
  
```  
// pragma_directive_intrinsic.cpp  
// processor: x86  
#include <dos.h>   // definitions for _disable, _enable  
#pragma intrinsic(_disable)  
#pragma intrinsic(_enable)  
void f1(void) {  
   _disable();  
   // do some work here that should not be interrupted  
   _enable();  
}  
int main() {  
}  
```  
  
 **End x86 Specific**  
  
 The floating-point functions listed below do not have true intrinsic forms. Instead they have versions that pass arguments directly to the floating-point chip rather than pushing them onto the program stack:  
  
|||||  
|-|-|-|-|  
|[acos](../vs140/acos--acosf--acosl.md)|[cosh](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)|[pow](../vs140/pow--powf--powl.md)|[tanh](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)|  
|[asin](../vs140/asin--asinf--asinl.md)|[fmod](../vs140/fmod--fmodf.md)|[sinh](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)||  
  
 The floating-point functions listed below have true intrinsic forms when you specify [/Oi](../vs140/-oi--generate-intrinsic-functions-.md), [/Og](../vs140/-og--global-optimizations-.md), and [/fp:fast](../vs140/-fp--specify-floating-point-behavior-.md) (or any option that includes /Og: [/Ox](../vs140/-ox--full-optimization-.md), [/O1](../vs140/-o1---o2--minimize-size--maximize-speed-.md), and /O2):  
  
|||||  
|-|-|-|-|  
|[atan](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)|[exp](../vs140/exp--expf.md)|[log10](../vs140/log--logf--log10--log10f.md)|[sqrt](../vs140/sqrt--sqrtf--sqrtl.md)|  
|[atan2](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)|[log](../vs140/log--logf--log10--log10f.md)|[sin](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)|[tan](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)|  
|[cos](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)||||  
  
 You can use [/fp:strict](../vs140/-fp--specify-floating-point-behavior-.md) or [/Za](../vs140/-za---ze--disable-language-extensions-.md) to override generation of true intrinsic floating-point options. In this case, the functions are generated as library routines that pass arguments directly to the floating-point chip instead of pushing them onto the program stack.  
  
 See [# pragma function](../vs140/function--c-c---.md) for information and an example on how to enable/disable intrinsics for a block of source text.  
  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)