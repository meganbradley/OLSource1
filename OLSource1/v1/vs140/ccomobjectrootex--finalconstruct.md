---
title: "CComObjectRootEx::FinalConstruct"
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
  - "CComObjectRootEx::FinalConstruct"
  - "CComObjectRootEx.FinalConstruct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FinalConstruct method"
  - "aggregation [C++], CComObjectRootEx"
ms.assetid: ab9f38e6-c5d0-4b70-b2f5-977e79b858c1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectRootEx::FinalConstruct
You can override this method in your derived class to perform any initialization required for your object.  
  
## Syntax  
  
```  
  
HRESULT FinalConstruct( );  
```  
  
## Return Value  
 Return `S_OK` on success or one of the standard error `HRESULT` values.  
  
## Remarks  
 By default, `CComObjectRootEx::FinalConstruct` simply returns `S_OK`.  
  
 There are advantages to performing initialization in `FinalConstruct` rather than the constructor of your class:  
  
-   You cannot return a status code from a constructor, but you can return an `HRESULT` by means of `FinalConstruct`'s return value. When objects of your class are being created using the standard class factory provided by ATL, this return value is propagated back to the COM client allowing you to provide them with detailed error information.  
  
-   You cannot call virtual functions through the virtual function mechanism from the constructor of a class. Calling a virtual function from the constructor of a class results in a statically resolved call to the function as it is defined at that point in the inheritance hierarchy. Calls to pure virtual functions result in linker errors.  
  
     Your class is not the most derived class in the inheritance hierarchy — it relies on a derived class supplied by ATL to provide some of its functionality. There is a good chance that your initialization will need to use the features provided by that class (this is certainly true when objects of your class need to aggregate other objects), but the constructor in your class has no way to access those features. The construction code for your class is executed before the most derived class is fully constructed.  
  
     However, `FinalConstruct` is called immediately after the most derived class is fully constructed allowing you to call virtual functions and use the reference-counting implementation provided by ATL.  
  
## Example  
 Typically, override this method in the class derived from `CComObjectRootEx` to create any aggregated objects. For example:  
  
 [!code[NVC_ATL_COM#40](../vs140/codesnippet/CPP/ccomobjectrootex--finalconstruct_1.h)]  
  
 If the construction fails, you can return an error. You can also use the macro [DECLARE_PROTECT_FINAL_CONSTRUCT](../vs140/declare_protect_final_construct.md) to protect your outer object from being deleted if, during creation, the internal aggregated object increments the reference count then decrements the count to 0.  
  
 Here is a typical way to create an aggregate:  
  
-   Add an **IUnknown** pointer to your class object and initialize it to **NULL** in the constructor.  
  
-   Override `FinalConstruct` to create the aggregate.  
  
-   Use the **IUnknown** pointer you defined as the parameter to the [COM_INTERFACE_ENTRY_AGGREGATE](../vs140/com_interface_entry_aggregate.md) macro.  
  
-   Override `FinalRelease` to release the **IUnknown** pointer.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)   
 [CComObjectRootEx::FinalRelease](../vs140/ccomobjectrootex--finalrelease.md)   
 [DECLARE_GET_CONTROLLING_UNKNOWN](../vs140/declare_get_controlling_unknown.md)