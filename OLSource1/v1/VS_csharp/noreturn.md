---
title: "noreturn"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "noreturn_cpp"
  - "noreturn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__declspec keyword [C++], noreturn"
  - "noreturn __declspec keyword"
ms.assetid: 9c6517e5-22d7-4051-9974-3d2200ae4d1d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# noreturn
## Microsoft Specific  
 This `__declspec` attribute tells the compiler that a function does not return. As a consequence, the compiler knows that the code following a call to a **__declspec(noreturn)** function is unreachable.  
  
 If the compiler finds a function with a control path that does not return a value, it generates a warning (C4715) or error message (C2202). If the control path cannot be reached due to a function that never returns, you can use **__declspec(noreturn)** to prevent this warning or error.  
  
> [!NOTE]
>  Adding **__declspec(noreturn)** to a function that is expected to return can result in undefined behavior.  
  
## Example  
 In the following sample,the **else** clause does not contain a return statement.  Declaring `fatal` as **__declspec(noreturn)** avoids an error or warning message.  
  
```  
// noreturn2.cpp  
__declspec(noreturn) extern void fatal () {}  
  
int main() {  
   if(1)  
     return 1;  
   else if(0)  
     return 0;  
   else  
     fatal();  
}  
```  
  
## See Also  
 [__declspec](../VS_csharp/__declspec.md)   
 [Keywords](../VS_csharp/keywords--c---.md)