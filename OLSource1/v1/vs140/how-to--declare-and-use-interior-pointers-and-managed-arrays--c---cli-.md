---
title: "How to: Declare and Use Interior Pointers and Managed Arrays (C++-CLI)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
H1: How to: Declare and Use Interior Pointers and Managed Arrays (C++/CLI)
dev_langs: 
  - C++
helpviewer_keywords: 
  - pointers, interior
  - arrays [C++], managed
ms.assetid: e61a2c09-a7d0-4867-91ea-6b8788a01079
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Declare and Use Interior Pointers and Managed Arrays (C++-CLI)
The following [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)] sample shows how you can declare and use an interior pointer to an array.  
  
> [!IMPORTANT]
>  This language feature is supported by the **/clr** compiler option, but not by the **/ZW** compiler option.  
  
## Example  
  
### Code  
  
```  
// interior_ptr_arrays.cpp  
// compile with: /clr  
#define SIZE 10  
  
int main() {  
   // declare the array  
   array<int>^ arr = gcnew array<int>(SIZE);  
  
   // initialize the array  
   for (int i = 0 ; i < SIZE ; i++)  
      arr[i] = i + 1;  
  
   // create an interior pointer into the array  
   interior_ptr<int> ipi = &arr[0];  
  
   System::Console::WriteLine("1st element in arr holds: {0}", arr[0]);  
   System::Console::WriteLine("ipi points to memory address whose value is: {0}", *ipi);  
  
   ipi++;  
   System::Console::WriteLine("after incrementing ipi, it points to memory address whose value is: {0}", *ipi);  
}  
```  
  
### Output  
  
```  
1st element in arr holds: 1  
ipi points to memory address whose value is: 1  
after incrementing ipi, it points to memory address whose value is: 2  
```  
  
## See Also  
 [interior_ptr (C++/CLI)](../vs140/interior_ptr--c---cli-.md)