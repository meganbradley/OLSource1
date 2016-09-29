---
title: "CSimpleStringT Class"
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
  - "ATL.CSimpleStringT"
  - "ATL::CSimpleStringT"
  - "ATL::CSimpleStringT<BaseType>"
  - "ATL.CSimpleStringT<BaseType>"
  - "CSimpleStringT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "shared classes, CSimpleStringT"
  - "strings [C++], ATL class"
  - "CSimpleStringT class"
ms.assetid: 15814fcb-5b8f-4425-a97e-3b61fc9b48d8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT Class
This class represents a `CSimpleStringT` object.  
  
## Syntax  
  
```  
  
      template <typename   
      BaseType  
      >  
class CSimpleStringT  
```  
  
#### Parameters  
 `BaseType`  
 The character type of the string class. Can be one of the following:  
  
-   `char` (for ANSI character strings).  
  
-   `wchar_t` (for Unicode character strings).  
  
-   **TCHAR** (for both ANSI and Unicode character strings).  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleStringT::PCXSTR](../vs140/csimplestringt--pcxstr.md)|A pointer to a constant string.|  
|[CSimpleStringT::PXSTR](../vs140/csimplestringt--pxstr.md)|A pointer to a string.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleStringT::CSimpleStringT](../vs140/csimplestringt--csimplestringt.md)|Constructs `CSimpleStringT` objects in various ways.|  
|[CSimpleStringT::~CSimpleStringT](../vs140/csimplestringt--~csimplestringt.md)|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleStringT::Append](../vs140/csimplestringt--append.md)|Appends a `CSimpleStringT` object to an existing `CSimpleStringT` object.|  
|[CSimpleStringT::AppendChar](../vs140/csimplestringt--appendchar.md)|Appends a character to an existing `CSimpleStringT` object.|  
|[CSimpleStringT::CopyChars](../vs140/csimplestringt--copychars.md)|Copies a character or characters to another string.|  
|[CSimpleStringT::CopyCharsOverlapped](../vs140/csimplestringt--copycharsoverlapped.md)|Copies a character or characters to another string in which the buffers overlap.|  
|[CSimpleStringT::Empty](../vs140/csimplestringt--empty.md)|Forces a string to have a length of zero.|  
|[CSimpleStringT::FreeExtra](../vs140/csimplestringt--freeextra.md)|Frees any extra memory previously allocated by the string object.|  
|[CSimpleStringT::GetAllocLength](../vs140/csimplestringt--getalloclength.md)|Retrieves the allocated length of a `CSimpleStringT` object.|  
|[CSimpleStringT::GetAt](../vs140/csimplestringt--getat.md)|Returns the character at a given position.|  
|[CSimpleStringT::GetBuffer](../vs140/csimplestringt--getbuffer.md)|Returns a pointer to the characters in a `CSimpleStringT`.|  
|[CSimpleStringT::GetBufferSetLength](../vs140/csimplestringt--getbuffersetlength.md)|Returns a pointer to the characters in a `CSimpleStringT`, truncating to the specified length.|  
|[CSimpleStringT::GetLength](../vs140/csimplestringt--getlength.md)|Returns the number of characters in a `CSimpleStringT` object.|  
|[CSimpleStringT::GetManager](../vs140/csimplestringt--getmanager.md)|Retrieves the memory manager of the `CSimpleStringT` object.|  
|[CSimpleStringT::GetString](../vs140/csimplestringt--getstring.md)|Retrieves the character string|  
|[CSimpleStringT::IsEmpty](../vs140/csimplestringt--isempty.md)|Tests whether a `CSimpleStringT` object contains no characters.|  
|[CSimpleStringT::LockBuffer](../vs140/csimplestringt--lockbuffer.md)|Disables reference counting and protects the string in the buffer.|  
|[CSimpleStringT::Preallocate](../vs140/csimplestringt--preallocate.md)|Allocates a specific amount of memory for the character buffer.|  
|[CSimpleStringT::ReleaseBuffer](../vs140/csimplestringt--releasebuffer.md)|Releases control of the buffer returned by `GetBuffer`.|  
|[CSimpleStringT::ReleaseBufferSetLength](../vs140/csimplestringt--releasebuffersetlength.md)|Releases control of the buffer returned by `GetBuffer`.|  
|[CSimpleStringT::SetAt](../vs140/csimplestringt--setat.md)|Sets a character at a given position.|  
|[CSimpleStringT::SetManager](../vs140/csimplestringt--setmanager.md)|Sets the memory manager of a `CSimpleStringT` object.|  
|[CSimpleStringT::SetString](../vs140/csimplestringt--setstring.md)|Sets the string of a `CSimpleStringT` object.|  
|[CSimpleStringT::StringLength](../vs140/csimplestringt--stringlength.md)|Returns the number of characters in the specified string.|  
|[CSimpleStringT::Truncate](../vs140/csimplestringt--truncate.md)|Truncates the string to a specified length.|  
|[CSimpleStringT::UnlockBuffer](../vs140/csimplestringt--unlockbuffer.md)|Enables reference counting and releases the string in the buffer.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleStringT::operator PCXSTR](../vs140/csimplestringt--operator-pcxstr.md)|Directly accesses characters stored in a `CSimpleStringT` object as a C-style string.|  
|[CSimpleStringT::operator &#91;&#93;](../vs140/csimplestringt--operator.md)|Returns the character at a given position — operator substitution for `GetAt`.|  
|[CSimpleStringT::operator +=](../vs140/csimplestringt--operator--=.md)|Concatenates a new string to the end of an existing string.|  
|[CSimpleStringT::operator =](../vs140/csimplestringt--operator-=.md)|Assigns a new value to a `CSimpleStringT` object.|  
  
## Remarks  
 `CSimpleStringT` is the base class for the various string classes supported by Visual C++. It provides minimal support for memory management of the string object and basic buffer manipulation. For more advanced string objects, see [CStringT Class](../vs140/cstringt-class.md).  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [ATL/MFC Shared Classes](../vs140/atl-mfc-shared-classes.md)