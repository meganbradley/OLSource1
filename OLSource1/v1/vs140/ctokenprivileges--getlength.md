---
title: "CTokenPrivileges::GetLength"
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
  - "ATL::CTokenPrivileges::GetLength"
  - "ATL.CTokenPrivileges.GetLength"
  - "CTokenPrivileges.GetLength"
  - "CTokenPrivileges::GetLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLength method"
ms.assetid: 33651c5b-0789-43bc-b06d-c6b5396c375d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTokenPrivileges::GetLength
Returns the length of the `CTokenPrivileges` object.  
  
## Syntax  
  
```  
  
UINT GetLength( ) const throw( );  
  
```  
  
## Return Value  
 Returns the number of bytes required to hold a **TOKEN_PRIVILEGES** structure represented by the `CTokenPrivileges` object, including all of the privilege entries it contains.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CTokenPrivileges Class](../vs140/ctokenprivileges-class.md)   
 [CTokenPrivileges::GetCount](../vs140/ctokenprivileges--getcount.md)