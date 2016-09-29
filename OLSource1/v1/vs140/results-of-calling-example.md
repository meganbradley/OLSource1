---
title: "Results of Calling Example"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "examples [C++], results of calling"
  - "results, thiscall call"
  - "results, __fastcall keyword call"
  - "results, __cdecl call"
  - "results, __stdcall call"
ms.assetid: aa70a7cb-ba1d-4aa6-bd0a-ba783da2e642
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Results of Calling Example
## Microsoft Specific  
  
## __cdecl  
 The C decorated function name is "_MyFunc."  
  
 ![CDECL calling convention](../vs140/media/vc37i01.gif "vc37I01")  
The __cdecl calling convention  
  
## __stdcall and thiscall  
 The C decorated name (`__stdcall`) is "_MyFunc@20." The C++ decorated name is proprietary.  
  
 ![&#95;&#95;stdcall and thiscall calling conventions](../vs140/media/vc37i02.gif "vc37I02")  
The __stdcall and thiscall calling conventions  
  
## __fastcall  
 The C decorated name (`__fastcall`) is "@MyFunc@20." The C++ decorated name is proprietary.  
  
 ![Calling convention for &#95;&#95;fastcall](../vs140/media/vc37i03.gif "vc37I03")  
The __fastcall calling convention  
  
### END Microsoft Specific  
  
## See Also  
 [Calling Example: Function Prototype and Call](../vs140/calling-example--function-prototype-and-call.md)