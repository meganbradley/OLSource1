---
title: "CComSafeArray::GetType"
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
  - "CComSafeArray::GetType"
  - "CComSafeArray.GetType"
  - "GetType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetType method"
ms.assetid: 5b504199-fd4a-4d7a-8669-05f4e8df0778
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::GetType
Returns the type of data stored in the array.  
  
## Syntax  
  
```  
  
VARTYPE GetType( ) const;  
  
```  
  
## Return Value  
 Returns the type of data stored in the array, which could be any of the following types:  
  
|VARTYPE|Description|  
|-------------|-----------------|  
|VT_I1|char|  
|VT_I2|short|  
|VT_I4|int|  
|VT_I4|long|  
|VT_I8|longlong|  
|VT_UI1|byte|  
|VT_UI2|ushort|  
|VT_UI4|uint|  
|VT_UI4|ulong|  
|VT_UI8|ulonglong|  
|VT_R4|float|  
|VT_R8|double|  
|VT_DECIMAL|decimal pointer|  
|VT_VARIANT|variant pointer|  
|VT_CY|Currency data type|  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)