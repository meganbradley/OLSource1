---
title: "Linker Tools Error LNK1301"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "LNK1301"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK1301"
ms.assetid: 760da428-7182-4b25-b20a-de90d4b9a9cd
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Error LNK1301
LTCG clr modules found, incompatible with /LTCG:parameter  
  
 A module compiled with /clr and /GL was passed to the linker along with one of the profile guided optimizations (PGO) parameters of /LTCG.  
  
 Profile guided optimizations are not supported for /clr modules.  
  
 For more information, see:  
  
-   [/GL (Whole Program Optimization)](../VS_csharp/-gl--whole-program-optimization-.md)  
  
-   [/LTCG (Link-time Code Generation)](../VS_csharp/-ltcg--link-time-code-generation-.md)  
  
-   [/clr (Common Language Runtime Compilation)](../VS_csharp/-clr--common-language-runtime-compilation-.md)  
  
-   [Profile-Guided Optimizations](../VS_csharp/profile-guided-optimizations.md)  
  
### To correct this error  
  
1.  Do not compile with /clr or do not link with one of the PGO parameters to /LTCG.  
  
## Example  
 The following sample generates LNK1301:  
  
```  
// LNK1301.cpp  
// compile with: /clr /GL /link /LTCG:PGI LNK1301.obj  
// LNK1301 expected  
class MyClass {  
public:  
   int i;  
};  
```