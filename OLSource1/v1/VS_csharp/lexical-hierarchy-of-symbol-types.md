---
title: "Lexical Hierarchy of Symbol Types"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "symbols [DIA SDK], type hierarchies"
ms.assetid: 912da653-ddfe-45a4-84aa-64281283739a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lexical Hierarchy of Symbol Types
The following table shows the symbol types in the lexical hierarchy.  
  
## Symbol Types  
  
|Symbol type|Description|  
|-----------------|-----------------|  
|[Annotation](../VS_csharp/annotation.md)|Specifies an annotated location in program code.|  
|[Block](../VS_csharp/block.md)|Specifies nested scopes in functions.|  
|`Compiland`|Specifies a `compiland` linked to the .exe file.|  
|[CompilandDetails](../VS_csharp/compilanddetails.md)|Specifies compiland data that may require loading additional compiland details and thus incur run-time overhead to retrieve.|  
|[CompilandEnv](../VS_csharp/compilandenv.md)|Specifies any additional environment variables significant to the compilation of the compiland.|  
|[Custom (Debug Interface Access SDK)](../VS_csharp/custom--debug-interface-access-sdk-.md)|Specifies a user-defined symbol.|  
|[Data (Debug Interface Access SDK)](../VS_csharp/data--debug-interface-access-sdk-.md)|Specifies such variables as parameters, local variables, global variables, and class members.|  
|[Exe](../VS_csharp/exe.md)|Specifies the global scope of the data; corresponds to an entire .exe or .dll file.|  
|[FuncDebugEnd](../VS_csharp/funcdebugend.md)|Specifies a function that has a defined point at which debugging is to end.|  
|[FuncDebugStart](../VS_csharp/funcdebugstart.md)|Specifies a function that has a defined point at which debugging is to begin.|  
|[Function (Debug Interface Access SDK)](../VS_csharp/function--debug-interface-access-sdk-.md)|Specifies a function.|  
|[Label (Debug Interface Access SDK)](../VS_csharp/label--debug-interface-access-sdk-.md)|Specifies a location in program code.|  
|[PublicSymbol](../VS_csharp/publicsymbol.md)|Specifies an external symbol that appears when building the executable program.|  
|[Thunk](../VS_csharp/thunk.md)|Specifies a `thunk`.|  
|[UsingNameSpace](../VS_csharp/usingnamespace.md)|Specifies a `namespace`identifier.|  
  
> [!NOTE]
>  Additional symbol properties may be available depending on the symbol type. These properties are listed in the individual symbol topics.  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_csharp/class-hierarchy-of-symbol-types.md)   
 [IDiaSymbol::get_symTag](../VS_csharp/idiasymbol--get_symtag.md)   
 [Symbols and Symbol Tags](../VS_csharp/symbols-and-symbol-tags.md)   
 [SymTagEnum Enumeration](../VS_csharp/symtagenum.md)