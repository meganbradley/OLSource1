---
title: "IOleObjectImpl::SetMoniker"
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
  - "SetMoniker"
  - "IOleObjectImpl.SetMoniker"
  - "IOleObjectImpl::SetMoniker"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMoniker method"
ms.assetid: 4de54621-cdda-4f99-96fc-4feee3689e02
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::SetMoniker
Tells the control what its moniker is.  
  
## Syntax  
  
```  
  
      STDMETHOD(SetMoniker)(  
   DWORD /* dwWhichMoniker */,  
   IMoniker** /* pmk */  
);  
```  
  
## Return Value  
 Returns **E_NOTIMPL**.  
  
## Remarks  
 See [IOleObject::SetMoniker](http://msdn.microsoft.com/library/windows/desktop/ms679671) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)