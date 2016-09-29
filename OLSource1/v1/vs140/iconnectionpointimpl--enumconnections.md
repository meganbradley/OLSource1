---
title: "IConnectionPointImpl::EnumConnections"
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
  - "EnumConnections"
  - "ATL.IConnectionPointImpl.EnumConnections"
  - "ATL::IConnectionPointImpl::EnumConnections"
  - "IConnectionPointImpl::EnumConnections"
  - "IConnectionPointImpl.EnumConnections"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnumConnections method"
ms.assetid: e58182eb-6b82-42d9-a156-8b0b74cd54f7
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IConnectionPointImpl::EnumConnections
Creates an enumerator to iterate through the connections for the connection point.  
  
## Syntax  
  
```  
  
      STDMETHOD(EnumConnections)(  
   IEnumConnections** ppEnum   
);  
```  
  
## Remarks  
 See [IConnectionPoint::EnumConnections](http://msdn.microsoft.com/library/windows/desktop/ms680755) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IConnectionPointImpl Class](../vs140/iconnectionpointimpl-class.md)   
 [IEnumConnections](http://msdn.microsoft.com/library/windows/desktop/ms682237)