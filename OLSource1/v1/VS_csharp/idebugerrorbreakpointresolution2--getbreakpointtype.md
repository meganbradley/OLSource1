---
title: "IDebugErrorBreakpointResolution2::GetBreakpointType"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugErrorBreakpointResolution2::GetBreakpointType"
helpviewer_keywords: 
  - "IDebugErrorBreakpointResolution2::GetBreakpointType"
ms.assetid: 0bdb1152-4752-4464-ae7c-6d666dc293b7
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugErrorBreakpointResolution2::GetBreakpointType
Gets the breakpoint type.  
  
## Syntax  
  
```cpp#  
HRESULT GetBreakpointType(   
   BP_TYPE* pBPType  
);  
```  
  
```c#  
int GetBreakpointType(   
   out enum_BP_TYPE pBPType  
);  
```  
  
#### Parameters  
 `pBPType`  
 [out] Returns a value from the [BP_TYPE](../VS_csharp/bp_type.md) enumeration that describes the type of breakpoint.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method returns the type of the breakpoint that failed to bind, thus requiring an error breakpoint event.  
  
## Example  
 The following example shows how to implement this method for a simple `CDebugErrorBreakpointResolution` object that exposes the [IDebugErrorBreakpointResolution2](../VS_csharp/idebugerrorbreakpointresolution2.md) interface.  
  
```  
HRESULT CDebugErrorBreakpointResolution::GetBreakpointType(BP_TYPE* pBPType)    
{    
   HRESULT hr;    
  
   if (pBPType)    
   {    
      // Set default BP_TYPE.    
      *pBPType = BPT_NONE;    
  
      // Check if the BPERESI_BPRESLOCATION flag is set in BPERESI_FIELDS.    
      if (IsFlagSet(m_bpErrorResolutionInfo.dwFields, BPERESI_BPRESLOCATION))    
      {    
         // Set the new BP_TYPE.    
         *pBPType = m_bpErrorResolutionInfo.bpResLocation.bpType;    
         hr = S_OK;    
      }    
      else    
      {    
         hr = E_FAIL;    
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
 [IDebugErrorBreakpointResolution2](../VS_csharp/idebugerrorbreakpointresolution2.md)   
 [BP_TYPE](../VS_csharp/bp_type.md)