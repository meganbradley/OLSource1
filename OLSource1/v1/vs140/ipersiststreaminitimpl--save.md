---
title: "IPersistStreamInitImpl::Save"
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
  - "IPersistStreamInitImpl<T>::Save"
  - "ATL.IPersistStreamInitImpl<T>.Save"
  - "IPersistStreamInitImpl.Save"
  - "ATL.IPersistStreamInitImpl.Save"
  - "IPersistStreamInitImpl::Save"
  - "ATL::IPersistStreamInitImpl::Save"
  - "ATL::IPersistStreamInitImpl<T>::Save"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Save method"
ms.assetid: 1cefec59-c369-45bb-9360-16b5a13bea6a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IPersistStreamInitImpl::Save
Saves the object's properties to the specified stream.  
  
## Syntax  
  
```  
  
      STDMETHOD(Save)(  
   LPSTREAM pStm,  
   BOOL fClearDirty   
);  
```  
  
## Remarks  
 ATL uses the object's property map to store this information.  
  
 See [IPersistStreamInit::Save](http://msdn.microsoft.com/library/windows/desktop/ms694439) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IPersistStreamInitImpl Class](../vs140/ipersiststreaminitimpl-class.md)   
 [BEGIN_PROP_MAP](../vs140/begin_prop_map.md)   
 [IPersistStreamInitImpl::Load](../vs140/ipersiststreaminitimpl--load.md)   
 [IStream](http://msdn.microsoft.com/library/windows/desktop/aa380034)