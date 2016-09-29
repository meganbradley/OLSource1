---
title: "__ll_lshift"
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
  - "__ll_lshift_cpp"
  - "__ll_lshift"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ll_lshift intrinsic"
  - "__ll_lshift intrinsic"
ms.assetid: fe98f733-426d-44b3-8f24-5d0d6d44bd94
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __ll_lshift
**Microsoft Specific**  
  
 Shifts the supplied 64-bit value to the left by the specified number of bits.  
  
## Syntax  
  
```  
unsigned __int64 __ll_lshift(  
   unsigned __int64 Mask,  
   int nBit  
);  
```  
  
#### Parameters  
 [in] `Mask`  
 The 64-bit integer value to shift left.  
  
 [in] `nBit`  
 The number of bits to shift.  
  
## Return Value  
 The mask shifted left by `nBit` bits.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|`__ll_lshift`|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** <intrin.h>  
  
## Remarks  
 If you compile your program using the 64 bit architecture and `nBit` is larger than 63, the number of bits to shift is `nBit` modulo 64. If you compile your program using the 32 bit architecture and `nBit` is larger than 31, the number of bits to shift is `nBit` modulo 32.  
  
 The `ll` in the name indicates that this is an operation on `long long` (`__int64`).  
  
## Example  
  
```  
// ll_lshift.cpp  
// compile with: /EHsc  
// processor: x86, x64  
#include <iostream>  
#include <intrin.h>  
using namespace std;  
  
#pragma intrinsic(__ll_lshift)  
  
int main()  
{  
   unsigned __int64 Mask = 0x100;  
   int nBit = 8;  
   Mask = __ll_lshift(Mask, nBit);  
   cout << hex << Mask << endl;  
}  
```  
  
## Output  
  
```  
10000  
```  
  
 **Note** There is no unsigned version of the left shift operation. This is because `__ll_lshift` already uses an unsigned input parameter. Unlike the right shift, there is no sign dependence for the left shift, because the least significant bit in the result is always set to zero regardless of the sign of the value shifted.  
  
### END Microsoft Specific  
  
## See Also  
 [__ll_rshift](../vs140/__ll_rshift.md)   
 [__ull_rshift](../vs140/__ull_rshift.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)