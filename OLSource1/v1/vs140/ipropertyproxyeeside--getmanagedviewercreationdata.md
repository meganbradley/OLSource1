---
title: "IPropertyProxyEESide::GetManagedViewerCreationData"
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
  - "IPropertyProxyEESide::GetManagedViewerCreationData"
helpviewer_keywords: 
  - "IPropertyProxyEESide::GetManagedViewerCreationData"
ms.assetid: c4eb4d60-8816-4d52-bc8d-dffd4f066499
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IPropertyProxyEESide::GetManagedViewerCreationData
Retrieves information about the viewer for this property type in order to instantiate that viewer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the name of the assembly holding this object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IEEDataStorage](../vs140/ieedatastorage.md) object containing the assembly bytes of this object (this is a null value if no bytes are available).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object containing the symbol store information for this object (this is a null value if no symbol store is available).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] Returns the class name containing this object.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Returns a value from the [ASSEMBLYLOCRESOLUTION](../vs140/assemblylocresolution.md) enumeration indicating the location of the assembly.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [out] Returns nonzero (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) if this object's value can be changed; zero (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) if the object is read-only.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method is used by type visualizers to instantiate a managed viewer.  
  
## See Also  
 [IPropertyProxyEESide](../vs140/ipropertyproxyeeside.md)   
 [ASSEMBLYLOCRESOLUTION](../vs140/assemblylocresolution.md)   
 [IEEDataStorage](../vs140/ieedatastorage.md)