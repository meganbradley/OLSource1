---
title: "CA2CAEX Class"
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
  - "ATL.CA2CAEX"
  - "ATL.CA2CAEX<t_nBufferLength>"
  - "ATLCONV/CA2CAEX"
  - "ATL::CA2CAEX<t_nBufferLength>"
  - "ATL::CA2CAEX"
  - "CA2CAEX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CA2CAEX class"
ms.assetid: 388e7c1d-a144-474c-a182-b15f69a74bd8
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2CAEX Class
This class is used by string conversion macros <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and the typedef **CA2CA**.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The size of the buffer used in the translation process. The default length is 128 bytes.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CA2CAEX::CA2CAEX](../vs140/ca2caex--ca2caex.md)|The constructor.|  
|[CA2CAEX::~CA2CAEX](../vs140/ca2caex--~ca2caex.md)|The destructor.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CA2CAEX::operator LPCSTR](../vs140/ca2caex--operator-lpcstr.md)|Conversion operator.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CA2CAEX::m_psz](../vs140/ca2caex--m_psz.md)|The data member that stores the source string.|  
  
## Remarks  
 Unless extra functionality is required, use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, or **CA2CA** in your own code.  
  
 This class is safe to use in loops and won't overflow the stack. By default, the ATL conversion classes and macros will use the current thread's ANSI code page for the conversion.  
  
 The following macros are based on this class:  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 The following typedef is based on this class:  
  
-   **CA2CA**  
  
 For a discussion of these text conversion macros, see [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md).  
  
## Example  
 See [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md) for an example of using these string conversion macros.  
  
## Requirements  
 **Header:** atlconv.h  
  
##  \<a name="ca2caex__ca2caex">\</a>  CA2CAEX::CA2CAEX  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The text string to be converted.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Unused in this class.  
  
### Remarks  
 Creates the buffer required for the translation.  
  
##  \<a name="ca2caex___dtorca2caex">\</a>  CA2CAEX::~CA2CAEX  
 The destructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Frees the allocated buffer.  
  
##  \<a name="ca2caex__m_psz">\</a>  CA2CAEX::m_psz  
 The data member that stores the source string.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="ca2caex__operator_lpcstr">\</a>  CA2CAEX::operator LPCSTR  
 Conversion operator.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns the text string as type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## See Also  
 [CA2AEX Class](../vs140/ca2aex-class.md)   
 [CA2WEX Class](../vs140/ca2wex-class.md)   
 [CW2AEX Class](../vs140/cw2aex-class.md)   
 [CW2CWEX Class](../vs140/cw2cwex-class.md)   
 [CW2WEX Class](../vs140/cw2wex-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)