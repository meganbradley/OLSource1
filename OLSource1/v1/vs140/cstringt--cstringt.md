---
title: "CStringT::CStringT"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CStringT.CStringT"
  - "ATL::CStringT::CStringT"
  - "ATL.CStringT.CStringT"
  - "CStringT::CStringT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStringT constructor"
  - "CStringT class, constructor"
ms.assetid: a7618d52-b2e6-42a2-8716-b02f2c5b20d7
caps.latest.revision: 24
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::CStringT
Constructs a `CStringT` object.  
  
## Syntax  
  
```  
CStringT( ) throw() :   
   CThisSimpleString(  
      StringTraits::GetDefaultManager()  
   );  
  
explicit CStringT(  
   IAtlStringMgr* pStringMgr  
) throw() :   
   CThisSimpleString(  
      pStringMgr  
   );  
  
CStringT(  
   const VARIANT& varSrc  
);  
  
CStringT(  
   const VARIANT& varSrc,  
   IAtlStringMgr* pStringMgr  
);  
  
CStringT(   
  const CStringT& strSrc  
) :   
   CThisSimpleString(   
      strSrc  
   );  
  
operator CSimpleStringT<  
   BaseType,  
   !_CSTRING_IMPL_::_MFCDLLTraitsCheck<  
      BaseType,  
      StringTraits  
   >::   c_bIsMFCDLLTraits   
> &()  
  
template <  
   bool bMFCDLL  
>  
CStringT(  
   const CSimpleStringT<  
      BaseType,  
      bMFCDLL  
   > & strSrc  
) :   
   CThisSimpleString(  
      strSrc  
);  
  
template <  
   class SystemString  
>  
CStringT(  
   SystemString^ pString  
) :   
   CThisSimpleString(  
      StringTraits::GetDefaultManager()  
   );  
  
CStringT(  
   const XCHAR* pszSrc  
) :   
   CThisSimpleString(  
      StringTraits::GetDefaultManager()  
   );  
  
CSTRING_EXPLICIT CStringT(  
   const YCHAR* pszSrc  
) :   
   CThisSimpleString(  
      StringTraits::GetDefaultManager()  
   );  
  
CStringT(  
   LPCSTR pszSrc,  
   IAtlStringMgr* pStringMgr  
) :   
   CThisSimpleString(  
      pStringMgr  
   );  
  
CStringT(  
   LPCWSTR pszSrc,  
   IAtlStringMgr* pStringMgr  
) :   
   CThisSimpleString(  
      pStringMgr  
);  
  
CSTRING_EXPLICIT CStringT(  
   const unsigned char* pszSrc  
) :   
   CThisSimpleString(  
      StringTraits::GetDefaultManager()  
   );  
  
/*CSTRING_EXPLICIT*/ CStringT(  
   char* pszSrc  
) :   
   CThisSimpleString(  
      StringTraits::GetDefaultManager()  
   );  
  
CSTRING_EXPLICIT CStringT(  
   unsigned char* pszSrc  
) :   
   CThisSimpleString(  
      StringTraits::GetDefaultManager()  
   );  
  
CSTRING_EXPLICIT CStringT(  
   wchar_t* pszSrc  
) :   
   CThisSimpleString(  
      StringTraits::GetDefaultManager()  
   );  
  
CStringT(  
   const unsigned char* pszSrc,  
   IAtlStringMgr* pStringMgr  
) :   
   CThisSimpleString(  
      pStringMgr  
   );  
  
CSTRING_EXPLICIT CStringT(  
   char ch,  
   int nLength = 1  
) :   
   CThisSimpleString(  
      StringTraits::GetDefaultManager()  
   );  
  
CSTRING_EXPLICIT CStringT(  
   wchar_t ch,  
   int nLength = 1  
) :   
   CThisSimpleString(  
      StringTraits::GetDefaultManager()  
   );  
  
CStringT(  
   const XCHAR* pch,  
   int nLength  
) :   
   CThisSimpleString(  
      pch,  
      nLength,  
      StringTraits::GetDefaultManager()  
   );  
  
CStringT(  
   const YCHAR* pch,  
   int nLength  
) :   
   CThisSimpleString(  
      StringTraits::GetDefaultManager()  
   );  
  
CStringT(  
   const XCHAR* pch,  
   int nLength,  
   IAtlStringMgr* pStringMgr  
) :   
   CThisSimpleString(  
      pch,  
      nLength,  
      pStringMgr  
);  
  
CStringT(  
   const YCHAR* pch,  
   int nLength,  
   IAtlStringMgr* pStringMgr  
) :   
   CThisSimpleString(  
      pStringMgr  
   );  
```  
  
#### Parameters  
 `pch`  
 A pointer to an array of characters of length `nLength`, not null-terminated.  
  
 `nLength`  
 A count of the number of characters in `pch`.  
  
 `ch`  
 A single character.  
  
 `pszSrc`  
 A null-terminated string to be copied into this `CStringT` object.  
  
 `pStringMgr`  
 A pointer to the memory manager for the `CStringT` object. For more information on `IAtlStringMgr` and memory management for `CStringT`, see [Memory Management with CStringT](../vs140/memory-management-with-cstringt.md).  
  
 `strSrc`  
 An existing `CStringT` object to be copied into this `CStringT` object. For more information on `CThisString` and `CThisSimpleString`, see the Remarks section.  
  
 `varSrc`  
 A variant object to be copied into this `CStringT` object.  
  
 `BaseType`  
 The character type of the string class. Can be one of the following:  
  
 `char` (for ANSI character strings).  
  
 `wchar_t` (for Unicode character strings).  
  
 `TCHAR` (for both ANSI and Unicode character strings).  
  
 `bMFCDLL`  
 Boolean that specifies whether the project is an MFC DLL (TRUE) or not (FALSE).  
  
 `SystemString`  
 Must be `System::String`, and the project must be compiled with /clr.  
  
 `pString`  
 A handle for a `CStringT` object.  
  
## Remarks  
 Because the constructors copy the input data into new allocated storage, you should be aware that memory exceptions may result. Note that some of these constructors act as conversion functions. This allows you to substitute, for example, an `LPTSTR` where a `CStringT` object is expected.  
  
-   `CStringT`( `LPCSTR` `lpsz` ): Constructs a Unicode `CStringT` from an ANSI string. You can also use this constructor to load a string resource as shown in the example below.  
  
-   `CStringT(`  `LPCWSTR` `lpsz` ): Constructs a `CStringT` from a Unicode string.  
  
-   `CStringT`( `const unsigned char*` `psz` ): Allows you to construct a `CStringT` from a pointer to `unsigned char`.  
  
> [!NOTE]
>  Define the **_CSTRING_DISABLE_NARROW_WIDE_CONVERSION** macro to turn off implicit string conversion between [!INCLUDE[vcpransi](../vs140/includes/vcpransi_md.md)] and [!INCLUDE[TLA#tla_unicode](../vs140/includes/tlasharptla_unicode_md.md)] strings. The macro excludes from compilation constructors that support conversion.  
  
 Note that the `strSrc` parameter can be either a `CStringT` or `CThisSimpleString` object. For `CStringT`, use one of its default instantiations (`CString`, `CStringA`, or `CStringW`); for `CThisSimpleString`, use a `this` pointer. `CThisSimpleString` declares an instance of the [CSimpleStringT Class](../vs140/csimplestringt-class.md), which is a smaller string class with less built-in functionality than the `CStringT` class.  
  
 The overload operator `CSimpleStringT<>&()` constructs a `CStringT` object from a `CSimpleStringT` declaration.  
  
> [!NOTE]
>  Although it is possible to create `CStringT` instances that contain embedded null characters, we recommend against it. Calling methods and operators on `CStringT` objects that contain embedded null characters can produce unintended results.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#112](../vs140/codesnippet/CPP/cstringt--cstringt_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)   
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)