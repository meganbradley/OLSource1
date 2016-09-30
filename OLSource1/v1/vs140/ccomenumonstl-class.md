---
title: "CComEnumOnSTL Class"
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
  - "CComEnumOnSTL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComEnumOnSTL class"
ms.assetid: befe1a44-7a00-4f28-9a2e-cc0fa526643c
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComEnumOnSTL Class
This class defines a COM enumerator object based on an STL collection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A COM enumerator ( [IEnumXXXX](https://msdn.microsoft.com/en-us/library/ms680089.aspx)) interface.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the interface ID of the enumerator interface.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of item exposed by the enumerator interface.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A [copy policy](../vs140/atl-copy-policy-classes.md) class.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An STL container class.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> defines a COM enumerator object based on an STL collection. This class can be used on its own or in conjunction with [ICollectionOnSTLImpl](../vs140/icollectiononstlimpl-class.md). Typical steps for using this class are outlined below. For more information, see [ATL Collections and Enumerators](../vs140/atl-collections-and-enumerators.md).  
  
## To use this class with ICollectionOnSTLImpl:  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> a specialization of this class.  
  
-   Use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as the final template argument in a specialization of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 See [ATL Collections and Enumerators](../vs140/atl-collections-and-enumerators.md) for an example.  
  
## To use this class independently of ICollectionOnSTLImpl:  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> a specialization of this class.  
  
-   Use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> as the template argument in a specialization of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
-   Create an instance of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> specialization.  
  
-   Initialize the enumerator object by calling [IEnumOnSTLImpl::Init](../vs140/ienumonstlimpl--init.md).  
  
-   Return the enumerator interface to the client.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 [CComObjectRootEx](../vs140/ccomobjectrootex-class.md)  
  
 [IEnumOnSTLImpl](../vs140/ienumonstlimpl-class.md)  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
## Example  
 The code shown below provides a generic function to handle the creation and initialization of an enumerator object:  
  
 [!code[NVC_ATL_COM#34](../vs140/codesnippet/CPP/ccomenumonstl-class_1.h)]  
  
 This template function can be used to implement the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> property of a collection interface as shown below:  
  
 [!code[NVC_ATL_COM#35](../vs140/codesnippet/CPP/ccomenumonstl-class_2.h)]  
  
 This code creates a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> that exposes a vector of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>s by means of the **IEnumVariant** interface. The **CVariantCollection** class simply specializes **CreateSTLEnumerator** to work with enumerator objects of this type.  
  
## See Also  
 [IEnumOnSTLImpl](../vs140/ienumonstlimpl-class.md)   
 [ATLCollections Sample: Demonstrates ICollectionOnSTLImpl, CComEnumOnSTL, and Custom Copy Policy Classes](../vs140/visual-c---samples.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)   
 [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md)   
 [IEnumOnSTLImpl Class](../vs140/ienumonstlimpl-class.md)