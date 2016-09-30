---
title: "Classes_merged"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 969f03b1-69e9-4b51-9814-dfd53b23752e
caps.latest.revision: 126
---
# Classes_merged
This class defines a COM enumerator object based on an array.  
  
## Syntax  
  
```  
  
template <class Base,  
      const IID*  piid,  
      class  T,  
      class  Copy,  
      class  ThreadModel  
    = CcomObjectThreadModel>  
   class ATL_NO_VTABLE CComEnum :  
   public CComEnumImpl< Base  
   ,  piid  
   ,  T  
   ,  Copy  
   >,  
   public CComObjectRootEx<  ThreadModel  
    >  
  
```  
  
#### Parameters  
 `Base`  
 A COM enumerator ( [IEnumXXXX](https://msdn.microsoft.com/en-us/library/ms680089.aspx)) interface.  
  
 `piid`  
 A pointer to the interface ID of the enumerator interface.  
  
 `T`  
 The type of item exposed by the enumerator interface.  
  
 `Copy`  
 A homogeneous [copy policy class](../vs140/atl-copy-policy-classes.md).  
  
 `ThreadModel`  
 The threading model of the class. This parameter defaults to the global object thread model used in your project.  
  
## Remarks  
 `CComEnum` defines a COM enumerator object based on an array. This class is analogous to [CComEnumOnSTL](../vs140/ccomenumonstl-class.md) which implements an enumerator based on an STL container. Typical steps for using this class are outlined below. For more information, see [ATL Collections and Enumerators](../vs140/atl-collections-and-enumerators.md).  
  
## To use this class:  
  
-   `typedef` a specialization of this class.  
  
-   Use the `typedef` as the template argument in a specialization of `CComObject`.  
  
-   Create an instance of the `CComObject` specialization.  
  
-   Initialize the enumerator object by calling [CComEnumImpl::Init](../vs140/ccomenumimpl--init.md).  
  
-   Return the enumerator interface to the client.  
  
## Inheritance Hierarchy  
 `CComObjectRootBase`  
  
 `Base`  
  
 [CComObjectRootEx](../vs140/ccomobjectrootex-class.md)  
  
 [CComEnumImpl](../vs140/ccomenumimpl-class.md)  
  
 `CComEnum`  
  
## Requirements  
 **Header:** atlcom.h  
  
## Example  
 The code shown below provides a reusable function for creating and initializing an enumerator object.  
  
 [!code[NVC_ATL_COM#32](../vs140/codesnippet/CPP/classes_merged_1.h)]  
  
 This template function can be used to implement the `_NewEnum` property of a collection interface as shown below:  
  
 [!code[NVC_ATL_COM#33](../vs140/codesnippet/CPP/classes_merged_2.h)]  
  
 This code creates a `typedef` for `CComEnum` that exposes a vector of **VARIANT**s through the **IEnumVariant** interface. The **CVariantArrayCollection** class simply specializes **CreateEnumerator** to work with enumerator objects of this type and passes the necessary arguments.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md)   
 [CComEnumImpl Class](../vs140/ccomenumimpl-class.md)   
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)