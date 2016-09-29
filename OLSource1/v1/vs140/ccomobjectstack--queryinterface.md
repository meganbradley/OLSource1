---
title: "CComObjectStack::QueryInterface"
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
  - "CComObjectStack::QueryInterface"
  - "CComObjectStack.QueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryInterface method"
ms.assetid: be11f4d5-ab21-4cf7-b7e5-5333bf2ca1e4
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectStack::QueryInterface
Returns **E_NOINTERFACE**.  
  
## Syntax  
  
```  
  
      HRESULT QueryInterface(  
   REFIID,  
   void**  
) ;  
```  
  
## Return Value  
 Returns **E_NOINTERFACE**.  
  
## Remarks  
 In debug mode, calls `_ASSERTE`.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectStack Class](../vs140/ccomobjectstack-class.md)