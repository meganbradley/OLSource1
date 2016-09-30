---
title: "CSimpleStringT::GetBuffer"
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
  - "CSimpleStringT<BaseType>::GetBuffer"
  - "ATL.CSimpleStringT.GetBuffer"
  - "ATL::CSimpleStringT<BaseType>::GetBuffer"
  - "CSimpleStringT::GetBuffer"
  - "CSimpleStringT.GetBuffer"
  - "ATL.CSimpleStringT<BaseType>.GetBuffer"
  - "ATL::CSimpleStringT::GetBuffer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBuffer method"
ms.assetid: 04eadc47-c1a7-420b-81da-35fc90ede986
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::GetBuffer
Returns a pointer to the internal character buffer for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The minimum number of characters that the character buffer can hold. This value does not include space for a null terminator.  
  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is larger than the length of the current buffer, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> destroys the current buffer, replaces it with a buffer of the requested size, and resets the object reference count to zero. If you have previously called [LockBuffer](../vs140/csimplestringt--lockbuffer.md) on this buffer, you lose the buffer lock.  
  
## Return Value  
 An <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointer to the object's (null-terminated) character buffer.  
  
## Remarks  
 Call this method to return the buffer contents of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. The returned <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not a constant and therefore allows direct modification of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> contents.  
  
 If you use the pointer returned by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to change the string contents, you must call [ReleaseBuffer](../vs140/csimplestringt--releasebuffer.md) before you use any other <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member methods.  
  
 The address returned by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> may not be valid after the call to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> because additional <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operations can cause the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> buffer to be reallocated. The buffer is not reallocated if you do not change the length of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 The buffer memory is automatically freed when the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object is destroyed.  
  
 If you keep track of the string length yourself, you should not append the terminating null character. However, you must specify the final string length when you release the buffer with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. If you do append a terminating null character, you should pass –1 (the default) for the length. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> then determines the buffer length.  
  
 If there is insufficient memory to satisfy the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> request, this method throws a CMemoryException*.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#81](../vs140/codesnippet/CPP/csimplestringt--getbuffer_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::GetBufferSetLength](../vs140/csimplestringt--getbuffersetlength.md)   
 [CSimpleStringT::ReleaseBuffer](../vs140/csimplestringt--releasebuffer.md)