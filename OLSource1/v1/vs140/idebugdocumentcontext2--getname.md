---
title: "IDebugDocumentContext2::GetName"
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
  - IDebugDocumentContext2::GetName
helpviewer_keywords: 
  - IDebugDocumentContext2::GetName
ms.assetid: 546c5b2e-f166-4edb-9e61-57d797ca98a1
caps.latest.revision: 15
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugDocumentContext2::GetName
Gets the displayable name of the document that contains this document context.  
  
## Syntax  
  
```cpp#  
HRESULT GetName(   
   GETNAME_TYPE gnType,  
   BSTR*        pbstrFileName  
);  
```  
  
```c#  
int GetName(   
   enum_GETNAME_TYPE  gnType,  
   out string         pbstrFileName  
);  
```  
  
#### Parameters  
 `gnType`  
 [in] A value from the [GETNAME_TYPE](../vs140/getname_type.md) enumeration that specifies the type of name to return.  
  
 `pbstrFileName`  
 [out] Returns the name of the file.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method typically forwards the call to the [IDebugDocument2::GetName](../vs140/idebugdocument2--getname.md) method, unless the document context is written to store the document name itself (as the Example show).  
  
## Example  
 The following example shows how to implement this method for a simple `CDebugContext` object that exposes the [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md) interface.  
  
```cpp#  
HRESULT CDebugContext::GetName(GETNAME_TYPE gnType, BSTR* pbstrFileName)    
{    
   HRESULT hr;    
  
   // Check for a valid file name argument.    
   if (pbstrFileName)    
   {    
      *pbstrFileName = NULL;    
  
      switch (gnType)    
      {    
         case GN_NAME:    
         case GN_FILENAME:    
         {    
            // Copy the member file name into the local file name.    
            *pbstrFileName = SysAllocString(m_sbstrFileName);    
            // Check for successful copy.    
            hr = (*pbstrFileName) ? S_OK : E_OUTOFMEMORY;    
            break;    
         }    
         default:    
         {    
            hr = E_FAIL;    
            break;    
         }    
      }    
   }    
   else    
   {    
      hr = E_INVALIDARG;    
   }    
  
   return hr;    
}    
```  
  
## See Also  
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)   
 [GETNAME_TYPE](../vs140/getname_type.md)