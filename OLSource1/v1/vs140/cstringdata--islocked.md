---
title: "CStringData::IsLocked"
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
  - "IsLocked"
  - "CStringData::IsLocked"
  - "ATL.CStringData.IsLocked"
  - "ATL::CStringData::IsLocked"
  - "CStringData.IsLocked"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsLocked method"
ms.assetid: aca3cc00-7411-4955-aa2a-5eeda8ba2aa6
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringData::IsLocked
Determines if the character buffer is locked.  
  
## Syntax  
  
```  
  
bool IsLocked( ) const throw( );  
  
```  
  
## Return Value  
 Returns **true** if the buffer is locked; otherwise **false**.  
  
## Remarks  
 Call this function to determine if the character buffer of a string object is currently locked.  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CStringData Class](../vs140/cstringdata-class.md)