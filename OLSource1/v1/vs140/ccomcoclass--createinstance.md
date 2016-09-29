---
title: "CComCoClass::CreateInstance"
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
  - "CComCoClass::CreateInstance"
  - "ATL.CComCoClass.CreateInstance"
  - "CComCoClass.CreateInstance"
  - "ATL::CComCoClass::CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstance method"
ms.assetid: c7f42e00-c11e-411d-a2b0-8cd5c6361e4c
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCoClass::CreateInstance
Use these `CreateInstance` functions to create an instance of a COM object and retrieve an interface pointer without using the COM API.  
  
## Syntax  
  
```  
  
      template <class   
      Q  
      >  
static HRESULT CreateInstance(  
   Q** pp   
);  
template <class Q>  
static HRESULT CreateInstance(  
   IUnknown* punkOuter,  
   Q** pp   
);  
```  
  
#### Parameters  
 `Q`  
 The COM interface that should be returned via `pp`.  
  
 *punkOuter*  
 [in] The outer unknown or controlling unknown of the aggregate.  
  
 `pp`  
 [out] The address of a pointer variable that receives the requested interface pointer if creation succeeds.  
  
## Return Value  
 A standard `HRESULT` value. See [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a description of possible return values.  
  
## Remarks  
 Use the first overload of this function for typical object creation; use the second overload when you need to aggregate the object being created.  
  
 The ATL class implementing the required COM object (that is, the class used as the first template parameter to [CComCoClass](../vs140/ccomcoclass-class.md)) must be in the same project as the calling code. The creation of the COM object is carried out by the class factory registered for this ATL class.  
  
 These functions are useful for creating objects that you have prevented from being externally creatable by using the [OBJECT_ENTRY_NON_CREATEABLE_EX_AUTO](../vs140/object_entry_non_createable_ex_auto.md) macro. They are also useful in situations where you want to avoid the COM API for reasons of efficiency.  
  
 Note that the interface `Q` must have an IID associated with it that can be retrieved using the [__uuidof](../vs140/__uuidof-operator.md) operator.  
  
## Example  
 In the following example, `CDocument` is a wizard-generated ATL class derived from `CComCoClass` that implements the **IDocument** interface. The class is registered in the object map with the `OBJECT_ENTRY_NON_CREATEABLE_EX_AUTO` macro so clients can't create instances of the document using [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615). `CApplication` is a CoClass that provides a method on one of its own COM interfaces to create instances of the document class. The code below shows how easy it to create instances of the document class using the `CreateInstance` member inherited from the `CComCoClass` base class.  
  
 [!code[NVC_ATL_COM#11](../vs140/codesnippet/CPP/ccomcoclass--createinstance_1.cpp)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComCoClass Class](../vs140/ccomcoclass-class.md)