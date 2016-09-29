---
title: "Storage of Bit Fields"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
ms.assetid: 4816a241-1580-4d1c-82ed-13d359733959
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Storage of Bit Fields
**ANSI 3.5.2.1** The order of allocation of bit fields within an int  
  
 Bit fields are allocated within an integer from least-significant to most-significant bit. In the following code  
  
```  
struct mybitfields  
{  
   unsigned a : 4;  
   unsigned b : 5;  
   unsigned c : 7;  
} test;  
  
int main( void )  
{  
   test.a = 2;  
   test.b = 31;  
   test.c = 0;  
}  
```  
  
 the bits would be arranged as follows:  
  
```  
00000001 11110010  
cccccccb bbbbaaaa  
```  
  
 Since the 80x86 processors store the low byte of integer values before the high byte, the integer 0x01F2 above would be stored in physical memory as 0xF2 followed by 0x01.  
  
## See Also  
 [Structures, Unions, Enumerations, and Bit Fields](../vs140/structures--unions--enumerations--and-bit-fields.md)