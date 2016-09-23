---
title: "Function (Debug Interface Access SDK)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - Function symbol
ms.assetid: 458dc91c-b78b-4427-84f4-615d89e26760
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Function (Debug Interface Access SDK)
Each function is identified by a `SymTagFunction` symbol.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|`Data type`|Description|  
|--------------|-----------------|-----------------|  
|[IDiaSymbol::get_access](../vs140/idiasymbol--get_access.md)|`DWORD`|One of the values of the [CV_access_e Enumeration](../vs140/cv_access_e.md), if the function is a member function.|  
|[IDiaSymbol::get_addressOffset](../vs140/idiasymbol--get_addressoffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../vs140/idiasymbol--get_addresssection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSymbol::get_classParent](../vs140/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Symbol for the class, if the function is a member function.|  
|[classParentId](../vs140/idiasymbol--get_classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[constType](../vs140/idiasymbol--get_consttype.md)|`BOOL`|`TRUE` if the function is marked as a constant.|  
|[customCallingConvention](../vs140/idiasymbol--get_customcallingconvention.md)|`BOOL`|`TRUE` if the function uses a custom calling convention (only in DIA SDK V8.0 or later).|  
|[farReturn](../vs140/idiasymbol--get_farreturn.md)|`BOOL`|`TRUE` if the function performs a far return (only in DIA SDK V8.0 or later).|  
|[hasAlloca](../vs140/idiasymbol--get_hasalloca.md)|`BOOL`|`TRUE` if the function uses allocated memory function (only uinnder DIA SDK V8.0 or later).|  
|[hasEH](../vs140/idiasymbol--get_haseh.md)|`BOOL`|`TRUE` if the function contains C++-style exception handling (only in DIA SDK V8.0 or later).|  
|[hasEHa](../vs140/idiasymbol--get_haseha.md)|`BOOL`|`TRUE` if the function contains asynchronous exception handling (only in DIA SDK V8.0 or later).|  
|[hasInlAsm](../vs140/idiasymbol--get_hasinlasm.md)|`BOOL`|`TRUE` if the function contains inline assembly (only in DIA SDK V8.0 or later).|  
|[hasLongJump](../vs140/idiasymbol--get_haslongjump.md)|`BOOL`|`TRUE` if the function contains a [longjmp](../vs140/longjmp.md) call (only in DIA SDK V8.0 or later).|  
|[hasSecurityChecks](../vs140/idiasymbol--get_hassecuritychecks.md)|`BOOL`|`TRUE` if the function contains security checks (only in DIA SDK V8.0 or later).|  
|[hasSEH](../vs140/idiasymbol--get_hasseh.md)|`BOOL`|`TRUE` if the function contains Win32-style structured exception handling (only in DIA SDK V8.0 or later).|  
|[hasSetJump](../vs140/idiasymbol--get_hassetjump.md)|`BOOL`|`TRUE` if the function contains a [setjmp](../vs140/setjmp.md) call (only in DIA SDK V8.0 or later).|  
|[interruptReturn](../vs140/idiasymbol--get_interruptreturn.md)|`BOOL`|`TRUE` if the function has a return from interrupt (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_intro](../vs140/idiasymbol--get_intro.md)|`BOOL`|`TRUE` if a function is intro virtual.|  
|[IDiaSymbol::get_InlSpec Method](../vs140/idiasymbol--get_inlspec.md)|`BOOL`|`TRUE` if the function has been marked with one of the [inline, __inline, \__forceinline](../vs140/inline--__inline--__forceinline.md) attributes.|  
|[isNaked](../vs140/idiasymbol--get_isnaked.md)|`BOOL`|`TRUE` if the function is marked with the [naked (C++)](../vs140/naked--c---.md) attribute (only in DIA SDK V8.0 or later).|  
|[isStatic](../vs140/idiasymbol--get_isstatic.md)|`BOOL`|`TRUE` if the function is static (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_length](../vs140/idiasymbol--get_length.md)|`ULONGLONG`|Number of bytes of function code, starting from location.|  
|[IDiaSymbol::get_lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../vs140/idiasymbol--get_locationtype.md)|`DWORD`|Functions can have static or metadata locations; for details, see [Symbol Locations](../vs140/symbol-locations.md).|  
|[IDiaSymbol::get_name](../vs140/idiasymbol--get_name.md)|`BSTR`|Name of the function.|  
|[noInline](../vs140/idiasymbol--get_noinline.md)|`BOOL`|`TRUE` if the function is not an inline function (only n DIA SDK V8.0 or later).|  
|[notReached](../vs140/idiasymbol--get_notreached.md)|`BOOL`|`TRUE` if the function is not reachable (only in DIA SDK V8.0 or later).|  
|[noReturn](../vs140/idiasymbol--get_noreturn.md)|`BOOL`|`TRUE` if the function does not return a value (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_noStackOrdering Method](../vs140/idiasymbol--get_nostackordering.md)|`BOOL`|`TRUE` if the function was compiled with buffer security checks but no stack ordering could be done.|  
|[optimizedCodeDebugInfo](../vs140/idiasymbol--get_optimizedcodedebuginfo.md)|`BOOL`|`TRUE` if the code has debug information for optimized code (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_pure](../vs140/idiasymbol--get_pure.md)|`BOOL`|`TRUE` if function is pure virtual.|  
|[relativeVirtualAddress](../vs140/idiasymbol--get_relativevirtualaddress.md)|`DWORD`|Relative position of this function within its module.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagFunction` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_token](../vs140/idiasymbol--get_token.md)|`DWORD`|Metadata token for the function.|  
|[IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md)|`IDiaSymbol*`|Symbol for the function signature.|  
|[typeId](../vs140/idiasymbol--get_typeid.md)|`DWORD`|ID of the type symbol.|  
|[unalignedType](../vs140/idiasymbol--get_unalignedtype.md)|`BOOL`|`TRUE` if the function is unaligned.|  
|[undecoratedName](../vs140/idiasymbol--get_undecoratedname.md)|`BSTR`|The undecorated form of the function name (only in DIA SDK v8.0 or later)|  
|[undecoratedNameEx](../vs140/idiasymbol--get_undecoratednameex.md)|`BSTR`|Part or all of the undecorated form of the function name (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_virtual](../vs140/idiasymbol--get_virtual.md)|`BOOL`|`TRUE` if a virtual function.|  
|[virtualAddress](../vs140/idiasymbol--get_virtualaddress.md)|`ULONGLONG`|Position of this function within the executable image.|  
|[IDiaSymbol::get_virtualBaseOffset](../vs140/idiasymbol--get_virtualbaseoffset.md)|`DWORD`|If a virtual function, then the offset in the virtual function table.|  
|[volatileType](../vs140/idiasymbol--get_volatiletype.md)|`BOOL`|`TRUE` if the function is marked as volatile.|  
  
## See Also  
 [CV_access_e Enumeration](../vs140/cv_access_e.md)   
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../vs140/locationtype.md)   
 [Symbol Locations](../vs140/symbol-locations.md)