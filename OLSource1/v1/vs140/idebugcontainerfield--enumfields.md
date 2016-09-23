---
title: "IDebugContainerField::EnumFields"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IDebugContainerField::EnumFields
helpviewer_keywords: 
  - IDebugContainerField::EnumFields method
ms.assetid: 9e5e681b-ad49-4c62-bd95-4afa11d61a57
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugContainerField::EnumFields
Creates an enumerator for the fields of the container.  
  
## Syntax  
  
```cpp#  
HRESULT EnumFields(   
   FIELD_KIND         dwKindFilter,  
   FIELD_MODIFIERS    dwModifiersFilter,  
   LPCOLESTR          pszNameFilter,  
   NAME_MATCH         nameMatch,  
   IEnumDebugFields** ppEnum  
);  
```  
  
```c#  
int EnumFields(  
   enum_ FIELD_KIND      dwKindFilter,   
   enum_ FIELD_MODIFIERS dwModifiersFilter,   
   string                pszNameFilter,   
   NAME_MATCH            nameMatch,   
   out IEnumDebugFields  ppEnum  
);  
```  
  
#### Parameters  
 `dwKindFilter`  
 [in] A combination of [FIELD_KIND](../vs140/field_kind.md) constants that select the fields to be enumerated. Field kinds can describe storage types, such as class or primitive, or specific information, such as local, parameter, or "this" pointer.  
  
 `dwModifiersFilter`  
 [in] A combination of [FIELD_MODIFIERS](../vs140/field_modifiers.md) constants that select the fields to be enumerated. Field modifiers can be access permissions, such as public or private, or storage information, such as virtual, static, or final.  
  
 `pszNameFilter`  
 [in] The name of the field to be enumerated. This can be a null value if all fields are to be returned.  
  
 `nameMatch`  
 [in] A value from the [NAME_MATCH](../vs140/name_match.md) enumeration that controls whether searching is case-sensitive or not.  
  
 `ppEnum`  
 [out] Returns an [IEnumDebugFields](../vs140/ienumdebugfields.md) object representing the list of fields. Returns a null value if there are no fields.  
  
## Return Value  
 If successful, returns S_OK or S_FALSE if there are no fields. Otherwise, returns an error code.  
  
## Remarks  
 The `dwKindFilter`, `dwModifiersFilter`, and `pszNameFilter` parameters can be combined, for example, to select all public virtual methods named "MyMethod".  
  
## See Also  
 [IDebugContainerField](../vs140/idebugcontainerfield.md)   
 [IEnumDebugFields](../vs140/ienumdebugfields.md)   
 [FIELD_KIND](../vs140/field_kind.md)   
 [FIELD_MODIFIERS](../vs140/field_modifiers.md)   
 [NAME_MATCH](../vs140/name_match.md)