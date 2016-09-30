---
title: "IPropertyProxyEESide::CreateReplacementObject"
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
  - "IPropertyProxyEESide::CreateReplacementObject"
helpviewer_keywords: 
  - "IPropertyProxyEESide::CreateReplacementObject"
ms.assetid: 0cfe79b8-c3f1-48b0-a225-e39dee2c92fe
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IPropertyProxyEESide::CreateReplacementObject
Creates a copy of a data object specific to the expression evaluator (EE).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IEEDataStorage](../vs140/ieedatastorage.md) object holding the data to be copied.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns a new <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method is given an [IEEDataStorage](../vs140/ieedatastorage.md) object representing an array of bytes. This incoming data object is typically not implemented by the EE. However, the object returned by this method is always implemented by the EE, which lets the EE implement the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface on whatever class is desired.  
  
 Note that the data supplied by the incoming <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object must be the same data in the outgoing <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
## See Also  
 [IPropertyProxyEESide](../vs140/ipropertyproxyeeside.md)   
 [IEEDataStorage](../vs140/ieedatastorage.md)