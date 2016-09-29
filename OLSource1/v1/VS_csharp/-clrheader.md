---
title: "-CLRHEADER"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/CLRHEADER"
f1_keywords: 
  - "/CLRHEADER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-CLRHEADER dumpbin option"
  - "/CLRHEADER dumpbin option"
  - "CLRHEADER dumpbin option"
ms.assetid: cf73424f-4541-47e2-b94e-69b95266ef2a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -CLRHEADER
```  
/CLRHEADER file  
```  
  
## Remarks  
 where:  
  
 `file`  
 An image file built with [/clr](../VS_csharp/-clr--common-language-runtime-compilation-.md).  
  
## Remarks  
 CLRHEADER displays information about the .NET headers used in any managed program. The output shows the location and size, in bytes, of the .NET header and sections in the header.  
  
 Only the [/HEADERS](../VS_csharp/-headers.md) DUMPBIN option is available for use on files produced with the [/GL](../VS_csharp/-gl--whole-program-optimization-.md) compiler option.  
  
 When /CLRHEADER is used on a file that was compiled with /clr, there will be a **clr Header:** section in the dumpbin output.  The value of **flags** indicates which /clr option was used:  
  
-   0  -- /clr (image may contain native code).  
  
-   1 -- /clr:safe (image is MSIL only, able to run on any CLR platform, and possibly verifiable).  
  
-   3 -- /clr:pure (image is MSIL only, but only able to run on x86 platforms).  
  
 You can also programmatically check if an image was built for the common language runtime.  For more information, see [How to: Determine if Image is Native or CLR](../VS_csharp/how-to--determine-if-an-image-is-native-or-clr.md).  
  
## See Also  
 [DUMPBIN Options](../VS_csharp/dumpbin-options.md)