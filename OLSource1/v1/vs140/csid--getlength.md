---
title: "CSid::GetLength"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.CSid.GetLength
  - CSid.GetLength
  - ATL::CSid::GetLength
  - CSid::GetLength
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetLength method
ms.assetid: d5661091-fffc-4cc2-aa27-eee6a0a2b9ff
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSid::GetLength
Returns the length of the `CSid` object.  
  
## Syntax  
  
```  
  
UINT GetLength( ) const throw( );  
  
```  
  
## Return Value  
 Returns the length in bytes of the `CSid` object.  
  
## Remarks  
 If the `CSid` structure is not valid, the return value is undefined. Before calling `GetLength`, use the [CSid::IsValid](../vs140/csid--isvalid.md) member function to verify that `CSid` is valid.  
  
> [!NOTE]
>  Under debug builds the function will cause an ASSERT if the `CSid` object is not valid.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)