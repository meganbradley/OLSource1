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
This class represents a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The character type of the string class. Can be one of the following:  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (for ANSI character strings).  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (for Unicode character strings).  
  
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
|[CSimpleStringT::CSimpleStringT](../vs140/csimplestringt--csimplestringt.md)|Constructs <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects in various ways.|  
|[CSimpleStringT::~CSimpleStringT](../vs140/csimplestringt--~csimplestringt.md)|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleStringT::Append](../vs140/csimplestringt--append.md)|Appends a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object to an existing <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
|[CSimpleStringT::AppendChar](../vs140/csimplestringt--appendchar.md)|Appends a character to an existing <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
|[CSimpleStringT::CopyChars](../vs140/csimplestringt--copychars.md)|Copies a character or characters to another string.|  
|[CSimpleStringT::CopyCharsOverlapped](../vs140/csimplestringt--copycharsoverlapped.md)|Copies a character or characters to another string in which the buffers overlap.|  
|[CSimpleStringT::Empty](../vs140/csimplestringt--empty.md)|Forces a string to have a length of zero.|  
|[CSimpleStringT::FreeExtra](../vs140/csimplestringt--freeextra.md)|Frees any extra memory previously allocated by the string object.|  
|[CSimpleStringT::GetAllocLength](../vs140/csimplestringt--getalloclength.md)|Retrieves the allocated length of a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
|[CSimpleStringT::GetAt](../vs140/csimplestringt--getat.md)|Returns the character at a given position.|  
|[CSimpleStringT::GetBuffer](../vs140/csimplestringt--getbuffer.md)|Returns a pointer to the characters in a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[CSimpleStringT::GetBufferSetLength](../vs140/csimplestringt--getbuffersetlength.md)|Returns a pointer to the characters in a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, truncating to the specified length.|  
|[CSimpleStringT::GetLength](../vs140/csimplestringt--getlength.md)|Returns the number of characters in a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
|[CSimpleStringT::GetManager](../vs140/csimplestringt--getmanager.md)|Retrieves the memory manager of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
|[CSimpleStringT::GetString](../vs140/csimplestringt--getstring.md)|Retrieves the character string|  
|[CSimpleStringT::IsEmpty](../vs140/csimplestringt--isempty.md)|Tests whether a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object contains no characters.|  
|[CSimpleStringT::LockBuffer](../vs140/csimplestringt--lockbuffer.md)|Disables reference counting and protects the string in the buffer.|  
|[CSimpleStringT::Preallocate](../vs140/csimplestringt--preallocate.md)|Allocates a specific amount of memory for the character buffer.|  
|[CSimpleStringT::ReleaseBuffer](../vs140/csimplestringt--releasebuffer.md)|Releases control of the buffer returned by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.|  
|[CSimpleStringT::ReleaseBufferSetLength](../vs140/csimplestringt--releasebuffersetlength.md)|Releases control of the buffer returned by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
|[CSimpleStringT::SetAt](../vs140/csimplestringt--setat.md)|Sets a character at a given position.|  
|[CSimpleStringT::SetManager](../vs140/csimplestringt--setmanager.md)|Sets the memory manager of a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
|[CSimpleStringT::SetString](../vs140/csimplestringt--setstring.md)|Sets the string of a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
|[CSimpleStringT::StringLength](../vs140/csimplestringt--stringlength.md)|Returns the number of characters in the specified string.|  
|[CSimpleStringT::Truncate](../vs140/csimplestringt--truncate.md)|Truncates the string to a specified length.|  
|[CSimpleStringT::UnlockBuffer](../vs140/csimplestringt--unlockbuffer.md)|Enables reference counting and releases the string in the buffer.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleStringT::operator PCXSTR](../vs140/csimplestringt--operator-pcxstr.md)|Directly accesses characters stored in a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object as a C-style string.|  
|[CSimpleStringT::operator &#91;&#93;](../vs140/csimplestringt--operator.md)|Returns the character at a given position — operator substitution for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
|[CSimpleStringT::operator +=](../vs140/csimplestringt--operator--=.md)|Concatenates a new string to the end of an existing string.|  
|[CSimpleStringT::operator =](../vs140/csimplestringt--operator-=.md)|Assigns a new value to a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is the base class for the various string classes supported by Visual C++. It provides minimal support for memory management of the string object and basic buffer manipulation. For more advanced string objects, see [CStringT Class](../vs140/cstringt-class.md).  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [ATL/MFC Shared Classes](../vs140/atl-mfc-shared-classes.md)