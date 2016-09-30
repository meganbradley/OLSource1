---
title: "CA2WEX Class"
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
  - "ATLCONV/CA2WEX"
  - "ATL.CA2WEX"
  - "ATL.CA2WEX<t_nBufferLength>"
  - "ATL::CA2WEX"
  - "ATL::CA2WEX<t_nBufferLength>"
  - "CA2WEX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CA2WEX class"
ms.assetid: 317d9ffb-e84f-47e8-beda-57e28fb19124
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2WEX Class
This class is used by the string conversion macros <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and the typedef **CA2W**.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The size of the buffer used in the translation process. The default length is 128 bytes.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CA2WEX::CA2WEX](../vs140/ca2wex--ca2wex.md)|The constructor.|  
|[CA2WEX::~CA2WEX](../vs140/ca2wex--~ca2wex.md)|The destructor.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CA2WEX::operator LPWSTR](../vs140/ca2wex--operator-lpwstr.md)|Conversion operator.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CA2WEX::m_psz](../vs140/ca2wex--m_psz.md)|The data member that stores the source string.|  
|[CA2WEX::m_szBuffer](../vs140/ca2wex--m_szbuffer.md)|The static buffer, used to store the converted string.|  
  
## Remarks  
 Unless extra functionality is required, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, or **CA2W** in your code.  
  
 This class contains a fixed-size static buffer which is used to store the result of the conversion. If the result is too large to fit into the static buffer, the class allocates memory using <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, freeing the memory when the object goes out of scope. This ensures that, unlike text conversion macros available in previous versions of ATL, this class is safe to use in loops and that it won't overflow the stack.  
  
 If the class tries to allocate memory on the heap and fails, it will call <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> with an argument of **E_OUTOFMEMORY**.  
  
 By default, the ATL conversion classes and macros use the current thread's ANSI code page for the conversion. If you want to override that behavior for a specific conversion, specify the code page as the second parameter to the constructor for the class.  
  
 The following macros are based on this class:  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 The following typedef is based on this class:  
  
-   **CA2W**  
  
 For a discussion of these text conversion macros, see [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md).  
  
## Example  
 See [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md) for an example of using these string conversion macros.  
  
## Requirements  
 **Header:** atlconv.h  
  
##  \<a name="ca2wex__ca2wex">\</a>  CA2WEX::CA2WEX  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The text string to be converted.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The code page used to perform the conversion. See the code page parameter discussion for the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] function [MultiByteToWideChar](http://msdn.microsoft.com/library/windows/desktop/dd319072) for more details.  
  
### Remarks  
 Allocates the buffer used in the translation process.  
  
##  \<a name="ca2wex___dtorca2wex">\</a>  CA2WEX::~CA2WEX  
 The destructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Frees the allocated buffer.  
  
##  \<a name="ca2wex__m_psz">\</a>  CA2WEX::m_psz  
 The data member that stores the source string.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="ca2wex__m_szbuffer">\</a>  CA2WEX::m_szBuffer  
 The static buffer, used to store the converted string.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="ca2wex__operator_lpwstr">\</a>  CA2WEX::operator LPWSTR  
 Conversion operator.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns the text string as type **LPWSTR.**  
  
## See Also  
 [CA2AEX Class](../vs140/ca2aex-class.md)   
 [CA2CAEX Class](../vs140/ca2caex-class.md)   
 [CW2AEX Class](../vs140/cw2aex-class.md)   
 [CW2CWEX Class](../vs140/cw2cwex-class.md)   
 [CW2WEX Class](../vs140/cw2wex-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)