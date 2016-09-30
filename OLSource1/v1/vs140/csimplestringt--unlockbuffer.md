---
title: "CSimpleStringT::UnlockBuffer"
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
  - "CSimpleStringT.UnlockBuffer"
  - "CSimpleStringT::UnlockBuffer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnlockBuffer method"
ms.assetid: 45ed73e4-6d5d-45fc-80e1-f4be2475aa17
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::UnlockBuffer
Unlocks the buffer of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Call this method to reset the reference count of the string to 1.  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> destructor automatically calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to ensure that the buffer is not locked when the destructor is called. For an example of this method, see [LockBuffer](../vs140/csimplestringt--lockbuffer.md).  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::LockBuffer](../vs140/csimplestringt--lockbuffer.md)   
 [CSimpleStringT::GetBuffer](../vs140/csimplestringt--getbuffer.md)   
 [CSimpleStringT::ReleaseBuffer](../vs140/csimplestringt--releasebuffer.md)