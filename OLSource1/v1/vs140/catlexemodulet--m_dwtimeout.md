---
title: "CAtlExeModuleT::m_dwTimeOut"
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
  - "CAtlExeModuleT::m_dwTimeOut"
  - "ATL::CAtlExeModuleT<T>::m_dwTimeOut"
  - "ATL.CAtlExeModuleT<T>.m_dwTimeOut"
  - "m_dwTimeOut"
  - "ATL::CAtlExeModuleT::m_dwTimeOut"
  - "CAtlExeModuleT.m_dwTimeOut"
  - "CAtlExeModuleT<T>::m_dwTimeOut"
  - "ATL.CAtlExeModuleT.m_dwTimeOut"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_dwTimeOut"
ms.assetid: 14eb29a9-0cc1-4da1-8644-f2a97dce8bca
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlExeModuleT::m_dwTimeOut
A time-out value used to delay the unloading of the module.  
  
## Syntax  
  
```  
  
DWORD m_dwTimeOut;  
  
```  
  
## Remarks  
 Change this value after calling [CAtlExeModuleT::InitializeCom](../vs140/catlexemodulet--initializecom.md) to define the number of milliseconds used as the time-out value for shutting down the server. The default value is 5000 milliseconds. See the [CAtlExeModuleT Overview](../vs140/catlexemodulet-class.md) for more details.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlExeModuleT Class](../vs140/catlexemodulet-class.md)