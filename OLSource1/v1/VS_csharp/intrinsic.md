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
  
 The following functions have intrinsic forms and the intrinsic forms are used when you specify [/Oi](../VS_csharp/-oi--generate-intrinsic-functions-.md):  
  
|||||  
|-|-|-|-|  
|[_disable](../VS_csharp/_disable.md)|[_outp](../VS_csharp/_outp--_outpw--_outpd.md)|[fabs](../VS_csharp/fabs--fabsf--fabsl.md)|[strcmp](../VS_csharp/strcmp--wcscmp--_mbscmp.md)|  
|[_enable](../VS_csharp/_enable.md)|[_outpw](../VS_csharp/_outp--_outpw--_outpd.md)|[labs](../Topic/labs,%20llabs.md)|[strcpy](../VS_csharp/strcpy--wcscpy--_mbscpy.md)|  
|[_inp](../VS_csharp/_inp--_inpw--_inpd.md)|[_rotl](../VS_csharp/_rotl--_rotl64--_rotr--_rotr64.md)|[memcmp](../VS_csharp/memcmp--wmemcmp.md)|[strlen](../VS_csharp/strlen--wcslen--_mbslen--_mbslen_l--_mbstrlen--_mbstrlen_l.md)|  
|[_inpw](../VS_csharp/_inp--_inpw--_inpd.md)|[_rotr](../VS_csharp/_rotl--_rotl64--_rotr--_rotr64.md)|[memcpy](../VS_csharp/memcpy--wmemcpy.md)||  
|[_lrotl](../VS_csharp/_lrotl--_lrotr.md)|[_strset](../VS_csharp/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)|[memset](../VS_csharp/memset--wmemset.md)||  
|[_lrotr](../VS_csharp/_lrotl--_lrotr.md)|[abs](../VS_csharp/abs--labs--llabs--_abs64.md)|[strcat](../VS_csharp/strcat--wcscat--_mbscat.md)||  
  
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
|[acos](../VS_csharp/acos--acosf--acosl.md)|[cosh](../VS_csharp/cos--cosf--cosl--cosh--coshf--coshl.md)|[pow](../VS_csharp/pow--powf--powl.md)|[tanh](../VS_csharp/tan--tanf--tanl--tanh--tanhf--tanhl.md)|  
|[asin](../VS_csharp/asin--asinf--asinl.md)|[fmod](../VS_csharp/fmod--fmodf.md)|[sinh](../VS_csharp/sin--sinf--sinl--sinh--sinhf--sinhl.md)||  
  
 The floating-point functions listed below have true intrinsic forms when you specify [/Oi](../VS_csharp/-oi--generate-intrinsic-functions-.md), [/Og](../VS_csharp/-og--global-optimizations-.md), and [/fp:fast](../VS_csharp/-fp--specify-floating-point-behavior-.md) (or any option that includes /Og: [/Ox](../VS_csharp/-ox--full-optimization-.md), [/O1](../VS_csharp/-o1---o2--minimize-size--maximize-speed-.md), and /O2):  
  
|||||  
|-|-|-|-|  
|[atan](../VS_csharp/atan--atanf--atanl--atan2--atan2f--atan2l.md)|[exp](../VS_csharp/exp--expf.md)|[log10](../VS_csharp/log--logf--log10--log10f.md)|[sqrt](../VS_csharp/sqrt--sqrtf--sqrtl.md)|  
|[atan2](../VS_csharp/atan--atanf--atanl--atan2--atan2f--atan2l.md)|[log](../VS_csharp/log--logf--log10--log10f.md)|[sin](../VS_csharp/sin--sinf--sinl--sinh--sinhf--sinhl.md)|[tan](../VS_csharp/tan--tanf--tanl--tanh--tanhf--tanhl.md)|  
|[cos](../VS_csharp/cos--cosf--cosl--cosh--coshf--coshl.md)||||  
  
 You can use [/fp:strict](../VS_csharp/-fp--specify-floating-point-behavior-.md) or [/Za](../VS_csharp/-za---ze--disable-language-extensions-.md) to override generation of true intrinsic floating-point options. In this case, the functions are generated as library routines that pass arguments directly to the floating-point chip instead of pushing them onto the program stack.  
  
 See [# pragma function](../VS_csharp/function--c-c---.md) for information and an example on how to enable/disable intrinsics for a block of source text.  
  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../VS_csharp/pragma-directives-and-the-__pragma-keyword.md)   
 [Compiler Intrinsics](../VS_csharp/compiler-intrinsics.md)