---
title: "IPropertyProxyEESide::ResolveAssemblyRef"
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
  - IPropertyProxyEESide::ResolveAssemblyRef
helpviewer_keywords: 
  - IPropertyProxyEESide::ResolveAssemblyRef
ms.assetid: 662ca0a6-dad0-4c00-a718-bb3bbc5bd9da
caps.latest.revision: 16
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IPropertyProxyEESide::ResolveAssemblyRef
Determines the location of the specified managed assembly reference.  
  
## Syntax  
  
```cpp#  
HRESULT ResolveAssemblyRef(  
   BSTR*                  assemName,  
   IEEDataStorage**       assemBytes,  
   IEEDataStorage**       assemPdb,  
   BSTR*                  assemLocation,  
   ASSEMBLYLOCRESOLUTION* alr  
);  
```  
  
```c#  
int ResolveAssemblyRef(  
   ref string                     assemName,  
   out IEEDataStorage             assemBytes,  
   out IEEDataStorage             assemPdb,  
   out string                     assemLocation,  
   out enum_ASSEMBLYLOCRESOLUTION alr  
);  
```  
  
#### Parameters  
 `assemName`  
 [in] Name of the assembly to resolve.  
  
 `assemBytes`  
 [out] Returns an [IEEDataStorage](../vs140/ieedatastorage.md) object containing the assembly bytes associated with the reference.  
  
 `assemPdb`  
 [out] Returns an `IEEDataStorage` object containing the symbol store data associated with this reference.  
  
 `assemLocation`  
 [out] Returns the path location of this reference.  
  
 `alr`  
 [out] Returns a value from the [ASSEMBLYLOCRESOLUTION](../vs140/assemblylocresolution.md) enumeration indicating the location of this reference's assembly.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is not typically implemented by a custom expression evaluator.  
  
## See Also  
 [IPropertyProxyEESide](../vs140/ipropertyproxyeeside.md)   
 [IEEDataStorage](../vs140/ieedatastorage.md)   
 [ASSEMBLYLOCRESOLUTION](../vs140/assemblylocresolution.md)