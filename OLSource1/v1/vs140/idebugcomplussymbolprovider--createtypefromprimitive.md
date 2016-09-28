---
title: "IDebugComPlusSymbolProvider::CreateTypeFromPrimitive"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugComPlusSymbolProvider::CreateTypeFromPrimitive"
  - "CreateTypeFromPrimitive"
ms.assetid: 37213cc2-a038-42ea-9b28-3ae40d4cfe69
caps.latest.revision: 15
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider::CreateTypeFromPrimitive
Creates a type from the specified primitive type.  
  
## Syntax  
  
```  
[C++]  
HRESULT CreateTypeFromPrimitive(  
   DWORD          dwPrimType,  
   IDebugAddress* pAddress,  
   IDebugField**  ppType  
);  
```  
  
```  
[C#]  
int CreateTypeFromPrimitive(  
   uint          dwPrimType,  
   IDebugAddress pAddress,  
   IDebugField   ppType  
);  
```  
  
#### Parameters  
 `dwPrimType`  
 [in] Value from the [CorElementType Enumeration](assetId:///c3809c8f-1737-4f0f-9442-0c01ee689871) that represents the primitive type.  
  
 `pAddress`  
 [in] An address object represented by an [IDebugAddress](../vs140/idebugaddress.md) interface.  
  
 `ppType`  
 [in] Returns an [IDebugField](../vs140/idebugfield.md) object that describes the type.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md) interface.  
  
```cpp#  
HRESULT CDebugSymbolProvider::CreateTypeFromPrimitive(  
    DWORD dwPrimType,  
    IDebugAddress* pAddress,  
    IDebugField** ppType)  
{  
    HRESULT hr = S_OK;  
    CDEBUG_ADDRESS addr;  
    const COR_SIGNATURE* pTypeInfo = (const COR_SIGNATURE*) & dwPrimType;  
    CDebugGenericParamScope* pGenScope = NULL;  
  
    //  
    // This function will only work for primitive types  
    //  
  
    METHOD_ENTRY( CDebugSymbolProvider::CreateTypeFromPrimitive );  
  
    IfFailGo( pAddress->GetAddress( &addr ) );  
  
    IfNullGo( pGenScope = new CDebugGenericParamScope(addr.GetModule(), addr.tokClass, addr.GetMethod()), E_OUTOFMEMORY );  
  
    IfFailGo( CreateType( pTypeInfo,  
                          1,  
                          addr.GetModule(),  
                          addr.GetMethod(),  
                          pGenScope,  
                          ppType ) );  
  
    METHOD_EXIT( CDebugSymbolProvider::CreateTypeFromPrimitive, hr );  
  
Error:  
  
    RELEASE( pGenScope );  
    return hr;  
}  
```  
  
## See Also  
 [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md)