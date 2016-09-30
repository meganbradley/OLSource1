---
title: "CRBMultiMap::CRBMultiMap"
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
  - "CRBMultiMap::CRBMultiMap"
  - "CRBMultiMap"
  - "ATL.CRBMultiMap.CRBMultiMap"
  - "CRBMultiMap.CRBMultiMap"
  - "ATL::CRBMultiMap::CRBMultiMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRBMultiMap constructor"
  - "CRBMultiMap class, constructor"
ms.assetid: 2102e839-1a86-4601-b092-e5e79427b1c3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBMultiMap::CRBMultiMap
The constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The block size.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter is a measure of the amount of memory allocated when a new element is required. Larger block sizes reduce calls to memory allocation routines, but use more resources. The default will allocate space for 10 elements at a time.  
  
 See the documentation for the base class [CRBTree](../vs140/crbtree-class.md) for information on the other methods available.  
  
## Example  
 [!code[NVC_ATL_Utilities#85](../vs140/codesnippet/CPP/crbmultimap--crbmultimap_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBMultiMap Class](../vs140/crbmultimap-class.md)   
 [CRBMultiMap::~CRBMultiMap](../vs140/crbmultimap--~crbmultimap.md)