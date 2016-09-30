---
title: "Function (Debug Interface Access SDK)"
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
  - "Function symbol"
ms.assetid: 458dc91c-b78b-4427-84f4-615d89e26760
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Function (Debug Interface Access SDK)
Each function is identified by a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> symbol.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Description|  
|--------------|-----------------|-----------------|  
|[IDiaSymbol::get_access](../vs140/idiasymbol--get_access.md)|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|One of the values of the [CV_access_e Enumeration](../vs140/cv_access_e.md), if the function is a member function.|  
|[IDiaSymbol::get_addressOffset](../vs140/idiasymbol--get_addressoffset.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Offset part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../vs140/idiasymbol--get_addresssection.md)|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Section part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSymbol::get_classParent](../vs140/idiasymbol--get_classparent.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Symbol for the class, if the function is a member function.|  
|[classParentId](../vs140/idiasymbol--get_classparentid.md)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|ID of the class parent symbol.|  
|[constType](../vs140/idiasymbol--get_consttype.md)|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the function is marked as a constant.|  
|[customCallingConvention](../vs140/idiasymbol--get_customcallingconvention.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the function uses a custom calling convention (only in DIA SDK V8.0 or later).|  
|[farReturn](../vs140/idiasymbol--get_farreturn.md)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the function performs a far return (only in DIA SDK V8.0 or later).|  
|[hasAlloca](../vs140/idiasymbol--get_hasalloca.md)|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if the function uses allocated memory function (only uinnder DIA SDK V8.0 or later).|  
|[hasEH](../vs140/idiasymbol--get_haseh.md)|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> if the function contains C++-style exception handling (only in DIA SDK V8.0 or later).|  
|[hasEHa](../vs140/idiasymbol--get_haseha.md)|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> if the function contains asynchronous exception handling (only in DIA SDK V8.0 or later).|  
|[hasInlAsm](../vs140/idiasymbol--get_hasinlasm.md)|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if the function contains inline assembly (only in DIA SDK V8.0 or later).|  
|[hasLongJump](../vs140/idiasymbol--get_haslongjump.md)|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> if the function contains a [longjmp](../vs140/longjmp.md) call (only in DIA SDK V8.0 or later).|  
|[hasSecurityChecks](../vs140/idiasymbol--get_hassecuritychecks.md)|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if the function contains security checks (only in DIA SDK V8.0 or later).|  
|[hasSEH](../vs140/idiasymbol--get_hasseh.md)|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> if the function contains Win32-style structured exception handling (only in DIA SDK V8.0 or later).|  
|[hasSetJump](../vs140/idiasymbol--get_hassetjump.md)|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if the function contains a [setjmp](../vs140/setjmp.md) call (only in DIA SDK V8.0 or later).|  
|[interruptReturn](../vs140/idiasymbol--get_interruptreturn.md)|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if the function has a return from interrupt (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_intro](../vs140/idiasymbol--get_intro.md)|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder> if a function is intro virtual.|  
|[IDiaSymbol::get_InlSpec Method](../vs140/idiasymbol--get_inlspec.md)|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if the function has been marked with one of the [inline, __inline, \__forceinline](../vs140/inline--__inline--__forceinline.md) attributes.|  
|[isNaked](../vs140/idiasymbol--get_isnaked.md)|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> if the function is marked with the [naked (C++)](../vs140/naked--c---.md) attribute (only in DIA SDK V8.0 or later).|  
|[isStatic](../vs140/idiasymbol--get_isstatic.md)|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder> if the function is static (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_length](../vs140/idiasymbol--get_length.md)|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Number of bytes of function code, starting from location.|  
|[IDiaSymbol::get_lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Symbol of the enclosing compiland.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../vs140/idiasymbol--get_locationtype.md)|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Functions can have static or metadata locations; for details, see [Symbol Locations](../vs140/symbol-locations.md).|  
|[IDiaSymbol::get_name](../vs140/idiasymbol--get_name.md)|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|Name of the function.|  
|[noInline](../vs140/idiasymbol--get_noinline.md)|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder> if the function is not an inline function (only n DIA SDK V8.0 or later).|  
|[notReached](../vs140/idiasymbol--get_notreached.md)|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder> if the function is not reachable (only in DIA SDK V8.0 or later).|  
|[noReturn](../vs140/idiasymbol--get_noreturn.md)|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder> if the function does not return a value (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_noStackOrdering Method](../vs140/idiasymbol--get_nostackordering.md)|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder> if the function was compiled with buffer security checks but no stack ordering could be done.|  
|[optimizedCodeDebugInfo](../vs140/idiasymbol--get_optimizedcodedebuginfo.md)|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder> if the code has debug information for optimized code (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_pure](../vs140/idiasymbol--get_pure.md)|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder> if function is pure virtual.|  
|[relativeVirtualAddress](../vs140/idiasymbol--get_relativevirtualaddress.md)|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|Relative position of this function within its module.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_token](../vs140/idiasymbol--get_token.md)|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|Metadata token for the function.|  
|[IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md)|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|Symbol for the function signature.|  
|[typeId](../vs140/idiasymbol--get_typeid.md)|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|ID of the type symbol.|  
|[unalignedType](../vs140/idiasymbol--get_unalignedtype.md)|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder> if the function is unaligned.|  
|[undecoratedName](../vs140/idiasymbol--get_undecoratedname.md)|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|The undecorated form of the function name (only in DIA SDK v8.0 or later)|  
|[undecoratedNameEx](../vs140/idiasymbol--get_undecoratednameex.md)|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Part or all of the undecorated form of the function name (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_virtual](../vs140/idiasymbol--get_virtual.md)|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder> if a virtual function.|  
|[virtualAddress](../vs140/idiasymbol--get_virtualaddress.md)|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|Position of this function within the executable image.|  
|[IDiaSymbol::get_virtualBaseOffset](../vs140/idiasymbol--get_virtualbaseoffset.md)|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|If a virtual function, then the offset in the virtual function table.|  
|[volatileType](../vs140/idiasymbol--get_volatiletype.md)|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder> if the function is marked as volatile.|  
  
## See Also  
 [CV_access_e Enumeration](../vs140/cv_access_e.md)   
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../vs140/locationtype.md)   
 [Symbol Locations](../vs140/symbol-locations.md)