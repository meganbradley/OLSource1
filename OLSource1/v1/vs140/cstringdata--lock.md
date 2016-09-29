---
title: "CStringData::Lock"
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
  - "ATL::CStringData::Lock"
  - "CStringData::Lock"
  - "ATL.CStringData.Lock"
  - "CStringData.Lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lock method"
ms.assetid: 0c20d2c0-6dc3-4d9f-a191-5566efc1ea71
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringData::Lock
Locks the character buffer of the associated string object.  
  
## Syntax  
  
```  
  
void Lock( ) throw( );  
  
```  
  
## Remarks  
 Call this function to lock the character buffer of the string data object. Locking and unlocking is used when direct access to the character buffer is required by the developer. A good example of locking is demonstrated by the [LockBuffer](../vs140/csimplestringt--lockbuffer.md) and [UnlockBuffer](../vs140/csimplestringt--unlockbuffer.md) methods of `CSimpleStringT`.  
  
> [!NOTE]
>  A character buffer can only be locked if the buffer is not shared among higher string objects.  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CStringData Class](../vs140/cstringdata-class.md)   
 [CStringData::Unlock](../vs140/cstringdata--unlock.md)