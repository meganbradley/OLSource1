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
Compiland information is split between symbols with a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> tag (low detail) and a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> tag (high detail). <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> requires loading additional symbols. However, it provides a wealth of information about the compiland that is not available with a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> symbol.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_backEndBuild](../vs140/idiasymbol--get_backendbuild.md)|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Back-end build number of the compiler.|  
|[IDiaSymbol::get_backEndMajor](../vs140/idiasymbol--get_backendmajor.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Back-end major version number of the compiler.|  
|[IDiaSymbol::get_backEndMinor](../vs140/idiasymbol--get_backendminor.md)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Back-end minor version number of the compiler.|  
|[compilerName](../vs140/idiasymbol--get_compilername.md)|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Name of the compiler that produced this compiland (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_editAndContinueEnabled](../vs140/idiasymbol--get_editandcontinueenabled.md)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if Edit and Continue were enabled at compilation.|  
|[IDiaSymbol::get_frontEndBuild](../vs140/idiasymbol--get_frontendbuild.md)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Front-end build number of the compiler.|  
|[IDiaSymbol::get_frontEndMajor](../vs140/idiasymbol--get_frontendmajor.md)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Front-end major version number of the compiler.|  
|[IDiaSymbol::get_frontEndMinor](../vs140/idiasymbol--get_frontendminor.md)|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Front-end minor version number of the compiler.|  
|[hasDebugInfo](../vs140/idiasymbol--get_hasdebuginfo.md)|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if this compiland has debug information (only in DIA SDK V8.0 or later).|  
|[hasManagedCode](../vs140/idiasymbol--get_hasmanagedcode.md)|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> if this compiland contains managed code (only in DIA SDK v8.0 or later).|  
|[hasSecurityChecks](../vs140/idiasymbol--get_hassecuritychecks.md)|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> if the compiland was compiled with the [/GS (Buffer Security Check)](../vs140/-gs--buffer-security-check-.md) compiler switch (only in DIA SDK V8.0 or later).|  
|[isCVTCIL](../vs140/idiasymbol--get_iscvtcil.md)|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if compiland was converted from Common Intermediate Language (CIL) code to native code.|  
|[isDataAligned](../vs140/idiasymbol--get_isdataaligned.md)|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> if user-defined types (UDT) have been aligned to some specified memory boundary (only in DIA SDK V8.0 or later).|  
|[isHotpatchable](../vs140/idiasymbol--get_ishotpatchable.md)|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if compiland was compiled with the [/hotpatch (Create Hotpatchable Image)](../vs140/-hotpatch--create-hotpatchable-image-.md) compiler switch (only in DIA SDK v8.0 or later).|  
|[isLTCG](../vs140/idiasymbol--get_isltcg.md)|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> if compiland was compiled with the [/LTCG (Link-time Code Generation)](../vs140/-ltcg--link-time-code-generation-.md) compiler switch (only in DIA SDK V8.0 or later).|  
|[isMSILNetmodule](../vs140/idiasymbol--get_ismsilnetmodule.md)|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|TRUE if compiland is a Microsoft Intermediate Language (MSIL) module (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_language](../vs140/idiasymbol--get_language.md)|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Source code language.|  
|[IDiaSymbol::get_lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Symbol for the compiland.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_platform](../vs140/idiasymbol--get_platform.md)|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Platform on which the compiland was compiled (one of the [CV_CPU_TYPE_e Enumeration](../vs140/cv_cpu_type_e.md) values).|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
  
## Remarks  
 Compilers often come in a form known as a two-pass compiler; in some compiler versions, each pass is handled by a separate program. These are known as front-end and back-end compilers, respectively, hence the symbol properties for back-end and front-end version numbers.  
  
## See Also  
 [Compiland](../vs140/compiland.md)   
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)