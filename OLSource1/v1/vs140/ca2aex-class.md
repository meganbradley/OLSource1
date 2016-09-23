---
title: "CA2AEX Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL::CA2AEX<t_nBufferLength>
  - CA2AEX
  - ATL.CA2AEX<t_nBufferLength>
  - ATLCONV/CA2AEX
  - ATL.CA2AEX
  - ATL::CA2AEX
dev_langs: 
  - C++
helpviewer_keywords: 
  - CA2AEX class
ms.assetid: 57dc65df-d9cf-4a84-99d3-6e031dde3664
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CA2AEX Class
This class is used by the string conversion macros `CA2TEX` and `CT2AEX`, and the typedef **CA2A**.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
template<  
   int  t_nBufferLength  
   = 128>  
   class CA2AEX  
  
```  
  
#### Parameters  
 `t_nBufferLength`  
 The size of the buffer used in the translation process. The default length is 128 bytes.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CA2AEX::CA2AEX](../vs140/ca2aex--ca2aex.md)|The constructor.|  
|[CA2AEX::~CA2AEX](../vs140/ca2aex--~ca2aex.md)|The destructor.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CA2AEX::operator LPSTR](../vs140/ca2aex--operator-lpstr.md)|Conversion operator.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CA2AEX::m_psz](../vs140/ca2aex--m_psz.md)|The data member that stores the source string.|  
|[CA2AEX::m_szBuffer](../vs140/ca2aex--m_szbuffer.md)|The static buffer, used to store the converted string.|  
  
## Remarks  
 Unless extra functionality is required, use `CA2TEX`, `CT2AEX`, or **CA2A** in your own code.  
  
 This class contains a fixed-size static buffer which is used to store the result of the conversion. If the result is too large to fit into the static buffer, the class allocates memory using `malloc`, freeing the memory when the object goes out of scope. This ensures that, unlike text conversion macros available in previous versions of ATL, this class is safe to use in loops and that it won't overflow the stack.  
  
 If the class tries to allocate memory on the heap and fails, it will call `AtlThrow` with an argument of **E_OUTOFMEMORY**.  
  
 By default, the ATL conversion classes and macros use the current thread's ANSI code page for the conversion.  
  
 The following macros are based on this class:  
  
-   `CA2TEX`  
  
-   `CT2AEX`  
  
 The following typedef is based on this class:  
  
-   **CA2A**  
  
 For a discussion of these text conversion macros, see [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md).  
  
## Example  
 See [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md) for an example of using these string conversion macros.  
  
## Requirements  
 **Header:** atlconv.h  
  
##  <a name="ca2aex__ca2aex"></a>  CA2AEX::CA2AEX  
 The constructor.  
  
```  
  
CA2AEX(  
      LPCSTR  psz  
,  
      UINT  nCodePage  
   ) throw(...);  
   CA2AEX(  
      LPCSTR  psz  
   ) throw(...);  
  
```  
  
### Parameters  
 `psz`  
 The text string to be converted.  
  
 `nCodePage`  
 Unused in this class.  
  
### Remarks  
 Creates the buffer required for the translation.  
  
##  <a name="ca2aex___dtorca2aex"></a>  CA2AEX::~CA2AEX  
 The destructor.  
  
```  
  
~CA2AEX( ) throw( );  
  
```  
  
### Remarks  
 Frees the allocated buffer.  
  
##  <a name="ca2aex__m_psz"></a>  CA2AEX::m_psz  
 The data member that stores the source string.  
  
```  
  
LPSTR m_psz;  
  
```  
  
##  <a name="ca2aex__m_szbuffer"></a>  CA2AEX::m_szBuffer  
 The static buffer, used to store the converted string.  
  
```  
  
char m_szBuffer[ t_nBufferLength  
   ];  
  
```  
  
##  <a name="ca2aex__operator_lpstr"></a>  CA2AEX::operator LPSTR  
 Conversion operator.  
  
```  
  
operator LPSTR( ) const throw( );  
  
```  
  
### Return Value  
 Returns the text string as type **LPSTR**.  
  
## See Also  
 [CA2CAEX Class](../vs140/ca2caex-class.md)   
 [CA2WEX Class](../vs140/ca2wex-class.md)   
 [CW2AEX Class](../vs140/cw2aex-class.md)   
 [CW2CWEX Class](../vs140/cw2cwex-class.md)   
 [CW2WEX Class](../vs140/cw2wex-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)