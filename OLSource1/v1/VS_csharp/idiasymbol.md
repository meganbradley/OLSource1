---
title: "IDiaSymbol"
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
  - "IDiaSymbol interface"
ms.assetid: 01ad328a-736c-4933-a9f8-c2ded19ddd8c
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol
Describes the properties of a symbol instance.  
  
## Syntax  
  
```  
IDiaSymbol : IUnknown  
```  
  
## Methods in Alphabetical Order  
 The following table shows the methods of `IDiaSymbol`.  
  
> [!NOTE]
>  Symbols will return meaningful data for only some of these methods, depending on the type of symbol. If a method returns `S_OK`, then that method has returned meaningful data.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaSymbol::findChildren](../VS_csharp/idiasymbol--findchildren.md)|Retrieves all children of the symbol.|  
|[findChildrenEx](../VS_csharp/idiasymbol--findchildrenex.md)|Retrieves the children of the symbol. This method is the extended version of [IDiaSymbol::findChildren](../VS_csharp/idiasymbol--findchildren.md).|  
|[findChildrenExByAddr](../VS_csharp/idiasymbol--findchildrenexbyaddr.md)|Retrieves the children of the symbol that are valid at a specified address.|  
|[findChildrenExByRVA](../VS_csharp/idiasymbol--findchildrenexbyrva.md)|Retrieves the children of the symbol that are valid at a specified relative virtual address (RVA).|  
|[findChildrenExByVA](../VS_csharp/idiasymbol--findchildrenexbyva.md)|Retrieves the children of the symbol that are valid at a specified virtual address.|  
|[findInlineFramesByAddr](../VS_csharp/idiasymbol--findinlineframesbyaddr.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a given address.|  
|[findInlineFramesByRVA](../VS_csharp/idiasymbol--findinlineframesbyrva.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified relative virtual address (RVA).|  
|[findInlineFramesByVA](../VS_csharp/idiasymbol--findinlineframesbyva.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified virtual address (VA).|  
|[findInlineeLines](../VS_csharp/idiasymbol--findinlineelines.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol.|  
|[findInlineeLinesByAddr](../VS_csharp/idiasymbol--findinlineelinesbyaddr.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol within the specified address range.|  
|[findInlineeLinesByRVA](../VS_csharp/idiasymbol--findinlineelinesbyrva.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol within the specified relative virtual address (RVA).|  
|[findInlineeLinesByVA](../VS_csharp/idiasymbol--findinlineelinesbyva.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol within the specified virtual address (VA).|  
|[findSymbolsByRVAForAcceleratorPointerTag](../VS_csharp/idiasymbol--findsymbolsbyrvaforacceleratorpointertag.md)|Given a corresponding tag value, this method returns an enumeration of symbols that are contained in this stub function at a specified relative virtual address.|  
|[findSymbolsForAcceleratorPointerTags](../VS_csharp/idiasymbol--findsymbolsforacceleratorpointertag.md)|Returns the number of accelerator pointer tags in a C++ AMP stub function.|  
|[get_acceleratorPointerTags](../VS_csharp/idiasymbol--get_acceleratorpointertags.md)|Returns all accelerator pointer tag values that correspond to a C++ AMP accelerator stub function.|  
|[IDiaSymbol::get_access](../VS_csharp/idiasymbol--get_access.md)|Retrieves the access modifier of a class member.|  
|[IDiaSymbol::get_addressOffset](../VS_csharp/idiasymbol--get_addressoffset.md)|Retrieves the offset part of an address location.|  
|[IDiaSymbol::get_addressSection](../VS_csharp/idiasymbol--get_addresssection.md)|Retrieves the section part of an address location.|  
|[IDiaSymbol::get_addressTaken](../VS_csharp/idiasymbol--get_addresstaken.md)|Retrieves a flag indicating whether another symbol references this address.|  
|[IDiaSymbol::get_age](../VS_csharp/idiasymbol--get_age.md)|Retrieves the age value of a program database.|  
|[IDiaSymbol::get_arrayIndexType](../VS_csharp/idiasymbol--get_arrayindextype.md)|Retrieves the symbol identifier of the array index type.|  
|[IDiaSymbol::get_arrayIndexTypeId](../VS_csharp/idiasymbol--get_arrayindextypeid.md)|Retrieves the array index type identifier of the symbol.|  
|[IDiaSymbol::get_backEndMajor](../VS_csharp/idiasymbol--get_backendmajor.md)|Retrieves the back-end major version number.|  
|[IDiaSymbol::get_backEndMinor](../VS_csharp/idiasymbol--get_backendminor.md)|Retrieves the back-end minor version number.|  
|[IDiaSymbol::get_backEndBuild](../VS_csharp/idiasymbol--get_backendbuild.md)|Retrieves the back-end build number.|  
|[get_baseDataOffset](../VS_csharp/idiasymbol--get_basedataoffset.md)|Retrieves the base data offset.|  
|[get_baseDataSlot](../VS_csharp/idiasymbol--get_basedataslot.md)|Retrieves the base data slot.|  
|[get_baseSymbol](../VS_csharp/idiasymbol--get_basesymbol.md)|Retrieves the symbol from which the pointer is based.|  
|[get_baseSymbolId](../VS_csharp/idiasymbol--get_basesymbolid.md)|Retrieves the symbol ID from which the pointer is based.|  
|[IDiaSymbol::get_baseType](../VS_csharp/idiasymbol--get_basetype.md)|Retrieves the type tag of a simple type.|  
|[IDiaSymbol::get_bitPosition](../VS_csharp/idiasymbol--get_bitposition.md)|Retrieves the bit position of a location.|  
|[get_builtInKind](../VS_csharp/idiasymbol--get_builtinkind.md)|Retrieves a built-in kind of the HLSL type.|  
|[IDiaSymbol::get_callingConvention](../VS_csharp/idiasymbol--get_callingconvention.md)|Returns an indicator of a method's calling convention.|  
|[IDiaSymbol::get_classParent](../VS_csharp/idiasymbol--get_classparent.md)|Retrieves a reference to the class parent of the symbol.|  
|[IDiaSymbol::get_classParentId](../VS_csharp/idiasymbol--get_classparentid.md)|Retrieves the class parent identifier of the symbol.|  
|[IDiaSymbol::get_code](../VS_csharp/idiasymbol--get_code.md)|Retrieves a flag indicating whether the symbol refers to a code address.|  
|[IDiaSymbol::get_compilerGenerated](../VS_csharp/idiasymbol--get_compilergenerated.md)|Retrieves a flag indicating whether the symbol was compiler-generated.|  
|[get_compilerName](../VS_csharp/idiasymbol--get_compilername.md)|Retrieves the name of the compiler used to create the [Compiland](../VS_csharp/compiland.md).|  
|[IDiaSymbol::get_constructor](../VS_csharp/idiasymbol--get_constructor.md)|Retrieves a flag indicating whether the user-defined data type has a constructor.|  
|[IDiaSymbol::get_container](../VS_csharp/idiasymbol--get_container.md)|Retrieves the containing symbol of this symbol.|  
|[IDiaSymbol::get_constType](../VS_csharp/idiasymbol--get_consttype.md)|Retrieves a flag indicating whether the user-defined data type is constant.|  
|[IDiaSymbol::get_count](../VS_csharp/idiasymbol--get_count.md)|Retrieves the number of items in a list or array.|  
|[get_countLiveRanges](../VS_csharp/idiasymbol--get_countliveranges.md)|Retrieves the number of valid address ranges associated with the local symbol.|  
|[get_customCallingConvention](../VS_csharp/idiasymbol--get_customcallingconvention.md)|Retrieves a flag indicating whether the function uses a custom calling convention.|  
|[IDiaSymbol::get_dataBytes](../VS_csharp/idiasymbol--get_databytes.md)|Retrieves the data bytes of an OEM symbol.|  
|[IDiaSymbol::get_dataKind](../VS_csharp/idiasymbol--get_datakind.md)|Retrieves the variable classification of a data symbol.|  
|[IDiaSymbol::get_editAndContinueEnabled](../VS_csharp/idiasymbol--get_editandcontinueenabled.md)|Retrieves the flag describing the Edit and Continue features of the compiled program or unit.|  
|[get_farReturn](../VS_csharp/idiasymbol--get_farreturn.md)|Retrieves a flag indicating whether the function uses a far return.|  
|[IDiaSymbol::get_frontEndMajor](../VS_csharp/idiasymbol--get_frontendmajor.md)|Retrieves the front-end major version number.|  
|[IDiaSymbol::get_frontEndMinor](../VS_csharp/idiasymbol--get_frontendminor.md)|Retrieves the front-end minor version number.|  
|[IDiaSymbol::get_frontEndBuild](../VS_csharp/idiasymbol--get_frontendbuild.md)|Retrieves the front-end build number.|  
|[IDiaSymbol::get_function](../VS_csharp/idiasymbol--get_function.md)|Retrieves a flag indicating whether the public symbol refers to a function.|  
|[IDiaSymbol::get_guid](../VS_csharp/idiasymbol--get_guid.md)|Retrieves the symbol's GUID.|  
|[get_hasAlloca](../VS_csharp/idiasymbol--get_hasalloca.md)|Retrieves a flag indicating whether the function contains a call to `alloca`.|  
|[IDiaSymbol::get_hasAssignmentOperator](../VS_csharp/idiasymbol--get_hasassignmentoperator.md)|Retrieves a flag indicating whether the user-defined data type has any assignment operators defined.|  
|[IDiaSymbol::get_hasCastOperator](../VS_csharp/idiasymbol--get_hascastoperator.md)|Retrieves a flag indicating whether the user-defined data type has any cast operators defined.|  
|[get_hasDebugInfo](../VS_csharp/idiasymbol--get_hasdebuginfo.md)|Retrieves a flag indicating whether the compiland contains any debugging information.|  
|[get_hasEH](../VS_csharp/idiasymbol--get_haseh.md)|Retrieves a flag indicating whether the function has a C++-style exception handler.|  
|[get_hasEHa](../VS_csharp/idiasymbol--get_haseha.md)|Retrieves a flag indicating whether the function has an asynchronous exception handler.|  
|[get_hasInlAsm](../VS_csharp/idiasymbol--get_hasinlasm.md)|Retrieves a flag indicating whether the function has inline assembly.|  
|[get_hasLongJump](../VS_csharp/idiasymbol--get_haslongjump.md)|Retrieves a flag indicating whether the function contains a longjmp command (part of C-style exception handling).|  
|[get_hasManagedCode](../VS_csharp/idiasymbol--get_hasmanagedcode.md)|Retrieves a flag indicating whether the module contains managed code.|  
|[IDiaSymbol::get_hasNestedTypes](../VS_csharp/idiasymbol--get_hasnestedtypes.md)|Retrieves a flag indicating whether the user-defined data type has nested type definitions.|  
|[get_hasSecurityChecks](../VS_csharp/idiasymbol--get_hassecuritychecks.md)|Retrieves a flag indicating whether the function or compiland has security checks compiled in (via the [/GS (Buffer Security Check)](../VS_csharp/-gs--buffer-security-check-.md) compiler switch).|  
|[get_hasSEH](../VS_csharp/idiasymbol--get_hasseh.md)|Retrieves a flag indicating whether the function has Win32-style Structured Exception Handling.|  
|[get_hasSetJump](../VS_csharp/idiasymbol--get_hassetjump.md)|Retrieves a flag indicating whether the function contains a setjmp command.|  
|[IDiaSymbol::get_indirectVirtualBaseClass](../VS_csharp/idiasymbol--get_indirectvirtualbaseclass.md)|Retrieves a flag indicating whether the user-defined data type is an indirect virtual base class.|  
|[get_InlSpec](../VS_csharp/idiasymbol--get_inlspec.md)|Retrieves a flag indicating whether the function has been marked with the inline attribute.|  
|[get_interruptReturn](../VS_csharp/idiasymbol--get_interruptreturn.md)|Retrieves a flag indicating whether the function has a return from interrupt instruction.|  
|[IDiaSymbol::get_intro](../VS_csharp/idiasymbol--get_intro.md)|Retrieves a flag indicating whether the function is the base class virtual function.|  
|[get_isAcceleratorGroupSharedLocal](../VS_csharp/idiasymbol--get_isacceleratorgroupsharedlocal.md)|Retrieves a flag that indicates whether the symbol corresponds to a group shared local variable in code compiled for a C++ AMP Accelerator.|  
|[get_isAcceleratorPointerTagLiveRange](../VS_csharp/idiasymbol--get_isacceleratorpointertagliverange.md)|Retrieves a flag that indicates whether the symbol corresponds to the *definition range symbol* for the tag component of a pointer variable in code compiled for a C++ AMP Accelerator. The definition range symbol is the location of a variable for a span of addresses.|  
|[get_isAcceleratorStubFunction](../VS_csharp/idiasymbol--get_isacceleratorstubfunction.md)|Indicates whether the symbol corresponds to a top-level function symbol for a shader compiled for an accelerator that corresponds to a `parallel_for_each` call.|  
|[get_isAggregated](../VS_csharp/idiasymbol--get_isaggregated.md)|Retrieves a flag indicating whether the data is part of an aggregate of many symbols.|  
|[get_isCTypes](../VS_csharp/idiasymbol--get_isctypes.md)|Retrieves a flag indicating whether the symbol file contains C types.|  
|[get_isCVTCIL](../VS_csharp/idiasymbol--get_iscvtcil.md)|Retrieves a flag indicating whether the module was converted from Common Intermediate Language (CIL) to native code.|  
|[get_isDataAligned](../VS_csharp/idiasymbol--get_isdataaligned.md)|Retrieves a flag indicating whether the elements of a user-defined data type are aligned to a specific boundary.|  
|[get_isHLSLData](../VS_csharp/idiasymbol--get_ishlsldata.md)|Specifies whether this symbol represents High Level Shader Language (HLSL) data.|  
|[get_isHotpatchable](../VS_csharp/idiasymbol--get_ishotpatchable.md)|Retrieves a flag indicating whether the module was compiled with the [/hotpatch (Create Hotpatchable Image)](../VS_csharp/-hotpatch--create-hotpatchable-image-.md) compiler switch.|  
|[get_isLTCG](../VS_csharp/idiasymbol--get_isltcg.md)|Retrieves a flag indicating whether the managed compiland was linked with the linker's LTCG.|  
|[get_isMatrixRowMajor](../VS_csharp/idiasymbol--get_ismatrixrowmajor.md)|Specifies whether the matrix is row major.|  
|[get_isMSILNetmodule](../VS_csharp/idiasymbol--get_ismsilnetmodule.md)|Retrieves a flag indicating whether the managed compiland is a .netmodule (containing only metadata).|  
|[get_isMultipleInheritance](../VS_csharp/idiasymbol--get_ismultipleinheritance.md)|Specifies whether the `this` pointer points to a data member with multiple inheritance.|  
|[get_isNaked](../VS_csharp/idiasymbol--get_isnaked.md)|Retrieves a flag indicating whether the function has the [naked (C++)](../VS_csharp/naked--c---.md) attribute.|  
|[get_isOptimizedAway](../VS_csharp/idiasymbol--get_isoptimizedaway.md)|Specifies whether the variable is optimized away.|  
|[get_isPointerBasedOnSymbolValue](../VS_csharp/idiasymbol--get_ispointerbasedonsymbolvalue.md)|Specifies whether the `this` pointer is based on a symbol value.|  
|[get_isPointerToDataMember](../VS_csharp/idiasymbol--get_ispointertodatamember.md)|Specifies whether this symbol is a pointer to a data member.|  
|[get_isPointerToMemberFunction](../VS_csharp/idiasymbol--get_ispointertomemberfunction.md)|Specifies whether this symbol is a pointer to a member function.|  
|[get_isReturnValue](../VS_csharp/idiasymbol--get_isreturnvalue.md)|Specifies whether the variable carries a return value.|  
|[get_isSdl](../VS_csharp/idiasymbol--get_issdl.md)|Specifies whether the module is compiled with the /SDL option.|  
|[get_isSingleInheritance](../VS_csharp/idiasymbol--get_issingleinheritance.md)|Specifies whether the `this` pointer points to a data member with single inheritance.|  
|[get_isSplitted](../VS_csharp/idiasymbol--get_issplitted.md)|Retrieves a flag indicating whether the data has been split into an aggregate of separate symbols.|  
|[get_isStatic](../VS_csharp/idiasymbol--get_isstatic.md)|Retrieves a flag indicating whether a function or thunk layer is static.|  
|[get_isStripped](../VS_csharp/idiasymbol--get_isstripped.md)|Retrieves a flag indicating whether private symbols have been stripped from the symbol file.|  
|[get_isVirtualInheritance](../VS_csharp/idiasymbol--get_isvirtualinheritance.md)|Specifies whether the `this` pointer points to a data member with virtual inheritance.|  
|[IDiaSymbol::get_language](../VS_csharp/idiasymbol--get_language.md)|Retrieves the language of the source.|  
|[IDiaSymbol::get_length](../VS_csharp/idiasymbol--get_length.md)|Retrieves the number of bytes of memory used by the object represented by this symbol.|  
|[IDiaSymbol::get_lexicalParent](../VS_csharp/idiasymbol--get_lexicalparent.md)|Retrieves a reference to the lexical parent of the symbol.|  
|[IDiaSymbol::get_lexicalParentId](../VS_csharp/idiasymbol--get_lexicalparentid.md)|Retrieves the lexical parent identifier of the symbol.|  
|[IDiaSymbol::get_libraryName](../VS_csharp/idiasymbol--get_libraryname.md)|Retrieves the file name of the library or object file from which the object was loaded.|  
|[get_liveRangeLength](../VS_csharp/idiasymbol--get_liverangelength.md)|Returns the length of the address range in which the local symbol is valid.|  
|[get_liveRangeStartAddressSection](../VS_csharp/idiasymbol--get_liverangestartaddresssection.md)|Returns the section part of the starting address range in which the local symbol is valid.|  
|[get_liveRangeStartAddressOffset](../VS_csharp/idiasymbol--get_liverangestartaddressoffset.md)|Returns the offset part of the starting address range in which the local symbol is valid.|  
|[get_liveRangeStartRelativeVirtualAddress](../VS_csharp/idiasymbol--get_liverangestartrelativevirtualaddress.md)|Returns the start of the address range in which the local symbol is valid.|  
|[IDiaSymbol::get_locationType](../VS_csharp/idiasymbol--get_locationtype.md)|Retrieves the location type of a data symbol.|  
|[IDiaSymbol::get_lowerBound](../VS_csharp/idiasymbol--get_lowerbound.md)|Retrieves the lower bound of a FORTRAN array dimension.|  
|[IDiaSymbol::get_lowerBoundId](../VS_csharp/idiasymbol--get_lowerboundid.md)|Retrieves the symbol identifier of the lower bound of a FORTRAN array dimension.|  
|[IDiaSymbol::get_machineType](../VS_csharp/idiasymbol--get_machinetype.md)|Retrieves the type of the target CPU.|  
|[IDiaSymbol::get_managed](../VS_csharp/idiasymbol--get_managed.md)|Retrieves a flag that indicating whether the symbol refers to managed code.|  
|[get_memorySpaceKind](../VS_csharp/idiasymbol--get_memoryspacekind.md)|Retrieves the memory space kind.|  
|[IDiaSymbol::get_msil](../VS_csharp/idiasymbol--get_msil.md)|Retrieves a flag indicating whether the symbol refers to Microsoft Intermediate Language (MSIL) code.|  
|[IDiaSymbol::get_name](../VS_csharp/idiasymbol--get_name.md)|Retrieves the name of the symbol.|  
|[IDiaSymbol::get_nested](../VS_csharp/idiasymbol--get_nested.md)|Retrieves a flag indicating whether the user-defined data type is nested.|  
|[get_noInline](../VS_csharp/idiasymbol--get_noinline.md)|Retrieves a flag indicating whether the function is marked with the [noinline](../VS_csharp/noinline.md) attribute.|  
|[get_noReturn](../VS_csharp/idiasymbol--get_noreturn.md)|Retrieves a flag indicating whether the function has been declared with the [noreturn](../VS_csharp/noreturn.md) attribute.|  
|[get_noStackOrdering](../VS_csharp/idiasymbol--get_nostackordering.md)|Retrieves a flag indicating whether no stack ordering could be done as part of stack buffer checking.|  
|[get_notReached](../VS_csharp/idiasymbol--get_notreached.md)|Retrieves a flag indicating whether the function or label is never reached.|  
|[get_numberOfAcceleratorPointerTags](../VS_csharp/idiasymbol--get_numberofacceleratorpointertags.md)|Returns the number of accelerator pointer tags in a C++ AMP stub function.|  
|[get_numberOfModifiers](../VS_csharp/idiasymbol--get_numberofmodifiers.md)|Retrieves the number of modifiers that are applied to the original type.|  
|[get_numberOfRegisterIndices](../VS_csharp/idiasymbol--get_numberofregisterindices.md)|Retrieves the number of register indices.|  
|[get_numberOfRows](../VS_csharp/idiasymbol--get_numberofrows.md)|Retrieves the number of rows in the matrix.|  
|[get_numberOfColumns](../VS_csharp/idiasymbol--get_numberofcolumns.md)|Retrieves the number of columns in the matrix.|  
|[get_objectFileName](../VS_csharp/idiasymbol--get_objectfilename.md)|Retrieves the object file name.|  
|[IDiaSymbol::get_objectPointerType](../VS_csharp/idiasymbol--get_objectpointertype.md)|Retrieves the type of the object pointer for a class method.|  
|[IDiaSymbol::get_oemId](../VS_csharp/idiasymbol--get_oemid.md)|Retrieves the symbol's `oemId` value.|  
|[IDiaSymbol::get_oemSymbolId](../VS_csharp/idiasymbol--get_oemsymbolid.md)|Retrieves the symbol's `oemSymbolId` value.|  
|[IDiaSymbol::get_offset](../VS_csharp/idiasymbol--get_offset.md)|Retrieves the offset of the symbol location.|  
|[get_optimizedCodeDebugInfo](../VS_csharp/idiasymbol--get_optimizedcodedebuginfo.md)|Retrieves a flag indicating whether the function or label contains optimized code as well as debug information.|  
|[IDiaSymbol::get_overloadedOperator](../VS_csharp/idiasymbol--get_overloadedoperator.md)|Retrieves a flag indicating whether the user-defined data type has overloaded operators.|  
|[IDiaSymbol::get_packed](../VS_csharp/idiasymbol--get_packed.md)|Retrieves a flag indicating whether the user-defined data type is packed.|  
|[IDiaSymbol::get_platform](../VS_csharp/idiasymbol--get_platform.md)|Retrieves the platform type for which the program or compiland was compiled.|  
|[IDiaSymbol::get_pure](../VS_csharp/idiasymbol--get_pure.md)|Retrieves a flag that indicating whether the function is pure virtual.|  
|[IDiaSymbol::get_rank](../VS_csharp/idiasymbol--get_rank.md)|Retrieves the rank of a FORTRAN multidimensional array.|  
|[IDiaSymbol::get_reference](../VS_csharp/idiasymbol--get_reference.md)|Retrieves a flag indicating whether a pointer type is a reference.|  
|[IDiaSymbol::get_registerId](../VS_csharp/idiasymbol--get_registerid.md)|Retrieves the register designator of the location.|  
|[get_registerType](../VS_csharp/idiasymbol--get_registertype.md)|Retrieves the register type.|  
|[IDiaSymbol::get_relativeVirtualAddress](../VS_csharp/idiasymbol--get_relativevirtualaddress.md)|Retrieves the relative virtual address (RVA) of the location.|  
|[get_restrictedType](../VS_csharp/idiasymbol--get_restrictedtype.md)|Specifies whether the `this` pointer is flagged as restricted.|  
|[get_samplerSlot](../VS_csharp/idiasymbol--get_samplerslot.md)|Retrieves the sampler slot.|  
|[IDiaSymbol::get_scoped](../VS_csharp/idiasymbol--get_scoped.md)|Retrieves a flag indicating whether the user-defined data type appears in a nonglobal lexical scope.|  
|[IDiaSymbol::get_signature](../VS_csharp/idiasymbol--get_signature.md)|Retrieves the symbol's signature value.|  
|[get_sizeInUdt](../VS_csharp/idiasymbol--get_sizeinudt.md)|Retrieves the size of a member of a user-defined type.|  
|[IDiaSymbol::get_slot](../VS_csharp/idiasymbol--get_slot.md)|Retrieves the slot number of the location.|  
|[IDiaSymbol::get_sourceFileName](../VS_csharp/idiasymbol--get_sourcefilename.md)|Retrieves the file name of the source file.|  
|[getSrcLineOnTypeDefn](../VS_csharp/idiasymbol--getsrclineontypedefn.md)|Retrieves the source file and line number that indicate where a specified user-defined type is defined.|  
|[get_stride](../VS_csharp/idiasymbol--get_stride.md)|Retrieves the stride of the matrix or strided array.|  
|[get_subType](../VS_csharp/idiasymbol--get_subtype.md)|Retrieves the sub type.|  
|[get_subTypeId](../VS_csharp/idiasymbol--get_subtypeid.md)|Retrieves the sub type ID.|  
|[IDiaSymbol::get_symbolsFileName](../VS_csharp/idiasymbol--get_symbolsfilename.md)|Retrieves the name of the file from which the symbols were loaded.|  
|[IDiaSymbol::get_symIndexId](../VS_csharp/idiasymbol--get_symindexid.md)|Retrieves the unique symbol identifier.|  
|[IDiaSymbol::get_symTag](../VS_csharp/idiasymbol--get_symtag.md)|Retrieves the symbol type classifier.|  
|[IDiaSymbol::get_targetOffset](../VS_csharp/idiasymbol--get_targetoffset.md)|Retrieves the offset section of a thunk target.|  
|[IDiaSymbol::get_targetRelativeVirtualAddress](../VS_csharp/idiasymbol--get_targetrelativevirtualaddress.md)|Retrieves the relative virtual address (RVA) of a thunk target.|  
|[IDiaSymbol::get_targetSection](../VS_csharp/idiasymbol--get_targetsection.md)|Retrieves the address section of a thunk target.|  
|[IDiaSymbol::get_targetVirtualAddress](../VS_csharp/idiasymbol--get_targetvirtualaddress.md)|Retrieves the virtual address (VA) of a thunk target.|  
|[get_textureSlot](../VS_csharp/idiasymbol--get_textureslot.md)|Retrieves the texture slot.|  
|[IDiaSymbol::get_thisAdjust](../VS_csharp/idiasymbol--get_thisadjust.md)|Retrieves the logical `this` adjustor for the method.|  
|[IDiaSymbol::get_thunkOrdinal](../VS_csharp/idiasymbol--get_thunkordinal.md)|Retrieves the thunk type of a function.|  
|[IDiaSymbol::get_timeStamp](../VS_csharp/idiasymbol--get_timestamp.md)|Retrieves the timestamp of the underlying executable file.|  
|[IDiaSymbol::get_token](../VS_csharp/idiasymbol--get_token.md)|Retrieves the metadata token of a managed function or variable.|  
|[IDiaSymbol::get_type](../VS_csharp/idiasymbol--get_type.md)|Retrieves a reference to the function signature.|  
|[IDiaSymbol::get_typeId](../VS_csharp/idiasymbol--get_typeid.md)|Retrieves the type identifier of the symbol.|  
|[IDiaSymbol::get_types](../VS_csharp/idiasymbol--get_types.md)|Retrieves an array of compiler-specific type values for this symbol.|  
|[IDiaSymbol::get_typeIds](../VS_csharp/idiasymbol--get_typeids.md)|Retrieves an array of compiler-specific type identifier values for this symbol.|  
|[get_uavSlot](../VS_csharp/idiasymbol--get_uavslot.md)|Retrieves the uav slot.|  
|[IDiaSymbol::get_udtKind](../VS_csharp/idiasymbol--get_udtkind.md)|Retrieves the variety of a user-defined type (UDT).|  
|[IDiaSymbol::get_unalignedType](../VS_csharp/idiasymbol--get_unalignedtype.md)|Retrieves a flag indicating whether the user-defined data type is unaligned.|  
|[IDiaSymbol::get_undecoratedName](../VS_csharp/idiasymbol--get_undecoratedname.md)|Retrieves the undecorated name for a C++ decorated, or linkage, name.|  
|[IDiaSymbol::get_undecoratedNameEx](../VS_csharp/idiasymbol--get_undecoratednameex.md)|Extension of the `get_undecoratedName` method that retrieves the undecorated name based on the value of an extension field.|  
|[get_unmodifiedTypeId](../VS_csharp/idiasymbol--get_unmodifiedtypeid.md)|Retrieves the ID of the original (unmodified) type.|  
|[IDiaSymbol::get_upperBound](../VS_csharp/idiasymbol--get_upperbound.md)|Retrieves the upper bound of a FORTRAN array dimension.|  
|[IDiaSymbol::get_upperBoundId](../VS_csharp/idiasymbol--get_upperboundid.md)|Retrieves the symbol identifier of the upper bound of a FORTRAN array dimension.|  
|[IDiaSymbol::get_value](../VS_csharp/idiasymbol--get_value.md)|Retrieves the value of a constant.|  
|[IDiaSymbol::get_virtual](../VS_csharp/idiasymbol--get_virtual.md)|Retrieves a flag indicating whether the function is virtual.|  
|[IDiaSymbol::get_virtualAddress](../VS_csharp/idiasymbol--get_virtualaddress.md)|Retrieves the virtual address (VA) of the location.|  
|[IDiaSymbol::get_virtualBaseClass](../VS_csharp/idiasymbol--get_virtualbaseclass.md)|Retrieves a flag indicating whether the user-defined data type is a virtual base class.|  
|[IDiaSymbol::get_virtualBaseDispIndex](../VS_csharp/idiasymbol--get_virtualbasedispindex.md)|Retrieves the index to the virtual base displacement table.|  
|[IDiaSymbol::get_virtualBaseOffset](../VS_csharp/idiasymbol--get_virtualbaseoffset.md)|Retrieves the offset in the virtual function table of a virtual function.|  
|[IDiaSymbol::get_virtualBasePointerOffset](../VS_csharp/idiasymbol--get_virtualbasepointeroffset.md)|Retrieves the offset of the virtual base pointer.|  
|[get_virtualBaseTableType](../VS_csharp/idiasymbol--get_virtualbasetabletype.md)|Retrieves the type of a virtual base table pointer.|  
|[IDiaSymbol::get_virtualTableShape](../VS_csharp/idiasymbol--get_virtualtableshape.md)|Retrieves the symbol interface of the type of the virtual table for a user-defined type.|  
|[IDiaSymbol::get_virtualTableShapeId](../VS_csharp/idiasymbol--get_virtualtableshapeid.md)|Retrieves the virtual table shape identifier of the symbol.|  
|[IDiaSymbol::get_volatileType](../VS_csharp/idiasymbol--get_volatiletype.md)|Retrieves a flag indicating whether the user-defined data type is volatile.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling one of the following methods:  
  
-   [IDiaEnumSymbols::Item](../VS_csharp/idiaenumsymbols--item.md)  
  
-   [IDiaEnumSymbols::Next](../VS_csharp/idiaenumsymbols--next.md)  
  
-   [IDiaEnumSymbolsByAddr::Next](../VS_csharp/idiaenumsymbolsbyaddr--next.md)  
  
-   [IDiaEnumSymbolsByAddr::Prev](../VS_csharp/idiaenumsymbolsbyaddr--prev.md)  
  
-   [IDiaEnumSymbolsByAddr::symbolByAddr](../VS_csharp/idiaenumsymbolsbyaddr--symbolbyaddr.md)  
  
-   [IDiaEnumSymbolsByAddr::symbolByRVA](../VS_csharp/idiaenumsymbolsbyaddr--symbolbyrva.md)  
  
-   [IDiaEnumSymbolsByAddr::symbolByVA](../VS_csharp/idiaenumsymbolsbyaddr--symbolbyva.md)  
  
-   [IDiaSession::findSymbolByAddr](../VS_csharp/idiasession--findsymbolbyaddr.md)  
  
-   [IDiaSession::findSymbolByRVA](../VS_csharp/idiasession--findsymbolbyrva.md)  
  
-   [IDiaSession::findSymbolByRVAEx](../VS_csharp/idiasession--findsymbolbyrvaex.md)  
  
-   [IDiaSession::findSymbolByVA](../VS_csharp/idiasession--findsymbolbyva.md)  
  
-   [IDiaSession::findSymbolByVAEx](../VS_csharp/idiasession--findsymbolbyvaex.md)  
  
-   [IDiaSession::findSymbolByToken](../VS_csharp/idiasession--findsymbolbytoken.md)  
  
-   [IDiaSession::symbolById](../VS_csharp/idiasession--symbolbyid.md)  
  
-   [IDiaStackWalkHelper::symbolForVA](../VS_csharp/idiastackwalkhelper--symbolforva.md)  
  
-   [IDiaSymbol::get_types](../VS_csharp/idiasymbol--get_types.md)  
  
## Example  
 This example shows how to display the local variables for a function at a given relative virtual address. It also shows how symbols of different types are related to each other.  
  
> [!NOTE]
>  `CDiaBSTR` is a class that wraps a `BSTR` and automatically handles freeing the string when the instantiation goes out of scope.  
  
```cpp#  
void DumpLocalVars( DWORD rva, IDiaSession *pSession )  
{  
    CComPtr< IDiaSymbol > pBlock;  
    if ( FAILED( psession->findSymbolByRVA( rva, SymTagBlock, &pBlock ) ) )  
    {  
        Fatal( "Failed to find symbols by RVA" );  
    }  
    CComPtr< IDiaSymbol > pscope;  
    for ( ; pBlock != NULL; )  
    {  
        CComPtr< IDiaEnumSymbols > pEnum;  
        // local data search  
        if ( FAILED( pBlock->findChildren( SymTagNull, NULL, nsNone, &pEnum ) ) )  
        {  
            Fatal( "Local scope findChildren failed" );  
        }  
        CComPtr< IDiaSymbol > pSymbol;  
        DWORD tag;  
        DWORD celt;  
        while ( pEnum != NULL &&  
                SUCCEEDED( pEnum->Next( 1, &pSymbol, &celt ) ) &&  
                celt == 1)  
        {  
            pSymbol->get_symTag( &tag );  
            if ( tag == SymTagData )  
            {  
                CDiaBSTR name;  
                DWORD    kind;  
                pSymbol->get_name( &name );  
                pSymbol->get_dataKind( &kind );  
                if ( name != NULL )  
                    wprintf_s( L"\t%s (%s)\n", name, szDataKinds[ kind ] );  
            }  
            else if ( tag == SymTagAnnotation )  
            {  
                CComPtr< IDiaEnumSymbols > pValues;  
                // local data search  
                wprintf_s( L"\tAnnotation:\n" );  
                if ( FAILED( pSymbol->findChildren( SymTagNull, NULL, nsNone, &pValues ) ) )  
                    Fatal( "Annotation findChildren failed" );  
                pSymbol = NULL;  
                while ( pValues != NULL &&  
                        SUCCEEDED( pValues->Next( 1, &pSymbol, &celt ) ) &&  
                        celt == 1 )  
                {  
                    CComVariant value;  
                    if ( pSymbol->get_value( &value ) != S_OK )  
                        Fatal( "No value for annotation data." );  
                    wprintf_s( L"\t\t%ws\n", value.bstrVal );  
                    pSymbol = NULL;  
                }  
            }  
            pSymbol = NULL;  
        }  
        pBlock->get_symTag( &tag );   
        if ( tag == SymTagFunction )    // stop when at function scope  
            break;  
        // move to lexical parent  
        CComPtr< IDiaSymbol > pParent;  
        if ( SUCCEEDED( pBlock->get_lexicalParent( &pParent ) )  
            && pParent != NULL ) {  
            pBlock = pParent;  
        }  
        else  
        {  
            Fatal( "Finding lexical parent failed." );  
        }  
    };  
}  
```  
  
## Requirements  
 `Header:` Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_csharp/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumSymbolsByAddr](../VS_csharp/idiaenumsymbolsbyaddr.md)   
 [IDiaEnumSymbols](../VS_csharp/idiaenumsymbols.md)   
 [IDiaSession](../VS_csharp/idiasession.md)   
 [Class Hierarchy of Symbol Types](../VS_csharp/class-hierarchy-of-symbol-types.md)   
 [Symbols and Symbol Tags](../VS_csharp/symbols-and-symbol-tags.md)   
 [Compiland](../VS_csharp/compiland.md)