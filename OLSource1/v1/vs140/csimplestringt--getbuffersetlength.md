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
Returns a pointer to the internal character buffer for the `CSimpleStringT` object, truncating or growing its length if necessary to exactly match the length specified in `nLength`.  
  
## Syntax  
  
```  
PXSTR GetBufferSetLength(  
   int nLength  
);  
```  
  
#### Parameters  
 `nLength`  
 The exact size of the `CSimpleStringT` character buffer in characters.  
  
## Return Value  
 A `PXSTR` pointer to the object's (null-terminated) character buffer.  
  
## Remarks  
 Call this method to retrieve a specified length of the internal buffer of the `CSimpleStringT` object. The returned `PXSTR` pointer is not `const` and thus allows direct modification of `CSimpleStringT` contents.  
  
 If you use the pointer returned by [GetBufferSetLength](#vclrfcsimplestringtgetbuffersetlength) to change the string contents, call `ReleaseBuffer` to update the internal state of `CsimpleStringT` before you use any other `CSimpleStringT` methods.  
  
 The address returned by `GetBufferSetLength` may not be valid after the call to `ReleaseBuffer` because additional `CSimpleStringT` operations can cause the `CSimpleStringT` buffer to be reallocated. The buffer is not reassigned if you do not change the length of the `CSimpleStringT`.  
  
 The buffer memory is automatically freed when the `CSimpleStringT` object is destroyed.  
  
 If you keep track of the string length yourself, do not not append the terminating null character. You must specify the final string length when you release the buffer by using `ReleaseBuffer`. If you do append a terminating null character when you call `ReleaseBuffer`, pass –1 (the default) for the length to `ReleaseBuffer`, and `ReleaseBuffer` will perform a `strlen` on the buffer to determine its length.  
  
 For more information about reference counting, see the following articles:  
  
-   [Managing Object Lifetimes through Reference Counting](http://msdn.microsoft.com/library/windows/desktop/ms687260) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
-   [Implementing Reference Counting](http://msdn.microsoft.com/library/windows/desktop/ms693431) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
-   [Rules for Managing Reference Counts](http://msdn.microsoft.com/library/windows/desktop/ms692481) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
## Example  
 The following example demonstrates the use of `CSimpleStringT::GetBufferSetLength`.  
  
 [!code[NVC_ATLMFC_Utilities#82](../vs140/codesnippet/CPP/csimplestringt--getbuffersetlength_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::GetBuffer](../vs140/csimplestringt--getbuffer.md)   
 [CSimpleStringT::ReleaseBuffer](../vs140/csimplestringt--releasebuffer.md)