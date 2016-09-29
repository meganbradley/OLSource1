---
title: "#pragma (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "#pragma"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "#pragma directive [C#]"
ms.assetid: 5b7944cd-d402-46a1-ad8f-feffb2d83673
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #pragma (C# Reference)
`#pragma` gives the compiler special instructions for the compilation of the file in which it appears. The instructions must be supported by the compiler. In other words, you cannot use `#pragma` to create custom preprocessing instructions. The Microsoft C# compiler supports the following two `#pragma` instructions:  
  
 [#pragma warning](../VS_csharp/sharppragma-warning--csharp-reference-.md)  
  
 [#pragma checksum](../VS_csharp/sharppragma-checksum--csharp-reference-.md)  
  
## Syntax  
  
```  
#pragma pragma-name pragma-arguments  
```  
  
#### Parameters  
 `pragma-name`  
 The name of a recognized pragma.  
  
 `pragma-arguments`  
 Pragma-specific arguments.  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Preprocessor Directives](../VS_csharp/csharp-preprocessor-directives.md)   
 [#pragma warning](../VS_csharp/sharppragma-warning--csharp-reference-.md)   
 [#pragma checksum](../VS_csharp/sharppragma-checksum--csharp-reference-.md)