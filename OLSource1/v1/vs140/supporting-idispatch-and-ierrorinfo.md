---
title: "Supporting IDispatch and IErrorInfo"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IErrorInfo"
  - "IDispatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ISupportErrorInfoImpl method"
  - "IErrorInfo class suppor in ATL"
  - "IDispatchImpl class"
  - "IDispatch class support in ATL"
ms.assetid: 7db2220f-319d-4ce9-9382-d340019f14f7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Supporting IDispatch and IErrorInfo
You can use the template class [IDispatchImpl](../vs140/idispatchimpl-class.md) to provide a default implementation of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> portion of any dual interfaces on your object.  
  
 If your object uses the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface to report errors back to the client, then your object must support the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface. The template class [ISupportErrorInfoImpl](../vs140/isupporterrorinfoimpl-class.md) provides an easy way to implement this if you only have a single interface that generates errors on your object.  
  
## See Also  
 [Fundamentals of ATL COM Objects](../vs140/fundamentals-of-atl-com-objects.md)