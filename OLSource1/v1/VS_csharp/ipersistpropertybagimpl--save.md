---
title: "IPersistPropertyBagImpl::Save"
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
  - "ATL::IPersistPropertyBagImpl::Save"
  - "ATL.IPersistPropertyBagImpl<T>.Save"
  - "IPersistPropertyBagImpl.Save"
  - "ATL.IPersistPropertyBagImpl.Save"
  - "IPersistPropertyBagImpl::Save"
  - "ATL::IPersistPropertyBagImpl<T>::Save"
  - "IPersistPropertyBagImpl<T>::Save"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Save method"
ms.assetid: 133739f8-2a0c-4594-a8f1-dacf5cf38e9b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IPersistPropertyBagImpl::Save
Saves the object's properties into a client-supplied property bag.  
  
## Syntax  
  
```  
  
      STDMETHOD(Save)(  
   LPPROPERTYBAG pPropBag,  
   BOOL fClearDirty,  
   BOOL fSaveAllProperties   
);  
```  
  
## Remarks  
 ATL uses the object's property map to store this information. By default, this method saves all properties, regardless of the value of *fSaveAllProperties*.  
  
 See [IPersistPropertyBag::Save](https://msdn.microsoft.com/en-us/library/aa768207.aspx) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IPersistPropertyBagImpl Class](../VS_csharp/ipersistpropertybagimpl-class.md)   
 [BEGIN_PROP_MAP](../VS_csharp/begin_prop_map.md)   
 [IPersistPropertyBagImpl::Load](../VS_csharp/ipersistpropertybagimpl--load.md)   
 [IPropertyBag](https://msdn.microsoft.com/en-us/library/aa768196.aspx)