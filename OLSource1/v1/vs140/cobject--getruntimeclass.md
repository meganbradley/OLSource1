---
title: "CObject::GetRuntimeClass"
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
  - "CObject.GetRuntimeClass"
  - "GetRuntimeClass"
  - "CObject::GetRuntimeClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRuntimeClass method"
  - "CObject class, miscellaneous"
ms.assetid: fee38b64-bde1-4086-9fa6-bc72940748ab
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObject::GetRuntimeClass
Returns the `CRuntimeClass` structure corresponding to this object's class.  
  
## Syntax  
  
```  
  
virtual CRuntimeClass* GetRuntimeClass( ) const;  
```  
  
## Return Value  
 A pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure corresponding to this object's class; never **NULL**.  
  
## Remarks  
 There is one `CRuntimeClass` structure for each `CObject`-derived class. The structure members are as follows:  
  
-   **LPCSTR m_lpszClassName** A null-terminated string containing the ASCII class name.  
  
-   **int m_nObjectSize** The size of the object, in bytes. If the object has data members that point to allocated memory, the size of that memory is not included.  
  
-   **UINT m_wSchema** The schema number ( – 1 for nonserializable classes). See the [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macro for a description of schema number.  
  
-   **CObject\* ( PASCAL\* m_pfnCreateObject )( )** A function pointer to the default constructor that creates an object of your class (valid only if the class supports dynamic creation; otherwise, returns **NULL**).  
  
-   **CRuntimeClass\* ( PASCAL\* m_pfn_GetBaseClass )( )** If your application is dynamically linked to the AFXDLL version of MFC, a pointer to a function that returns the `CRuntimeClass` structure of the base class.  
  
-   **CRuntimeClass\* m_pBaseClass** If your application is statically linked to MFC, a pointer to the `CRuntimeClass` structure of the base class.  
  
 This function requires use of the [IMPLEMENT_DYNAMIC](../vs140/implement_dynamic.md), [IMPLEMENT_DYNCREATE](../vs140/implement_dyncreate.md), or [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macro in the class implementation. You will get incorrect results otherwise.  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all `CObject` examples.  
  
 [!code[NVC_MFCCObjectSample#10](../vs140/codesnippet/CPP/cobject--getruntimeclass_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CObject Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObject::IsKindOf](../vs140/cobject--iskindof.md)   
 [RUNTIME_CLASS](../vs140/runtime_class.md)