---
title: "IDebugCustomAttributeQuery::IsCustomAttributeDefined"
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
  - "IDebugCustomAttributeQuery::IsCustomAttributeDefined"
  - "IsCustomAttributeDefined"
ms.assetid: c7425db6-4347-4f69-8f88-337ddaa34fa6
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCustomAttributeQuery::IsCustomAttributeDefined
Determines if the specified custom attribute is defined.  
  
## Syntax  
  
```cpp#  
HRESULT IsCustomAttributeDefined(  
   LPCOLESTR pszCustomAttributeName  
);  
```  
  
```c#  
int IsCustomAttributeDefined(  
   string pszCustomAttributeName  
);  
```  
  
#### Parameters  
 `pszCustomAttributeName`  
 [in] Name of the custom attribute.  
  
## Return Value  
 If the custom attribute is defined, returns `S_OK`; otherwise, returns `S_FALSE`.  
  
## Example  
 The following example shows how to implement this method for a **CDebugClassFieldSymbol** object that exposes the [IDebugCustomAttributeQuery](../vs140/idebugcustomattributequery.md) interface.  
  
```cpp#  
HRESULT CDebugClassFieldSymbol::IsCustomAttributeDefined(  
    LPCOLESTR pszCustomAttribute  
)  
{  
    HRESULT hr = S_FALSE;  
    CComPtr<IMetaDataImport> pMetadata;  
    mdToken token = mdTokenNil;  
    CComPtr<IDebugField> pField;  
    CComPtr<IDebugCustomAttributeQuery> pCA;  
  
    ASSERT(IsValidWideStringPtr(pszCustomAttribute));  
  
    METHOD_ENTRY( CDebugClassFieldSymbol::IsCustomAttributeDefined );  
  
    IfFalseGo( pszCustomAttribute, E_INVALIDARG );  
  
    IfFailGo( m_spSH->GetMetadata( m_spAddress->GetModule(), &pMetadata ) );  
  
    IfFailGo( CDebugCustomAttribute::GetTokenFromAddress( m_spAddress, &token) );  
    IfFailGo( pMetadata->GetCustomAttributeByName( token,  
              pszCustomAttribute,  
              NULL,  
              NULL ) );  
Error:  
  
    METHOD_EXIT( CDebugClassFieldSymbol::IsCustomAttributeDefined, hr );  
  
    if (hr != S_OK)  
    {  
        hr = S_FALSE;  
    }  
  
    return hr;  
}  
```  
  
## See Also  
 [IDebugCustomAttributeQuery](../vs140/idebugcustomattributequery.md)