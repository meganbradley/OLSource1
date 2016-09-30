---
title: "CSimpleStringT::GetBufferSetLength"
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
  - "ATL::CSimpleStringT::GetBufferSetLength"
  - "ATL.CSimpleStringT.GetBufferSetLength"
  - "CSimpleStringT.GetBufferSetLength"
  - "GetBufferSetLength"
  - "CSimpleStringT::GetBufferSetLength"
  - "ATL::CSimpleStringT<BaseType>::GetBufferSetLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBufferSetLength method"
ms.assetid: 41528b28-008f-47a7-bc16-129f514076ec
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::GetBufferSetLength
Returns a pointer to the internal character buffer for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object, truncating or growing its length if necessary to exactly match the length specified in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The exact size of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> character buffer in characters.  
  
## Return Value  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointer to the object's (null-terminated) character buffer.  
  
## Remarks  
 Call this method to retrieve a specified length of the internal buffer of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. The returned <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> pointer is not <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and thus allows direct modification of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> contents.  
  
 If you use the pointer returned by [GetBufferSetLength](#vclrfcsimplestringtgetbuffersetlength) to change the string contents, call <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to update the internal state of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> before you use any other <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> methods.  
  
 The address returned by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> may not be valid after the call to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> because additional <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> operations can cause the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> buffer to be reallocated. The buffer is not reassigned if you do not change the length of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 The buffer memory is automatically freed when the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object is destroyed.  
  
 If you keep track of the string length yourself, do not not append the terminating null character. You must specify the final string length when you release the buffer by using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If you do append a terminating null character when you call <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, pass –1 (the default) for the length to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> will perform a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> on the buffer to determine its length.  
  
 For more information about reference counting, see the following articles:  
  
-   [Managing Object Lifetimes through Reference Counting](http://msdn.microsoft.com/library/windows/desktop/ms687260) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
-   [Implementing Reference Counting](http://msdn.microsoft.com/library/windows/desktop/ms693431) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
-   [Rules for Managing Reference Counts](http://msdn.microsoft.com/library/windows/desktop/ms692481) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
## Example  
 The following example demonstrates the use of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 [!code[NVC_ATLMFC_Utilities#82](../vs140/codesnippet/CPP/csimplestringt--getbuffersetlength_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::GetBuffer](../vs140/csimplestringt--getbuffer.md)   
 [CSimpleStringT::ReleaseBuffer](../vs140/csimplestringt--releasebuffer.md)