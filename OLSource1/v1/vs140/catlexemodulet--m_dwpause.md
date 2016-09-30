---
title: "CAtlExeModuleT::m_dwPause"
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
  - "CAtlExeModuleT::m_dwPause"
  - "CAtlExeModuleT<T>::m_dwPause"
  - "ATL.CAtlExeModuleT<T>.m_dwPause"
  - "ATL::CAtlExeModuleT<T>::m_dwPause"
  - "m_dwPause"
  - "CAtlExeModuleT<T>.m_dwPause"
  - "ATL.CAtlExeModuleT.m_dwPause"
  - "CAtlExeModuleT.m_dwPause"
  - "ATL::CAtlExeModuleT::m_dwPause"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_dwPause"
ms.assetid: 143af4d5-d80e-4a7a-8e73-871d6a5f6e92
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlExeModuleT::m_dwPause
A pause value used to ensure all objects are gone before shutdown.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Change this value after calling [CAtlExeModuleT::InitializeCom](../vs140/catlexemodulet--initializecom.md) to set the number of milliseconds used as the pause value for shutting down the server. The default value is 1000 milliseconds.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlExeModuleT Class](../vs140/catlexemodulet-class.md)