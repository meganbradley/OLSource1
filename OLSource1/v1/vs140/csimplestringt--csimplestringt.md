---
title: "CSimpleStringT::CSimpleStringT"
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
  - CSimpleStringT<BaseType>::CSimpleStringT
  - CSimpleStringT::CSimpleStringT
  - ATL::CSimpleStringT::CSimpleStringT
  - ATL.CSimpleStringT.CSimpleStringT
  - ATL::CSimpleStringT<BaseType>::CSimpleStringT
  - CSimpleStringT.CSimpleStringT
dev_langs: 
  - C++
helpviewer_keywords: 
  - CSimpleStringT class, constructor
ms.assetid: 97999818-a7ec-42f4-b8b5-946eff498559
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSimpleStringT::CSimpleStringT
Constructs a `CSimpleStringT` object.  
  
## Syntax  
  
```  
  
      CSimpleStringT(  
   const XCHAR* pchSrc,  
   int nLength,  
   IAtlStringMgr* pStringMgr  
);  
CSimpleStringT(  
   PCXSTR pszSrc,  
   IAtlStringMgr* pStringMgr  
);  
CSimpleStringT(  
   const CSimpleStringT& strSrc   
);  
explicit CSimpleStringT(  
   IAtlStringMgr* pStringMgr  
) throw( );  
```  
  
#### Parameters  
 `strSrc`  
 An existing `CSimpleStringT` object to be copied into this `CSimpleStringT` object.  
  
 `pchSrc`  
 A pointer to an array of characters of length `nLength`, not null terminated.  
  
 `pszSrc`  
 A null-terminated string to be copied into this `CSimpleStringT` object.  
  
 `nLength`  
 A count of the number of characters in `pch`.  
  
 `pStringMgr`  
 A pointer to the memory manager of the `CSimpleStringT` object. For more information about `IAtlStringMgr` and memory management for `CSimpleStringT`, see [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md).  
  
## Remarks  
 Construct a new `CSimpleStringT` object. Because the constructors copy the input data into new allocated storage, memory exceptions may result.  
  
## Example  
 The following example demonstrates the use of `CSimpleStringT::CSimpleStringT` by using the ATL `typedef``CSimpleString`. `CSimpleString` is a commonly used specialization of the class template `CSimpleStringT`.  
  
 A specialization defines a class by putting specific type parameters into a class template. For more information, see [Class Template Instantiation](../vs140/class-template-instantiation.md).  
  
 [!code[NVC_ATLMFC_Utilities#77](../vs140/codesnippet/CPP/csimplestringt--csimplestringt_1.cpp)]
  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)