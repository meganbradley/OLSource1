---
title: "CW2AEX Class"
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
  - "ATL::CW2AEX<t_nBufferLength>"
  - "CW2AEX"
  - "ATL.CW2AEX<t_nBufferLength>"
  - "ATL::CW2AEX"
  - "ATL.CW2AEX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CW2AEX class"
ms.assetid: 44dc2cf5-dd30-440b-a9b9-b21b43f49843
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CW2AEX Class
This class is used by the string conversion macros `CT2AEX`, `CW2TEX`, `CW2CTEX`, and `CT2CAEX`, and the typedef **CW2A**.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
template<  
   int  t_nBufferLength  
   = 128>  
   class CW2AEX  
  
```  
  
#### Parameters  
 `t_nBufferLength`  
 The size of the buffer used in the translation process. The default length is 128 bytes.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CW2AEX::CW2AEX](../vs140/cw2aex--cw2aex.md)|The constructor.|  
|[CW2AEX::~CW2AEX](../vs140/cw2aex--~cw2aex.md)|The destructor.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CW2AEX::operator LPSTR](../vs140/cw2aex--operator-lpstr.md)|Conversion operator.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CW2AEX::m_psz](../vs140/cw2aex--m_psz.md)|The data member that stores the source string.|  
|[CW2AEX::m_szBuffer](../vs140/cw2aex--m_szbuffer.md)|The static buffer, used to store the converted string.|  
  
## Remarks  
 Unless extra functionality is required, use `CT2AEX`, `CW2TEX`, `CW2CTEX`, `CT2CAEX`, or **CW2A** in your code.  
  
 This class contains a fixed-size static buffer which is used to store the result of the conversion. If the result is too large to fit into the static buffer, the class allocates memory using `malloc`, freeing the memory when the object goes out of scope. This ensures that, unlike text conversion macros available in previous versions of ATL, this class is safe to use in loops and that it won't overflow the stack.  
  
 If the class tries to allocate memory on the heap and fails, it will call `AtlThrow` with an argument of **E_OUTOFMEMORY**.  
  
 By default, the ATL conversion classes and macros use the current thread's ANSI code page for the conversion. If you want to override that behavior for a specific conversion, specify the code page as the second parameter to the constructor for the class.  
  
 The following macros are based on this class:  
  
-   `CT2AEX`  
  
-   `CW2TEX`  
  
-   `CW2CTEX`  
  
-   `CT2CAEX`  
  
 The following typedef is based on this class:  
  
-   **CW2A**  
  
 For a discussion of these text conversion macros, see [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md).  
  
## Example  
 See [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md) for an example of using these string conversion macros.  
  
## Requirements  
 **Header:** atlconv.h  
  
##  \<a name="cw2aex__cw2aex"></a>  CW2AEX::CW2AEX  
 The constructor.  
  
```  
  
CW2AEX(  
      LPCWSTR  psz,  
      UINT  nCodePage  
   ) throw(...);  
   CW2AEX(  
      LPCWSTR  psz  
   ) throw(...);  
  
```  
  
### Parameters  
 `psz`  
 The text string to be converted.  
  
 `nCodePage`  
 The code page used to perform the conversion. See the code page parameter discussion for the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] function [MultiByteToWideChar](http://msdn.microsoft.com/library/windows/desktop/dd319072) for more details.  
  
### Remarks  
 Allocates the buffer used in the translation process.  
  
##  \<a name="cw2aex___dtorcw2aex"></a>  CW2AEX::~CW2AEX  
 The destructor.  
  
```  
  
~CW2AEX( ) throw( );  
  
```  
  
### Remarks  
 Frees the allocated buffer.  
  
##  \<a name="cw2aex__m_psz"></a>  CW2AEX::m_psz  
 The data member that stores the source string.  
  
```  
  
LPSTR m_psz;  
  
```  
  
##  \<a name="cw2aex__m_szbuffer"></a>  CW2AEX::m_szBuffer  
 The static buffer, used to store the converted string.  
  
```  
  
char m_szBuffer[ t_nBufferLength  
   ];  
  
```  
  
##  \<a name="cw2aex__operator_lpstr"></a>  CW2AEX::operator LPSTR  
 Conversion operator.  
  
```  
  
operator LPSTR( ) const throw( );  
  
```  
  
### Return Value  
 Returns the text string as type **LPSTR.**  
  
## See Also  
 [CA2AEX Class](../vs140/ca2aex-class.md)   
 [CA2CAEX Class](../vs140/ca2caex-class.md)   
 [CA2WEX Class](../vs140/ca2wex-class.md)   
 [CW2CWEX Class](../vs140/cw2cwex-class.md)   
 [CW2WEX Class](../vs140/cw2wex-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)