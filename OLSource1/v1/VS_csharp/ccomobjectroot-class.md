---
title: "CComObjectRoot Class"
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
  - "CComObjectRoot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComObjectRoot class"
ms.assetid: f8797c38-6e73-4f67-85c2-71654cffa8eb
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectRoot Class
This typedef of [CComObjectRootEx](../VS_csharp/ccomobjectrootex-class.md) is templatized on the default threading model of the server.  
  
## Syntax  
  
```  
  
typedef CComObjectRootEx<CComObjectThreadModel> CComObjectRoot;  
  
```  
  
## Remarks  
 `CComObjectRoot` is a `typedef` of [CComObjectRootEx](../VS_csharp/ccomobjectrootex-class.md) templatized on the default threading model of the server. Thus [CComObjectThreadModel](../VS_csharp/ccomobjectthreadmodel.md) will reference either [CComSingleThreadModel](../VS_csharp/ccomsinglethreadmodel-class.md) or [CComMultiThreadModel](../VS_csharp/ccommultithreadmodel-class.md).  
  
 `CComObjectRootEx` handles object reference count management for both nonaggregated and aggregated objects. It holds the object reference count if your object is not being aggregated, and holds the pointer to the outer unknown if your object is being aggregated. For aggregated objects, `CComObjectRootEx` methods can be used to handle the failure of the inner object to construct, and to protect the outer object from deletion when inner interfaces are released or the inner object is deleted.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectRootEx Class Members](assetId:///e3ce9c3d-9c8e-4fe5-b682-8e56740a0164)   
 [CComObjectRootEx Class](../VS_csharp/ccomobjectrootex-class.md)   
 [CComAggObject Class](../VS_csharp/ccomaggobject-class.md)   
 [CComObject Class](../VS_csharp/ccomobject-class.md)   
 [CComPolyObject Class](../VS_csharp/ccompolyobject-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)