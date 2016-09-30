---
title: "IPropertyProxyEESide::InPlaceUpdateObject"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IPropertyProxyEESide::InPlaceUpdateObject"
helpviewer_keywords: 
  - "IPropertyProxyEESide::InPlaceUpdateObject"
ms.assetid: abf89411-1853-4f23-b244-d5e0afa197b1
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IPropertyProxyEESide::InPlaceUpdateObject
Updates the object's data with the given data object and returns a new data object representing the object's new data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IEEDataStorage](../vs140/ieedatastorage.md) object containing the new data.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns a new <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object containing the replaced data.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method actually updates the object's data. The data in the returned [IEEDataStorage](../vs140/ieedatastorage.md) object does not need to be the same as the data in the incoming <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object, but the returned object must reflect the property's current value.  
  
 The incoming data object is typically not implemented by the EE. However, the object returned by this method is always implemented by the EE, which lets the EE implement the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interface on whatever class is desired.  
  
 The [IPropertyProxyEESide::CreateReplacementObject](../vs140/ipropertyproxyeeside--createreplacementobject.md) method creates a data object based on the incoming data object but does not affect the property's original data.  
  
## See Also  
 [IPropertyProxyEESide](../vs140/ipropertyproxyeeside.md)   
 [IEEDataStorage](../vs140/ieedatastorage.md)   
 [IPropertyProxyEESide::CreateReplacementObject](../vs140/ipropertyproxyeeside--createreplacementobject.md)