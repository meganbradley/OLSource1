---
title: "OpenMP Libraries"
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
ms.assetid: f89abf97-67e3-4327-bc30-43f85b9533a2
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OpenMP Libraries
Discusses the .lib files that make up the OpenMP run-time libraries in Visual C++.  
  
 The following libraries contain the Visual C++ OpenMP run-time library functions.  
  
|OpenMP run-time library|Characteristics|  
|------------------------------|---------------------|  
|VCOMP.LIB|Multithreaded, dynamic link (import library for VCOMP.LIB).|  
|VCOMPD.LIB|Multithreaded, dynamic link (import library for VCOMPD.LID) (debug)|  
  
 If _DEBUG is defined in a compilation and if `#include omp.h` is in source code, VCOMPD.LIB will be the default lib. Otherwise, VCOMP.LIB will be used.  
  
 You can use [/NODEFAULTLIB (Ignore Libraries)](../VS_csharp/-nodefaultlib--ignore-libraries-.md) to remove the default lib and explicitly link with the lib of your choice.  
  
 The OpenMP DLLs are in the Visual C++ redistributable directory and need to be distributed with applications that use OpenMP.  
  
## See Also  
 [Library Reference](../VS_csharp/openmp-library-reference.md)