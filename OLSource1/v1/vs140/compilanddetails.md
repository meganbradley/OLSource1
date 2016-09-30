---
title: "CompilandDetails"
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
  - "CompilandDetails symbol"
ms.assetid: ddc7d794-c622-4c63-b2a6-72f8b2d0022a
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CompilandDetails
Compiland information is split between symbols with a `SymTagCompiland` tag (low detail) and a `SymTagCompilandDetails` tag (high detail). `SymTagCompilandDetails` requires loading additional symbols. However, it provides a wealth of information about the compiland that is not available with a `SymTagCompiland` symbol.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_backEndBuild](../vs140/idiasymbol--get_backendbuild.md)|`DWORD`|Back-end build number of the compiler.|  
|[IDiaSymbol::get_backEndMajor](../vs140/idiasymbol--get_backendmajor.md)|`DWORD`|Back-end major version number of the compiler.|  
|[IDiaSymbol::get_backEndMinor](../vs140/idiasymbol--get_backendminor.md)|`DWORD`|Back-end minor version number of the compiler.|  
|[compilerName](../vs140/idiasymbol--get_compilername.md)|`BSTR`|Name of the compiler that produced this compiland (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_editAndContinueEnabled](../vs140/idiasymbol--get_editandcontinueenabled.md)|`BOOL`|`TRUE` if Edit and Continue were enabled at compilation.|  
|[IDiaSymbol::get_frontEndBuild](../vs140/idiasymbol--get_frontendbuild.md)|`DWORD`|Front-end build number of the compiler.|  
|[IDiaSymbol::get_frontEndMajor](../vs140/idiasymbol--get_frontendmajor.md)|`DWORD`|Front-end major version number of the compiler.|  
|[IDiaSymbol::get_frontEndMinor](../vs140/idiasymbol--get_frontendminor.md)|`DWORD`|Front-end minor version number of the compiler.|  
|[hasDebugInfo](../vs140/idiasymbol--get_hasdebuginfo.md)|`BOOL`|`TRUE` if this compiland has debug information (only in DIA SDK V8.0 or later).|  
|[hasManagedCode](../vs140/idiasymbol--get_hasmanagedcode.md)|`BOOL`|`TRUE` if this compiland contains managed code (only in DIA SDK v8.0 or later).|  
|[hasSecurityChecks](../vs140/idiasymbol--get_hassecuritychecks.md)|`BOOL`|`TRUE` if the compiland was compiled with the [/GS (Buffer Security Check)](../vs140/-gs--buffer-security-check-.md) compiler switch (only in DIA SDK V8.0 or later).|  
|[isCVTCIL](../vs140/idiasymbol--get_iscvtcil.md)|`BOOL`|`TRUE` if compiland was converted from Common Intermediate Language (CIL) code to native code.|  
|[isDataAligned](../vs140/idiasymbol--get_isdataaligned.md)|`BOOL`|`TRUE` if user-defined types (UDT) have been aligned to some specified memory boundary (only in DIA SDK V8.0 or later).|  
|[isHotpatchable](../vs140/idiasymbol--get_ishotpatchable.md)|`BOOL`|`TRUE` if compiland was compiled with the [/hotpatch (Create Hotpatchable Image)](../vs140/-hotpatch--create-hotpatchable-image-.md) compiler switch (only in DIA SDK v8.0 or later).|  
|[isLTCG](../vs140/idiasymbol--get_isltcg.md)|`BOOL`|`TRUE` if compiland was compiled with the [/LTCG (Link-time Code Generation)](../vs140/-ltcg--link-time-code-generation-.md) compiler switch (only in DIA SDK V8.0 or later).|  
|[isMSILNetmodule](../vs140/idiasymbol--get_ismsilnetmodule.md)|`BOOL`|TRUE if compiland is a Microsoft Intermediate Language (MSIL) module (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_language](../vs140/idiasymbol--get_language.md)|`DWORD`|Source code language.|  
|[IDiaSymbol::get_lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol for the compiland.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_platform](../vs140/idiasymbol--get_platform.md)|`DWORD`|Platform on which the compiland was compiled (one of the [CV_CPU_TYPE_e Enumeration](../vs140/cv_cpu_type_e.md) values).|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagCompilandDetails` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
  
## Remarks  
 Compilers often come in a form known as a two-pass compiler; in some compiler versions, each pass is handled by a separate program. These are known as front-end and back-end compilers, respectively, hence the symbol properties for back-end and front-end version numbers.  
  
## See Also  
 [Compiland](../vs140/compiland.md)   
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)