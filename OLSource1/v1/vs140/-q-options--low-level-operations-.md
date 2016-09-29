---
title: "-Q Options (Low-Level Operations)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Q Options (Low-Level Operations)"
f1_keywords: 
  - "/q"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Q compiler option [C++]"
  - "-Q compiler option [C++]"
  - "/Q compiler option [C++]"
ms.assetid: 9fa738b9-630a-4bde-bc87-bdfa30552be4
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Q Options (Low-Level Operations)
You can use the **/Q** compiler options to perform the following low-level compiler operations:  
  
-   [/Qfast_transcendentals (Force Fast Transcendentals)](../vs140/-qfast_transcendentals--force-fast-transcendentals-.md): Generates fast transcendentals.  
  
-   [/QIfist (Suppress _ftol)](../vs140/-qifist--suppress-_ftol-.md): Suppresses `_ftol` when a conversion from a floating-point type to an integer type is required (x86 only).  
  
-   [/Qimprecise_fwaits (Remove fwaits Inside try Blocks)](../vs140/-qimprecise_fwaits--remove-fwaits-inside-try-blocks-.md): Removes `fwait` commands inside `try` blocks.  
  
-   [/Qpar (Auto-Parallelizer)](../vs140/-qpar--auto-parallelizer-.md): Enables automatic parallelization of loops that are marked with the [#pragma loop()](../vs140/loop.md) directive.  
  
-   [/Qpar-report (Auto-Parallelizer)](../vs140/-qpar-report--auto-parallelizer-reporting-level-.md): Enables reporting levels for automatic parallelization.  
  
-   [/Qsafe_fp_loads](../vs140/-qsafe_fp_loads.md): Suppresses optimizations for floating-point register loads and for moves between memory and MMX registers.  
  
-   [/Qvec-report (Auto-Vectorizer)](../vs140/-qvec-report--auto-vectorizer-reporting-level-.md): Enables reporting levels for automatic vectorization.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)