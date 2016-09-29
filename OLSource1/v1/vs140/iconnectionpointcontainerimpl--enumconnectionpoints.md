---
title: "IConnectionPointContainerImpl::EnumConnectionPoints"
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
  - "EnumConnectionPoints"
  - "IConnectionPointContainerImpl::EnumConnectionPoints"
  - "ATL::IConnectionPointContainerImpl::EnumConnectionPoints"
  - "IConnectionPointContainerImpl.EnumConnectionPoints"
  - "ATL.IConnectionPointContainerImpl.EnumConnectionPoints"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnumConnectionPoints method"
ms.assetid: ca5a3676-3484-4d75-8ee3-47d049a09051
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IConnectionPointContainerImpl::EnumConnectionPoints
Creates an enumerator to iterate through the connection points supported in the connectable object.  
  
## Syntax  
  
```  
  
      STDMETHOD(EnumConnectionPoints)(  
   IEnumConnectionPoints **ppEnum   
);  
```  
  
## Remarks  
 See [IConnectionPointContainer::EnumConnectionPoints](http://msdn.microsoft.com/library/windows/desktop/ms682460) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IConnectionPointContainerImpl Class](../vs140/iconnectionpointcontainerimpl-class.md)   
 [IConnectionPointImpl Class](../vs140/iconnectionpointimpl-class.md)   
 [IEnumConnectionPoints](http://msdn.microsoft.com/library/windows/desktop/ms688265)